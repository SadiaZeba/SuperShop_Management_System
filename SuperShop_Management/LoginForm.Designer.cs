namespace SuperShopManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIdLog = new System.Windows.Forms.Label();
            this.lblPasL = new System.Windows.Forms.Label();
            this.txtLogId = new System.Windows.Forms.TextBox();
            this.txtPaslog = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 178);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(445, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 275);
            this.panel2.TabIndex = 1;
            // 
            // lblIdLog
            // 
            this.lblIdLog.AutoSize = true;
            this.lblIdLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLog.Location = new System.Drawing.Point(53, 238);
            this.lblIdLog.Name = "lblIdLog";
            this.lblIdLog.Size = new System.Drawing.Size(62, 18);
            this.lblIdLog.TabIndex = 2;
            this.lblIdLog.Text = "User Id";
            // 
            // lblPasL
            // 
            this.lblPasL.AutoSize = true;
            this.lblPasL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasL.Location = new System.Drawing.Point(53, 296);
            this.lblPasL.Name = "lblPasL";
            this.lblPasL.Size = new System.Drawing.Size(83, 18);
            this.lblPasL.TabIndex = 3;
            this.lblPasL.Text = "Password";
            // 
            // txtLogId
            // 
            this.txtLogId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLogId.Location = new System.Drawing.Point(156, 239);
            this.txtLogId.Name = "txtLogId";
            this.txtLogId.Size = new System.Drawing.Size(157, 20);
            this.txtLogId.TabIndex = 4;
            // 
            // txtPaslog
            // 
            this.txtPaslog.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPaslog.Location = new System.Drawing.Point(156, 294);
            this.txtPaslog.Name = "txtPaslog";
            this.txtPaslog.Size = new System.Drawing.Size(157, 20);
            this.txtPaslog.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(68, 368);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 35);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(293, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(735, 456);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPaslog);
            this.Controls.Add(this.txtLogId);
            this.Controls.Add(this.lblPasL);
            this.Controls.Add(this.lblIdLog);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIdLog;
        private System.Windows.Forms.Label lblPasL;
        private System.Windows.Forms.TextBox txtLogId;
        private System.Windows.Forms.TextBox txtPaslog;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}