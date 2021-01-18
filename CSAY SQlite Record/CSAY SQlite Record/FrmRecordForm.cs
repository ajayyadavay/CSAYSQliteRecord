using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CSAY_SQlite_Record
{
    public partial class FrmRecordForm : Form
    {
        public static string StrDisplayRecordFormat, StrFileName;
        string Text2Write;
        public FrmRecordForm()
        {
            InitializeComponent();
        }

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            string FiscalYear = TxtAddFiscalYear.Text;

            string ProjectName = TxtAddProjecName.Text;
            string Ward = TxtAddWard.Text;
            string Location = TxtAddLocation.Text;
            string BudgetType = TxtAddBudgetType.Text;

            string WorkPermit = TxtWorkPermit.Text;
            string WorkStart = TxtWorkStart.Text;
            string FirstRunningBill = TxtFirstRunBill.Text;
            string FinalBill = TxtFinalBill.Text;

            string CurrentStatus = TxtAddCurStatus.Text;
            string Description = TxtDescription.Text;
            string Remark = TxtAddRemark.Text;

            string LabReport = TxtLabReport.Text;
            string Board = TxtBoard.Text;

            string ProgramBudget = TxtAddProgramBudget.Text;
            string Contingency = TxtAddContingency.Text;
            string EstimatedBudget0 = TxtAddEstiBud0.Text;
            string NetPayable0 = TxtAddNetPay0.Text;
            string Contribution0 = TxtAddContribution0.Text;

            string EstimatedBudget1 = TxtAddEstiBud1.Text;
            string NetPayable1 = TxtAddNetPay1.Text;
            string Contribution1 = TxtAddContribution1.Text;

            string EstimatedBudget2 = TxtAddEstiBud2.Text;
            string NetPayable2 = TxtAddNetPay2.Text;
            string Contribution2 = TxtAddContribution2.Text;

            string Cube1 = TxtCube1.Text;
            string Cube2 = TxtCube2.Text;
            string Cube3 = TxtCube3.Text;
            string Cube4 = TxtCube4.Text;
            string Cube5 = TxtCube5.Text;
            string Cube6 = TxtCube6.Text;
            string Cube7 = TxtCube7.Text;
            string Cube8 = TxtCube8.Text;
            string Cube9 = TxtCube9.Text;

            string UCName = TxtUCName.Text;
            string UCContact = TxtUCContact.Text;

            string Length = TxtLength.Text;
            string Width = TxtWidth.Text;
            string Height = TxtHeight.Text;

            string Refer = TxtRefer.Text;


            DialogResult dr = MessageBox.Show("Are you sure, you want to Add?", "Add", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //Add
                SQLiteConnection ConnectDb = new SQLiteConnection("Data Source = ProgramRecord.sqlite3");
                ConnectDb.Open();
                string query = "INSERT INTO TableProjectRecords(FiscalYear,ProjectName,Ward," +
                    "Location,BudgetType,WorkPermit,WorkStart,FirstRunningBill,FinalBill," +
                    "CurrentStatus,Description,Remark,LabReport,Board," +
                    "ProgramBudget,Contingency,EstimatedBudget0,NetPayable0,Contribution0," +
                    "EstimatedBudget1,NetPayable1,Contribution1,EstimatedBudget2,NetPayable2," +
                    "Contribution2,Cube1,Cube2,Cube3,Cube4,Cube5,Cube6,Cube7,Cube8,Cube9,UCName,UCContact," +
                    "Length,Width,Height,Refer) " +
                    "VALUES('" + FiscalYear + "','" + ProjectName + "','" + Ward + "','" + Location + "'," +
                    "'" + BudgetType + "','" + WorkPermit + "','" + WorkStart + "','" + FirstRunningBill + "'" +
                    ",'" + FinalBill + "','" + CurrentStatus + "','" + Description + "','" + Remark + "'" +
                    ",'" + LabReport + "','" + Board + "','" + ProgramBudget + "','" + Contingency + "','" + EstimatedBudget0 + "','" + NetPayable0 + "'" +
                    ",'" + Contribution0 + "','" + EstimatedBudget1 + "','" + NetPayable1 + "','" + Contribution1 + "'" +
                    ",'" + EstimatedBudget2 + "','" + NetPayable2 + "','" + Contribution2 + "','" + Cube1 + "'" +
                    ",'" + Cube2 + "','" + Cube3 + "','" + Cube4 + "','" + Cube5 + "','" + Cube6 + "'" +
                    ",'" + Cube7 + "','" + Cube8 + "','" + Cube9 + "','" + UCName + "','" + UCContact + "'" +
                    ",'" + Length + "','" + Width + "','" + Height + "','" + Refer + "')"; 

                SQLiteCommand Cmd = new SQLiteCommand(query, ConnectDb);
                Cmd.ExecuteNonQuery();

                ConnectDb.Close();

                // clear text boxex
                TxtProjectID.Text = "";
                TxtAddFiscalYear.Text = "";
                TxtAddProjecName.Text = "";
                TxtAddWard.Text = "";
                TxtAddLocation.Text = "";

                TxtWorkPermit.Text = "";
                TxtWorkStart.Text = "";
                TxtFirstRunBill.Text = "";
                TxtFinalBill.Text = "";

                TxtAddCurStatus.Text = "";
                TxtDescription.Text = "";
                TxtAddRemark.Text = "";

                TxtLabReport.Text = "";
                TxtBoard.Text = "";

                TxtAddBudgetType.Text = "";
                TxtAddProgramBudget.Text = "";
                TxtAddContingency.Text = "";
                TxtAddEstiBud0.Text = "";
                TxtAddNetPay0.Text = "";
                TxtAddContribution0.Text = "";

                TxtAddEstiBud1.Text = "";
                TxtAddNetPay1.Text = "";
                TxtAddContribution1.Text = "";

                TxtAddEstiBud2.Text = "";
                TxtAddNetPay2.Text = "";
                TxtAddContribution2.Text = "";

                TxtCube1.Text = "";
                TxtCube2.Text = "";
                TxtCube3.Text = "";
                TxtCube4.Text = "";
                TxtCube5.Text = "";
                TxtCube6.Text = "";
                TxtCube7.Text = "";
                TxtCube8.Text = "";
                TxtCube9.Text = "";

                TxtUCName.Text = "";
                TxtUCContact.Text = "";

                TxtLength.Text = "";
                TxtWidth.Text = "";
                TxtHeight.Text = "";

                TxtRefer.Text = "";

                ComboBoxFiscalYear.SelectedIndex = -1;
                ComboBoxProjectName.SelectedIndex = -1;
                ComboBoxAddCurStatus.SelectedIndex = -1;
                ComboBoxAddBudgetType.SelectedIndex = -1;
                ComboBoxLabReport.SelectedIndex = -1;
                ComboBoxBoard.SelectedIndex = -1;

                LblCheck.Text = "Log: " ;
                LblCheck.ForeColor = Color.Black;

                TxtAddLog.AppendText("Activity: Record Successfully Added : " + ProjectName + " of " + Ward + " at " + Location);
                TxtAddLog.AppendText(Environment.NewLine);

                using (System.IO.StreamWriter sw = System.IO.File.AppendText(@".\Log\Log.txt"))
                {
                    Text2Write = "[" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "]" + "  --->  " + "ADD" +" ---> "+ ProjectName + " of " + Ward + " at " + Location; ;
                    sw.WriteLine(Text2Write);
                }
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            //Add ---> Fiscal year 
            string[] FiscalYearList = System.IO.File.ReadAllLines(@".\ComboBoxList\FiscalYear.txt");
            foreach (var line in FiscalYearList)
            {
                //string[] tokens = line.Split('\n');
                ComboBoxFiscalYear.Items.Add(line);
            }

            //Add ---> Project Name
            string[] ProjectNameList =System.IO.File.ReadAllLines(@".\ComboBoxList\ProjectName.txt");
            foreach (var line in ProjectNameList)
            {
                //string[] tokens = line.Split('\n');
                ComboBoxProjectName.Items.Add(line);
            }
            /*ComboBoxProjectName.Items.Add("PCC Road (1:2:4)");
            ComboBoxProjectName.Items.Add("Sarwajanik Bhawan");
            ComboBoxProjectName.Items.Add("Pratikshaalaya");
            ComboBoxProjectName.Items.Add("Krishi Sadak");
            ComboBoxProjectName.Items.Add("Pratikshaalaya");
            ComboBoxProjectName.Items.Add("Krishi Sadak");
            ComboBoxProjectName.Items.Add("Specify Others");*/

            //Add ---> Budget Type 
            string[] BudgetTypeList = System.IO.File.ReadAllLines(@".\ComboBoxList\BudgetType.txt");
            foreach (var line in BudgetTypeList)
            {
                //string[] tokens = line.Split('\n');
                ComboBoxAddBudgetType.Items.Add(line);
            }
            /*ComboBoxAddBudgetType.Items.Add("Ward");
            ComboBoxAddBudgetType.Items.Add("Nagar");
            ComboBoxAddBudgetType.Items.Add("Sansadiya Bikash Kosh");
            ComboBoxAddBudgetType.Items.Add("Specify Others");*/

            //Add ---> CurrentStatus
            string[] CurrentStatusList = System.IO.File.ReadAllLines(@".\ComboBoxList\CurrentStatus.txt");
            foreach (var line in CurrentStatusList)
            {
                //string[] tokens = line.Split('\n');
                ComboBoxAddCurStatus.Items.Add(line);
            }
            /*ComboBoxAddCurStatus.Items.Add("Work Permit");
            ComboBoxAddCurStatus.Items.Add("Work Start");
            ComboBoxAddCurStatus.Items.Add("Running Bill #1");
            ComboBoxAddCurStatus.Items.Add("Final Bill");
            ComboBoxAddCurStatus.Items.Add("Specify Others");*/

            //Add ---> Lab Report 
            string[] LabReportList = System.IO.File.ReadAllLines(@".\ComboBoxList\LabReport.txt");
            foreach (var line in LabReportList)
            {
                //string[] tokens = line.Split('\n');
                ComboBoxLabReport.Items.Add(line);
            }
            /*ComboBoxLabReport.Items.Add("Available");
            ComboBoxLabReport.Items.Add("Not Available");
            ComboBoxLabReport.Items.Add("Not Required");
            ComboBoxLabReport.Items.Add("Specify Others");*/

            //Add ---> Board
            string[] BoardList = System.IO.File.ReadAllLines(@".\ComboBoxList\Board.txt");
            foreach (var line in BoardList)
            {
                //string[] tokens = line.Split('\n');
                ComboBoxBoard.Items.Add(line);
            }
            /*ComboBoxBoard.Items.Add("Available");
            ComboBoxBoard.Items.Add("Not Available");
            ComboBoxBoard.Items.Add("Not Required");
            ComboBoxBoard.Items.Add("Specify Others");*/

            //Add ---> Remark 
            string[] RemarkList = System.IO.File.ReadAllLines(@".\ComboBoxList\ProjectName.txt");
            foreach (var line in RemarkList)
            {
                //string[] tokens = line.Split('\n');
               ComboBoxRemark.Items.Add(line);
            }
        }

        private void BtnAddCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Initial Estimate
                string ProgramBudget, EstimatedBudget0, EstimatedBudget2, EstimatedBudget1;
                string Contingency_Percent;

                //ProgramBudget
                if (TxtAddProgramBudget.Text == "")
                {
                    ProgramBudget = 0.ToString();
                }
                else
                {
                    ProgramBudget = TxtAddProgramBudget.Text;
                }

                //EstimatedBudget0
                if (TxtAddEstiBud0.Text == "")
                {
                    EstimatedBudget0 = 0.ToString();
                }
                else
                {
                    EstimatedBudget0 = TxtAddEstiBud0.Text;
                }

                //EstimatedBudget2
                if (TxtAddEstiBud2.Text == "")
                {
                    EstimatedBudget2 = 0.ToString();
                }
                else
                {
                    EstimatedBudget2 = TxtAddEstiBud2.Text;
                }

                //contingency percent
                if (TxtContingencyPercent.Text == "")
                {
                    Contingency_Percent = 3.ToString();
                }
                else
                {
                    Contingency_Percent = TxtContingencyPercent.Text;
                }

                double Contingency = Convert.ToDouble(ProgramBudget) * Convert.ToDouble(Contingency_Percent) / 100;
                double NetPayable0 = Convert.ToDouble(ProgramBudget) - Contingency;
                double Contribution0 = Convert.ToDouble(EstimatedBudget0) - NetPayable0;

                //Frist running bill
                double NetPayable1, Contribution1;
                //EstimatedBudget2
                if (TxtAddEstiBud1.Text == "")
                {
                    EstimatedBudget1 = 0.ToString();
                }
                else
                {
                    EstimatedBudget1 = TxtAddEstiBud1.Text;
                }

                //Netpayable1
                /*if (TxtAddNetPay1.Text == "")
                {
                    NetPayable1 = 0;
                }
                else
                {
                    NetPayable1 = Convert.ToDouble(TxtAddNetPay1.Text);
                }*/

                double EvaluationFactor = NetPayable0 / Convert.ToDouble(EstimatedBudget0);
                TxtEvalulationFactor.Text = EvaluationFactor.ToString();
                NetPayable1 = Convert.ToDouble(EstimatedBudget1) * NetPayable0 / Convert.ToDouble(EstimatedBudget0);
                Contribution1 = Convert.ToDouble(EstimatedBudget1) - NetPayable1;
                TxtAddNetPay1.Text = NetPayable1.ToString("0.00");
                TxtAddContribution1.Text = Contribution1.ToString("0.00");

                

                //Final Bill
                double NetPayable2, Contribution2,TotalNetPay,TotalContribution;

                /*if (Convert.ToDouble(EstimatedBudget2) * 0.9 > NetPayable0)
                {
                    NetPayable2 = NetPayable0;
                }
                else
                {
                    NetPayable2 = Convert.ToDouble(EstimatedBudget2) * 0.9;
                }*/

                //TxtTotalNetPayable.Text = NetPayable2.ToString();
                //Contribution2 = Convert.ToDouble(EstimatedBudget2) - NetPayable2 - Contribution1;

                TotalNetPay = Convert.ToDouble(EstimatedBudget2) * NetPayable0 / Convert.ToDouble(EstimatedBudget0); ;
                TxtTotalNetPayable.Text = TotalNetPay.ToString("0.00");
                TotalContribution = Convert.ToDouble(EstimatedBudget2) - Convert.ToDouble(TotalNetPay);
                TxtTotalContribution.Text = TotalContribution.ToString("0.00");

                //Total Netpay
                /*if (TxtTotalNetPayable.Text == "")
                {
                    TotalNetPay = 0;
                }
                else
                {
                    TotalNetPay = Convert.ToDouble(TxtTotalNetPayable.Text);
                }
                //TotalNetPay = Convert.ToDouble(TxtTotalNetPayable.Text);
                //TotalContribution = Convert.ToDouble(TxtTotalContribution.Text);
                // TotalContribution
                if (TxtTotalContribution.Text == "")
                {
                    TotalContribution = 0;
                }
                else
                {
                    TotalContribution = Convert.ToDouble(TxtTotalContribution.Text);
                }*/

                NetPayable2 = TotalNetPay - NetPayable1;
                Contribution2 = TotalContribution - Contribution1;
                if(TotalNetPay <= NetPayable0)
                {
                    LblCheck.Text = "Log: " + "OK";
                    LblCheck.ForeColor = Color.Green;
                }
                else
                {
                    LblCheck.Text = "Log: " + "Review";
                    LblCheck.ForeColor = Color.Red;
                }
                //TxtTotalContribution.Text = (Contribution2 + Contribution1).ToString();

                //NetPayable2 = NetPayable2 - NetPayable1;
                //TxtAddNetPay2.Text = NetPayable2.ToString();


                TxtAddContingency.Text = Contingency.ToString("0.00");
                TxtAddNetPay0.Text = NetPayable0.ToString("0.00");
                TxtAddContribution0.Text = Contribution0.ToString("0.00");
                TxtAddContribution2.Text = Contribution2.ToString("0.00");
                TxtAddNetPay2.Text = NetPayable2.ToString("0.00");
            }
            catch
            {

            }

        }

        private void ComboBoxAddBudgetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtAddBudgetType.Text = ComboBoxAddBudgetType.Text;
        }

        private void ComboBoxAddCurStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtAddCurStatus.Text = ComboBoxAddCurStatus.Text;
        }

        private void BtnAddExit_Click(object sender, EventArgs e)
        {
            /*using (System.IO.StreamWriter sw = System.IO.File.AppendText(@".\Log\Log.txt"))
            {
                Text2Write = "[" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "]" + "  --->  " + "EXIT"  + " ---> "+  "Record Form" ;
                sw.WriteLine(Text2Write);
            }*/

            Close();
        }

        private void RadioBtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            TxtProjectID.Enabled = false;
            BtnAddRecord.Enabled = true;
            DeleteTextFields();

            BtnDelete.Enabled = false;
            BtnModify.Enabled = false;
            BtnDisplay.Enabled = false;

            LblCheck.Text = "Log: ";
            LblCheck.ForeColor = Color.Black;
        }

        private void RadioBtnDisModDel_CheckedChanged(object sender, EventArgs e)
        {
            TxtProjectID.Enabled = true;
            BtnAddRecord.Enabled = false;
            DeleteTextFields();

            BtnDelete.Enabled = true;
            BtnModify.Enabled = true;
            BtnDisplay.Enabled = true;

            LblCheck.Text = "Log: ";
            LblCheck.ForeColor = Color.Black;
        }
        public void DeleteTextFields()
        {
            // clear text boxex
            TxtProjectID.Text = "";
            TxtAddFiscalYear.Text = "";
            TxtAddProjecName.Text = "";
            TxtAddWard.Text = "";
            TxtAddLocation.Text = "";

            TxtWorkPermit.Text = "";
            TxtWorkStart.Text = "";
            TxtFirstRunBill.Text = "";
            TxtFinalBill.Text = "";

            TxtAddCurStatus.Text = "";
            TxtDescription.Text = "";
            TxtAddRemark.Text = "";

            TxtLabReport.Text = "";
            TxtBoard.Text = "";

            TxtAddBudgetType.Text = "";
            TxtAddProgramBudget.Text = "";
            TxtAddContingency.Text = "";
            TxtAddEstiBud0.Text = "";
            TxtAddNetPay0.Text = "";
            TxtAddContribution0.Text = "";

            TxtAddEstiBud1.Text = "";
            TxtAddNetPay1.Text = "";
            TxtAddContribution1.Text = "";

            TxtAddEstiBud2.Text = "";
            TxtAddNetPay2.Text = "";
            TxtAddContribution2.Text = "";

            TxtCube1.Text = "";
            TxtCube2.Text = "";
            TxtCube3.Text = "";
            TxtCube4.Text = "";
            TxtCube5.Text = "";
            TxtCube6.Text = "";
            TxtCube7.Text = "";
            TxtCube8.Text = "";
            TxtCube9.Text = "";

            TxtUCName.Text = "";
            TxtUCContact.Text = "";

            TxtLength.Text = "";
            TxtWidth.Text = "";
            TxtHeight.Text = "";

            TxtRefer.Text = "";

            ComboBoxFiscalYear.SelectedIndex = -1;
            ComboBoxProjectName.SelectedIndex = -1;
            ComboBoxAddCurStatus.SelectedIndex = -1;
            ComboBoxAddBudgetType.SelectedIndex = -1;
            ComboBoxLabReport.SelectedIndex = -1;
            ComboBoxBoard.SelectedIndex = -1;
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            string ProjectID = TxtProjectID.Text;
            string FiscalYear = TxtAddFiscalYear.Text;
            string ProjectName = TxtAddProjecName.Text;
            string Ward = TxtAddWard.Text;
            string Location = TxtAddLocation.Text;
            string BudgetType = TxtAddBudgetType.Text;

            string WorkPermit = TxtWorkPermit.Text;
            string WorkStart = TxtWorkStart.Text;
            string FirstRunningBill = TxtFirstRunBill.Text;
            string FinalBill = TxtFinalBill.Text;

            string CurrentStatus = TxtAddCurStatus.Text;
            string Description = TxtDescription.Text;
            string Remark = TxtAddRemark.Text;

            string LabReport = TxtLabReport.Text;
            string Board = TxtBoard.Text;

            string ProgramBudget = TxtAddProgramBudget.Text;
            string Contingency = TxtAddContingency.Text;
            string EstimatedBudget0 = TxtAddEstiBud0.Text;
            string NetPayable0 = TxtAddNetPay0.Text;
            string Contribution0 = TxtAddContribution0.Text;

            string EstimatedBudget1 = TxtAddEstiBud1.Text;
            string NetPayable1 = TxtAddNetPay1.Text;
            string Contribution1 = TxtAddContribution1.Text;

            string EstimatedBudget2 = TxtAddEstiBud2.Text;
            string NetPayable2 = TxtAddNetPay2.Text;
            string Contribution2 = TxtAddContribution2.Text;

            string Cube1 = TxtCube1.Text;
            string Cube2 = TxtCube2.Text;
            string Cube3 = TxtCube3.Text;
            string Cube4 = TxtCube4.Text;
            string Cube5 = TxtCube5.Text;
            string Cube6 = TxtCube6.Text;
            string Cube7 = TxtCube7.Text;
            string Cube8 = TxtCube8.Text;
            string Cube9 = TxtCube9.Text;

            string UCName = TxtUCName.Text;
            string UCContact = TxtUCContact.Text;

            string Length = TxtLength.Text;
            string Width = TxtWidth.Text;
            string Height = TxtHeight.Text;

            string Refer = TxtRefer.Text;

            DialogResult dr = MessageBox.Show("Are you sure, you want to Modify?", "Modify", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //Modify
                SQLiteConnection ConnectDb = new SQLiteConnection("Data Source = ProgramRecord.sqlite3");
                ConnectDb.Open();

                //string query = "REPLACE INTO SWAT_Iterations(ID,ProjectName,IterationNo,Parameters,Remark,Findings,FinalVerdict) VALUES('" + ID + "','" + ProjectName + "','" + IterationNo + "','" + Parameters + "','" + Remark + "','" + Findings + "','" + FinalVerdict + "')";

                string query = "REPLACE INTO TableProjectRecords(ProjectID,FiscalYear,ProjectName,Ward," +
                    "Location,BudgetType,WorkPermit,WorkStart,FirstRunningBill,FinalBill," +
                    "CurrentStatus,Description,Remark,LabReport,Board," +
                    "ProgramBudget,Contingency,EstimatedBudget0,NetPayable0,Contribution0," +
                    "EstimatedBudget1,NetPayable1,Contribution1,EstimatedBudget2,NetPayable2," +
                    "Contribution2,Cube1,Cube2,Cube3,Cube4,Cube5,Cube6,Cube7,Cube8,Cube9,UCName,UCContact," +
                    "Length,Width,Height,Refer) " +
                   "VALUES('" + ProjectID + "', '" + FiscalYear + "','" + ProjectName + "','" + Ward + "','" + Location + "'," +
                    "'" + BudgetType + "','" + WorkPermit + "','" + WorkStart + "','" + FirstRunningBill + "'" +
                    ",'" + FinalBill + "','" + CurrentStatus + "','" + Description + "','" + Remark + "'" +
                    ",'" + LabReport + "','" + Board + "','" + ProgramBudget + "','" + Contingency + "','" + EstimatedBudget0 + "','" + NetPayable0 + "'" +
                    ",'" + Contribution0 + "','" + EstimatedBudget1 + "','" + NetPayable1 + "','" + Contribution1 + "'" +
                    ",'" + EstimatedBudget2 + "','" + NetPayable2 + "','" + Contribution2 + "','" + Cube1 + "'" +
                    ",'" + Cube2 + "','" + Cube3 + "','" + Cube4 + "','" + Cube5 + "','" + Cube6 + "'" +
                    ",'" + Cube7 + "','" + Cube8 + "','" + Cube9 + "','" + UCName + "','" + UCContact + "'" +
                    ",'" + Length + "','" + Width + "','" + Height + "','" + Refer + "')";

                SQLiteCommand Cmd = new SQLiteCommand(query, ConnectDb);
                Cmd.ExecuteNonQuery();

                ConnectDb.Close();

                TxtAddLog.AppendText("Activity: Successfully Modified Record: " + "Project ID: " + ProjectID + "  " +ProjectName + " of " + Ward + " at " + Location);
                TxtAddLog.AppendText(Environment.NewLine);

                using (System.IO.StreamWriter sw = System.IO.File.AppendText(@".\Log\Log.txt"))
                {
                    Text2Write = "[" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "]" + "  --->  " + "MODIFY" + " ---> " + "Project ID: " + ProjectID + "  " + ProjectName + " of " + Ward + " at " + Location;
                    sw.WriteLine(Text2Write);
                }
                LblCheck.Text = "Log: ";
                LblCheck.ForeColor = Color.Black;
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string ProjectID = TxtProjectID.Text;

            string ProjectName = TxtAddProjecName.Text;
            string Ward = TxtAddWard.Text;
            string Location = TxtAddLocation.Text;

            if (TxtProjectID.Text == "")
            {
                TxtAddLog.Text = "Enter Project ID to Delete";
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are You Sure, you want to delete?", "Delete", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //delete
                    SQLiteConnection ConnectDb = new SQLiteConnection("Data Source = ProgramRecord.sqlite3");
                    ConnectDb.Open();

                    //string query = "DELETE FROM  SWAT_Iterations WHERE ID ='" + TxtUpdateID.Text + "' ";
                    string query = "DELETE FROM  TableProjectRecords WHERE ProjectID ='" + TxtProjectID.Text + "' ";
                    SQLiteCommand Cmd = new SQLiteCommand(query, ConnectDb);
                    Cmd.ExecuteNonQuery();

                    ConnectDb.Close();

                    TxtProjectID.Text = "";

                    TxtAddLog.AppendText("Deleted Projedt ID: " + ProjectID + " => " + ProjectName + " of " + Ward + " at " + Location);
                    TxtAddLog.AppendText(Environment.NewLine);

                    using (System.IO.StreamWriter sw = System.IO.File.AppendText(@".\Log\Log.txt"))
                    {
                        Text2Write = "[" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "]" + "  --->  " + "DELETE" + " ---> " + "Project ID: " + ProjectID + "  " + ProjectName + " of " + Ward + " at " + Location;
                        sw.WriteLine(Text2Write);
                    }

                    LblCheck.Text = "Log: ";
                    LblCheck.ForeColor = Color.Black;
                }
                else if (dr == DialogResult.No)
                {
                    //Nothing to do
                }

            }
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            if (TxtProjectID.Text == "")
            {
                TxtAddLog.AppendText("Enter Project ID to Display");
                TxtAddLog.AppendText(Environment.NewLine);
            }
            else
            {
                SQLiteConnection ConnectDb = new SQLiteConnection("Data Source = ProgramRecord.sqlite3");
                ConnectDb.Open();

                //string query = "SELECT * FROM SWAT_Iterations where ID = '" + TxtUpdateID.Text + "'";
                string query = "SELECT * FROM TableProjectRecords where ProjectID = '" + TxtProjectID.Text + "'";

                SQLiteDataAdapter DataAdptr = new SQLiteDataAdapter(query, ConnectDb);

                DataTable Dt = new DataTable();
                DataAdptr.Fill(Dt);
                //string value;
                foreach (DataRow row in Dt.Rows) //there is only one row here
                {
                    //value = row[1].ToString();
                    //TxtAddProjecName.Text = row[1].ToString();

                    TxtAddFiscalYear.Text = row[1].ToString();
                    TxtAddProjecName.Text = row[2].ToString();
                    TxtAddWard.Text = row[3].ToString();
                    TxtAddLocation.Text = row[4].ToString();
                    TxtAddBudgetType.Text = row[5].ToString();

                    TxtWorkPermit.Text = row[6].ToString();
                    TxtWorkStart.Text = row[7].ToString();
                    TxtFirstRunBill.Text = row[8].ToString();
                    TxtFinalBill.Text = row[9].ToString();

                    TxtAddCurStatus.Text = row[10].ToString();
                    TxtDescription.Text = row[11].ToString();
                    TxtAddRemark.Text = row[12].ToString();

                    TxtLabReport.Text = row[13].ToString();
                    TxtBoard.Text = row[14].ToString();

                    TxtAddProgramBudget.Text = row[15].ToString();
                    TxtAddContingency.Text = row[16].ToString();
                    TxtAddEstiBud0.Text = row[17].ToString();
                    TxtAddNetPay0.Text = row[18].ToString();
                    TxtAddContribution0.Text = row[19].ToString();

                    TxtAddEstiBud1.Text = row[20].ToString();
                    TxtAddNetPay1.Text = row[21].ToString();
                    TxtAddContribution1.Text = row[22].ToString();

                    TxtAddEstiBud2.Text = row[23].ToString();
                    TxtAddNetPay2.Text = row[24].ToString();
                    TxtAddContribution2.Text = row[25].ToString();

                    TxtCube1.Text = row[26].ToString();
                    TxtCube2.Text = row[27].ToString();
                    TxtCube3.Text = row[28].ToString();
                    TxtCube4.Text = row[29].ToString();
                    TxtCube5.Text = row[30].ToString();
                    TxtCube6.Text = row[31].ToString();
                    TxtCube7.Text = row[32].ToString();
                    TxtCube8.Text = row[33].ToString();
                    TxtCube9.Text = row[34].ToString();

                    TxtUCContact.Text = row[35].ToString();
                    TxtUCName.Text = row[36].ToString();

                    TxtLength.Text = row[37].ToString();
                    TxtWidth.Text = row[38].ToString();
                    TxtHeight.Text = row[39].ToString();

                    TxtRefer.Text = row[40].ToString();
                }
                ConnectDb.Close();

                string ProjectID = TxtProjectID.Text;

                string ProjectName = TxtAddProjecName.Text;
                string Ward = TxtAddWard.Text;
                string Location = TxtAddLocation.Text;

                TxtAddLog.AppendText("Displayed Projedt ID: " + ProjectID + " => " + ProjectName + " of " + Ward + " at " + Location);
                TxtAddLog.AppendText(Environment.NewLine);
            }
        }
        public void StoreDatainRecordFormat()
        {
            string ProjectID = TxtProjectID.Text;
            string FiscalYear = TxtAddFiscalYear.Text;
            string ProjectName = TxtAddProjecName.Text;
            string Ward = TxtAddWard.Text;
            string Location = TxtAddLocation.Text;
            string BudgetType = TxtAddBudgetType.Text;

            string WorkPermit = TxtWorkPermit.Text;
            string WorkStart = TxtWorkStart.Text;
            string FirstRunningBill = TxtFirstRunBill.Text;
            string FinalBill = TxtFinalBill.Text;

            string CurrentStatus = TxtAddCurStatus.Text;
            string Description = TxtDescription.Text;
            string Remark = TxtAddRemark.Text;

            string LabReport = TxtLabReport.Text;
            string Board = TxtBoard.Text;

            string ProgramBudget = TxtAddProgramBudget.Text;
            string Contingency = TxtAddContingency.Text;
            string EstimatedBudget0 = TxtAddEstiBud0.Text;
            string NetPayable0 = TxtAddNetPay0.Text;
            string Contribution0 = TxtAddContribution0.Text;

            string EstimatedBudget1 = TxtAddEstiBud1.Text;
            string NetPayable1 = TxtAddNetPay1.Text;
            string Contribution1 = TxtAddContribution1.Text;

            string EstimatedBudget2 = TxtAddEstiBud2.Text;
            string NetPayable2 = TxtAddNetPay2.Text;
            string Contribution2 = TxtAddContribution2.Text;

            string Cube1 = TxtCube1.Text;
            string Cube2 = TxtCube2.Text;
            string Cube3 = TxtCube3.Text;
            string Cube4 = TxtCube4.Text;
            string Cube5 = TxtCube5.Text;
            string Cube6 = TxtCube6.Text;
            string Cube7 = TxtCube7.Text;
            string Cube8 = TxtCube8.Text;
            string Cube9 = TxtCube9.Text;

            string UCName = TxtUCName.Text;
            string UCContact = TxtUCContact.Text;

            string Length = TxtLength.Text;
            string Width = TxtWidth.Text;
            string Height = TxtHeight.Text;

            string Refer = TxtRefer.Text;

            //Storing in string

            StrDisplayRecordFormat = "";

            StrDisplayRecordFormat += "ModifiedDate:" + DateTime.Now.ToString("hh:mm:ss");
            StrDisplayRecordFormat += Environment.NewLine;

            StrDisplayRecordFormat += "--------------------------------------";
            StrDisplayRecordFormat += Environment.NewLine;

            StrDisplayRecordFormat += ("A. General");
            StrDisplayRecordFormat += Environment.NewLine;

            StrDisplayRecordFormat += "--------------------------------------";
            StrDisplayRecordFormat += Environment.NewLine;

            StrDisplayRecordFormat += "Project ID:  " + ProjectID;
            StrDisplayRecordFormat += Environment.NewLine;

            StrDisplayRecordFormat += ("Fiscal Year:  " + FiscalYear);
            StrDisplayRecordFormat += Environment.NewLine;

            StrDisplayRecordFormat += "Project Name:  " + ProjectName;
            StrDisplayRecordFormat += Environment.NewLine;

            StrDisplayRecordFormat += "Ward:  " + Ward;
            StrDisplayRecordFormat += Environment.NewLine;

            StrDisplayRecordFormat += "Location:  " + Location;
            StrDisplayRecordFormat += Environment.NewLine;

            StrDisplayRecordFormat += "Budget Type:  " + BudgetType;
            StrDisplayRecordFormat += Environment.NewLine;

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("B. Work Date");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("WorkStart:  " + WorkStart);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("WorkPermit:  " + WorkPermit);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("First Running Bill:  " + FirstRunningBill);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Final Bill:  " + FinalBill);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("C. Others");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("CurrentStatus:  " + CurrentStatus);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Description:  " + Description);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Remark:  " + Remark);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("D. Document");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Lab Report:  " + LabReport);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Board:  " + Board);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("E. Work Permit");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("ProgramBudget:  " + ProgramBudget);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Contingency:  " + Contingency);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Estimated Budget 0:  " + EstimatedBudget0);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Net Payable 0:  " + NetPayable0);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Contribution 0:  " + Contribution0);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("F. First Running Bill");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Estimated Budget 1:  " + EstimatedBudget1);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Net Payable 1:  " + NetPayable1);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Contribution 1:  " + Contribution1);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("G. Final Bill");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Estimated Budget 2:  " + EstimatedBudget2);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Net Payable 2:  " + NetPayable2);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Contribution 2:  " + Contribution2);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("H. Cube Cast Date");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Cube 1:  " + Cube1);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Cube 2:  " + Cube2);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Cube 3:  " + Cube3);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Cube 4:  " + Cube4);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Cube 5:  " + Cube5);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Cube 6:  " + Cube6);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Cube 7:  " + Cube7);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Cube 8:  " + Cube8);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Cube 9:  " + Cube9);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("I. U/C Info");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("U/C Name:  " + UCName);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("U/C Contact:  " + UCContact);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("J. Project Mesurement Info");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Length:  " + Length);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Width:  " + Width);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Height:  " + Height);
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("K. Reference");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("--------------------------------------");
            StrDisplayRecordFormat += (Environment.NewLine);

            StrDisplayRecordFormat += ("Refer Previous Estimate (if revised):  " + Refer);
            StrDisplayRecordFormat += (Environment.NewLine);

            //store filename in string
            StrFileName = "";
            //StrFileName = Ward + "_" + ProjectID + "_" + ProjectName + "_" + Location +"_" + BudgetType + ".txt";
            StrFileName = Ward + "_" + Location + "_ID_" + ProjectID +"_" + ".txt";
        }

        private void BtnPreviewRecord_Click(object sender, EventArgs e)
        {
            StoreDatainRecordFormat(); 
            FrmDisplayRecordFormat fdisrecformat = new FrmDisplayRecordFormat();
            fdisrecformat.Show();
        }

        private void ComboBoxLabReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtLabReport.Text = ComboBoxLabReport.Text;
        }

        private void ComboBoxProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtAddProjecName.Text = ComboBoxProjectName.Text;
        }

        private void ComboBoxFiscalYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtAddFiscalYear.Text = ComboBoxFiscalYear.Text;
        }

        private void ComboBoxRemark_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtAddRemark.Text = ComboBoxRemark.Text;
        }

        public void EvaluationFactor()
        {
            try
            {
               // string EstimatedBudget0 = TxtAddEstiBud0.Text;
               // string NetPayable0 = TxtAddNetPay0.Text;
                
                double EvalFacto = Convert.ToDouble(TxtAddNetPay0.Text) / Convert.ToDouble(TxtAddEstiBud0.Text);
                TxtEvalulationFactor.Text = EvalFacto.ToString();

            }
            catch
            {

            }
        }

        private void ComboBoxBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtBoard.Text = ComboBoxBoard.Text;
        }
    }
}
