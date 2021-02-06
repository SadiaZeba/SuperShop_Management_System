namespace SuperShopManagementSystem
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSM = new System.Windows.Forms.Button();
            this.btnPr = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager";
            // 
            // btnSM
            // 
            this.btnSM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSM.Location = new System.Drawing.Point(271, 110);
            this.btnSM.Name = "btnSM";
            this.btnSM.Size = new System.Drawing.Size(184, 32);
            this.btnSM.TabIndex = 1;
            this.btnSM.Text = "Salesman Info";
            this.btnSM.UseVisualStyleBackColor = false;
            this.btnSM.Click += new System.EventHandler(this.btnSM_Click);
            this.btnSM.MouseLeave += new System.EventHandler(this.btnSM_MouseLeave);
            this.btnSM.MouseHover += new System.EventHandler(this.btnSM_MouseHover);
            // 
            // btnPr
            // 
            this.btnPr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPr.Location = new System.Drawing.Point(271, 210);
            this.btnPr.Name = "btnPr";
            this.btnPr.Size = new System.Drawing.Size(184, 33);
            this.btnPr.TabIndex = 2;
            this.btnPr.Text = "Product Info";
            this.btnPr.UseVisualStyleBackColor = false;
            this.btnPr.Click += new System.EventHandler(this.btnPr_Click);
            this.btnPr.MouseLeave += new System.EventHandler(this.btnPr_MouseLeave);
            this.btnPr.MouseHover += new System.EventHandler(this.btnPr_MouseHover);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(271, 313);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(184, 33);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order Info";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.MouseLeave += new System.EventHandler(this.btnOrder_MouseLeave);
            this.btnOrder.MouseHover += new System.EventHandler(this.btnOrder_MouseHover);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(488, 210);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 29);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(12, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 262);
            this.panel2.TabIndex = 5;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(616, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPr);
            this.Controls.Add(this.btnSM);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSM;
        private System.Windows.Forms.Button btnPr;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
    }
}