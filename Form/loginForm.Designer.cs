namespace WindowsFormsApplication1
{
    partial class loginForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.uname = new MetroFramework.Controls.MetroTextBox();
            this.pass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.metroLabel1.Location = new System.Drawing.Point(123, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.UseWaitCursor = true;
            // 
            // uname
            // 
            this.uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.uname.Lines = new string[0];
            this.uname.Location = new System.Drawing.Point(127, 119);
            this.uname.MaxLength = 32767;
            this.uname.Name = "uname";
            this.uname.PasswordChar = '\0';
            this.uname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uname.SelectedText = "";
            this.uname.Size = new System.Drawing.Size(187, 23);
            this.uname.Style = MetroFramework.MetroColorStyle.Black;
            this.uname.TabIndex = 1;
            this.uname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uname.UseCustomBackColor = true;
            this.uname.UseCustomForeColor = true;
            this.uname.UseSelectable = true;
            // 
            // pass
            // 
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.pass.Lines = new string[0];
            this.pass.Location = new System.Drawing.Point(127, 170);
            this.pass.MaxLength = 32767;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '\0';
            this.pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pass.SelectedText = "";
            this.pass.Size = new System.Drawing.Size(187, 23);
            this.pass.Style = MetroFramework.MetroColorStyle.Black;
            this.pass.TabIndex = 3;
            this.pass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pass.UseCustomBackColor = true;
            this.pass.UseCustomForeColor = true;
            this.pass.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Window;
            this.metroLabel2.Location = new System.Drawing.Point(123, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            this.metroLabel2.UseWaitCursor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveControl = null;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(127, 199);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(187, 32);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogin.TileImage = global::WindowsFormsApplication1.Properties.Resources.appbar_arrow;
            this.btnLogin.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseCustomForeColor = true;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.UseStyleColors = true;
            this.btnLogin.UseTileImage = true;
            this.btnLogin.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 337);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.metroLabel1);
            this.Name = "loginForm";
            this.Text = "Login Window";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox uname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox pass;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnLogin;
    }
}