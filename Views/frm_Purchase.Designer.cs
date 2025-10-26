namespace Compu_Pos.Views
{
    partial class frm_Purchase
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
            btn_Save = new Button();
            cbo_Emp = new ComboBox();
            cbo_inv_Type = new ComboBox();
            fhjmg = new Label();
            Last_total = new TextBox();
            label7 = new Label();
            label9 = new Label();
            Rest = new TextBox();
            label6 = new Label();
            Pay = new TextBox();
            Discount = new TextBox();
            Total = new TextBox();
            label8 = new Label();
            label5 = new Label();
            DT = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txt_Purchase_Num = new TextBox();
            DGV = new DataGridView();
            Parcode = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Price_3 = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Totals = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewTextBoxColumn();
            Search_Name = new TextBox();
            Barcode = new TextBox();
            Pric_3 = new TextBox();
            Price_1 = new TextBox();
            Price_2 = new TextBox();
            label2 = new Label();
            label10 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label20 = new Label();
            qty = new TextBox();
            label13 = new Label();
            cbo_Deleviry = new ComboBox();
            label21 = new Label();
            cbo_Branch = new ComboBox();
            label11 = new Label();
            textBox1 = new TextBox();
            cbo_Store = new ComboBox();
            cbo_Cat = new ComboBox();
            cbo_unit = new ComboBox();
            label17 = new Label();
            label18 = new Label();
            label12 = new Label();
            AddToDGV = new Button();
            Save = new Button();
            cbo_ProductName = new ComboBox();
            flashTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.LightSkyBlue;
            btn_Save.Location = new Point(40, 1077);
            btn_Save.Margin = new Padding(5, 4, 5, 4);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(449, 79);
            btn_Save.TabIndex = 53;
            btn_Save.Text = "حفظ الفاتورة";
            btn_Save.UseVisualStyleBackColor = false;
            // 
            // cbo_Emp
            // 
            cbo_Emp.FormattingEnabled = true;
            cbo_Emp.Location = new Point(17, 120);
            cbo_Emp.Margin = new Padding(5, 4, 5, 4);
            cbo_Emp.Name = "cbo_Emp";
            cbo_Emp.Size = new Size(286, 33);
            cbo_Emp.TabIndex = 51;
            // 
            // cbo_inv_Type
            // 
            cbo_inv_Type.FormattingEnabled = true;
            cbo_inv_Type.Items.AddRange(new object[] { "نقدي", "آجل", "نقدي و آجل" });
            cbo_inv_Type.Location = new Point(17, 222);
            cbo_inv_Type.Margin = new Padding(5, 4, 5, 4);
            cbo_inv_Type.Name = "cbo_inv_Type";
            cbo_inv_Type.Size = new Size(283, 33);
            cbo_inv_Type.TabIndex = 50;
            // 
            // fhjmg
            // 
            fhjmg.AutoSize = true;
            fhjmg.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            fhjmg.Location = new Point(304, 413);
            fhjmg.Margin = new Padding(8, 0, 8, 0);
            fhjmg.Name = "fhjmg";
            fhjmg.Size = new Size(89, 30);
            fhjmg.TabIndex = 49;
            fhjmg.Text = "الاجمالي";
            // 
            // Last_total
            // 
            Last_total.BackColor = SystemColors.ButtonHighlight;
            Last_total.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Last_total.ForeColor = SystemColors.HotTrack;
            Last_total.Location = new Point(17, 403);
            Last_total.Margin = new Padding(8, 7, 8, 7);
            Last_total.Name = "Last_total";
            Last_total.ReadOnly = true;
            Last_total.Size = new Size(283, 44);
            Last_total.TabIndex = 48;
            Last_total.Text = "0";
            Last_total.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(308, 543);
            label7.Margin = new Padding(8, 0, 8, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 30);
            label7.TabIndex = 47;
            label7.Text = "الباقي";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(304, 478);
            label9.Margin = new Padding(8, 0, 8, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 30);
            label9.TabIndex = 46;
            label9.Text = "المدفوع";
            // 
            // Rest
            // 
            Rest.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Rest.Location = new Point(17, 533);
            Rest.Margin = new Padding(8, 7, 8, 7);
            Rest.Name = "Rest";
            Rest.ReadOnly = true;
            Rest.Size = new Size(283, 44);
            Rest.TabIndex = 45;
            Rest.Text = "0";
            Rest.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(308, 283);
            label6.Margin = new Padding(8, 0, 8, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 30);
            label6.TabIndex = 42;
            label6.Text = "المجموع";
            // 
            // Pay
            // 
            Pay.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Pay.Location = new Point(17, 468);
            Pay.Margin = new Padding(8, 7, 8, 7);
            Pay.Name = "Pay";
            Pay.Size = new Size(283, 44);
            Pay.TabIndex = 44;
            Pay.Text = "0";
            Pay.TextAlign = HorizontalAlignment.Center;
            Pay.TextChanged += Pay_TextChanged;
            Pay.KeyPress += Pay_KeyPress;
            // 
            // Discount
            // 
            Discount.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Discount.Location = new Point(17, 338);
            Discount.Margin = new Padding(8, 7, 8, 7);
            Discount.Name = "Discount";
            Discount.Size = new Size(283, 44);
            Discount.TabIndex = 41;
            Discount.Text = "0";
            Discount.TextAlign = HorizontalAlignment.Center;
            Discount.TextChanged += Discount_TextChanged;
            Discount.KeyPress += Discount_KeyPress;
            // 
            // Total
            // 
            Total.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Total.Location = new Point(17, 273);
            Total.Margin = new Padding(8, 7, 8, 7);
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Size = new Size(283, 44);
            Total.TabIndex = 40;
            Total.Text = "0";
            Total.TextAlign = HorizontalAlignment.Center;
            Total.TextChanged += Total_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(308, 348);
            label8.Margin = new Padding(8, 0, 8, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 30);
            label8.TabIndex = 43;
            label8.Text = "الخصم";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(308, 72);
            label5.Margin = new Padding(8, 0, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 37;
            label5.Text = "التاريخ";
            // 
            // DT
            // 
            DT.CustomFormat = "dd-MM-yyyy";
            DT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DT.Format = DateTimePickerFormat.Custom;
            DT.Location = new Point(17, 69);
            DT.Margin = new Padding(8, 7, 8, 7);
            DT.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            DT.MinDate = new DateTime(2025, 8, 1, 0, 0, 0, 0);
            DT.Name = "DT";
            DT.Size = new Size(286, 32);
            DT.TabIndex = 36;
            DT.Value = new DateTime(2025, 9, 5, 22, 37, 32, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(308, 225);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 35;
            label4.Text = "نوع الفاتورة";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(308, 127);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 34;
            label3.Text = "اسم الموظف";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(308, 23);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 32;
            label1.Text = "رقم الفاتورة";
            // 
            // txt_Purchase_Num
            // 
            txt_Purchase_Num.Location = new Point(17, 18);
            txt_Purchase_Num.Margin = new Padding(8, 7, 8, 7);
            txt_Purchase_Num.Name = "txt_Purchase_Num";
            txt_Purchase_Num.Size = new Size(286, 32);
            txt_Purchase_Num.TabIndex = 31;
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV.BackgroundColor = Color.Azure;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { Parcode, name, Price_3, Quantity, Totals, Delete });
            DGV.Location = new Point(522, 174);
            DGV.Margin = new Padding(8, 7, 8, 7);
            DGV.MultiSelect = false;
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RightToLeft = RightToLeft.Yes;
            DGV.RowHeadersWidth = 51;
            DGV.RowTemplate.Height = 29;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(1251, 524);
            DGV.TabIndex = 30;
            DGV.CellClick += DGV_CellClick;
            // 
            // Parcode
            // 
            Parcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Parcode.FillWeight = 150F;
            Parcode.HeaderText = "الباركود";
            Parcode.MinimumWidth = 6;
            Parcode.Name = "Parcode";
            Parcode.ReadOnly = true;
            // 
            // name
            // 
            name.FillWeight = 150F;
            name.HeaderText = "الأسم";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 212;
            // 
            // Price_3
            // 
            Price_3.FillWeight = 150F;
            Price_3.HeaderText = "السعر";
            Price_3.MinimumWidth = 6;
            Price_3.Name = "Price_3";
            Price_3.ReadOnly = true;
            Price_3.Width = 211;
            // 
            // Quantity
            // 
            Quantity.FillWeight = 150F;
            Quantity.HeaderText = "الكمية";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 212;
            // 
            // Totals
            // 
            Totals.FillWeight = 150F;
            Totals.HeaderText = "المجموع";
            Totals.MinimumWidth = 6;
            Totals.Name = "Totals";
            Totals.ReadOnly = true;
            Totals.Width = 211;
            // 
            // Delete
            // 
            Delete.HeaderText = "حذف";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 141;
            // 
            // Search_Name
            // 
            Search_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Search_Name.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Search_Name.Location = new Point(836, 24);
            Search_Name.Margin = new Padding(8, 7, 8, 7);
            Search_Name.Name = "Search_Name";
            Search_Name.Size = new Size(389, 32);
            Search_Name.TabIndex = 54;
            Search_Name.TextChanged += Search_Name_TextChanged;
            // 
            // Barcode
            // 
            Barcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Barcode.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Barcode.Location = new Point(1399, 24);
            Barcode.Margin = new Padding(8, 7, 8, 7);
            Barcode.Name = "Barcode";
            Barcode.Size = new Size(250, 32);
            Barcode.TabIndex = 57;
            Barcode.TextAlign = HorizontalAlignment.Center;
            Barcode.TextChanged += Barcode_TextChanged;
            Barcode.KeyPress += Barcode_KeyPress;
            // 
            // Pric_3
            // 
            Pric_3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pric_3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Pric_3.Location = new Point(1085, 72);
            Pric_3.Margin = new Padding(8, 7, 8, 7);
            Pric_3.Name = "Pric_3";
            Pric_3.Size = new Size(140, 32);
            Pric_3.TabIndex = 56;
            Pric_3.Text = "0";
            Pric_3.TextAlign = HorizontalAlignment.Center;
            Pric_3.KeyPress += Pric_3_KeyPress;
            // 
            // Price_1
            // 
            Price_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Price_1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Price_1.Location = new Point(1399, 72);
            Price_1.Margin = new Padding(8, 7, 8, 7);
            Price_1.Name = "Price_1";
            Price_1.Size = new Size(250, 32);
            Price_1.TabIndex = 59;
            Price_1.Text = "0";
            Price_1.TextAlign = HorizontalAlignment.Center;
            Price_1.KeyPress += Price_1_KeyPress;
            // 
            // Price_2
            // 
            Price_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Price_2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Price_2.Location = new Point(1399, 122);
            Price_2.Margin = new Padding(8, 7, 8, 7);
            Price_2.Name = "Price_2";
            Price_2.Size = new Size(250, 32);
            Price_2.TabIndex = 58;
            Price_2.Text = "0";
            Price_2.TextAlign = HorizontalAlignment.Center;
            Price_2.KeyPress += Price_2_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1652, 27);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 62;
            label2.Text = "الباركود";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1228, 75);
            label10.Margin = new Padding(8, 0, 8, 0);
            label10.Name = "label10";
            label10.Size = new Size(128, 25);
            label10.TabIndex = 63;
            label10.Text = "سعر المستخدم";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(1228, 27);
            label14.Margin = new Padding(8, 0, 8, 0);
            label14.Name = "label14";
            label14.Size = new Size(104, 25);
            label14.TabIndex = 67;
            label14.Text = "اسم الصنف";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(1652, 75);
            label15.Margin = new Padding(8, 0, 8, 0);
            label15.Name = "label15";
            label15.Size = new Size(100, 25);
            label15.TabIndex = 68;
            label15.Text = "سعر المورد";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(1652, 125);
            label16.Margin = new Padding(8, 0, 8, 0);
            label16.Name = "label16";
            label16.Size = new Size(101, 25);
            label16.TabIndex = 69;
            label16.Text = "سعر الجملة";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(1228, 125);
            label20.Margin = new Padding(8, 0, 8, 0);
            label20.Name = "label20";
            label20.Size = new Size(123, 25);
            label20.TabIndex = 74;
            label20.Text = "الكمية الجديدة";
            // 
            // qty
            // 
            qty.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            qty.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            qty.Location = new Point(1085, 122);
            qty.Margin = new Padding(8, 7, 8, 7);
            qty.Name = "qty";
            qty.Size = new Size(140, 32);
            qty.TabIndex = 71;
            qty.Text = "1";
            qty.TextAlign = HorizontalAlignment.Center;
            qty.KeyPress += qty_KeyPress;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(374, 627);
            label13.Margin = new Padding(8, 0, 8, 0);
            label13.Name = "label13";
            label13.Size = new Size(53, 25);
            label13.TabIndex = 79;
            label13.Text = "الفرع";
            label13.Visible = false;
            // 
            // cbo_Deleviry
            // 
            cbo_Deleviry.FormattingEnabled = true;
            cbo_Deleviry.Location = new Point(17, 171);
            cbo_Deleviry.Margin = new Padding(5, 4, 5, 4);
            cbo_Deleviry.Name = "cbo_Deleviry";
            cbo_Deleviry.Size = new Size(283, 33);
            cbo_Deleviry.TabIndex = 81;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(308, 174);
            label21.Margin = new Padding(8, 0, 8, 0);
            label21.Name = "label21";
            label21.Size = new Size(114, 25);
            label21.TabIndex = 80;
            label21.Text = "اسم المندوب";
            // 
            // cbo_Branch
            // 
            cbo_Branch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbo_Branch.FormattingEnabled = true;
            cbo_Branch.Location = new Point(326, 630);
            cbo_Branch.Name = "cbo_Branch";
            cbo_Branch.Size = new Size(39, 33);
            cbo_Branch.TabIndex = 85;
            cbo_Branch.Visible = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(375, 580);
            label11.Margin = new Padding(8, 0, 8, 0);
            label11.Name = "label11";
            label11.Size = new Size(114, 25);
            label11.TabIndex = 95;
            label11.Text = "الكمية الحالية";
            label11.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(326, 581);
            textBox1.Margin = new Padding(8, 7, 8, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 32);
            textBox1.TabIndex = 94;
            textBox1.Visible = false;
            // 
            // cbo_Store
            // 
            cbo_Store.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbo_Store.FormattingEnabled = true;
            cbo_Store.Location = new Point(326, 675);
            cbo_Store.Name = "cbo_Store";
            cbo_Store.Size = new Size(39, 33);
            cbo_Store.TabIndex = 93;
            cbo_Store.Visible = false;
            // 
            // cbo_Cat
            // 
            cbo_Cat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbo_Cat.FormattingEnabled = true;
            cbo_Cat.Location = new Point(460, 662);
            cbo_Cat.Name = "cbo_Cat";
            cbo_Cat.Size = new Size(49, 33);
            cbo_Cat.TabIndex = 92;
            cbo_Cat.Visible = false;
            // 
            // cbo_unit
            // 
            cbo_unit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbo_unit.Enabled = false;
            cbo_unit.FormattingEnabled = true;
            cbo_unit.Location = new Point(522, 73);
            cbo_unit.Name = "cbo_unit";
            cbo_unit.RightToLeft = RightToLeft.Yes;
            cbo_unit.Size = new Size(208, 33);
            cbo_unit.TabIndex = 91;
            cbo_unit.Text = "قطعة";
            cbo_unit.Visible = false;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(374, 677);
            label17.Margin = new Padding(8, 0, 8, 0);
            label17.Name = "label17";
            label17.Size = new Size(66, 25);
            label17.TabIndex = 90;
            label17.Text = "المخزن";
            label17.Visible = false;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(444, 627);
            label18.Margin = new Padding(8, 0, 8, 0);
            label18.Name = "label18";
            label18.Size = new Size(60, 25);
            label18.TabIndex = 89;
            label18.Text = "القسم";
            label18.Visible = false;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Enabled = false;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(741, 76);
            label12.Margin = new Padding(8, 0, 8, 0);
            label12.Name = "label12";
            label12.Size = new Size(64, 25);
            label12.TabIndex = 88;
            label12.Text = "الوحدة";
            label12.Visible = false;
            // 
            // AddToDGV
            // 
            AddToDGV.BackColor = Color.DeepSkyBlue;
            AddToDGV.Location = new Point(519, 116);
            AddToDGV.Name = "AddToDGV";
            AddToDGV.Size = new Size(211, 48);
            AddToDGV.TabIndex = 96;
            AddToDGV.Text = "اضافة";
            AddToDGV.UseVisualStyleBackColor = false;
            AddToDGV.Click += AddToDGV_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.LightSkyBlue;
            Save.Location = new Point(17, 649);
            Save.Name = "Save";
            Save.Size = new Size(283, 53);
            Save.TabIndex = 97;
            Save.Text = "حفظ الفاتورة";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // cbo_ProductName
            // 
            cbo_ProductName.FormattingEnabled = true;
            cbo_ProductName.Location = new Point(836, 75);
            cbo_ProductName.Name = "cbo_ProductName";
            cbo_ProductName.Size = new Size(208, 33);
            cbo_ProductName.TabIndex = 98;
            cbo_ProductName.Visible = false;
            cbo_ProductName.SelectedIndexChanged += cbo_ProductName_SelectedIndexChanged;
            // 
            // flashTimer
            // 
            flashTimer.Tick += flashTimer_Tick;
            // 
            // frm_Purchase
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1790, 714);
            Controls.Add(cbo_ProductName);
            Controls.Add(Save);
            Controls.Add(AddToDGV);
            Controls.Add(label11);
            Controls.Add(textBox1);
            Controls.Add(cbo_Store);
            Controls.Add(cbo_Cat);
            Controls.Add(cbo_unit);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label12);
            Controls.Add(cbo_Branch);
            Controls.Add(cbo_Deleviry);
            Controls.Add(label21);
            Controls.Add(label13);
            Controls.Add(label20);
            Controls.Add(qty);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(Price_1);
            Controls.Add(Price_2);
            Controls.Add(Barcode);
            Controls.Add(Pric_3);
            Controls.Add(Search_Name);
            Controls.Add(btn_Save);
            Controls.Add(cbo_Emp);
            Controls.Add(cbo_inv_Type);
            Controls.Add(fhjmg);
            Controls.Add(Last_total);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(Rest);
            Controls.Add(label6);
            Controls.Add(Pay);
            Controls.Add(Discount);
            Controls.Add(Total);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(DT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txt_Purchase_Num);
            Controls.Add(DGV);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frm_Purchase";
            Text = "فاتورة المشتريات";
            Load += frm_Purchase_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Save;
        private ComboBox cbo_Emp;
        private ComboBox cbo_inv_Type;
        private Label fhjmg;
        private TextBox Last_total;
        private Label label7;
        private Label label9;
        private TextBox Rest;
        private Label label6;
        private TextBox Pay;
        private TextBox Discount;
        private TextBox Total;
        private Label label8;
        private Label label5;
        private DateTimePicker DT;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txt_Purchase_Num;
        private DataGridView DGV;
        private TextBox Search_Name;
        private TextBox Barcode;
        private TextBox Pric_3;
        private TextBox Price_1;
        private TextBox Price_2;
        private Label label2;
        private Label label10;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label20;
        private TextBox qty;
        private Label label13;
        private ComboBox cbo_Deleviry;
        private Label label21;
        private ComboBox cbo_Branch;
        private Label label11;
        private TextBox textBox1;
        private ComboBox cbo_Store;
        private ComboBox cbo_Cat;
        private ComboBox cbo_unit;
        private Label label17;
        private Label label18;
        private Label label12;
        private Button AddToDGV;
        private Button Save;
        private DataGridViewTextBoxColumn Parcode;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Price_3;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Totals;
        private DataGridViewTextBoxColumn Delete;
        private ComboBox cbo_ProductName;
        private System.Windows.Forms.Timer flashTimer;
    }
}