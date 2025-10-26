namespace Compu_Pos.Views
{
    partial class frm_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Product));
            label5 = new Label();
            label4 = new Label();
            cbo_stores = new ComboBox();
            cbo_branches = new ComboBox();
            txt_name = new TextBox();
            txt_id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_new = new Button();
            btn_delete = new Button();
            btn_save = new Button();
            label3 = new Label();
            cbo_cats = new ComboBox();
            txt_price2 = new TextBox();
            txt_price1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txt_price3 = new TextBox();
            label8 = new Label();
            txt_search = new TextBox();
            label9 = new Label();
            hid_pri_1 = new PictureBox();
            hid_pri_2 = new PictureBox();
            hid_pri_3 = new PictureBox();
            txt_qty = new TextBox();
            label10 = new Label();
            label11 = new Label();
            cbo_units = new ComboBox();
            txt_Parcode = new TextBox();
            label12 = new Label();
            lstbox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)hid_pri_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hid_pri_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hid_pri_3).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1105, 493);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 32;
            label5.Text = "المخزن";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1105, 538);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 31;
            label4.Text = "الفرع";
            // 
            // cbo_stores
            // 
            cbo_stores.FormattingEnabled = true;
            cbo_stores.Location = new Point(801, 491);
            cbo_stores.Margin = new Padding(4);
            cbo_stores.Name = "cbo_stores";
            cbo_stores.RightToLeft = RightToLeft.Yes;
            cbo_stores.Size = new Size(296, 36);
            cbo_stores.TabIndex = 30;
            // 
            // cbo_branches
            // 
            cbo_branches.FormattingEnabled = true;
            cbo_branches.Location = new Point(801, 537);
            cbo_branches.Margin = new Padding(4);
            cbo_branches.Name = "cbo_branches";
            cbo_branches.RightToLeft = RightToLeft.Yes;
            cbo_branches.Size = new Size(296, 36);
            cbo_branches.TabIndex = 29;
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Location = new Point(640, 99);
            txt_name.Margin = new Padding(4);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(457, 70);
            txt_name.TabIndex = 28;
            txt_name.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_id
            // 
            txt_id.BorderStyle = BorderStyle.FixedSingle;
            txt_id.Enabled = false;
            txt_id.Location = new Point(928, 55);
            txt_id.Margin = new Padding(4);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(169, 34);
            txt_id.TabIndex = 27;
            txt_id.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1105, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 26;
            label2.Text = "اسم المنتج";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1105, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 25;
            label1.Text = "الرقم المرجعي";
            // 
            // btn_new
            // 
            btn_new.Location = new Point(800, 596);
            btn_new.Margin = new Padding(4);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(95, 51);
            btn_new.TabIndex = 24;
            btn_new.Text = "جديد";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(928, 596);
            btn_delete.Margin = new Padding(4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(95, 51);
            btn_delete.TabIndex = 23;
            btn_delete.Text = "حذف";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(1056, 596);
            btn_save.Margin = new Padding(4);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(95, 51);
            btn_save.TabIndex = 22;
            btn_save.Text = "حفظ";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1105, 448);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 35;
            label3.Text = "القسم";
            // 
            // cbo_cats
            // 
            cbo_cats.FormattingEnabled = true;
            cbo_cats.Location = new Point(801, 445);
            cbo_cats.Margin = new Padding(4);
            cbo_cats.Name = "cbo_cats";
            cbo_cats.RightToLeft = RightToLeft.Yes;
            cbo_cats.Size = new Size(296, 36);
            cbo_cats.TabIndex = 34;
            // 
            // txt_price2
            // 
            txt_price2.BorderStyle = BorderStyle.FixedSingle;
            txt_price2.Location = new Point(878, 267);
            txt_price2.Margin = new Padding(4);
            txt_price2.Name = "txt_price2";
            txt_price2.Size = new Size(219, 34);
            txt_price2.TabIndex = 39;
            txt_price2.TextAlign = HorizontalAlignment.Right;
            txt_price2.KeyPress += txt_price2_KeyPress;
            // 
            // txt_price1
            // 
            txt_price1.BorderStyle = BorderStyle.FixedSingle;
            txt_price1.Location = new Point(878, 223);
            txt_price1.Margin = new Padding(4);
            txt_price1.Name = "txt_price1";
            txt_price1.Size = new Size(219, 34);
            txt_price1.TabIndex = 38;
            txt_price1.TextAlign = HorizontalAlignment.Right;
            txt_price1.KeyPress += txt_price1_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1105, 268);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 28);
            label6.TabIndex = 37;
            label6.Text = "سعر الديللر";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1105, 223);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(107, 28);
            label7.TabIndex = 36;
            label7.Text = "سعر الجملة";
            // 
            // txt_price3
            // 
            txt_price3.BorderStyle = BorderStyle.FixedSingle;
            txt_price3.Location = new Point(878, 311);
            txt_price3.Margin = new Padding(4);
            txt_price3.Name = "txt_price3";
            txt_price3.Size = new Size(219, 34);
            txt_price3.TabIndex = 41;
            txt_price3.TextAlign = HorizontalAlignment.Right;
            txt_price3.KeyPress += txt_price3_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1105, 313);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(136, 28);
            label8.TabIndex = 40;
            label8.Text = "سعر المستخدم";
            // 
            // txt_search
            // 
            txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_search.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(36, 46);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(592, 39);
            txt_search.TabIndex = 42;
            txt_search.TextAlign = HorizontalAlignment.Right;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(640, 51);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 28);
            label9.TabIndex = 43;
            label9.Text = "البحث";
            // 
            // hid_pri_1
            // 
            hid_pri_1.Image = (Image)resources.GetObject("hid_pri_1.Image");
            hid_pri_1.Location = new Point(810, 220);
            hid_pri_1.Name = "hid_pri_1";
            hid_pri_1.Size = new Size(64, 34);
            hid_pri_1.SizeMode = PictureBoxSizeMode.StretchImage;
            hid_pri_1.TabIndex = 44;
            hid_pri_1.TabStop = false;
            hid_pri_1.Click += hid_pri_1_Click;
            // 
            // hid_pri_2
            // 
            hid_pri_2.Image = (Image)resources.GetObject("hid_pri_2.Image");
            hid_pri_2.Location = new Point(810, 265);
            hid_pri_2.Name = "hid_pri_2";
            hid_pri_2.Size = new Size(64, 34);
            hid_pri_2.SizeMode = PictureBoxSizeMode.StretchImage;
            hid_pri_2.TabIndex = 47;
            hid_pri_2.TabStop = false;
            hid_pri_2.Click += hid_pri_2_Click;
            // 
            // hid_pri_3
            // 
            hid_pri_3.Image = (Image)resources.GetObject("hid_pri_3.Image");
            hid_pri_3.Location = new Point(810, 310);
            hid_pri_3.Name = "hid_pri_3";
            hid_pri_3.Size = new Size(64, 34);
            hid_pri_3.SizeMode = PictureBoxSizeMode.StretchImage;
            hid_pri_3.TabIndex = 48;
            hid_pri_3.TabStop = false;
            hid_pri_3.Click += hid_pri_3_Click;
            // 
            // txt_qty
            // 
            txt_qty.BorderStyle = BorderStyle.FixedSingle;
            txt_qty.Location = new Point(801, 355);
            txt_qty.Margin = new Padding(4);
            txt_qty.Name = "txt_qty";
            txt_qty.Size = new Size(296, 34);
            txt_qty.TabIndex = 50;
            txt_qty.TextAlign = HorizontalAlignment.Center;
            txt_qty.KeyPress += txt_qty_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1105, 358);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(63, 28);
            label10.TabIndex = 49;
            label10.Text = "الكمية";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1105, 403);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(66, 28);
            label11.TabIndex = 52;
            label11.Text = "الوحدة";
            // 
            // cbo_units
            // 
            cbo_units.FormattingEnabled = true;
            cbo_units.Location = new Point(801, 399);
            cbo_units.Margin = new Padding(4);
            cbo_units.Name = "cbo_units";
            cbo_units.RightToLeft = RightToLeft.Yes;
            cbo_units.Size = new Size(296, 36);
            cbo_units.TabIndex = 51;
            // 
            // txt_Parcode
            // 
            txt_Parcode.BorderStyle = BorderStyle.FixedSingle;
            txt_Parcode.Location = new Point(801, 179);
            txt_Parcode.Margin = new Padding(4);
            txt_Parcode.Name = "txt_Parcode";
            txt_Parcode.Size = new Size(296, 34);
            txt_Parcode.TabIndex = 54;
            txt_Parcode.TextAlign = HorizontalAlignment.Right;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1105, 178);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(72, 28);
            label12.TabIndex = 53;
            label12.Text = "الباركود";
            // 
            // lstbox
            // 
            lstbox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lstbox.FormattingEnabled = true;
            lstbox.ItemHeight = 31;
            lstbox.Location = new Point(37, 85);
            lstbox.Name = "lstbox";
            lstbox.Size = new Size(590, 562);
            lstbox.TabIndex = 55;
            lstbox.SelectedIndexChanged += lst_SelectedIndexChanged;
            // 
            // frm_Product
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 701);
            Controls.Add(lstbox);
            Controls.Add(txt_Parcode);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(cbo_units);
            Controls.Add(txt_qty);
            Controls.Add(label10);
            Controls.Add(hid_pri_3);
            Controls.Add(hid_pri_2);
            Controls.Add(hid_pri_1);
            Controls.Add(label9);
            Controls.Add(txt_search);
            Controls.Add(txt_price3);
            Controls.Add(label8);
            Controls.Add(txt_price2);
            Controls.Add(txt_price1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(cbo_cats);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbo_stores);
            Controls.Add(cbo_branches);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_new);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frm_Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)hid_pri_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hid_pri_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hid_pri_3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private ComboBox cbo_stores;
        private ComboBox cbo_branches;
        private TextBox txt_name;
        private TextBox txt_id;
        private Label label2;
        private Label label1;
        private Button btn_new;
        private Button btn_delete;
        private Button btn_save;
        private Label label3;
        private ComboBox cbo_cats;
        private TextBox txt_price2;
        private TextBox txt_price1;
        private Label label6;
        private Label label7;
        private TextBox txt_price3;
        private Label label8;
        private TextBox txt_search;
        private Label label9;
        private PictureBox hid_pri_1;
        private PictureBox hid_pri_2;
        private PictureBox hid_pri_3;
        private TextBox txt_qty;
        private Label label10;
        private Label label11;
        private ComboBox cbo_units;
        private TextBox txt_Parcode;
        private Label label12;
        private ListBox lstbox;
    }
}