namespace Compu_Pos.Views
{
    partial class frm_Purchase_Return
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
            DT = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DGV = new DataGridView();
            Parcode = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Price_3 = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Totla = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label5 = new Label();
            Discount = new TextBox();
            Total = new TextBox();
            Pay = new TextBox();
            btn_Save = new Button();
            cbo_Cust = new ComboBox();
            cbo_Emp = new ComboBox();
            cbo_inv_Type = new ComboBox();
            fhjmg = new Label();
            Last_total = new TextBox();
            label7 = new Label();
            label9 = new Label();
            Rest = new TextBox();
            label6 = new Label();
            txt_Invoice_Num = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // DT
            // 
            DT.CustomFormat = "dd-MM-yyyy";
            DT.Enabled = false;
            DT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DT.Format = DateTimePickerFormat.Custom;
            DT.Location = new Point(26, 248);
            DT.Margin = new Padding(8, 7, 8, 7);
            DT.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            DT.MinDate = new DateTime(2025, 8, 1, 0, 0, 0, 0);
            DT.Name = "DT";
            DT.Size = new Size(344, 34);
            DT.TabIndex = 60;
            DT.Value = new DateTime(2025, 9, 5, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(383, 89);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 32);
            label4.TabIndex = 59;
            label4.Text = "نوع الفاتورة";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(383, 144);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 32);
            label3.TabIndex = 58;
            label3.Text = "اسم الموظف";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(383, 198);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 32);
            label2.TabIndex = 57;
            label2.Text = "اسم العميل";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(383, 34);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 56;
            label1.Text = "رقم الفاتورة";
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV.BackgroundColor = Color.Azure;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { Parcode, name, Price_3, Quantity, Totla, Delete });
            DGV.Location = new Point(556, 34);
            DGV.Margin = new Padding(8, 7, 8, 7);
            DGV.MultiSelect = false;
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RightToLeft = RightToLeft.Yes;
            DGV.RowHeadersWidth = 51;
            DGV.RowTemplate.Height = 29;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(1135, 608);
            DGV.TabIndex = 54;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(383, 378);
            label8.Margin = new Padding(8, 0, 8, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 37);
            label8.TabIndex = 67;
            label8.Text = "الخصم";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(383, 251);
            label5.Margin = new Padding(8, 0, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 32);
            label5.TabIndex = 61;
            label5.Text = "التاريخ";
            // 
            // Discount
            // 
            Discount.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Discount.Location = new Point(26, 370);
            Discount.Margin = new Padding(8, 7, 8, 7);
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            Discount.Size = new Size(341, 53);
            Discount.TabIndex = 65;
            Discount.Text = "0";
            Discount.TextAlign = HorizontalAlignment.Center;
            // 
            // Total
            // 
            Total.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Total.Location = new Point(26, 301);
            Total.Margin = new Padding(8, 7, 8, 7);
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Size = new Size(341, 53);
            Total.TabIndex = 64;
            Total.Text = "0";
            Total.TextAlign = HorizontalAlignment.Center;
            // 
            // Pay
            // 
            Pay.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Pay.Location = new Point(26, 511);
            Pay.Margin = new Padding(8, 7, 8, 7);
            Pay.Name = "Pay";
            Pay.ReadOnly = true;
            Pay.Size = new Size(341, 53);
            Pay.TabIndex = 68;
            Pay.Text = "0";
            Pay.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.LightSkyBlue;
            btn_Save.Location = new Point(71, 1080);
            btn_Save.Margin = new Padding(5, 4, 5, 4);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(449, 79);
            btn_Save.TabIndex = 77;
            btn_Save.Text = "حفظ الفاتورة";
            btn_Save.UseVisualStyleBackColor = false;
            // 
            // cbo_Cust
            // 
            cbo_Cust.Enabled = false;
            cbo_Cust.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbo_Cust.FormattingEnabled = true;
            cbo_Cust.Location = new Point(26, 195);
            cbo_Cust.Margin = new Padding(5, 4, 5, 4);
            cbo_Cust.Name = "cbo_Cust";
            cbo_Cust.Size = new Size(344, 36);
            cbo_Cust.TabIndex = 76;
            // 
            // cbo_Emp
            // 
            cbo_Emp.Enabled = false;
            cbo_Emp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbo_Emp.FormattingEnabled = true;
            cbo_Emp.Location = new Point(26, 141);
            cbo_Emp.Margin = new Padding(5, 4, 5, 4);
            cbo_Emp.Name = "cbo_Emp";
            cbo_Emp.Size = new Size(341, 36);
            cbo_Emp.TabIndex = 75;
            // 
            // cbo_inv_Type
            // 
            cbo_inv_Type.Enabled = false;
            cbo_inv_Type.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbo_inv_Type.FormattingEnabled = true;
            cbo_inv_Type.Items.AddRange(new object[] { "نقدي", "آجل", "نقدي و آجل" });
            cbo_inv_Type.Location = new Point(26, 86);
            cbo_inv_Type.Margin = new Padding(5, 4, 5, 4);
            cbo_inv_Type.Name = "cbo_inv_Type";
            cbo_inv_Type.Size = new Size(341, 36);
            cbo_inv_Type.TabIndex = 74;
            // 
            // fhjmg
            // 
            fhjmg.AutoSize = true;
            fhjmg.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            fhjmg.Location = new Point(383, 448);
            fhjmg.Margin = new Padding(8, 0, 8, 0);
            fhjmg.Name = "fhjmg";
            fhjmg.Size = new Size(111, 37);
            fhjmg.TabIndex = 73;
            fhjmg.Text = "الاجمالي";
            // 
            // Last_total
            // 
            Last_total.BackColor = SystemColors.ButtonHighlight;
            Last_total.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Last_total.ForeColor = SystemColors.HotTrack;
            Last_total.Location = new Point(26, 440);
            Last_total.Margin = new Padding(8, 7, 8, 7);
            Last_total.Name = "Last_total";
            Last_total.ReadOnly = true;
            Last_total.Size = new Size(341, 53);
            Last_total.TabIndex = 72;
            Last_total.Text = "0";
            Last_total.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(383, 586);
            label7.Margin = new Padding(8, 0, 8, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 37);
            label7.TabIndex = 71;
            label7.Text = "الباقي";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(383, 519);
            label9.Margin = new Padding(8, 0, 8, 0);
            label9.Name = "label9";
            label9.Size = new Size(107, 37);
            label9.TabIndex = 70;
            label9.Text = "المدفوع";
            // 
            // Rest
            // 
            Rest.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Rest.Location = new Point(26, 578);
            Rest.Margin = new Padding(8, 7, 8, 7);
            Rest.Name = "Rest";
            Rest.ReadOnly = true;
            Rest.Size = new Size(341, 53);
            Rest.TabIndex = 69;
            Rest.Text = "0";
            Rest.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(383, 309);
            label6.Margin = new Padding(8, 0, 8, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 37);
            label6.TabIndex = 66;
            label6.Text = "المجموع";
            // 
            // txt_Invoice_Num
            // 
            txt_Invoice_Num.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Invoice_Num.Location = new Point(26, 31);
            txt_Invoice_Num.Margin = new Padding(8, 7, 8, 7);
            txt_Invoice_Num.Name = "txt_Invoice_Num";
            txt_Invoice_Num.Size = new Size(344, 34);
            txt_Invoice_Num.TabIndex = 55;
            // 
            // frm_Purchase_Return
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1708, 710);
            Controls.Add(DT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DGV);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(Discount);
            Controls.Add(Total);
            Controls.Add(Pay);
            Controls.Add(btn_Save);
            Controls.Add(cbo_Cust);
            Controls.Add(cbo_Emp);
            Controls.Add(cbo_inv_Type);
            Controls.Add(fhjmg);
            Controls.Add(Last_total);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(Rest);
            Controls.Add(label6);
            Controls.Add(txt_Invoice_Num);
            Name = "frm_Purchase_Return";
            Text = "مرتجع المشتريات";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DT;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView DGV;
        private DataGridViewTextBoxColumn Parcode;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Price_3;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Totla;
        private DataGridViewTextBoxColumn Delete;
        private Label label8;
        private Label label5;
        private TextBox Discount;
        private TextBox Total;
        private TextBox Pay;
        private Button btn_Save;
        private ComboBox cbo_Cust;
        private ComboBox cbo_Emp;
        private ComboBox cbo_inv_Type;
        private Label fhjmg;
        private TextBox Last_total;
        private Label label7;
        private Label label9;
        private TextBox Rest;
        private Label label6;
        private TextBox txt_Invoice_Num;
    }
}