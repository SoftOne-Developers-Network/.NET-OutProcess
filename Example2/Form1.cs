using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Softone;



namespace Example2
{
    public partial class Form1 : Form
    {
        private XSupport Prg;
        public Form1()
        {
            InitializeComponent();
            XSupport.InitInterop();

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            XSupport.EndInterop();
        }

        private void Soft1Login(string xco, string UserName, string Password, int Company, int Branch, DateTime LoginDate)
        {
            try
            {
                Prg = XSupport.Login(xco, UserName, Password, Company, Branch, LoginDate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Soft1Login("C:\\devdays\\soft1\\web.xco", edUN.Text.Trim(), edPS.Text.Trim(), 1000, 1000, DateTime.Today);
        }

        
        private void InsSalDocToS1(int seriesID, int CustID, int ItemID)
        {
            XModule ModuleFinDoc = Prg.CreateModule("SALDOC");
            XTable FinDoc = ModuleFinDoc.GetTable("FINDOC");
            XTable IteLines = ModuleFinDoc.GetTable("ITELINES");
            XTable MtrDoc = ModuleFinDoc.GetTable("MTRDOC");
            try
            {
                ModuleFinDoc.InsertData();
                FinDoc.Current["SERIES"] = seriesID;
                FinDoc.Current["FPRMS"] = seriesID;
                FinDoc.Current["TRNDATE"] = DateTime.Today;
                FinDoc.Current["TRDR"] = CustID;
                FinDoc.Current["VATSTS"] = 1;
                FinDoc.Current["FISCPRD"] = DateTime.Today.Year;
                FinDoc.Current["BRANCH"] = 1;

                MtrDoc.Current["WHOUSE"] = 1;


                FinDoc.Current.Post();
                MtrDoc.Current.Post();

                IteLines.Current.Insert();
                IteLines.Current["MTRL"] = ItemID;
                IteLines.Current["QTY"] = 1.00;
                IteLines.Current["QTY1"] = 1.00;
                IteLines.Current["PRICE"] = 1.190;
                IteLines.Current["DISC1PRC"] = 10.00;
                IteLines.Current.Post();



                ModuleFinDoc.PostData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnCreateSalDoc_Click(object sender, EventArgs e)
        {
            InsSalDocToS1(int.Parse(edSeries.Text.Trim()), int.Parse(edCustID.Text.Trim()), int.Parse(edItemID.Text.Trim()));
        }

    }
}
