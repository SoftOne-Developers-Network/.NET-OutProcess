namespace Example2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edPS = new System.Windows.Forms.TextBox();
            this.edUN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edSeries = new System.Windows.Forms.TextBox();
            this.edCustID = new System.Windows.Forms.TextBox();
            this.edItemID = new System.Windows.Forms.TextBox();
            this.btnCreateSalDoc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.Location = new System.Drawing.Point(-16, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "5.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(-16, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "4.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(-16, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "3.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(-16, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "2.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(-16, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "1.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.edPS);
            this.panel1.Controls.Add(this.edUN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 71);
            this.panel1.TabIndex = 43;
            // 
            // edPS
            // 
            this.edPS.Location = new System.Drawing.Point(100, 42);
            this.edPS.Name = "edPS";
            this.edPS.Size = new System.Drawing.Size(170, 20);
            this.edPS.TabIndex = 7;
            // 
            // edUN
            // 
            this.edUN.Location = new System.Drawing.Point(100, 10);
            this.edUN.Name = "edUN";
            this.edUN.Size = new System.Drawing.Size(170, 20);
            this.edUN.TabIndex = 6;
            this.edUN.Text = "Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UserName";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(294, 10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(182, 53);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Series Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Item ID";
            // 
            // edSeries
            // 
            this.edSeries.Location = new System.Drawing.Point(88, 116);
            this.edSeries.Name = "edSeries";
            this.edSeries.Size = new System.Drawing.Size(100, 20);
            this.edSeries.TabIndex = 52;
            this.edSeries.Text = "62";
            // 
            // edCustID
            // 
            this.edCustID.Location = new System.Drawing.Point(87, 142);
            this.edCustID.Name = "edCustID";
            this.edCustID.Size = new System.Drawing.Size(100, 20);
            this.edCustID.TabIndex = 53;
            this.edCustID.Text = "33";
            // 
            // edItemID
            // 
            this.edItemID.Location = new System.Drawing.Point(87, 168);
            this.edItemID.Name = "edItemID";
            this.edItemID.Size = new System.Drawing.Size(100, 20);
            this.edItemID.TabIndex = 54;
            this.edItemID.Tag = "";
            this.edItemID.Text = "14";
            // 
            // btnCreateSalDoc
            // 
            this.btnCreateSalDoc.Location = new System.Drawing.Point(232, 119);
            this.btnCreateSalDoc.Name = "btnCreateSalDoc";
            this.btnCreateSalDoc.Size = new System.Drawing.Size(210, 75);
            this.btnCreateSalDoc.TabIndex = 55;
            this.btnCreateSalDoc.Text = "Create SalDoc";
            this.btnCreateSalDoc.UseVisualStyleBackColor = true;
            this.btnCreateSalDoc.Click += new System.EventHandler(this.btnCreateSalDoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 429);
            this.Controls.Add(this.btnCreateSalDoc);
            this.Controls.Add(this.edItemID);
            this.Controls.Add(this.edCustID);
            this.Controls.Add(this.edSeries);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Dev days Example 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox edPS;
        private System.Windows.Forms.TextBox edUN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edSeries;
        private System.Windows.Forms.TextBox edCustID;
        private System.Windows.Forms.TextBox edItemID;
        private System.Windows.Forms.Button btnCreateSalDoc;
    }
}

