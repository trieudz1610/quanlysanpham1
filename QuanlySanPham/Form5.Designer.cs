namespace QuanlySanPham
{
    partial class AdminTransaction
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTranssaction = new System.Windows.Forms.DataGridView();
            this.transactions_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactions_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactions_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactions_totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranssaction)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "List of Transactions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Admin";
            // 
            // dgvTranssaction
            // 
            this.dgvTranssaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranssaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactions_id,
            this.product_id,
            this.product_name,
            this.customer_id,
            this.customer_name,
            this.transactions_date,
            this.transactions_quantity,
            this.transactions_totalprice});
            this.dgvTranssaction.Location = new System.Drawing.Point(12, 94);
            this.dgvTranssaction.Name = "dgvTranssaction";
            this.dgvTranssaction.Size = new System.Drawing.Size(773, 277);
            this.dgvTranssaction.TabIndex = 22;
            // 
            // transactions_id
            // 
            this.transactions_id.DataPropertyName = "transactions_id";
            this.transactions_id.HeaderText = "Transactions ID";
            this.transactions_id.Name = "transactions_id";
            this.transactions_id.Width = 50;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "Product ID";
            this.product_id.Name = "product_id";
            this.product_id.Width = 50;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "Product Name";
            this.product_name.Name = "product_name";
            this.product_name.Width = 150;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "Customer ID";
            this.customer_id.Name = "customer_id";
            this.customer_id.Width = 50;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "Customer Name";
            this.customer_name.Name = "customer_name";
            this.customer_name.Width = 150;
            // 
            // transactions_date
            // 
            this.transactions_date.DataPropertyName = "transactions_date";
            this.transactions_date.HeaderText = "Transactions Date";
            this.transactions_date.Name = "transactions_date";
            // 
            // transactions_quantity
            // 
            this.transactions_quantity.DataPropertyName = "transactions_quantity";
            this.transactions_quantity.HeaderText = "Transactions Quantity";
            this.transactions_quantity.Name = "transactions_quantity";
            // 
            // transactions_totalprice
            // 
            this.transactions_totalprice.DataPropertyName = "transactions_totalprice";
            this.transactions_totalprice.HeaderText = "Transactions Totalprice";
            this.transactions_totalprice.Name = "transactions_totalprice";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(684, 398);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 40);
            this.btnLogOut.TabIndex = 23;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 47);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 35);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.dgvTranssaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "AdminTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.AdminTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranssaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTranssaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactions_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactions_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactions_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactions_totalprice;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBack;
    }
}