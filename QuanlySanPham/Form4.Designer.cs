namespace QuanlySanPham
{
    partial class CustomerInformation
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerGender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtC4 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDetele = new System.Windows.Forms.Button();
            this.DgvCustomer = new System.Windows.Forms.DataGridView();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbCustomerID = new System.Windows.Forms.Label();
            this.LbCustomerNameError = new System.Windows.Forms.Label();
            this.LbAddressError = new System.Windows.Forms.Label();
            this.LbPhoneError = new System.Windows.Forms.Label();
            this.lbemailError = new System.Windows.Forms.Label();
            this.lbGenderError = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(140, 36);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(168, 20);
            this.txtCustomerID.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(140, 95);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(168, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(140, 157);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(168, 20);
            this.txtCustomerAddress.TabIndex = 2;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(140, 276);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(168, 20);
            this.txtCustomerEmail.TabIndex = 3;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(140, 221);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(168, 20);
            this.txtCustomerPhone.TabIndex = 4;
            // 
            // txtCustomerGender
            // 
            this.txtCustomerGender.Location = new System.Drawing.Point(140, 334);
            this.txtCustomerGender.Name = "txtCustomerGender";
            this.txtCustomerGender.Size = new System.Drawing.Size(168, 20);
            this.txtCustomerGender.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer ID";
            // 
            // txtC4
            // 
            this.txtC4.AutoSize = true;
            this.txtC4.Location = new System.Drawing.Point(43, 95);
            this.txtC4.Name = "txtC4";
            this.txtC4.Size = new System.Drawing.Size(82, 13);
            this.txtC4.TabIndex = 8;
            this.txtC4.Text = "Customer Name";
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.Location = new System.Drawing.Point(43, 157);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(92, 13);
            this.txt3.TabIndex = 9;
            this.txt3.Text = "Customer Address";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(43, 224);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(85, 13);
            this.txt2.TabIndex = 10;
            this.txt2.Text = "Customer Phone";
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(43, 279);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(79, 13);
            this.txt1.TabIndex = 11;
            this.txt1.Text = "Customer Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Customer Gender";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(46, 389);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 35);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(140, 389);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDetele
            // 
            this.btnDetele.Location = new System.Drawing.Point(327, 389);
            this.btnDetele.Name = "btnDetele";
            this.btnDetele.Size = new System.Drawing.Size(75, 35);
            this.btnDetele.TabIndex = 16;
            this.btnDetele.Text = "Detele";
            this.btnDetele.UseVisualStyleBackColor = true;
            this.btnDetele.Click += new System.EventHandler(this.btnDetele_Click);
            // 
            // DgvCustomer
            // 
            this.DgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.customer_name,
            this.customer_address,
            this.customer_phone,
            this.customer_email,
            this.customer_gender});
            this.DgvCustomer.Location = new System.Drawing.Point(383, 36);
            this.DgvCustomer.Name = "DgvCustomer";
            this.DgvCustomer.Size = new System.Drawing.Size(676, 331);
            this.DgvCustomer.TabIndex = 17;
            this.DgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // customer_address
            // 
            this.customer_address.DataPropertyName = "customer_address";
            this.customer_address.HeaderText = "Customer Address";
            this.customer_address.Name = "customer_address";
            this.customer_address.Width = 150;
            // 
            // customer_phone
            // 
            this.customer_phone.DataPropertyName = "customer_phone";
            this.customer_phone.HeaderText = "Customer Phone";
            this.customer_phone.Name = "customer_phone";
            this.customer_phone.Width = 80;
            // 
            // customer_email
            // 
            this.customer_email.DataPropertyName = "customer_email";
            this.customer_email.HeaderText = "Customer Email";
            this.customer_email.Name = "customer_email";
            this.customer_email.Width = 150;
            // 
            // customer_gender
            // 
            this.customer_gender.DataPropertyName = "customer_gender";
            this.customer_gender.HeaderText = "Customer Gender";
            this.customer_gender.Name = "customer_gender";
            this.customer_gender.Width = 50;
            // 
            // LbCustomerID
            // 
            this.LbCustomerID.AutoSize = true;
            this.LbCustomerID.Location = new System.Drawing.Point(149, 63);
            this.LbCustomerID.Name = "LbCustomerID";
            this.LbCustomerID.Size = new System.Drawing.Size(0, 13);
            this.LbCustomerID.TabIndex = 18;
            // 
            // LbCustomerNameError
            // 
            this.LbCustomerNameError.AutoSize = true;
            this.LbCustomerNameError.Location = new System.Drawing.Point(152, 122);
            this.LbCustomerNameError.Name = "LbCustomerNameError";
            this.LbCustomerNameError.Size = new System.Drawing.Size(0, 13);
            this.LbCustomerNameError.TabIndex = 19;
            // 
            // LbAddressError
            // 
            this.LbAddressError.AutoSize = true;
            this.LbAddressError.Location = new System.Drawing.Point(149, 191);
            this.LbAddressError.Name = "LbAddressError";
            this.LbAddressError.Size = new System.Drawing.Size(0, 13);
            this.LbAddressError.TabIndex = 20;
            // 
            // LbPhoneError
            // 
            this.LbPhoneError.AutoSize = true;
            this.LbPhoneError.Location = new System.Drawing.Point(149, 244);
            this.LbPhoneError.Name = "LbPhoneError";
            this.LbPhoneError.Size = new System.Drawing.Size(0, 13);
            this.LbPhoneError.TabIndex = 21;
            // 
            // lbemailError
            // 
            this.lbemailError.AutoSize = true;
            this.lbemailError.Location = new System.Drawing.Point(152, 299);
            this.lbemailError.Name = "lbemailError";
            this.lbemailError.Size = new System.Drawing.Size(0, 13);
            this.lbemailError.TabIndex = 22;
            // 
            // lbGenderError
            // 
            this.lbGenderError.AutoSize = true;
            this.lbGenderError.Location = new System.Drawing.Point(149, 357);
            this.lbGenderError.Name = "lbGenderError";
            this.lbGenderError.Size = new System.Drawing.Size(0, 13);
            this.lbGenderError.TabIndex = 23;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(824, 389);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 35);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbGenderError);
            this.Controls.Add(this.lbemailError);
            this.Controls.Add(this.LbPhoneError);
            this.Controls.Add(this.LbAddressError);
            this.Controls.Add(this.LbCustomerNameError);
            this.Controls.Add(this.LbCustomerID);
            this.Controls.Add(this.DgvCustomer);
            this.Controls.Add(this.btnDetele);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txtC4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerGender);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Name = "CustomerInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtC4;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDetele;
        private System.Windows.Forms.DataGridView DgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_gender;
        private System.Windows.Forms.Label LbCustomerID;
        private System.Windows.Forms.Label LbCustomerNameError;
        private System.Windows.Forms.Label LbAddressError;
        private System.Windows.Forms.Label LbPhoneError;
        private System.Windows.Forms.Label lbemailError;
        private System.Windows.Forms.Label lbGenderError;
        private System.Windows.Forms.Button btnBack;
    }
}