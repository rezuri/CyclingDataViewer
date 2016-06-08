using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;

namespace CyclingDataViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                lblFile1.Text = openFileDialog1.FileName;
            }
        }

        private void btnGetFiles2_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog2.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                lblFile2.Text = openFileDialog2.FileName;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var data = ExcelExtractService.OpenExcelWorkbook(lblFile1.Text);
            chart1.DataSource = data;
        }
    }
}
