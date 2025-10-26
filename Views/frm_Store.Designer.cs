namespace Compu_Pos.Views
{
    partial class frm_Store
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
            txt_details = new TextBox();
            txt_name = new TextBox();
            txt_id = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_new = new Button();
            btn_delete = new Button();
            btn_save = new Button();
            cbo_Store = new ComboBox();
            cbo_branch = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txt_details
            // 
            txt_details.Location = new Point(44, 310);
            txt_details.Margin = new Padding(4);
            txt_details.Name = "txt_details";
            txt_details.Size = new Size(390, 34);
            txt_details.TabIndex = 19;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(44, 180);
            txt_name.Margin = new Padding(4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(390, 34);
            txt_name.TabIndex = 18;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(44, 116);
            txt_id.Margin = new Padding(4);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(390, 34);
            txt_id.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 317);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 16;
            label3.Text = "التفاصيل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 187);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 15;
            label2.Text = "اسم المخزن";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 122);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 14;
            label1.Text = "الرقم المرجعي";
            // 
            // btn_new
            // 
            btn_new.Location = new Point(44, 386);
            btn_new.Margin = new Padding(4);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(170, 38);
            btn_new.TabIndex = 13;
            btn_new.Text = "جديد";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(235, 386);
            btn_delete.Margin = new Padding(4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(170, 38);
            btn_delete.TabIndex = 12;
            btn_delete.Text = "حذف";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(426, 386);
            btn_save.Margin = new Padding(4);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(170, 38);
            btn_save.TabIndex = 11;
            btn_save.Text = "حفظ";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // cbo_Store
            // 
            cbo_Store.FormattingEnabled = true;
            cbo_Store.Location = new Point(44, 36);
            cbo_Store.Margin = new Padding(6);
            cbo_Store.Name = "cbo_Store";
            cbo_Store.Size = new Size(390, 36);
            cbo_Store.TabIndex = 10;
            cbo_Store.SelectedIndexChanged += cbo_Store_SelectedIndexChanged;
            // 
            // cbo_branch
            // 
            cbo_branch.FormattingEnabled = true;
            cbo_branch.Location = new Point(44, 244);
            cbo_branch.Margin = new Padding(6);
            cbo_branch.Name = "cbo_branch";
            cbo_branch.Size = new Size(390, 36);
            cbo_branch.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 252);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 21;
            label4.Text = "اسم الفرع";
            // 
            // frm_Store
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 447);
            Controls.Add(label4);
            Controls.Add(cbo_branch);
            Controls.Add(txt_details);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_new);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Controls.Add(cbo_Store);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frm_Store";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store";
            Load += frm_Store_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_details;
        private TextBox txt_name;
        private TextBox txt_id;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_new;
        private Button btn_delete;
        private Button btn_save;
        private ComboBox cbo_Store;
        private ComboBox cbo_branch;
        private Label label4;
    }
}