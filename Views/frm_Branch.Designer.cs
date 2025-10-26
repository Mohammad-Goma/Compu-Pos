namespace Compu_Pos.Views
{
    partial class frm_Branch
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
            cbo_branch = new ComboBox();
            btn_save = new Button();
            btn_delete = new Button();
            btn_new = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_id = new TextBox();
            txt_name = new TextBox();
            txt_details = new TextBox();
            SuspendLayout();
            // 
            // cbo_branch
            // 
            cbo_branch.FormattingEnabled = true;
            cbo_branch.Location = new Point(55, 26);
            cbo_branch.Margin = new Padding(4);
            cbo_branch.Name = "cbo_branch";
            cbo_branch.Size = new Size(298, 36);
            cbo_branch.TabIndex = 0;
            cbo_branch.SelectedIndexChanged += cbo_branch_SelectedIndexChanged;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(422, 348);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(155, 43);
            btn_save.TabIndex = 1;
            btn_save.Text = "حفظ";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(239, 348);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(155, 43);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "حذف";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_new
            // 
            btn_new.Location = new Point(55, 348);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(155, 43);
            btn_new.TabIndex = 3;
            btn_new.Text = "جديد";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(404, 121);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 4;
            label1.Text = "الرقم المرجعي";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 191);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 5;
            label2.Text = "اسم الفرع";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 265);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 6;
            label3.Text = "التفاصيل";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(55, 115);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(298, 34);
            txt_id.TabIndex = 7;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(55, 185);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(298, 34);
            txt_name.TabIndex = 8;
            // 
            // txt_details
            // 
            txt_details.Location = new Point(55, 259);
            txt_details.Name = "txt_details";
            txt_details.Size = new Size(298, 34);
            txt_details.TabIndex = 9;
            // 
            // frm_Branch
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 434);
            Controls.Add(txt_details);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_new);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Controls.Add(cbo_branch);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frm_Branch";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الفروع";
            Load += frm_Branch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbo_branch;
        private Button btn_save;
        private Button btn_delete;
        private Button btn_new;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_id;
        private TextBox txt_name;
        private TextBox txt_details;
    }
}