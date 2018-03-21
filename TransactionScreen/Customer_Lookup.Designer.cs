namespace TransactionScreen
{
    partial class Customer_Lookup
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.cust_grid = new System.Windows.Forms.DataGridView();
            this.search_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cust_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Customer Name",
            "Member Category"});
            this.comboBox.Location = new System.Drawing.Point(149, 67);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(298, 39);
            this.comboBox.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(149, 112);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(438, 38);
            this.searchBox.TabIndex = 1;
            // 
            // cust_grid
            // 
            this.cust_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cust_grid.Location = new System.Drawing.Point(145, 188);
            this.cust_grid.Name = "cust_grid";
            this.cust_grid.RowTemplate.Height = 40;
            this.cust_grid.Size = new System.Drawing.Size(1216, 673);
            this.cust_grid.TabIndex = 2;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(643, 112);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(137, 52);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(508, 910);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(123, 55);
            this.ok_btn.TabIndex = 4;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(688, 910);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(123, 55);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Customer_Lookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 1712);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.cust_grid);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.comboBox);
            this.Name = "Customer_Lookup";
            this.Text = "Customer_Lookup";
            ((System.ComponentModel.ISupportInitialize)(this.cust_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView cust_grid;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}