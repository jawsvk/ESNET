namespace EF2DEMO
{
    partial class Movie_Maintenance
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
            this.load_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vidcodeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.movieTitleBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.last_btn = new System.Windows.Forms.Button();
            this.first_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(249, 407);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(152, 56);
            this.load_btn.TabIndex = 0;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video Code";
            // 
            // vidcodeBox
            // 
            this.vidcodeBox.Location = new System.Drawing.Point(451, 70);
            this.vidcodeBox.Name = "vidcodeBox";
            this.vidcodeBox.Size = new System.Drawing.Size(100, 38);
            this.vidcodeBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movie Title";
            // 
            // movieTitleBox
            // 
            this.movieTitleBox.Location = new System.Drawing.Point(451, 134);
            this.movieTitleBox.Name = "movieTitleBox";
            this.movieTitleBox.Size = new System.Drawing.Size(424, 38);
            this.movieTitleBox.TabIndex = 4;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(451, 199);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(295, 38);
            this.genreBox.TabIndex = 6;
            this.genreBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genre";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(451, 256);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(155, 38);
            this.priceBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rental Price";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(407, 407);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(152, 56);
            this.update_btn.TabIndex = 9;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(565, 407);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(152, 56);
            this.insert_btn.TabIndex = 10;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(723, 407);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(152, 56);
            this.del_btn.TabIndex = 11;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.Location = new System.Drawing.Point(165, 407);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(78, 56);
            this.prev_btn.TabIndex = 12;
            this.prev_btn.Text = "<";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(881, 407);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(78, 56);
            this.next_btn.TabIndex = 13;
            this.next_btn.Text = ">";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Location = new System.Drawing.Point(249, 494);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 121);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(428, 47);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(151, 51);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Find";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(43, 47);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(349, 38);
            this.searchBox.TabIndex = 0;
            // 
            // last_btn
            // 
            this.last_btn.Location = new System.Drawing.Point(881, 494);
            this.last_btn.Name = "last_btn";
            this.last_btn.Size = new System.Drawing.Size(78, 56);
            this.last_btn.TabIndex = 15;
            this.last_btn.Text = ">>";
            this.last_btn.UseVisualStyleBackColor = true;
            this.last_btn.Click += new System.EventHandler(this.last_btn_Click);
            // 
            // first_btn
            // 
            this.first_btn.Location = new System.Drawing.Point(165, 494);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(78, 56);
            this.first_btn.TabIndex = 16;
            this.first_btn.Text = "<<";
            this.first_btn.UseVisualStyleBackColor = true;
            this.first_btn.Click += new System.EventHandler(this.first_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 705);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1185, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripStatus
            // 
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Movie_Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 727);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.first_btn);
            this.Controls.Add(this.last_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.movieTitleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vidcodeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load_btn);
            this.Name = "Movie_Maintenance";
            this.Text = "Movie Maintenance";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vidcodeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox movieTitleBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button last_btn;
        private System.Windows.Forms.Button first_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripStatus;
    }
}