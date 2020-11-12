using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CSAY_SQlite_Record
{
    public partial class FrmProgramRecord : Form
    {
        public FrmProgramRecord()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLoadRecords_Click(object sender, EventArgs e)
        {
            SQLiteConnection ConnectDb = new SQLiteConnection("Data Source = ProgramRecord.sqlite3");
            ConnectDb.Open();

            string query = "SELECT * FROM TableProjectRecords";
            SQLiteDataAdapter DataAdptr = new SQLiteDataAdapter(query, ConnectDb);

            DataTable Dt = new DataTable();
            DataAdptr.Fill(Dt);
            dataGridViewAllPara.DataSource = Dt;

            /*dataGridViewAllPara.Columns[0].Width = 60; //ProjectID
            dataGridViewAllPara.Columns[1].Width = 180; //FiscalYear
            dataGridViewAllPara.Columns[2].Width = 80; //ProjectName
            dataGridViewAllPara.Columns[3].Width = 200; //Ward
            dataGridViewAllPara.Columns[4].Width = 290;  //Location
            dataGridViewAllPara.Columns[5].Width = 290;  //BudgetType
            dataGridViewAllPara.Columns[6].Width = 120;  //ProgramBudget
            dataGridViewAllPara.Columns[7].Width = 60; //Contingency
            dataGridViewAllPara.Columns[8].Width = 180; //EstimatedBudget0
            dataGridViewAllPara.Columns[9].Width = 80; //NetPayable0
            dataGridViewAllPara.Columns[10].Width = 200; //Contribution0
            dataGridViewAllPara.Columns[11].Width = 290;  //EstimatedBudget1
            dataGridViewAllPara.Columns[12].Width = 290;  //NetPayable1
            dataGridViewAllPara.Columns[13].Width = 120;  //Contribution1
            dataGridViewAllPara.Columns[14].Width = 60; //EstimatedBudget2
            dataGridViewAllPara.Columns[15].Width = 180; //NetPayable2
            dataGridViewAllPara.Columns[16].Width = 80; //Contribution2
            dataGridViewAllPara.Columns[18].Width = 290;  //CurrentStatus
            dataGridViewAllPara.Columns[17].Width = 200; //Record
            dataGridViewAllPara.Columns[19].Width = 290;  //Remark*/

            ConnectDb.Close();
            LblDbLog.Text = "Recent Activity: Iteration Record Loaded Successfully";

            int rcount = Dt.Rows.Count;
            LblRecordNo.Text = "Record No: " + rcount.ToString();
        }

        private void BtnOpenAddForm_Click(object sender, EventArgs e)
        {
            FrmRecordForm fadd = new FrmRecordForm();
            fadd.Show();
        }

        private void FrmProgramRecord_Load(object sender, EventArgs e)
        {
            //Filter --> Heading --> Level 1
            string[] FilterLevel1 = System.IO.File.ReadAllLines(@".\ComboBoxList\FilterLevel1.txt");
            foreach (var line in FilterLevel1) 
            {
                //string[] tokens = line.Split('\n');
                ComboBoxFilterBy.Items.Add(line);
            }
            /*ComboBoxFilterBy.Items.Add("ProjectID");
            ComboBoxFilterBy.Items.Add("ProjectName");
            ComboBoxFilterBy.Items.Add("Ward");
            ComboBoxFilterBy.Items.Add("BudgetType");
            ComboBoxFilterBy.Items.Add("CurrentStatus");
            ComboBoxFilterBy.Items.Add("Remark");
            ComboBoxFilterBy.Items.Add("LabReport");
            ComboBoxFilterBy.Items.Add("Board");*/

            //Filter --> Heading --> Level 2
            string[] FilterLevel2 = System.IO.File.ReadAllLines(@".\ComboBoxList\FilterLevel2.txt");
            foreach (var line in FilterLevel2)
            {
                //string[] tokens = line.Split('\n');
                ComboBoxFilterByLevel2.Items.Add(line);
            }
            /*ComboBoxFilterByLevel2.Items.Add("Ward");
            ComboBoxFilterByLevel2.Items.Add("BudgetType");
            ComboBoxFilterByLevel2.Items.Add("CurrentStatus");
            ComboBoxFilterByLevel2.Items.Add("Remark");
            ComboBoxFilterByLevel2.Items.Add("LabReport");
            ComboBoxFilterByLevel2.Items.Add("Board");*/

        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            SQLiteConnection ConnectDb = new SQLiteConnection("Data Source = ProgramRecord.sqlite3");
            ConnectDb.Open();

            //string query1 = "SELECT * FROM SWAT_Parameters";
            string query = "SELECT * FROM TableProjectRecords where " + ComboBoxFilterBy.Text + " = '" + ComboBoxFilterDistinctValues.Text + "'";
            SQLiteDataAdapter DataAdptr = new SQLiteDataAdapter(query, ConnectDb);

            DataTable Dt = new DataTable();
            DataAdptr.Fill(Dt);
            dataGridViewAllPara.DataSource = Dt;

            /*dataGridViewAllPara.Columns[0].Width = 60; //ID
            dataGridViewAllPara.Columns[1].Width = 180; //ProjetName
            dataGridViewAllPara.Columns[2].Width = 80; //IterationNo
            dataGridViewAllPara.Columns[3].Width = 200; //Parameters
            dataGridViewAllPara.Columns[4].Width = 290;  //Remark
            dataGridViewAllPara.Columns[5].Width = 290;  //Findings
            dataGridViewAllPara.Columns[6].Width = 120;  //Findings*/

            ConnectDb.Close();
            //MessageBox.Show("Parameters Data Loaded Successfully.", "Load Parameters");
            int rcount = Dt.Rows.Count;
            LblRecordNo.Text = "Record No: " + rcount.ToString();
        }

        private void BtnFilterLevel2_Click(object sender, EventArgs e)
        {
            SQLiteConnection ConnectDb = new SQLiteConnection("Data Source = ProgramRecord.sqlite3");
            ConnectDb.Open();

            //string query1 = "SELECT * FROM SWAT_Parameters";
            string query = "SELECT * FROM TableProjectRecords where " + ComboBoxFilterBy.Text + " = '" + ComboBoxFilterDistinctValues.Text + "'AND " + ComboBoxFilterByLevel2.Text + " ='" + ComboBoxFilterDistinctValuesLevel2.Text + "'";
            SQLiteDataAdapter DataAdptr = new SQLiteDataAdapter(query, ConnectDb);

            DataTable Dt = new DataTable();
            DataAdptr.Fill(Dt);
            dataGridViewAllPara.DataSource = Dt;

            /*dataGridViewAllPara.Columns[0].Width = 60; //ID
            dataGridViewAllPara.Columns[1].Width = 180; //ProjetName
            dataGridViewAllPara.Columns[2].Width = 80; //IterationNo
            dataGridViewAllPara.Columns[3].Width = 200; //Parameters
            dataGridViewAllPara.Columns[4].Width = 290;  //Remark
            dataGridViewAllPara.Columns[5].Width = 290;  //Findings
            dataGridViewAllPara.Columns[6].Width = 120;  //Findings*/

            ConnectDb.Close();
            //MessageBox.Show("Parameters Data Loaded Successfully.", "Load Parameters");
            int rcount = Dt.Rows.Count;
            LblRecordNo.Text = "Record No: " + rcount.ToString();
        }

        private void ComboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value;
            SQLiteConnection ConnectDb = new SQLiteConnection("Data Source = ProgramRecord.sqlite3");
            ConnectDb.Open();

            //for unique value
            string query = "SELECT DISTINCT " + ComboBoxFilterBy.Text + " FROM TableProjectRecords";
            SQLiteDataAdapter DataAdptr = new SQLiteDataAdapter(query, ConnectDb);

            DataTable Dt = new DataTable();
            DataAdptr.Fill(Dt);

            ComboBoxFilterDistinctValues.Items.Clear();
            foreach (DataRow row in Dt.Rows)
            {
                value = row[0].ToString();
                ComboBoxFilterDistinctValues.Items.Add(value);
            }

            ConnectDb.Close();
        }

        private void ComboBoxFilterByLevel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value;
            SQLiteConnection ConnectDb = new SQLiteConnection("Data Source = ProgramRecord.sqlite3");
            ConnectDb.Open();

            //for unique value
            string query = "SELECT DISTINCT " + ComboBoxFilterByLevel2.Text + " FROM TableProjectRecords";
            SQLiteDataAdapter DataAdptr = new SQLiteDataAdapter(query, ConnectDb);

            DataTable Dt = new DataTable();
            DataAdptr.Fill(Dt);

            ComboBoxFilterDistinctValuesLevel2.Items.Clear();
            foreach (DataRow row in Dt.Rows)
            {
                value = row[0].ToString();
                ComboBoxFilterDistinctValuesLevel2.Items.Add(value);
            }

            ConnectDb.Close();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout fa = new FrmAbout();
            fa.Show();
        }

        private void CopyAlltoClipboard()
        {
            dataGridViewAllPara.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewAllPara.MultiSelect = true;
            dataGridViewAllPara.SelectAll();
            DataObject dataObj = dataGridViewAllPara.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CopyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "Record " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

               
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[5, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                // xlWorkBook.Close();
                //  xlexcel.Quit();
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);

                MessageBox.Show("Export Completed Sucessfully.");

            }
            catch
            {
                

            }
        }
    }
}
