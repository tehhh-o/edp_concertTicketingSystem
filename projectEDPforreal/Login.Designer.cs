namespace projectEDPforreal
{
    partial class Login
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.Window;
            this.loginPanel.Controls.Add(this.groupBox2);
            this.loginPanel.Location = new System.Drawing.Point(45, 35);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(620, 551);
            this.loginPanel.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtLoginPassword);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtLoginEmail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(64, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 412);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(68, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 52);
            this.button6.TabIndex = 10;
            this.button6.Text = "SignUp";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "login";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(150, 161);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(263, 22);
            this.txtLoginPassword.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Password";
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Location = new System.Drawing.Point(150, 108);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(263, 22);
            this.txtLoginEmail.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name/Email";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(741, 658);
            this.Controls.Add(this.loginPanel);
            this.Name = "Login";
            this.Text = "Form2";
            this.loginPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.Label label10;
    }
}