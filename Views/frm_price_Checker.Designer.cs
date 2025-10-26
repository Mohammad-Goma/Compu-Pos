namespace Compu_Pos.Views
{
    partial class frm_price_Checker
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
            Search = new TextBox();
            name = new TextBox();
            parcode = new TextBox();
            qty = new TextBox();
            price_3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            price_2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // Search
            // 
            Search.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            Search.Location = new Point(37, 50);
            Search.Name = "Search";
            Search.Size = new Size(1127, 56);
            Search.TabIndex = 0;
            Search.TextChanged += Search_TextChanged;
            Search.KeyPress += Search_KeyPress;
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(35, 356);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(945, 50);
            name.TabIndex = 1;
            name.TextAlign = HorizontalAlignment.Center;
            // 
            // parcode
            // 
            parcode.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            parcode.Location = new Point(35, 442);
            parcode.Name = "parcode";
            parcode.ReadOnly = true;
            parcode.Size = new Size(945, 50);
            parcode.TabIndex = 2;
            parcode.TextAlign = HorizontalAlignment.Center;
            // 
            // qty
            // 
            qty.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            qty.Location = new Point(37, 528);
            qty.Name = "qty";
            qty.ReadOnly = true;
            qty.Size = new Size(943, 50);
            qty.TabIndex = 3;
            qty.TextAlign = HorizontalAlignment.Center;
            // 
            // price_3
            // 
            price_3.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            price_3.Location = new Point(37, 270);
            price_3.Name = "price_3";
            price_3.ReadOnly = true;
            price_3.Size = new Size(945, 50);
            price_3.TabIndex = 4;
            price_3.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1010, 274);
            label1.Name = "label1";
            label1.Size = new Size(98, 45);
            label1.TabIndex = 5;
            label1.Text = "السعر";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1010, 359);
            label2.Name = "label2";
            label2.Size = new Size(177, 45);
            label2.TabIndex = 6;
            label2.Text = "اسم الصنف";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1010, 444);
            label3.Name = "label3";
            label3.Size = new Size(170, 45);
            label3.TabIndex = 7;
            label3.Text = "رقم الباركود";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1010, 529);
            label5.Name = "label5";
            label5.Size = new Size(101, 45);
            label5.TabIndex = 8;
            label5.Text = "الكمية";
            // 
            // price_2
            // 
            price_2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            price_2.Location = new Point(37, 184);
            price_2.Name = "price_2";
            price_2.ReadOnly = true;
            price_2.Size = new Size(945, 50);
            price_2.TabIndex = 9;
            price_2.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1013, 189);
            label4.Name = "label4";
            label4.Size = new Size(82, 45);
            label4.TabIndex = 10;
            label4.Text = "ديللر";
            // 
            // frm_price_Checker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 629);
            Controls.Add(label4);
            Controls.Add(price_2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(price_3);
            Controls.Add(qty);
            Controls.Add(parcode);
            Controls.Add(name);
            Controls.Add(Search);
            Name = "frm_price_Checker";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "عرض السعر";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Search;
        private TextBox name;
        private TextBox parcode;
        private TextBox qty;
        private TextBox price_3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox price_2;
        private Label label4;
    }
}