using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Softone;
using System.Threading;

namespace Example1
{
    public partial class Form1 : Form
    {
        XSupport Prg;
        XModule Customer;
        XModule SalDoc;
        XTable CustTbl;
        int FHostHandle;

        public Form1()
        {
            InitializeComponent();
            XSupport.InitInterop( Handle.ToInt32() );  //Change2
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
            Soft1Login("C:\\DevDays\\Soft1\\web.XCO", edUN.Text.Trim(), edPS.Text.Trim(), 1000, 1000, DateTime.Today);
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            Customer = Prg.CreateModule("CUSTOMER");
            CustTbl = Customer.GetTable("TRDR");
        }

        private void btnLocateFromID_Click(object sender, EventArgs e)
        {
            Customer.LocateData(int.Parse(txtID.Text));
           txtCode.Text = (string)CustTbl[0, "NAME"];

        }

        private void btnPostback_Click(object sender, EventArgs e)
        {
            CustTbl.Current.Edit(0);
            CustTbl.Current["NAME"] = txtCode.Text;
            CustTbl.Current.Post();
            Customer.PostData();

        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            Prg.ExecS1Command("CUSTOMER[AUTOLOCATE=69]", null);//Change2
        }


        private void button2_Click(object sender, EventArgs e)
        {
            printSalDoc();
        }

        

        private void printSalDoc()
        {

           SalDoc = Prg.CreateModule("SALDOC");
           SalDoc.LocateData(101820);

           object[] myArray;
           myArray = new object[4];
           object SysRequest = Prg.GetStockObj("SysRequest", true);
           myArray[0] = SalDoc.Handle;

           myArray[1] = edFormCode.Text;
           myArray[2] = @"928";
           myArray[3] = "C:\\Users\\johng\\Desktop\\netPrint.txt";
           Prg.CallPublished(SysRequest, "PrintForm", myArray);
       }

        
    }
}
