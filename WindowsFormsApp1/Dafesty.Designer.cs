namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VidCode = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Update_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Code: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rental Price: ";
            // 
            // VidCode
            // 
            this.VidCode.Location = new System.Drawing.Point(372, 188);
            this.VidCode.Name = "VidCode";
            this.VidCode.Size = new System.Drawing.Size(228, 38);
            this.VidCode.TabIndex = 2;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(372, 263);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(228, 38);
            this.Price.TabIndex = 3;
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(331, 435);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(174, 69);
            this.Update_btn.TabIndex = 4;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "View Movie List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 793);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.VidCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Change Video Rental Price";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VidCode;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button button1;
    }
}

