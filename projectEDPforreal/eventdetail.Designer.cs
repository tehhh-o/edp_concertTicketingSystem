namespace projectEDPforreal
{
    partial class eventdetail
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
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rowA = new System.Windows.Forms.CheckBox();
            this.rowB = new System.Windows.Forms.CheckBox();
            this.rowC = new System.Windows.Forms.CheckBox();
            this.lstSeats = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ticket2Go";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(292, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "event name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblLocation);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(145, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 207);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Summary";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(292, 156);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 16);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "event date";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(292, 100);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 16);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "event details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 157);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lstSeats);
            this.groupBox2.Controls.Add(this.rowC);
            this.groupBox2.Controls.Add(this.rowB);
            this.groupBox2.Controls.Add(this.rowA);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(145, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 347);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "seat selection";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Choose your row";
            // 
            // rowA
            // 
            this.rowA.AutoSize = true;
            this.rowA.Location = new System.Drawing.Point(89, 70);
            this.rowA.Name = "rowA";
            this.rowA.Size = new System.Drawing.Size(68, 20);
            this.rowA.TabIndex = 15;
            this.rowA.Text = "Row A";
            this.rowA.UseVisualStyleBackColor = true;
            this.rowA.CheckedChanged += new System.EventHandler(this.rowA_CheckedChanged);
            // 
            // rowB
            // 
            this.rowB.AutoSize = true;
            this.rowB.Location = new System.Drawing.Point(219, 69);
            this.rowB.Name = "rowB";
            this.rowB.Size = new System.Drawing.Size(68, 20);
            this.rowB.TabIndex = 16;
            this.rowB.Text = "Row B";
            this.rowB.UseVisualStyleBackColor = true;
            this.rowB.CheckedChanged += new System.EventHandler(this.rowB_CheckedChanged);
            // 
            // rowC
            // 
            this.rowC.AutoSize = true;
            this.rowC.Location = new System.Drawing.Point(352, 69);
            this.rowC.Name = "rowC";
            this.rowC.Size = new System.Drawing.Size(68, 20);
            this.rowC.TabIndex = 17;
            this.rowC.Text = "Row C";
            this.rowC.UseVisualStyleBackColor = true;
            this.rowC.CheckedChanged += new System.EventHandler(this.rowC_CheckedChanged);
            // 
            // lstSeats
            // 
            this.lstSeats.FormattingEnabled = true;
            this.lstSeats.ItemHeight = 16;
            this.lstSeats.Location = new System.Drawing.Point(42, 107);
            this.lstSeats.Name = "lstSeats";
            this.lstSeats.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSeats.Size = new System.Drawing.Size(448, 196);
            this.lstSeats.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 70);
            this.button1.TabIndex = 19;
            this.button1.Text = "Checkout Button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // eventdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 685);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "eventdetail";
            this.Text = "eventdetail";
            this.Load += new System.EventHandler(this.eventdetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox rowC;
        private System.Windows.Forms.CheckBox rowB;
        private System.Windows.Forms.CheckBox rowA;
        private System.Windows.Forms.ListBox lstSeats;
        private System.Windows.Forms.Button button1;
    }
}