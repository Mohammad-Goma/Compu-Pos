namespace Compu_Pos.Views
{
    partial class frm_Cat
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
            btn_new = new Button();
            btn_delete = new Button();
            btn_save = new Button();
            txt_name = new TextBox();
            txt_id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbo_branch = new ComboBox();
            cbo_store = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            lst_box = new ListBox();
            SuspendLayout();
            // 
            // btn_new
            // 
            btn_new.Location = new Point(376, 280);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(130, 44);
            btn_new.TabIndex = 6;
            btn_new.Text = "جديد";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(567, 280);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(130, 44);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "حذف";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(758, 280);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(130, 44);
            btn_save.TabIndex = 4;
            btn_save.Text = "حفظ";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(376, 82);
            txt_name.Name = "txt_name";
            txt_name.RightToLeft = RightToLeft.Yes;
            txt_name.Size = new Size(378, 34);
            txt_name.TabIndex = 14;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(376, 18);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.RightToLeft = RightToLeft.Yes;
            txt_id.Size = new Size(378, 34);
            txt_id.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(760, 84);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 11;
            label2.Text = "اسم القسم";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(760, 19);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 10;
            label1.Text = "الرقم المرجعي";
            // 
            // cbo_branch
            // 
            cbo_branch.FormattingEnabled = true;
            cbo_branch.Location = new Point(376, 132);
            cbo_branch.Name = "cbo_branch";
            cbo_branch.RightToLeft = RightToLeft.Yes;
            cbo_branch.Size = new Size(378, 36);
            cbo_branch.TabIndex = 16;
            // 
            // cbo_store
            // 
            cbo_store.FormattingEnabled = true;
            cbo_store.Location = new Point(376, 184);
            cbo_store.Name = "cbo_store";
            cbo_store.RightToLeft = RightToLeft.Yes;
            cbo_store.Size = new Size(378, 36);
            cbo_store.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(760, 135);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 18;
            label4.Text = "الفرع";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(760, 186);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 19;
            label5.Text = "المخزن";
            // 
            // lst_box
            // 
            lst_box.FormattingEnabled = true;
            lst_box.ItemHeight = 28;
            lst_box.Location = new Point(12, 12);
            lst_box.Name = "lst_box";
            lst_box.Size = new Size(330, 312);
            lst_box.TabIndex = 20;
            lst_box.SelectedIndexChanged += lst_box_SelectedIndexChanged;
            // 
            // frm_Cat
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 344);
            Controls.Add(lst_box);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbo_store);
            Controls.Add(cbo_branch);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_new);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frm_Cat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cat";
            Load += frm_Cat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_new;
        private Button btn_delete;
        private Button btn_save;
        private TextBox txt_name;
        private TextBox txt_id;
        private Label label2;
        private Label label1;
        private ComboBox cbo_branch;
        private ComboBox cbo_store;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn storeFKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn branchFKDataGridViewTextBoxColumn;
        private ListBox lst_box;
    }
}