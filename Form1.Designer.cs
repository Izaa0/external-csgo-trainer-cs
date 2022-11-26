namespace xp
{
    partial class LoginMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textKey = new System.Windows.Forms.TextBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.keyInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(47, 79);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(163, 23);
            this.textKey.TabIndex = 0;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(85, 131);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 1;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // keyInfo
            // 
            this.keyInfo.AutoSize = true;
            this.keyInfo.Location = new System.Drawing.Point(85, 61);
            this.keyInfo.Name = "keyInfo";
            this.keyInfo.Size = new System.Drawing.Size(84, 15);
            this.keyInfo.TabIndex = 2;
            this.keyInfo.Text = "enter key here:";
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(253, 196);
            this.Controls.Add(this.keyInfo);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.textKey);
            this.Name = "LoginMenu";
            this.Opacity = 0.85D;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textKey;
        private Button btnLaunch;
        private Label keyInfo;
    }
}