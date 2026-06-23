namespace projectEDPforreal
{
    partial class user_bookmark
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lbBookmark = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Bookmark";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Info;
            this.btnBack.Location = new System.Drawing.Point(693, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 48);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back To Home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbBookmark
            // 
            this.lbBookmark.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbBookmark.HideSelection = false;
            this.lbBookmark.Location = new System.Drawing.Point(46, 79);
            this.lbBookmark.Name = "lbBookmark";
            this.lbBookmark.Size = new System.Drawing.Size(780, 338);
            this.lbBookmark.TabIndex = 3;
            this.lbBookmark.UseCompatibleStateImageBehavior = false;
            // 
            // user_bookmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projectEDPforreal.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.lbBookmark);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "user_bookmark";
            this.Text = "user_bookmark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lbBookmark;
    }
}