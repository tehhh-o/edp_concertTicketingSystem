namespace projectEDPforreal
{
    partial class receipts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receipts));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.Amountbox = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.Datebox = new System.Windows.Forms.TextBox();
            this.Bookbox = new System.Windows.Forms.TextBox();
            this.RecBox = new System.Windows.Forms.TextBox();
            this.Paymentbox = new System.Windows.Forms.TextBox();
            this.NoBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone No :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.NoBox);
            this.groupBox1.Controls.Add(this.Paymentbox);
            this.groupBox1.Controls.Add(this.RecBox);
            this.groupBox1.Controls.Add(this.Bookbox);
            this.groupBox1.Controls.Add(this.Datebox);
            this.groupBox1.Controls.Add(this.Total);
            this.groupBox1.Controls.Add(this.Amountbox);
            this.groupBox1.Controls.Add(this.Namebox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(58, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 415);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipt Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Booking ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Receipt ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payment Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Ticket";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Booking Date :";
            // 
            // Namebox
            // 
            this.Namebox.BackColor = System.Drawing.Color.GhostWhite;
            this.Namebox.Enabled = false;
            this.Namebox.Location = new System.Drawing.Point(150, 58);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(204, 22);
            this.Namebox.TabIndex = 10;
            // 
            // Amountbox
            // 
            this.Amountbox.Location = new System.Drawing.Point(150, 303);
            this.Amountbox.Name = "Amountbox";
            this.Amountbox.Size = new System.Drawing.Size(204, 22);
            this.Amountbox.TabIndex = 12;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(150, 262);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(204, 22);
            this.Total.TabIndex = 13;
            // 
            // Datebox
            // 
            this.Datebox.Location = new System.Drawing.Point(150, 226);
            this.Datebox.Name = "Datebox";
            this.Datebox.Size = new System.Drawing.Size(204, 22);
            this.Datebox.TabIndex = 14;
            // 
            // Bookbox
            // 
            this.Bookbox.Location = new System.Drawing.Point(150, 187);
            this.Bookbox.Name = "Bookbox";
            this.Bookbox.Size = new System.Drawing.Size(204, 22);
            this.Bookbox.TabIndex = 15;
            // 
            // RecBox
            // 
            this.RecBox.Location = new System.Drawing.Point(150, 139);
            this.RecBox.Name = "RecBox";
            this.RecBox.Size = new System.Drawing.Size(204, 22);
            this.RecBox.TabIndex = 16;
            // 
            // Paymentbox
            // 
            this.Paymentbox.Location = new System.Drawing.Point(150, 342);
            this.Paymentbox.Name = "Paymentbox";
            this.Paymentbox.Size = new System.Drawing.Size(204, 22);
            this.Paymentbox.TabIndex = 17;
            // 
            // NoBox
            // 
            this.NoBox.Location = new System.Drawing.Point(150, 98);
            this.NoBox.Name = "NoBox";
            this.NoBox.Size = new System.Drawing.Size(204, 22);
            this.NoBox.TabIndex = 18;
            // 
            // receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(572, 520);
            this.Controls.Add(this.groupBox1);
            this.Name = "receipts";
            this.Text = "receipts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NoBox;
        private System.Windows.Forms.TextBox Paymentbox;
        private System.Windows.Forms.TextBox RecBox;
        private System.Windows.Forms.TextBox Bookbox;
        private System.Windows.Forms.TextBox Datebox;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.TextBox Amountbox;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}