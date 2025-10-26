namespace Compu_Pos.Views
{
    partial class frm_Invoice
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
            components = new System.ComponentModel.Container();
            DGV = new DataGridView();
            Parcode = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Price_3 = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Totla = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewTextBoxColumn();
            txt_Invoice_Num = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DT = new DateTimePicker();
            label5 = new Label();
            Search_Parcode = new TextBox();
            Total = new TextBox();
            Discount = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            Rest = new TextBox();
            Pay = new TextBox();
            fhjmg = new Label();
            Last_total = new TextBox();
            cbo_inv_Type = new ComboBox();
            cbo_Emp = new ComboBox();
            cbo_Cust = new ComboBox();
            btn_Save = new Button();
            flashTimer = new System.Windows.Forms.Timer(components);
            label10 = new Label();
            label20 = new Label();
            qty = new TextBox();
            AddToDGV = new Button();
            txt_Price_3 = new TextBox();
            CBO_Name = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV.BackgroundColor = Color.Azure;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { Parcode, name, Price_3, Quantity, Totla, Delete });
            DGV.Location = new Point(456, 120);
            DGV.Margin = new Padding(5, 4, 5, 4);
            DGV.MultiSelect = false;
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowHeadersWidth = 51;
            DGV.RowTemplate.Height = 29;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(1166, 592);
            DGV.TabIndex = 0;
            DGV.CellBeginEdit += DGV_CellBeginEdit;
            DGV.CellClick += DGV_CellClick;
            DGV.CellEndEdit += DGV_CellEndEdit;
            DGV.CellValueChanged += DGV_CellValueChanged;
            DGV.RowsRemoved += DGV_RowsRemoved;
            // 
            // Parcode
            // 
            Parcode.FillWeight = 150F;
            Parcode.HeaderText = "الباركود";
            Parcode.MinimumWidth = 6;
            Parcode.Name = "Parcode";
            Parcode.ReadOnly = true;
            Parcode.Width = 250;
            // 
            // name
            // 
            name.FillWeight = 150F;
            name.HeaderText = "الأسم";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 400;
            // 
            // Price_3
            // 
            Price_3.FillWeight = 150F;
            Price_3.HeaderText = "السعر";
            Price_3.MinimumWidth = 6;
            Price_3.Name = "Price_3";
            Price_3.ReadOnly = true;
            Price_3.Width = 125;
            // 
            // Quantity
            // 
            Quantity.FillWeight = 150F;
            Quantity.HeaderText = "الكمية";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 125;
            // 
            // Totla
            // 
            Totla.FillWeight = 150F;
            Totla.HeaderText = "المجموع";
            Totla.MinimumWidth = 6;
            Totla.Name = "Totla";
            Totla.ReadOnly = true;
            Totla.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "حذف";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 70;
            // 
            // txt_Invoice_Num
            // 
            txt_Invoice_Num.Location = new Point(25, 23);
            txt_Invoice_Num.Margin = new Padding(5, 4, 5, 4);
            txt_Invoice_Num.Name = "txt_Invoice_Num";
            txt_Invoice_Num.Size = new Size(263, 32);
            txt_Invoice_Num.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(299, 31);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 5;
            label1.Text = "رقم الفاتورة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(299, 204);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 6;
            label2.Text = "اسم العميل";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(299, 144);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 7;
            label3.Text = "اسم الموظف";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(299, 85);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 8;
            label4.Text = "نوع الفاتورة";
            // 
            // DT
            // 
            DT.CustomFormat = "dd-MM-yyyy";
            DT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DT.Format = DateTimePickerFormat.Custom;
            DT.Location = new Point(25, 258);
            DT.Margin = new Padding(5, 4, 5, 4);
            DT.MaxDate = new DateTime(2040, 12, 31, 0, 0, 0, 0);
            DT.MinDate = new DateTime(2025, 8, 1, 0, 0, 0, 0);
            DT.Name = "DT";
            DT.Size = new Size(263, 32);
            DT.TabIndex = 9;
            DT.Value = new DateTime(2025, 10, 5, 10, 58, 12, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(299, 262);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 10;
            label5.Text = "التاريخ";
            // 
            // Search_Parcode
            // 
            Search_Parcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Search_Parcode.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Search_Parcode.Location = new Point(1240, 29);
            Search_Parcode.Margin = new Padding(5, 4, 5, 4);
            Search_Parcode.Name = "Search_Parcode";
            Search_Parcode.Size = new Size(382, 32);
            Search_Parcode.TabIndex = 11;
            Search_Parcode.TextChanged += Search_TextChanged;
            Search_Parcode.Enter += Search_Parcode_Enter;
            // 
            // Total
            // 
            Total.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Total.Location = new Point(25, 316);
            Total.Margin = new Padding(5, 4, 5, 4);
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Size = new Size(262, 44);
            Total.TabIndex = 13;
            Total.Text = "0";
            Total.TextAlign = HorizontalAlignment.Center;
            Total.TextChanged += Total_TextChanged;
            // 
            // Discount
            // 
            Discount.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Discount.Location = new Point(25, 386);
            Discount.Margin = new Padding(5, 4, 5, 4);
            Discount.Name = "Discount";
            Discount.Size = new Size(262, 44);
            Discount.TabIndex = 15;
            Discount.Text = "0";
            Discount.TextAlign = HorizontalAlignment.Center;
            Discount.TextChanged += Discount_TextChanged;
            Discount.KeyPress += Discount_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(299, 326);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 30);
            label6.TabIndex = 17;
            label6.Text = "المجموع";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(299, 396);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 30);
            label8.TabIndex = 19;
            label8.Text = "الخصم";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(299, 606);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 30);
            label7.TabIndex = 23;
            label7.Text = "الباقي";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(299, 535);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 30);
            label9.TabIndex = 22;
            label9.Text = "المدفوع";
            // 
            // Rest
            // 
            Rest.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Rest.Location = new Point(25, 596);
            Rest.Margin = new Padding(5, 4, 5, 4);
            Rest.Name = "Rest";
            Rest.ReadOnly = true;
            Rest.Size = new Size(263, 44);
            Rest.TabIndex = 21;
            Rest.Text = "0";
            Rest.TextAlign = HorizontalAlignment.Center;
            // 
            // Pay
            // 
            Pay.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Pay.Location = new Point(25, 526);
            Pay.Margin = new Padding(5, 4, 5, 4);
            Pay.Name = "Pay";
            Pay.Size = new Size(262, 44);
            Pay.TabIndex = 20;
            Pay.Text = "0";
            Pay.TextAlign = HorizontalAlignment.Center;
            Pay.TextChanged += Pay_TextChanged;
            // 
            // fhjmg
            // 
            fhjmg.AutoSize = true;
            fhjmg.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            fhjmg.Location = new Point(299, 467);
            fhjmg.Margin = new Padding(5, 0, 5, 0);
            fhjmg.Name = "fhjmg";
            fhjmg.Size = new Size(89, 30);
            fhjmg.TabIndex = 25;
            fhjmg.Text = "الاجمالي";
            // 
            // Last_total
            // 
            Last_total.BackColor = SystemColors.ButtonHighlight;
            Last_total.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Last_total.ForeColor = SystemColors.HotTrack;
            Last_total.Location = new Point(25, 456);
            Last_total.Margin = new Padding(5, 4, 5, 4);
            Last_total.Name = "Last_total";
            Last_total.ReadOnly = true;
            Last_total.Size = new Size(262, 44);
            Last_total.TabIndex = 24;
            Last_total.Text = "0";
            Last_total.TextAlign = HorizontalAlignment.Center;
            // 
            // cbo_inv_Type
            // 
            cbo_inv_Type.FormattingEnabled = true;
            cbo_inv_Type.Items.AddRange(new object[] { "نقدي", "آجل", "نقدي و آجل" });
            cbo_inv_Type.Location = new Point(25, 81);
            cbo_inv_Type.Name = "cbo_inv_Type";
            cbo_inv_Type.Size = new Size(262, 33);
            cbo_inv_Type.TabIndex = 26;
            // 
            // cbo_Emp
            // 
            cbo_Emp.FormattingEnabled = true;
            cbo_Emp.Location = new Point(25, 140);
            cbo_Emp.Name = "cbo_Emp";
            cbo_Emp.Size = new Size(262, 33);
            cbo_Emp.TabIndex = 27;
            // 
            // cbo_Cust
            // 
            cbo_Cust.FormattingEnabled = true;
            cbo_Cust.Location = new Point(25, 199);
            cbo_Cust.Name = "cbo_Cust";
            cbo_Cust.Size = new Size(263, 33);
            cbo_Cust.TabIndex = 28;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.LightSkyBlue;
            btn_Save.Location = new Point(51, 661);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(196, 51);
            btn_Save.TabIndex = 29;
            btn_Save.Text = "حفظ الفاتورة";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // flashTimer
            // 
            flashTimer.Tick += flashTimer_Tick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(832, 77);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(58, 25);
            label10.TabIndex = 32;
            label10.Text = "السعر";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(1076, 77);
            label20.Margin = new Padding(8, 0, 8, 0);
            label20.Name = "label20";
            label20.Size = new Size(135, 25);
            label20.TabIndex = 76;
            label20.Text = "الكمية المطلوبة";
            // 
            // qty
            // 
            qty.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            qty.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            qty.Location = new Point(925, 74);
            qty.Margin = new Padding(8, 7, 8, 7);
            qty.Name = "qty";
            qty.Size = new Size(135, 32);
            qty.TabIndex = 75;
            qty.Text = "1";
            qty.TextAlign = HorizontalAlignment.Center;
            // 
            // AddToDGV
            // 
            AddToDGV.BackColor = Color.DeepSkyBlue;
            AddToDGV.Location = new Point(456, 65);
            AddToDGV.Name = "AddToDGV";
            AddToDGV.Size = new Size(145, 48);
            AddToDGV.TabIndex = 97;
            AddToDGV.Text = "اضافة";
            AddToDGV.UseVisualStyleBackColor = false;
            AddToDGV.Click += AddToDGV_Click;
            // 
            // txt_Price_3
            // 
            txt_Price_3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Price_3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Price_3.Location = new Point(693, 74);
            txt_Price_3.Margin = new Padding(8, 7, 8, 7);
            txt_Price_3.Name = "txt_Price_3";
            txt_Price_3.Size = new Size(126, 32);
            txt_Price_3.TabIndex = 98;
            txt_Price_3.Text = "0";
            txt_Price_3.TextAlign = HorizontalAlignment.Center;
            // 
            // CBO_Name
            // 
            CBO_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CBO_Name.AutoCompleteMode = AutoCompleteMode.Suggest;
            CBO_Name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CBO_Name.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CBO_Name.FormattingEnabled = true;
            CBO_Name.Location = new Point(1240, 79);
            CBO_Name.Name = "CBO_Name";
            CBO_Name.Size = new Size(382, 36);
            CBO_Name.TabIndex = 99;
            CBO_Name.DropDown += CBO_Name_DropDown;
            CBO_Name.SelectedIndexChanged += CBO_Name_SelectedIndexChanged;
            CBO_Name.Enter += CBO_Name_Enter;
            CBO_Name.KeyUp += CBO_Name_KeyUp;
            // 
            // frm_Invoice
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1636, 741);
            Controls.Add(CBO_Name);
            Controls.Add(txt_Price_3);
            Controls.Add(AddToDGV);
            Controls.Add(label20);
            Controls.Add(qty);
            Controls.Add(label10);
            Controls.Add(btn_Save);
            Controls.Add(cbo_Cust);
            Controls.Add(cbo_Emp);
            Controls.Add(cbo_inv_Type);
            Controls.Add(fhjmg);
            Controls.Add(Last_total);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(Rest);
            Controls.Add(Pay);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(Discount);
            Controls.Add(Total);
            Controls.Add(Search_Parcode);
            Controls.Add(label5);
            Controls.Add(DT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Invoice_Num);
            Controls.Add(DGV);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frm_Invoice";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة المبيعات";
            WindowState = FormWindowState.Maximized;
            Load += frm_Invoice_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private TextBox txt_Invoice_Num;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker DT;
        private Label label5;
        private TextBox Search_Parcode;
        private TextBox Total;
        private TextBox Discount;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
        private TextBox Rest;
        private TextBox Pay;
        private Label fhjmg;
        private TextBox Last_total;
        private ComboBox cbo_inv_Type;
        private ComboBox cbo_Emp;
        private ComboBox cbo_Cust;
        private Button btn_Save;
        private System.Windows.Forms.Timer flashTimer;
        private Label label10;
        private Label label20;
        private TextBox qty;
        private Button AddToDGV;
        private TextBox txt_Price_3;
        private ComboBox CBO_Name;
        private DataGridViewTextBoxColumn Parcode;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Price_3;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Totla;
        private DataGridViewTextBoxColumn Delete;
    }
}