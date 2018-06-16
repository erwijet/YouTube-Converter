namespace Youtube_Converter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cb_vid = new MaterialSkin.Controls.MaterialCheckBox();
            this.cb_audio = new MaterialSkin.Controls.MaterialCheckBox();
            this.l_prompt = new MaterialSkin.Controls.MaterialLabel();
            this.rb_uri = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_ytmi = new MaterialSkin.Controls.MaterialRadioButton();
            this.l_status = new MaterialSkin.Controls.MaterialLabel();
            this.tb_path = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_start = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_vid
            // 
            this.cb_vid.AutoSize = true;
            this.cb_vid.Depth = 0;
            this.cb_vid.Font = new System.Drawing.Font("Roboto", 10F);
            this.cb_vid.Location = new System.Drawing.Point(288, 83);
            this.cb_vid.Margin = new System.Windows.Forms.Padding(0);
            this.cb_vid.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cb_vid.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_vid.Name = "cb_vid";
            this.cb_vid.Ripple = true;
            this.cb_vid.Size = new System.Drawing.Size(65, 30);
            this.cb_vid.TabIndex = 0;
            this.cb_vid.Text = "Video";
            this.cb_vid.UseVisualStyleBackColor = true;
            // 
            // cb_audio
            // 
            this.cb_audio.AutoSize = true;
            this.cb_audio.Checked = true;
            this.cb_audio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_audio.Depth = 0;
            this.cb_audio.Font = new System.Drawing.Font("Roboto", 10F);
            this.cb_audio.Location = new System.Drawing.Point(288, 113);
            this.cb_audio.Margin = new System.Windows.Forms.Padding(0);
            this.cb_audio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cb_audio.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_audio.Name = "cb_audio";
            this.cb_audio.Ripple = true;
            this.cb_audio.Size = new System.Drawing.Size(66, 30);
            this.cb_audio.TabIndex = 1;
            this.cb_audio.Text = "Audio";
            this.cb_audio.UseVisualStyleBackColor = true;
            // 
            // l_prompt
            // 
            this.l_prompt.AutoSize = true;
            this.l_prompt.Depth = 0;
            this.l_prompt.Font = new System.Drawing.Font("Roboto", 11F);
            this.l_prompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.l_prompt.Location = new System.Drawing.Point(12, 21);
            this.l_prompt.MouseState = MaterialSkin.MouseState.HOVER;
            this.l_prompt.Name = "l_prompt";
            this.l_prompt.Size = new System.Drawing.Size(102, 19);
            this.l_prompt.TabIndex = 2;
            this.l_prompt.Text = "Youtube Path:";
            // 
            // rb_uri
            // 
            this.rb_uri.AutoSize = true;
            this.rb_uri.Checked = true;
            this.rb_uri.Depth = 0;
            this.rb_uri.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_uri.Location = new System.Drawing.Point(15, 82);
            this.rb_uri.Margin = new System.Windows.Forms.Padding(0);
            this.rb_uri.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_uri.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_uri.Name = "rb_uri";
            this.rb_uri.Ripple = true;
            this.rb_uri.Size = new System.Drawing.Size(101, 30);
            this.rb_uri.TabIndex = 3;
            this.rb_uri.TabStop = true;
            this.rb_uri.Text = "Youtube Url";
            this.rb_uri.UseVisualStyleBackColor = true;
            // 
            // rb_ytmi
            // 
            this.rb_ytmi.AutoSize = true;
            this.rb_ytmi.Depth = 0;
            this.rb_ytmi.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_ytmi.Location = new System.Drawing.Point(15, 113);
            this.rb_ytmi.Margin = new System.Windows.Forms.Padding(0);
            this.rb_ytmi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_ytmi.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_ytmi.Name = "rb_ytmi";
            this.rb_ytmi.Ripple = true;
            this.rb_ytmi.Size = new System.Drawing.Size(124, 30);
            this.rb_ytmi.TabIndex = 4;
            this.rb_ytmi.Text = "Local YTMI File";
            this.rb_ytmi.UseVisualStyleBackColor = true;
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Depth = 0;
            this.l_status.Font = new System.Drawing.Font("Roboto", 11F);
            this.l_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.l_status.Location = new System.Drawing.Point(64, 178);
            this.l_status.MouseState = MaterialSkin.MouseState.HOVER;
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(0, 19);
            this.l_status.TabIndex = 6;
            // 
            // tb_path
            // 
            this.tb_path.Depth = 0;
            this.tb_path.Hint = "";
            this.tb_path.Location = new System.Drawing.Point(15, 48);
            this.tb_path.MaxLength = 32767;
            this.tb_path.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_path.Name = "tb_path";
            this.tb_path.PasswordChar = '\0';
            this.tb_path.SelectedText = "";
            this.tb_path.SelectionLength = 0;
            this.tb_path.SelectionStart = 0;
            this.tb_path.Size = new System.Drawing.Size(339, 23);
            this.tb_path.TabIndex = 7;
            this.tb_path.TabStop = false;
            this.tb_path.Text = "http://youtube.com/";
            this.tb_path.UseSystemPasswordChar = false;
            // 
            // btn_start
            // 
            this.btn_start.AutoSize = true;
            this.btn_start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_start.Depth = 0;
            this.btn_start.Icon = null;
            this.btn_start.Location = new System.Drawing.Point(241, 170);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_start.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_start.Name = "btn_start";
            this.btn_start.Primary = false;
            this.btn_start.Size = new System.Drawing.Size(149, 36);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Begin Conversion";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Youtube_Converter.Properties.Resources.X;
            this.pictureBox3.Location = new System.Drawing.Point(381, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(399, 22);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Youtube_Converter.Properties.Resources.lg_comet_spinner;
            this.pictureBox1.Location = new System.Drawing.Point(18, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 213);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.l_status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rb_ytmi);
            this.Controls.Add(this.rb_uri);
            this.Controls.Add(this.l_prompt);
            this.Controls.Add(this.cb_audio);
            this.Controls.Add(this.cb_vid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox cb_vid;
        private MaterialSkin.Controls.MaterialCheckBox cb_audio;
        private MaterialSkin.Controls.MaterialLabel l_prompt;
        private MaterialSkin.Controls.MaterialRadioButton rb_uri;
        private MaterialSkin.Controls.MaterialRadioButton rb_ytmi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel l_status;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_path;
        private MaterialSkin.Controls.MaterialFlatButton btn_start;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}