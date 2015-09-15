namespace Example1
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
            this.edUN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edPS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPostback = new System.Windows.Forms.Button();
            this.btnLocateFromID = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.edFormCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.Location = new System.Drawing.Point(-31, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "5.";
            // 
            // edUN
            // 
            this.edUN.Location = new System.Drawing.Point(100, 10);
            this.edUN.Name = "edUN";
            this.edUN.Size = new System.Drawing.Size(170, 20);
            this.edUN.TabIndex = 6;
            this.edUN.Text = "Admin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(-31, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "4.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(-31, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "3.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(-31, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "2.";
            // 
            // edPS
            // 
            this.edPS.Location = new System.Drawing.Point(100, 42);
            this.edPS.Name = "edPS";
            this.edPS.Size = new System.Drawing.Size(170, 20);
            this.edPS.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(-31, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "1.";
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(80, 96);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(353, 23);
            this.btnCreateCustomer.TabIndex = 21;
            this.btnCreateCustomer.Text = "Create Customer Object";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
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
            this.panel1.Size = new System.Drawing.Size(797, 71);
            this.panel1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 60);
            this.button1.TabIndex = 36;
            this.button1.Text = "Open CUSTOMER Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Enter customer  ID :";
            // 
            // btnPostback
            // 
            this.btnPostback.Location = new System.Drawing.Point(80, 307);
            this.btnPostback.Name = "btnPostback";
            this.btnPostback.Size = new System.Drawing.Size(353, 23);
            this.btnPostback.TabIndex = 25;
            this.btnPostback.Text = "After locate if Change push to Post";
            this.btnPostback.UseVisualStyleBackColor = true;
            this.btnPostback.Click += new System.EventHandler(this.btnPostback_Click);
            // 
            // btnLocateFromID
            // 
            this.btnLocateFromID.Location = new System.Drawing.Point(238, 149);
            this.btnLocateFromID.Name = "btnLocateFromID";
            this.btnLocateFromID.Size = new System.Drawing.Size(101, 23);
            this.btnLocateFromID.TabIndex = 24;
            this.btnLocateFromID.Text = "Push to Locate";
            this.btnLocateFromID.UseVisualStyleBackColor = true;
            this.btnLocateFromID.Click += new System.EventHandler(this.btnLocateFromID_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(184, 227);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(249, 20);
            this.txtCode.TabIndex = 23;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(184, 151);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(45, 20);
            this.txtID.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Push to Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // edFormCode
            // 
            this.edFormCode.Location = new System.Drawing.Point(181, 418);
            this.edFormCode.Name = "edFormCode";
            this.edFormCode.Size = new System.Drawing.Size(45, 20);
            this.edFormCode.TabIndex = 39;
            this.edFormCode.Text = "6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Enter form code:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 577);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edFormCode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreateCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPostback);
            this.Controls.Add(this.btnLocateFromID);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "DevDays OutProcess Example";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edUN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edPS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPostback;
        private System.Windows.Forms.Button btnLocateFromID;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox edFormCode;
        private System.Windows.Forms.Label label5;
    }
}

