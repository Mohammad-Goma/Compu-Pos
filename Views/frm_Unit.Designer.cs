namespace Compu_Pos.Views
{
    partial class frm_Unit
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
            btn_save = new Button();
            btn_delete = new Button();
            btn_new = new Button();
            txt_id = new TextBox();
            txt_name = new TextBox();
            txt_symbol = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstbox = new ListBox();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.DeepSkyBlue;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(683, 310);
            btn_save.Margin = new Padding(4);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(135, 42);
            btn_save.TabIndex = 10;
            btn_save.Text = "حفظ";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.DeepSkyBlue;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Location = new Point(513, 310);
            btn_delete.Margin = new Padding(4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(135, 42);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "حذف";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_new
            // 
            btn_new.BackColor = Color.DeepSkyBlue;
            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.Location = new Point(343, 310);
            btn_new.Margin = new Padding(4);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(135, 42);
            btn_new.TabIndex = 12;
            btn_new.Text = "جديد";
            btn_new.UseVisualStyleBackColor = false;
            btn_new.Click += btn_new_Click;
            // 
            // txt_id
            // 
            txt_id.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txt_id.Location = new Point(343, 65);
            txt_id.Margin = new Padding(4);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(319, 39);
            txt_id.TabIndex = 13;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txt_name.Location = new Point(343, 118);
            txt_name.Margin = new Padding(4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(319, 39);
            txt_name.TabIndex = 14;
            // 
            // txt_symbol
            // 
            txt_symbol.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txt_symbol.Location = new Point(343, 171);
            txt_symbol.Margin = new Padding(4);
            txt_symbol.Name = "txt_symbol";
            txt_symbol.Size = new Size(319, 39);
            txt_symbol.TabIndex = 15;
            txt_symbol.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(686, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 16;
            label1.Text = "الرقم المرجعي";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(686, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 32);
            label2.TabIndex = 17;
            label2.Text = "اسم الوحدة";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(686, 173);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 32);
            label3.TabIndex = 18;
            label3.Text = "التفاصيل";
            label3.Visible = false;
            // 
            // lstbox
            // 
            lstbox.FormattingEnabled = true;
            lstbox.ItemHeight = 28;
            lstbox.Location = new Point(12, 12);
            lstbox.Name = "lstbox";
            lstbox.Size = new Size(253, 340);
            lstbox.TabIndex = 19;
            lstbox.SelectedIndexChanged += lstbox_SelectedIndexChanged;
            // 
            // frm_Unit
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 379);
            Controls.Add(lstbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_symbol);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(btn_new);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frm_Unit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unit";
            Load += frm_Unit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_save;
        private Button btn_delete;
        private Button btn_new;
        private TextBox txt_id;
        private TextBox txt_name;
        private TextBox txt_symbol;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstbox;
    }
}