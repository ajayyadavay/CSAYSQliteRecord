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

namespace CSAY_SQlite_Record
{
    public partial class FrmDisplayRecordFormat : Form
    {
        public FrmDisplayRecordFormat()
        {
            InitializeComponent();
        }

        private void FrmDisplayRecordFormat_Load(object sender, EventArgs e)
        {
           //FrmRecordForm frecrod = new FrmRecordForm();
           TxtDisplayRecordFormat.Text =FrmRecordForm.StrDisplayRecordFormat;
            
        }

        private void BtnExportToTextFile_Click(object sender, EventArgs e)
        {
            try
            {
                //string ThisFilename = "DemoFile.txt";
                string ThisFilename =FrmRecordForm.StrFileName;
                TextWriter WriteToTxtFile = new StreamWriter(ThisFilename);
                WriteToTxtFile.Write(TxtDisplayRecordFormat.Text);
                WriteToTxtFile.Close();

                MessageBox.Show("FileName saved is - " + ThisFilename);
            }
            catch
            {

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
