namespace SuperShopManagementSystem
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpExp = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBackP = new System.Windows.Forms.Button();
            this.btnDelP = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            this.dgvPro = new System.Windows.Forms.DataGridView();
            this.Pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pavailablequantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pexpirydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchP = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPquantity = new System.Windows.Forms.TextBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpExp);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnBackP);
            this.panel2.Controls.Add(this.btnDelP);
            this.panel2.Controls.Add(this.btnAddP);
            this.panel2.Controls.Add(this.dgvPro);
            this.panel2.Controls.Add(this.txtSearchP);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtPquantity);
            this.panel2.Controls.Add(this.txtPname);
            this.panel2.Controls.Add(this.txtIdP);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 422);
            this.panel2.TabIndex = 1;
            // 
            // dtpExp
            // 
            this.dtpExp.CustomFormat = "";
            this.dtpExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExp.Location = new System.Drawing.Point(392, 172);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.Size = new System.Drawing.Size(122, 20);
            this.dtpExp.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(11, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 204);
            this.panel3.TabIndex = 16;
            // 
            // btnBackP
            // 
            this.btnBackP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackP.Location = new System.Drawing.Point(616, 159);
            this.btnBackP.Name = "btnBackP";
            this.btnBackP.Size = new System.Drawing.Size(109, 33);
            this.btnBackP.TabIndex = 15;
            this.btnBackP.Text = "Back";
            this.btnBackP.UseVisualStyleBackColor = false;
            this.btnBackP.Click += new System.EventHandler(this.btnBackP_Click);
            // 
            // btnDelP
            // 
            this.btnDelP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelP.Location = new System.Drawing.Point(616, 95);
            this.btnDelP.Name = "btnDelP";
            this.btnDelP.Size = new System.Drawing.Size(109, 31);
            this.btnDelP.TabIndex = 14;
            this.btnDelP.Text = "Delete";
            this.btnDelP.UseVisualStyleBackColor = false;
            this.btnDelP.Click += new System.EventHandler(this.btnDelP_Click);
            // 
            // btnAddP
            // 
            this.btnAddP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddP.Location = new System.Drawing.Point(616, 28);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(109, 30);
            this.btnAddP.TabIndex = 13;
            this.btnAddP.Text = "Add";
            this.btnAddP.UseVisualStyleBackColor = false;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // dgvPro
            // 
            this.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pid,
            this.Pname,
            this.Pavailablequantity,
            this.Pprice,
            this.Pexpirydate});
            this.dgvPro.Location = new System.Drawing.Point(3, 261);
            this.dgvPro.Name = "dgvPro";
            this.dgvPro.Size = new System.Drawing.Size(842, 161);
            this.dgvPro.TabIndex = 12;
            this.dgvPro.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPro_MouseDoubleClick);
            // 
            // Pid
            // 
            this.Pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pid.DataPropertyName = "Pid";
            this.Pid.HeaderText = "Product ID";
            this.Pid.Name = "Pid";
            // 
            // Pname
            // 
            this.Pname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pname.DataPropertyName = "Pname";
            this.Pname.HeaderText = "Product Name";
            this.Pname.Name = "Pname";
            // 
            // Pavailablequantity
            // 
            this.Pavailablequantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pavailablequantity.DataPropertyName = "Pavailablequantity";
            this.Pavailablequantity.HeaderText = "Available Quantity";
            this.Pavailablequantity.Name = "Pavailablequantity";
            // 
            // Pprice
            // 
            this.Pprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pprice.DataPropertyName = "Pprice";
            this.Pprice.HeaderText = "Price";
            this.Pprice.Name = "Pprice";
            // 
            // Pexpirydate
            // 
            this.Pexpirydate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pexpirydate.DataPropertyName = "Pexpirydate";
            this.Pexpirydate.HeaderText = "Expiry Date";
            this.Pexpirydate.Name = "Pexpirydate";
            // 
            // txtSearchP
            // 
            this.txtSearchP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSearchP.Location = new System.Drawing.Point(616, 211);
            this.txtSearchP.Name = "txtSearchP";
            this.txtSearchP.Size = new System.Drawing.Size(128, 20);
            this.txtSearchP.TabIndex = 11;
            this.txtSearchP.TextChanged += new System.EventHandler(this.txtSearchP_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(392, 134);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(122, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // txtPquantity
            // 
            this.txtPquantity.Location = new System.Drawing.Point(392, 97);
            this.txtPquantity.Name = "txtPquantity";
            this.txtPquantity.Size = new System.Drawing.Size(122, 20);
            this.txtPquantity.TabIndex = 8;
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(392, 65);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(122, 20);
            this.txtPname.TabIndex = 7;
            // 
            // txtIdP
            // 
            this.txtIdP.Location = new System.Drawing.Point(392, 27);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(122, 20);
            this.txtIdP.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(549, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Expiry Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product ID";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(848, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPro;
        private System.Windows.Forms.TextBox txtSearchP;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPquantity;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackP;
        private System.Windows.Forms.Button btnDelP;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pavailablequantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pexpirydate;
    }
}