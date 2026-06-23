namespace projectEDPforreal
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPaymentId = new System.Windows.Forms.TextBox();
            this.tbBookingId = new System.Windows.Forms.TextBox();
            this.tbPaymentMethod = new System.Windows.Forms.TextBox();
            this.tbPaymentDate = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbPaymentStatus = new System.Windows.Forms.TextBox();
            this.tbReceiptId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.Thankyou = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(7, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(7, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Booking ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(5, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Method :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(5, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment Date :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(5, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(5, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Payment Status :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(7, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Receipt ID :";
            // 
            // tbPaymentId
            // 
            this.tbPaymentId.Location = new System.Drawing.Point(144, 98);
            this.tbPaymentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPaymentId.Name = "tbPaymentId";
            this.tbPaymentId.Size = new System.Drawing.Size(191, 22);
            this.tbPaymentId.TabIndex = 7;
            this.tbPaymentId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbBookingId
            // 
            this.tbBookingId.Location = new System.Drawing.Point(144, 135);
            this.tbBookingId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBookingId.Name = "tbBookingId";
            this.tbBookingId.Size = new System.Drawing.Size(191, 22);
            this.tbBookingId.TabIndex = 8;
            this.tbBookingId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbPaymentMethod
            // 
            this.tbPaymentMethod.Location = new System.Drawing.Point(143, 174);
            this.tbPaymentMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPaymentMethod.Name = "tbPaymentMethod";
            this.tbPaymentMethod.Size = new System.Drawing.Size(191, 22);
            this.tbPaymentMethod.TabIndex = 9;
            this.tbPaymentMethod.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbPaymentDate
            // 
            this.tbPaymentDate.Location = new System.Drawing.Point(144, 215);
            this.tbPaymentDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPaymentDate.Name = "tbPaymentDate";
            this.tbPaymentDate.Size = new System.Drawing.Size(191, 22);
            this.tbPaymentDate.TabIndex = 10;
            this.tbPaymentDate.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(144, 256);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(191, 22);
            this.tbAmount.TabIndex = 11;
            this.tbAmount.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbPaymentStatus
            // 
            this.tbPaymentStatus.Location = new System.Drawing.Point(143, 297);
            this.tbPaymentStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPaymentStatus.Name = "tbPaymentStatus";
            this.tbPaymentStatus.Size = new System.Drawing.Size(191, 22);
            this.tbPaymentStatus.TabIndex = 12;
            // 
            // tbReceiptId
            // 
            this.tbReceiptId.Location = new System.Drawing.Point(143, 337);
            this.tbReceiptId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReceiptId.Name = "tbReceiptId";
            this.tbReceiptId.Size = new System.Drawing.Size(191, 22);
            this.tbReceiptId.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbReceiptId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPaymentStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPaymentDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPaymentMethod);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbBookingId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbPaymentId);
            this.groupBox1.Location = new System.Drawing.Point(31, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(349, 377);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(5, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phone No. :";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(144, 63);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(191, 22);
            this.tbPhone.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(7, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Name :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(144, 32);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(191, 22);
            this.tbName.TabIndex = 14;
            // 
            // Thankyou
            // 
            this.Thankyou.AutoSize = true;
            this.Thankyou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thankyou.Location = new System.Drawing.Point(124, 415);
            this.Thankyou.Name = "Thankyou";
            this.Thankyou.Size = new System.Drawing.Size(10, 16);
            this.Thankyou.TabIndex = 15;
            this.Thankyou.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ticket2GO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(108, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Thank you for purchasing with us!";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(138, 481);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(145, 23);
            this.btnback.TabIndex = 19;
            this.btnback.Text = "Back To Home";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(427, 516);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Thankyou);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPaymentId;
        private System.Windows.Forms.TextBox tbBookingId;
        private System.Windows.Forms.TextBox tbPaymentMethod;
        private System.Windows.Forms.TextBox tbPaymentDate;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbPaymentStatus;
        private System.Windows.Forms.TextBox tbReceiptId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label Thankyou;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnback;
    }
}