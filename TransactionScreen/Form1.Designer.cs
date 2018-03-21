namespace TransactionScreen
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
            this.movieTitleBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CustNameBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cust_lookup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.remarksBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dueDate = new System.Windows.Forms.DateTimePicker();
            this.issueDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vidCodeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movieTitleBox
            // 
            this.movieTitleBox.Location = new System.Drawing.Point(483, 237);
            this.movieTitleBox.Name = "movieTitleBox";
            this.movieTitleBox.ReadOnly = true;
            this.movieTitleBox.Size = new System.Drawing.Size(362, 38);
            this.movieTitleBox.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 32;
            // 
            // CustNameBox
            // 
            this.CustNameBox.Location = new System.Drawing.Point(483, 113);
            this.CustNameBox.Name = "CustNameBox";
            this.CustNameBox.ReadOnly = true;
            this.CustNameBox.Size = new System.Drawing.Size(362, 38);
            this.CustNameBox.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(660, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 52);
            this.button3.TabIndex = 30;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cust_lookup
            // 
            this.cust_lookup.Location = new System.Drawing.Point(718, 56);
            this.cust_lookup.Name = "cust_lookup";
            this.cust_lookup.Size = new System.Drawing.Size(76, 51);
            this.cust_lookup.TabIndex = 29;
            this.cust_lookup.Text = "...";
            this.cust_lookup.UseVisualStyleBackColor = true;
            this.cust_lookup.Click += new System.EventHandler(this.cust_lookup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(853, 881);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 85);
            this.button1.TabIndex = 28;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // remarksBox
            // 
            this.remarksBox.Location = new System.Drawing.Point(483, 428);
            this.remarksBox.Multiline = true;
            this.remarksBox.Name = "remarksBox";
            this.remarksBox.Size = new System.Drawing.Size(538, 417);
            this.remarksBox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = "Remarks";
            // 
            // dueDate
            // 
            this.dueDate.Location = new System.Drawing.Point(483, 357);
            this.dueDate.MinDate = new System.DateTime(2018, 3, 21, 0, 0, 0, 0);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(322, 38);
            this.dueDate.TabIndex = 25;
            // 
            // issueDate
            // 
            this.issueDate.Location = new System.Drawing.Point(483, 301);
            this.issueDate.Name = "issueDate";
            this.issueDate.Size = new System.Drawing.Size(322, 38);
            this.issueDate.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Due Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Issue Date";
            // 
            // vidCodeBox
            // 
            this.vidCodeBox.Location = new System.Drawing.Point(483, 193);
            this.vidCodeBox.Name = "vidCodeBox";
            this.vidCodeBox.Size = new System.Drawing.Size(150, 38);
            this.vidCodeBox.TabIndex = 21;
            this.vidCodeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vidCodeBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Video Code";
            // 
            // customerIDBox
            // 
            this.customerIDBox.Location = new System.Drawing.Point(483, 69);
            this.customerIDBox.Name = "customerIDBox";
            this.customerIDBox.Size = new System.Drawing.Size(206, 38);
            this.customerIDBox.TabIndex = 19;
            this.customerIDBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customerIDBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 1512);
            this.Controls.Add(this.movieTitleBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustNameBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cust_lookup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.remarksBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.issueDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vidCodeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerIDBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox movieTitleBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustNameBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cust_lookup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox remarksBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dueDate;
        private System.Windows.Forms.DateTimePicker issueDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vidCodeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerIDBox;
        private System.Windows.Forms.Label label1;
    }
}

