namespace Compu_Pos.Views
{
    partial class frm_Employee
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
            FullName = new TextBox();
            JobTitle = new TextBox();
            Department = new TextBox();
            Salary = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lst_box = new ListBox();
            label6 = new Label();
            Id = new TextBox();
            HireDate = new DateTimePicker();
            Save = new Button();
            Delete = new Button();
            New = new Button();
            SuspendLayout();
            // 
            // FullName
            // 
            FullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FullName.Location = new Point(374, 109);
            FullName.Name = "FullName";
            FullName.Size = new Size(335, 34);
            FullName.TabIndex = 0;
            // 
            // JobTitle
            // 
            JobTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            JobTitle.Location = new Point(374, 157);
            JobTitle.Name = "JobTitle";
            JobTitle.Size = new Size(335, 34);
            JobTitle.TabIndex = 1;
            // 
            // Department
            // 
            Department.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Department.Location = new Point(374, 205);
            Department.Name = "Department";
            Department.Size = new Size(335, 34);
            Department.TabIndex = 2;
            // 
            // Salary
            // 
            Salary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Salary.Location = new Point(374, 253);
            Salary.Name = "Salary";
            Salary.Size = new Size(335, 34);
            Salary.TabIndex = 3;
            Salary.KeyPress += Salary_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(723, 115);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 6;
            label1.Text = "اسم الموظف";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(723, 158);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 7;
            label2.Text = "المسمى الوظيفي";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(723, 210);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 8;
            label3.Text = "القسم";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(723, 259);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 9;
            label4.Text = "الراتب";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(723, 311);
            label5.Name = "label5";
            label5.Size = new Size(131, 28);
            label5.TabIndex = 10;
            label5.Text = "تاريخ التوظيف";
            // 
            // lst_box
            // 
            lst_box.FormattingEnabled = true;
            lst_box.ItemHeight = 20;
            lst_box.Location = new Point(12, 43);
            lst_box.Name = "lst_box";
            lst_box.Size = new Size(331, 404);
            lst_box.TabIndex = 8;
            lst_box.SelectedIndexChanged += lst_box_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(723, 53);
            label6.Name = "label6";
            label6.Size = new Size(130, 28);
            label6.TabIndex = 13;
            label6.Text = "الرقم المرجعي";
            // 
            // Id
            // 
            Id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Id.Location = new Point(374, 47);
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Size = new Size(335, 34);
            Id.TabIndex = 10;
            // 
            // HireDate
            // 
            HireDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HireDate.Location = new Point(374, 306);
            HireDate.Name = "HireDate";
            HireDate.Size = new Size(335, 34);
            HireDate.TabIndex = 4;
            // 
            // Save
            // 
            Save.BackColor = Color.DeepSkyBlue;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Save.ForeColor = SystemColors.ActiveCaptionText;
            Save.Location = new Point(723, 409);
            Save.Name = "Save";
            Save.Size = new Size(130, 38);
            Save.TabIndex = 5;
            Save.Text = "حفظ";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Salmon;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.Location = new Point(548, 409);
            Delete.Name = "Delete";
            Delete.Size = new Size(130, 38);
            Delete.TabIndex = 6;
            Delete.Text = "حذف";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // New
            // 
            New.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            New.Location = new Point(374, 409);
            New.Name = "New";
            New.Size = new Size(130, 38);
            New.TabIndex = 7;
            New.Text = "جديد";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // frm_Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 471);
            Controls.Add(New);
            Controls.Add(Delete);
            Controls.Add(Save);
            Controls.Add(HireDate);
            Controls.Add(label6);
            Controls.Add(Id);
            Controls.Add(lst_box);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Salary);
            Controls.Add(Department);
            Controls.Add(JobTitle);
            Controls.Add(FullName);
            Name = "frm_Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += frm_Employee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FullName;
        private TextBox JobTitle;
        private TextBox Department;
        private TextBox Salary;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lst_box;
        private Label label6;
        private TextBox Id;
        private DateTimePicker HireDate;
        private Button Save;
        private Button Delete;
        private Button New;
    }
}