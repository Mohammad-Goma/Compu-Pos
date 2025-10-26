namespace Compu_Pos.Views
{
    partial class frm_Company
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
            label5 = new Label();
            label4 = new Label();
            txt_name = new TextBox();
            txt_id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_new = new Button();
            btn_delete = new Button();
            btn_save = new Button();
            txt_phone = new TextBox();
            txt_adress = new TextBox();
            txt_email = new TextBox();
            label3 = new Label();
            label6 = new Label();
            lst_box = new ListBox();
            dt_Company = new DateTimePicker();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1353, 187);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 30;
            label5.Text = "رقم الهاتف";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1353, 145);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 29;
            label4.Text = "العنوان";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(827, 100);
            txt_name.Margin = new Padding(4);
            txt_name.Name = "txt_name";
            txt_name.RightToLeft = RightToLeft.Yes;
            txt_name.Size = new Size(518, 34);
            txt_name.TabIndex = 26;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(827, 58);
            txt_id.Margin = new Padding(4);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.RightToLeft = RightToLeft.Yes;
            txt_id.Size = new Size(518, 34);
            txt_id.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1353, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 24;
            label2.Text = "اسم الشركة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1353, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 23;
            label1.Text = "الرقم المرجعي";
            // 
            // btn_new
            // 
            btn_new.Location = new Point(827, 425);
            btn_new.Margin = new Padding(4);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(154, 50);
            btn_new.TabIndex = 22;
            btn_new.Text = "جديد";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(1009, 425);
            btn_delete.Margin = new Padding(4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(154, 50);
            btn_delete.TabIndex = 21;
            btn_delete.Text = "حذف";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(1191, 425);
            btn_save.Margin = new Padding(4);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(154, 50);
            btn_save.TabIndex = 20;
            btn_save.Text = "حفظ";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(827, 184);
            txt_phone.Margin = new Padding(4);
            txt_phone.Name = "txt_phone";
            txt_phone.RightToLeft = RightToLeft.Yes;
            txt_phone.Size = new Size(518, 34);
            txt_phone.TabIndex = 33;
            // 
            // txt_adress
            // 
            txt_adress.Location = new Point(827, 142);
            txt_adress.Margin = new Padding(4);
            txt_adress.Name = "txt_adress";
            txt_adress.RightToLeft = RightToLeft.Yes;
            txt_adress.Size = new Size(518, 34);
            txt_adress.TabIndex = 32;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(827, 226);
            txt_email.Margin = new Padding(4);
            txt_email.Name = "txt_email";
            txt_email.RightToLeft = RightToLeft.Yes;
            txt_email.Size = new Size(518, 34);
            txt_email.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1353, 229);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 34;
            label3.Text = "الايميل";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1353, 271);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 28);
            label6.TabIndex = 36;
            label6.Text = "تاريخ التعامل";
            // 
            // lst_box
            // 
            lst_box.FormattingEnabled = true;
            lst_box.ItemHeight = 28;
            lst_box.Location = new Point(24, 51);
            lst_box.Name = "lst_box";
            lst_box.Size = new Size(785, 424);
            lst_box.TabIndex = 38;
            lst_box.SelectedIndexChanged += lst_box_SelectedIndexChanged;
            // 
            // dt_Company
            // 
            dt_Company.CustomFormat = "DD/mm/yyyy";
            dt_Company.Enabled = false;
            dt_Company.Location = new Point(827, 271);
            dt_Company.Name = "dt_Company";
            dt_Company.RightToLeft = RightToLeft.Yes;
            dt_Company.Size = new Size(518, 34);
            dt_Company.TabIndex = 39;
            // 
            // frm_Company
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 495);
            Controls.Add(dt_Company);
            Controls.Add(lst_box);
            Controls.Add(label6);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(txt_phone);
            Controls.Add(txt_adress);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_new);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frm_Company";
            Text = "Company";
            Load += frm_Company_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox txt_name;
        private TextBox txt_id;
        private Label label2;
        private Label label1;
        private Button btn_new;
        private Button btn_delete;
        private Button btn_save;
        private TextBox txt_phone;
        private TextBox txt_adress;
        private TextBox txt_email;
        private Label label3;
        private TextBox dt_company;
        private Label label6;
        private ListBox lst_box;
        private DateTimePicker dt_Company;
    }
}