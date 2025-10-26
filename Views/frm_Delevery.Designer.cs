namespace Compu_Pos.Views
{
    partial class frm_Delevery
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
            New = new Button();
            Delete = new Button();
            Save = new Button();
            label6 = new Label();
            Id = new TextBox();
            lst_box = new ListBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PhoneNumber = new TextBox();
            Name_D = new TextBox();
            label5 = new Label();
            PhoneNumber_2 = new TextBox();
            label7 = new Label();
            PhoneNumber_3 = new TextBox();
            DeliveryDate = new DateTimePicker();
            cbo_comp = new ComboBox();
            cbo_delevery = new ComboBox();
            SuspendLayout();
            // 
            // New
            // 
            New.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            New.Location = new Point(38, 439);
            New.Name = "New";
            New.Size = new Size(130, 38);
            New.TabIndex = 36;
            New.Text = "جديد";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Salmon;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.Location = new Point(212, 439);
            Delete.Name = "Delete";
            Delete.Size = new Size(130, 38);
            Delete.TabIndex = 35;
            Delete.Text = "حذف";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.DeepSkyBlue;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Save.ForeColor = SystemColors.ActiveCaptionText;
            Save.Location = new Point(387, 439);
            Save.Name = "Save";
            Save.Size = new Size(130, 38);
            Save.TabIndex = 34;
            Save.Text = "حفظ";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(387, 80);
            label6.Name = "label6";
            label6.Size = new Size(130, 28);
            label6.TabIndex = 43;
            label6.Text = "الرقم المرجعي";
            // 
            // Id
            // 
            Id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Id.Location = new Point(38, 82);
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.RightToLeft = RightToLeft.Yes;
            Id.Size = new Size(335, 34);
            Id.TabIndex = 42;
            // 
            // lst_box
            // 
            lst_box.FormattingEnabled = true;
            lst_box.ItemHeight = 20;
            lst_box.Location = new Point(387, 36);
            lst_box.Name = "lst_box";
            lst_box.Size = new Size(93, 24);
            lst_box.TabIndex = 41;
            lst_box.Visible = false;
            //lst_box.SelectedIndexChanged += lst_box_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(387, 368);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 40;
            label4.Text = "اسم الشركة";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(387, 320);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 39;
            label3.Text = "تاريخ التعاون";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(387, 176);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 38;
            label2.Text = "رقم الهاتف";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(387, 128);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 37;
            label1.Text = "اسم المندوب";
            // 
            // PhoneNumber
            // 
            PhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumber.Location = new Point(38, 176);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.RightToLeft = RightToLeft.Yes;
            PhoneNumber.Size = new Size(335, 34);
            PhoneNumber.TabIndex = 31;
            // 
            // Name_D
            // 
            Name_D.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name_D.Location = new Point(38, 129);
            Name_D.Name = "Name_D";
            Name_D.RightToLeft = RightToLeft.Yes;
            Name_D.Size = new Size(335, 34);
            Name_D.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(387, 224);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 45;
            label5.Text = "رقم الهاتف";
            // 
            // PhoneNumber_2
            // 
            PhoneNumber_2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumber_2.Location = new Point(38, 223);
            PhoneNumber_2.Name = "PhoneNumber_2";
            PhoneNumber_2.RightToLeft = RightToLeft.Yes;
            PhoneNumber_2.Size = new Size(335, 34);
            PhoneNumber_2.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(387, 272);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 47;
            label7.Text = "رقم الهاتف";
            // 
            // PhoneNumber_3
            // 
            PhoneNumber_3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumber_3.Location = new Point(38, 270);
            PhoneNumber_3.Name = "PhoneNumber_3";
            PhoneNumber_3.RightToLeft = RightToLeft.Yes;
            PhoneNumber_3.Size = new Size(335, 34);
            PhoneNumber_3.TabIndex = 46;
            // 
            // DeliveryDate
            // 
            DeliveryDate.CustomFormat = "dd-MM-yyyy";
            DeliveryDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeliveryDate.Format = DateTimePickerFormat.Custom;
            DeliveryDate.Location = new Point(38, 317);
            DeliveryDate.Name = "DeliveryDate";
            DeliveryDate.Size = new Size(335, 34);
            DeliveryDate.TabIndex = 48;
            // 
            // cbo_comp
            // 
            cbo_comp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbo_comp.FormattingEnabled = true;
            cbo_comp.Location = new Point(38, 364);
            cbo_comp.Name = "cbo_comp";
            cbo_comp.RightToLeft = RightToLeft.Yes;
            cbo_comp.Size = new Size(335, 36);
            cbo_comp.TabIndex = 49;
            // 
            // cbo_delevery
            // 
            cbo_delevery.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbo_delevery.FormattingEnabled = true;
            cbo_delevery.Location = new Point(38, 30);
            cbo_delevery.Name = "cbo_delevery";
            cbo_delevery.Size = new Size(335, 39);
            cbo_delevery.TabIndex = 50;
            cbo_delevery.SelectedIndexChanged += cbo_delevery_SelectedIndexChanged;
            // 
            // frm_Delevery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 506);
            Controls.Add(cbo_delevery);
            Controls.Add(cbo_comp);
            Controls.Add(DeliveryDate);
            Controls.Add(label7);
            Controls.Add(PhoneNumber_3);
            Controls.Add(label5);
            Controls.Add(PhoneNumber_2);
            Controls.Add(New);
            Controls.Add(Delete);
            Controls.Add(Save);
            Controls.Add(label6);
            Controls.Add(Id);
            Controls.Add(lst_box);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PhoneNumber);
            Controls.Add(Name_D);
            MaximizeBox = false;
            Name = "frm_Delevery";
            Text = "Delevery";
            Load += frm_Delevery_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button New;
        private Button Delete;
        private Button Save;
        private Label label6;
        private TextBox Id;
        private ListBox lst_box;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox PhoneNumber;
        private TextBox Name_D;
        private Label label5;
        private TextBox PhoneNumber_2;
        private Label label7;
        private TextBox PhoneNumber_3;
        private DateTimePicker DeliveryDate;
        private ComboBox cbo_comp;
        private ComboBox cbo_delevery;
    }
}