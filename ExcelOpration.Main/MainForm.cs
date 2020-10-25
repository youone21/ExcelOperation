using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelOprationMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            rbWrite.Enabled = false;

            if (rbFile.Checked)
            {
                groupBox6.Enabled = false;
                lblFilrOrForder.Text = "读取文件：";
            }
            else
            {
                groupBox6.Enabled = true;
                lblFilrOrForder.Text = "读取文件夹：";
            }
        }

        private void rbFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFile.Checked)
            {
                groupBox6.Enabled = false;
                lblFilrOrForder.Text = "读取文件：";
                txtInput.Text = string.Empty;
            }
            else
            {
                groupBox6.Enabled = true;
                lblFilrOrForder.Text = "读取文件夹：";
                txtInput.Text = string.Empty;
            }
        }

        private void btnInputSelect_Click(object sender, EventArgs e)
        {
            if (rbFile.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = openFileDialog1.FileName;
                }
            }
            else
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }

        private void btnOutputSelect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // todo
        }
    }
}
