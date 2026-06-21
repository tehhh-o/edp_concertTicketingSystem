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
            this.label1 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticket2Go";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(296, 74);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(288, 41);
            this.searchbox.TabIndex = 31;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(170, 78);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(102, 37);
            this.search_button.TabIndex = 32;
            this.search_button.Text = "Search Event";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // grpResults
            // 
            this.grpResults.Location = new System.Drawing.Point(170, 121);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(628, 538);
            this.grpResults.TabIndex = 33;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "groupBox1";
            // 
            // eventbrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 698);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.label1);
            this.Name = "eventbrowser";
            this.Text = "eventbrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.GroupBox grpResults;
    }
}