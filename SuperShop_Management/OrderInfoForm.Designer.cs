namespace SuperShopManagementSystem
{
    partial class OrderInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderInfoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrderInfo = new System.Windows.Forms.DataGridView();
            this.Oserial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oproductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oproductid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdO = new System.Windows.Forms.TextBox();
            this.txtQuantityO = new System.Windows.Forms.TextBox();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.OrdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 69);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Orders";
            // 
            // dgvOrderInfo
            // 
            this.dgvOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Oserial,
            this.Oid,
            this.Oproductname,
            this.Oproductid,
            this.Oquantity,
            this.Oprice,
            this.Ocost,
            this.Odate});
            this.dgvOrderInfo.Location = new System.Drawing.Point(5, 325);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderInfo.Size = new System.Drawing.Size(337, 148);
            this.dgvOrderInfo.TabIndex = 1;
            // 
            // Oserial
            // 
            this.Oserial.DataPropertyName = "Oserial";
            this.Oserial.HeaderText = "Order Serial";
            this.Oserial.Name = "Oserial";
            this.Oserial.Visible = false;
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
            this.Oproductname.HeaderText = "Product Name";
            this.Oproductname.Name = "Oproductname";
            // 
            // Oproductid
            // 
            this.Oproductid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Oproductid.DataPropertyName = "Oproductid";
            this.Oproductid.HeaderText = "Product Id";
            this.Oproductid.Name = "Oproductid";
            this.Oproductid.Visible = false;
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
            this.Odate.Visible = false;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(685, 166);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(105, 31);
            this.btnAddOrder.TabIndex = 2;
            this.btnAddOrder.Text = "Add to cart";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelOrder.Location = new System.Drawing.Point(611, 443);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(129, 29);
            this.btnDelOrder.TabIndex = 3;
            this.btnDelOrder.Text = "Delete Order";
            this.btnDelOrder.UseVisualStyleBackColor = false;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(12, 479);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(101, 30);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Logout";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // txtIdO
            // 
            this.txtIdO.Location = new System.Drawing.Point(502, 214);
            this.txtIdO.Name = "txtIdO";
            this.txtIdO.Size = new System.Drawing.Size(144, 20);
            this.txtIdO.TabIndex = 8;
            // 
            // txtQuantityO
            // 
            this.txtQuantityO.Location = new System.Drawing.Point(502, 166);
            this.txtQuantityO.Name = "txtQuantityO";
            this.txtQuantityO.Size = new System.Drawing.Size(144, 20);
            this.txtQuantityO.TabIndex = 9;
            // 
            // cmbItemName
            // 
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(502, 117);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(154, 21);
            this.cmbItemName.TabIndex = 11;
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(442, 382);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(129, 30);
            this.btnSub.TabIndex = 12;
            this.btnSub.Text = "Submit";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(5, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 230);
            this.panel2.TabIndex = 13;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(625, 382);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(104, 30);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "Update";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(276, 276);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(151, 20);
            this.txtTotalCost.TabIndex = 16;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(503, 263);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(153, 20);
            this.txtDiscount.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Cost";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtDis);
            this.panel3.Controls.Add(this.dgvCart);
            this.panel3.Controls.Add(this.txtTotalCost);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(815, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 441);
            this.panel3.TabIndex = 21;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdId,
            this.ProName,
            this.Quantity,
            this.Price,
            this.Cost});
            this.dgvCart.Location = new System.Drawing.Point(63, 67);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(340, 163);
            this.dgvCart.TabIndex = 20;
            this.dgvCart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCart_MouseDoubleClick);
            // 
            // OrdId
            // 
            this.OrdId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrdId.DataPropertyName = "OrdId";
            this.OrdId.HeaderText = "Order Id";
            this.OrdId.Name = "OrdId";
            // 
            // ProName
            // 
            this.ProName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProName.DataPropertyName = "ProName";
            this.ProName.HeaderText = "Product Name";
            this.ProName.Name = "ProName";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(442, 443);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 30);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(276, 317);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(151, 20);
            this.txtDis.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(169, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Net Amount ";
            // 
            // OrderInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1258, 521);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvOrderInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.cmbItemName);
            this.Controls.Add(this.txtQuantityO);
            this.Controls.Add(this.txtIdO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDelOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.panel1);
            this.Name = "OrderInfoForm";
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrderInfo;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdO;
        private System.Windows.Forms.TextBox txtQuantityO;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oserial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oproductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oproductid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odate;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.Label label7;
    }
}