using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comented this part out cuz its fucking anoying
            
            //hehe
            /*
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");
            System.Diagnostics.Process.Start("http://pornhub.com");

            //msg
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIc           MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("you have virus!!!!", "you have virus!!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            */
            
           //lol
            
            System.Diagnostics.Process.Start("system32");

            MessageBox.Show("Delete sys32?", "Windows",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            
            MessageBox.Show("Are you sure?", "Windows",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            MessageBox.Show("Deleting...", "Windows",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            MessageBox.Show("Succses!", "Windows",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
