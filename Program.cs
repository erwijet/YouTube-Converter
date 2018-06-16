using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaToolkit;
using VideoLibrary;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaToolkit.Model;

namespace Youtube_Converter
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
