namespace Compu_Pos.Views
{
    partial class frm_Customer
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
            Address = new TextBox();
            Email = new TextBox();
            PhoneNumber = new TextBox();
            FullName = new TextBox();
            SuspendLayout();
            // 
            // New
            // 
            New.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            New.Location = new Point(308, 334);
            New.Name = "New";
            New.Size = new Size(130, 38);
            New.TabIndex = 6;
            New.Text = "جديد";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Salmon;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.Location = new Point(482, 334);
            Delete.Name = "Delete";
            Delete.Size = new Size(130, 38);
            Delete.TabIndex = 5;
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
            Save.Location = new Point(657, 334);
            Save.Name = "Save";
            Save.Size = new Size(130, 38);
            Save.TabIndex = 4;
            Save.Text = "حفظ";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(657, 62);
            label6.Name = "label6";
            label6.Size = new Size(130, 28);
            label6.TabIndex = 29;
            label6.Text = "الرقم المرجعي";
            // 
            // Id
            // 
            Id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Id.Location = new Point(308, 56);
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.RightToLeft = RightToLeft.Yes;
            Id.Size = new Size(335, 34);
            Id.TabIndex = 28;
            // 
            // lst_box
            // 
            lst_box.FormattingEnabled = true;
            lst_box.ItemHeight = 20;
            lst_box.Location = new Point(12, 54);
            lst_box.Name = "lst_box";
            lst_box.Size = new Size(272, 324);
            lst_box.TabIndex = 27;
            lst_box.SelectedIndexChanged += lst_box_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(657, 266);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 25;
            label4.Text = "العنوان";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(657, 215);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 24;
            label3.Text = "البريد الالكتروني";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(657, 164);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 23;
            label2.Text = "رقم الهاتف";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(657, 113);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 22;
            label1.Text = "اسم العميل";
            // 
            // Address
            // 
            Address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Address.Location = new Point(308, 260);
            Address.Name = "Address";
            Address.RightToLeft = RightToLeft.Yes;
            Address.Size = new Size(335, 34);
            Address.TabIndex = 3;
            // 
            // Email
            // 
            Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Email.Location = new Point(308, 209);
            Email.Name = "Email";
            Email.RightToLeft = RightToLeft.Yes;
            Email.Size = new Size(335, 34);
            Email.TabIndex = 2;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumber.Location = new Point(308, 158);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.RightToLeft = RightToLeft.Yes;
            PhoneNumber.Size = new Size(335, 34);
            PhoneNumber.TabIndex = 1;
            // 
            // FullName
            // 
            FullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FullName.Location = new Point(308, 107);
            FullName.Name = "FullName";
            FullName.RightToLeft = RightToLeft.Yes;
            FullName.Size = new Size(335, 34);
            FullName.TabIndex = 0;
            // 
            // frm_Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 399);
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
            Controls.Add(Address);
            Controls.Add(Email);
            Controls.Add(PhoneNumber);
            Controls.Add(FullName);
            Name = "frm_Customer";
            Text = "Customer";
            Load += frm_Customer_Load;
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
        private TextBox Address;
        private TextBox Email;
        private TextBox PhoneNumber;
        private TextBox FullName;
    }
}