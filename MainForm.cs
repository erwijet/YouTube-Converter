using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using VideoLibrary;
using MediaToolkit.Model;
using System.Windows.Forms;
using MediaToolkit;

namespace Youtube_Converter
{
    public partial class MainForm : Form
    {
        public bool RunOnce = false;
        public BackgroundWorker bw = new BackgroundWorker();
        public string path = "";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public string status
        {
            get => l_status.Text;
            set => l_status.Text = value;
        }

        public MainForm()
        {
            InitializeComponent();
            pictureBox2.MouseDown += PictureBox2_MouseDown;
            bw.DoWork += ConvertAsync;
            bw.RunWorkerCompleted += WorkerEnd;
            bw.WorkerReportsProgress = true;
            bw.ProgressChanged += ProgressUpdated;
        }

        public MainForm(string YTMI)
        {
            InitializeComponent();
            pictureBox2.MouseDown += PictureBox2_MouseDown;
            bw.DoWork += ConvertAsync;
            bw.RunWorkerCompleted += WorkerEnd;
            bw.WorkerReportsProgress = true;
            bw.ProgressChanged += ProgressUpdated;

            if (File.Exists(YTMI))
            {
                RunOnce = true;
                bw.RunWorkerAsync(new object[] { 0, tb_path.Text });
            }
            else Close();
        }

        private void ProgressUpdated(object sender, ProgressChangedEventArgs e)
        {
            BeginLoading(e.UserState as string);
        }

        private void WorkerEnd(object sender, RunWorkerCompletedEventArgs e)
        { 
            System.Diagnostics.Process.Start((new FileInfo(path).Directory).ToString());
            EndLoading();
            if (RunOnce) Close();
        }

        private void ConvertAsync(object sender, DoWorkEventArgs e)
        {
            int foo = 0;
            if (!int.TryParse((e.Argument as object[])[0].ToString(), out foo))
            {
                //string path = (e.Argument as object[])[2] as string;
                object[] args = e.Argument as object[];
                GetMediaFromYoutube(
                    args[0] as string,
                        int.Parse(args[1].ToString()),
                           out path);
            }
            else
            {
                object[] args = e.Argument as object[];
                foreach (string s in File.ReadAllLines(args[1] as string))
                {
                    string p = "";
                    int code = 0;
                    RunParse(s, out p, out code);
                    GetMediaFromYoutube(p, code, out path);
                }
            }
        }
        
        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void BeginLoading(string message)
        {
            status = message;
            pictureBox1.Visible = true;
        }

        public void EndLoading()
        {
            status = "";
            pictureBox1.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EndLoading();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            EndLoading();
            if (rb_uri.Checked)
            {
                //string path = "";
                if (cb_vid.Checked || cb_audio.Checked)
                {
                    int mode = 2;
                    BeginLoading("Starting...");

                    if (cb_audio.Checked)
                    {
                        if (cb_vid.Checked) mode = 2;
                        else mode = 0;
                    }
                    else if (cb_vid.Checked) mode = 1;
                    bw.RunWorkerAsync(new object[] { tb_path.Text, mode.ToString(), path });
                }
                else
                {
                    MessageBox.Show("Please select a mode");
                    EndLoading();
                }
            }
            else
            {
                if (File.Exists(tb_path.Text))
                {
                    bw.RunWorkerAsync(new object[] { 0, tb_path.Text });
                }
            }

        }

        public void RunParse(string input, out string URL, out int CODE)
        {
            CODE = int.Parse(input.Split('@')[input.Split('@').Length - 1]);
            URL = input.Substring(0, input.Length - (CODE + 1));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">The Youtube URL</param>
        /// <param name="mode">
        /// 0: audio
        /// 1: video
        /// 2: mixed
        /// </param>
        public void GetMediaFromYoutube(string path, int mode, out string filename)
        {
            try
            {
                var source = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\";
                var youtube = YouTube.Default;
                var vid = youtube.GetVideo(path);
                bw.ReportProgress(10, $"Downloading \'{vid.FullName}\'...");
                File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

                var inputFile = new MediaFile { Filename = source + vid.FullName };
                var outputFile = new MediaFile { Filename = $"{source + vid.FullName}.mp3" };

                bw.ReportProgress(10, "Finishing...");

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);

                    engine.Convert(inputFile, outputFile);
                }

                filename = outputFile.Filename;

                bw.ReportProgress(10, "Cleaning Up...");

                switch (mode)
                {

                    case 0:
                        File.Delete(outputFile.Filename.Substring(0, outputFile.Filename.Length - ".mp3".Length));
                        break;
                    case 1:
                        File.Delete(outputFile.Filename);
                        break;
                    case 2:
                        break;
                }
            }
            catch
            {
                bw.ReportProgress(10, "Error: Video URL Not Valid");
                MessageBox.Show($"Error: The url: {path} \ncould not be found. Check to make sure that the video\n is a YouTube video and has \nnot been taken down or removed.");
            }
            filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
    }

    [Obsolete("Use the \'bw\' background worker.")]
    public static class Converter
    {
        [Obsolete("Use the async bw.DoWork() method.")]
        public static void Run(string path, out string filename)
        {
            var source = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\";
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(path);
            File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

            var inputFile = new MediaFile { Filename = source + vid.FullName };
            var outputFile = new MediaFile { Filename = $"{source + vid.FullName}.mp3" };


            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);
            }

            filename = outputFile.Filename;
        }
    }
}
