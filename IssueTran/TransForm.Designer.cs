namespace IssueTran
{
    partial class TransForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerIDBox = new System.Windows.Forms.TextBox();
            this.vidCodeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.issueDate = new System.Windows.Forms.DateTimePicker();
            this.dueDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CustNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.movieTitleBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // customerIDBox
            // 
            this.customerIDBox.Location = new System.Drawing.Point(464, 141);
            this.customerIDBox.Name = "customerIDBox";
            this.customerIDBox.Size = new System.Drawing.Size(206, 38);
            this.customerIDBox.TabIndex = 1;
            this.customerIDBox.Enter += new System.EventHandler(this.customerIDBox_Enter);
            // 
            // vidCodeBox
            // 
            this.vidCodeBox.Location = new System.Drawing.Point(464, 265);
            this.vidCodeBox.Name = "vidCodeBox";
            this.vidCodeBox.Size = new System.Drawing.Size(150, 38);
            this.vidCodeBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Video Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Issue Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Due Date";
            // 
            // issueDate
            // 
            this.issueDate.Location = new System.Drawing.Point(464, 373);
            this.issueDate.Name = "issueDate";
            this.issueDate.Size = new System.Drawing.Size(322, 38);
            this.issueDate.TabIndex = 8;
            // 
            // dueDate
            // 
            this.dueDate.Location = new System.Drawing.Point(464, 429);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(322, 38);
            this.dueDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Remarks";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(464, 500);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(538, 417);
            this.textBox3.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 953);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 85);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(699, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(641, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 38);
            this.button3.TabIndex = 14;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CustNameBox
            // 
            this.CustNameBox.Location = new System.Drawing.Point(464, 185);
            this.CustNameBox.Name = "CustNameBox";
            this.CustNameBox.ReadOnly = true;
            this.CustNameBox.Size = new System.Drawing.Size(362, 38);
            this.CustNameBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 16;
            // 
            // movieTitleBox
            // 
            this.movieTitleBox.Location = new System.Drawing.Point(464, 309);
            this.movieTitleBox.Name = "movieTitleBox";
            this.movieTitleBox.ReadOnly = true;
            this.movieTitleBox.Size = new System.Drawing.Size(362, 38);
            this.movieTitleBox.TabIndex = 17;
            // 
            // TransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 1130);
            this.Controls.Add(this.movieTitleBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustNameBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.issueDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vidCodeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerIDBox);
            this.Controls.Add(this.label1);
            this.Name = "TransForm";
            this.Text = "New Transaction Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerIDBox;
        private System.Windows.Forms.TextBox vidCodeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker issueDate;
        private System.Windows.Forms.DateTimePicker dueDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox CustNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox movieTitleBox;
    }
}

