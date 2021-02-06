namespace SuperShopManagementSystem
{
    partial class SalesmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesmanForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteS = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlColorS = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchS = new System.Windows.Forms.Label();
            this.dgvSalesman = new System.Windows.Forms.DataGridView();
            this.txtSearchS = new System.Windows.Forms.TextBox();
            this.txtAdrS = new System.Windows.Forms.TextBox();
            this.txtEmailS = new System.Windows.Forms.TextBox();
            this.txtSalS = new System.Windows.Forms.TextBox();
            this.txtPasS = new System.Windows.Forms.TextBox();
            this.txtNameS = new System.Windows.Forms.TextBox();
            this.txtIdS = new System.Windows.Forms.TextBox();
            this.lblAdrS = new System.Windows.Forms.Label();
            this.lblEmailS = new System.Windows.Forms.Label();
            this.lblSalS = new System.Windows.Forms.Label();
            this.lblPaS = new System.Windows.Forms.Label();
            this.lblNameS = new System.Windows.Forms.Label();
            this.lblIdS = new System.Windows.Forms.Label();
            this.Eid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Esalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Epassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlColorS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesman)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnDeleteS);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.pnlColorS);
            this.panel1.Controls.Add(this.lblSearchS);
            this.panel1.Controls.Add(this.dgvSalesman);
            this.panel1.Controls.Add(this.txtSearchS);
            this.panel1.Controls.Add(this.txtAdrS);
            this.panel1.Controls.Add(this.txtEmailS);
            this.panel1.Controls.Add(this.txtSalS);
            this.panel1.Controls.Add(this.txtPasS);
            this.panel1.Controls.Add(this.txtNameS);
            this.panel1.Controls.Add(this.txtIdS);
            this.panel1.Controls.Add(this.lblAdrS);
            this.panel1.Controls.Add(this.lblEmailS);
            this.panel1.Controls.Add(this.lblSalS);
            this.panel1.Controls.Add(this.lblPaS);
            this.panel1.Controls.Add(this.lblNameS);
            this.panel1.Controls.Add(this.lblIdS);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 484);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(375, 200);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(239, 23);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteS.Location = new System.Drawing.Point(375, 144);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(239, 23);
            this.btnDeleteS.TabIndex = 18;
            this.btnDeleteS.Text = "Delete";
            this.btnDeleteS.UseVisualStyleBackColor = false;
            this.btnDeleteS.Click += new System.EventHandler(this.btnDeleteS_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(375, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(239, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlColorS
            // 
            this.pnlColorS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlColorS.Controls.Add(this.label1);
            this.pnlColorS.Location = new System.Drawing.Point(3, 3);
            this.pnlColorS.Name = "pnlColorS";
            this.pnlColorS.Size = new System.Drawing.Size(863, 61);
            this.pnlColorS.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Salesman";
            // 
            // lblSearchS
            // 
            this.lblSearchS.AutoSize = true;
            this.lblSearchS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchS.Location = new System.Drawing.Point(635, 255);
            this.lblSearchS.Name = "lblSearchS";
            this.lblSearchS.Size = new System.Drawing.Size(61, 18);
            this.lblSearchS.TabIndex = 15;
            this.lblSearchS.Text = "Search";
            // 
            // dgvSalesman
            // 
            this.dgvSalesman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eid,
            this.Ename,
            this.Eaddress,
            this.Eemail,
            this.Esalary,
            this.Epassword});
            this.dgvSalesman.Location = new System.Drawing.Point(3, 279);
            this.dgvSalesman.Name = "dgvSalesman";
            this.dgvSalesman.Size = new System.Drawing.Size(863, 202);
            this.dgvSalesman.TabIndex = 14;
            this.dgvSalesman.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSalesman_MouseDoubleClick);
            // 
            // txtSearchS
            // 
            this.txtSearchS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearchS.Location = new System.Drawing.Point(702, 253);
            this.txtSearchS.Name = "txtSearchS";
            this.txtSearchS.Size = new System.Drawing.Size(155, 20);
            this.txtSearchS.TabIndex = 12;
            this.txtSearchS.TextChanged += new System.EventHandler(this.txtSearchS_TextChanged);
            // 
            // txtAdrS
            // 
            this.txtAdrS.Location = new System.Drawing.Point(179, 247);
            this.txtAdrS.Name = "txtAdrS";
            this.txtAdrS.Size = new System.Drawing.Size(147, 20);
            this.txtAdrS.TabIndex = 11;
            // 
            // txtEmailS
            // 
            this.txtEmailS.Location = new System.Drawing.Point(179, 217);
            this.txtEmailS.Name = "txtEmailS";
            this.txtEmailS.Size = new System.Drawing.Size(147, 20);
            this.txtEmailS.TabIndex = 10;
            // 
            // txtSalS
            // 
            this.txtSalS.Location = new System.Drawing.Point(179, 189);
            this.txtSalS.Name = "txtSalS";
            this.txtSalS.Size = new System.Drawing.Size(147, 20);
            this.txtSalS.TabIndex = 9;
            // 
            // txtPasS
            // 
            this.txtPasS.Location = new System.Drawing.Point(179, 156);
            this.txtPasS.Name = "txtPasS";
            this.txtPasS.Size = new System.Drawing.Size(147, 20);
            this.txtPasS.TabIndex = 8;
            // 
            // txtNameS
            // 
            this.txtNameS.Location = new System.Drawing.Point(179, 124);
            this.txtNameS.Name = "txtNameS";
            this.txtNameS.Size = new System.Drawing.Size(147, 20);
            this.txtNameS.TabIndex = 7;
            // 
            // txtIdS
            // 
            this.txtIdS.Location = new System.Drawing.Point(179, 93);
            this.txtIdS.Name = "txtIdS";
            this.txtIdS.Size = new System.Drawing.Size(147, 20);
            this.txtIdS.TabIndex = 6;
            // 
            // lblAdrS
            // 
            this.lblAdrS.AutoSize = true;
            this.lblAdrS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdrS.Location = new System.Drawing.Point(90, 250);
            this.lblAdrS.Name = "lblAdrS";
            this.lblAdrS.Size = new System.Drawing.Size(69, 18);
            this.lblAdrS.TabIndex = 5;
            this.lblAdrS.Text = "Address";
            // 
            // lblEmailS
            // 
            this.lblEmailS.AutoSize = true;
            this.lblEmailS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailS.Location = new System.Drawing.Point(90, 223);
            this.lblEmailS.Name = "lblEmailS";
            this.lblEmailS.Size = new System.Drawing.Size(50, 18);
            this.lblEmailS.TabIndex = 4;
            this.lblEmailS.Text = "Email";
            // 
            // lblSalS
            // 
            this.lblSalS.AutoSize = true;
            this.lblSalS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalS.Location = new System.Drawing.Point(90, 191);
            this.lblSalS.Name = "lblSalS";
            this.lblSalS.Size = new System.Drawing.Size(55, 18);
            this.lblSalS.TabIndex = 3;
            this.lblSalS.Text = "Salary";
            // 
            // lblPaS
            // 
            this.lblPaS.AutoSize = true;
            this.lblPaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaS.Location = new System.Drawing.Point(90, 158);
            this.lblPaS.Name = "lblPaS";
            this.lblPaS.Size = new System.Drawing.Size(83, 18);
            this.lblPaS.TabIndex = 2;
            this.lblPaS.Text = "Password";
            // 
            // lblNameS
            // 
            this.lblNameS.AutoSize = true;
            this.lblNameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameS.Location = new System.Drawing.Point(90, 123);
            this.lblNameS.Name = "lblNameS";
            this.lblNameS.Size = new System.Drawing.Size(52, 18);
            this.lblNameS.TabIndex = 1;
            this.lblNameS.Text = "Name";
            // 
            // lblIdS
            // 
            this.lblIdS.AutoSize = true;
            this.lblIdS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdS.Location = new System.Drawing.Point(90, 92);
            this.lblIdS.Name = "lblIdS";
            this.lblIdS.Size = new System.Drawing.Size(24, 18);
            this.lblIdS.TabIndex = 0;
            this.lblIdS.Text = "ID";
            // 
            // Eid
            // 
            this.Eid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eid.DataPropertyName = "Eid";
            this.Eid.HeaderText = "ID";
            this.Eid.Name = "Eid";
            // 
            // Ename
            // 
            this.Ename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ename.DataPropertyName = "Ename";
            this.Ename.HeaderText = "Name";
            this.Ename.Name = "Ename";
            // 
            // Eaddress
            // 
            this.Eaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eaddress.DataPropertyName = "Eaddress";
            this.Eaddress.HeaderText = "Address";
            this.Eaddress.Name = "Eaddress";
            // 
            // Eemail
            // 
            this.Eemail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eemail.DataPropertyName = "Eemail";
            this.Eemail.HeaderText = "Email";
            this.Eemail.Name = "Eemail";
            // 
            // Esalary
            // 
            this.Esalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Esalary.DataPropertyName = "Esalary";
            this.Esalary.HeaderText = "Salary";
            this.Esalary.Name = "Esalary";
            // 
            // Epassword
            // 
            this.Epassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Epassword.DataPropertyName = "Epassword";
            this.Epassword.HeaderText = "Password";
            this.Epassword.Name = "Epassword";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(638, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 158);
            this.panel2.TabIndex = 20;
            // 
            // SalesmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 488);
            this.Controls.Add(this.panel1);
            this.Name = "SalesmanForm";
            this.Text = "Salesman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesmanForm_FormClosing);
            this.Load += new System.EventHandler(this.SalesmanForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlColorS.ResumeLayout(false);
            this.pnlColorS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSalesman;
        private System.Windows.Forms.TextBox txtSearchS;
        private System.Windows.Forms.TextBox txtAdrS;
        private System.Windows.Forms.TextBox txtEmailS;
        private System.Windows.Forms.TextBox txtSalS;
        private System.Windows.Forms.TextBox txtPasS;
        private System.Windows.Forms.TextBox txtNameS;
        private System.Windows.Forms.TextBox txtIdS;
        private System.Windows.Forms.Label lblAdrS;
        private System.Windows.Forms.Label lblEmailS;
        private System.Windows.Forms.Label lblSalS;
        private System.Windows.Forms.Label lblPaS;
        private System.Windows.Forms.Label lblNameS;
        private System.Windows.Forms.Label lblIdS;
        private System.Windows.Forms.Label lblSearchS;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlColorS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Esalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Epassword;
        private System.Windows.Forms.Panel panel2;
    }
}

