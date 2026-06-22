namespace projectEDPforreal
{
    partial class eventbrowser
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
            this.searchbox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(222, 60);
            this.searchbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(217, 34);
            this.searchbox.TabIndex = 31;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(128, 63);
            this.search_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(76, 30);
            this.search_button.TabIndex = 32;
            this.search_button.Text = "Search Event";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // grpResults
            // 
            this.grpResults.Location = new System.Drawing.Point(128, 98);
            this.grpResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpResults.Name = "grpResults";
            this.grpResults.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpResults.Size = new System.Drawing.Size(471, 437);
            this.grpResults.TabIndex = 33;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "groupBox1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 29);
            this.label11.TabIndex = 34;
            this.label11.Text = "Ticket2Go";
            // 
            // eventbrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 567);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.searchbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "eventbrowser";
            this.Text = "eventbrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label label11;
    }
}