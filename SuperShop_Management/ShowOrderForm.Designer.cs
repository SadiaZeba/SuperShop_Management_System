namespace SuperShopManagementSystem
{
    partial class ShowOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowOrderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBO = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.Oserial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oproductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oproductid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 64);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnBO);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.dgvInfo);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 406);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(3, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 232);
            this.panel3.TabIndex = 3;
            // 
            // btnBO
            // 
            this.btnBO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBO.Location = new System.Drawing.Point(40, 108);
            this.btnBO.Name = "btnBO";
            this.btnBO.Size = new System.Drawing.Size(166, 27);
            this.btnBO.TabIndex = 2;
            this.btnBO.Text = "Back";
            this.btnBO.UseVisualStyleBackColor = false;
            this.btnBO.Click += new System.EventHandler(this.btnBO_Click);
            this.btnBO.MouseLeave += new System.EventHandler(this.btnBO_MouseLeave);
            this.btnBO.MouseHover += new System.EventHandler(this.btnBO_MouseHover);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(40, 36);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(166, 27);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show Information";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            this.btnShow.MouseLeave += new System.EventHandler(this.btnShow_MouseLeave);
            this.btnShow.MouseHover += new System.EventHandler(this.btnShow_MouseHover);
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Oserial,
            this.Oid,
            this.Oproductname,
            this.Oproductid,
            this.Oquantity,
            this.Oprice,
            this.Ocost,
            this.Odate});
            this.dgvInfo.Location = new System.Drawing.Point(232, 0);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.Size = new System.Drawing.Size(625, 406);
            this.dgvInfo.TabIndex = 0;
            // 
            // Oserial
            // 
            this.Oserial.DataPropertyName = "Oserial";
            this.Oserial.HeaderText = "Order Serial";
            this.Oserial.Name = "Oserial";
            // 
            // Oid
            // 
            this.Oid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Oid.DataPropertyName = "Oid";
            this.Oid.HeaderText = "Order Id";
            this.Oid.Name = "Oid";
            // 
            // Oproductname
            // 
            this.Oproductname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Oproductname.DataPropertyName = "Oproductname";
            this.Oproductname.HeaderText = "Order name";
            this.Oproductname.Name = "Oproductname";
            // 
            // Oproductid
            // 
            this.Oproductid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Oproductid.DataPropertyName = "Oproductid";
            this.Oproductid.HeaderText = "Product Id";
            this.Oproductid.Name = "Oproductid";
            // 
            // Oquantity
            // 
            this.Oquantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Oquantity.DataPropertyName = "Oquantity";
            this.Oquantity.HeaderText = "Quantity";
            this.Oquantity.Name = "Oquantity";
            // 
            // Oprice
            // 
            this.Oprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Oprice.DataPropertyName = "Oprice";
            this.Oprice.HeaderText = "Price";
            this.Oprice.Name = "Oprice";
            // 
            // Ocost
            // 
            this.Ocost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocost.DataPropertyName = "Ocost";
            this.Ocost.HeaderText = "Cost";
            this.Ocost.Name = "Ocost";
            // 
            // Odate
            // 
            this.Odate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Odate.DataPropertyName = "Odate";
            this.Odate.HeaderText = "Order Date";
            this.Odate.Name = "Odate";
            // 
            // ShowOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(858, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ShowOrderForm";
            this.Text = "Order Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowOrderForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button btnBO;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oserial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oproductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oproductid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odate;
        private System.Windows.Forms.Panel panel3;
    }
}