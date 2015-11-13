using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Streams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const String fileName = @"N:\desktop\test.txt";

        StreamWriter sw = null;
        StreamReader sr = null;

        private void btnWriteFile_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                sw = new StreamWriter(fileName, true);

                sw.WriteLine(txtInput.Text);
                sw.WriteLine(nudInput.Value.ToString());
                sw.WriteLine(txtCharInput.Text);

                txtInput.Clear();
                nudInput.Value = (decimal)0.0000;
                txtCharInput.Clear();
                txtInput.Focus();

                sw.Close();
            }
            catch(DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
;
            }
        }

        private void btnRead_MouseClick(object sender, MouseEventArgs e)
        {
            lbxData.Items.Clear();
            try
            {
                sr = new StreamReader(fileName);
                string strLine = sr.ReadLine();
                while (strLine != null)
                {
                    lbxData.Items.Add(strLine);
                    strLine = sr.ReadLine();
                }
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
