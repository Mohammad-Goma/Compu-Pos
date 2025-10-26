namespace Compu_Pos.Reports.RPT_Views
{
    partial class frm_rpt_Invoice
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
            StartDate = new DateTimePicker();
            EndDate = new DateTimePicker();
            btnShowReport = new Button();
            dgv = new DataGridView();
            lblTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // StartDate
            // 
            StartDate.CustomFormat = "dd-MM-yyyy";
            StartDate.Format = DateTimePickerFormat.Custom;
            StartDate.Location = new Point(1115, 43);
            StartDate.Margin = new Padding(5);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(192, 32);
            StartDate.TabIndex = 0;
            // 
            // EndDate
            // 
            EndDate.CustomFormat = "dd-MM-yyyy";
            EndDate.Format = DateTimePickerFormat.Custom;
            EndDate.Location = new Point(771, 42);
            EndDate.Margin = new Padding(5);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(201, 32);
            EndDate.TabIndex = 1;
            // 
            // btnShowReport
            // 
            btnShowReport.Location = new Point(571, 38);
            btnShowReport.Margin = new Padding(5);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(162, 42);
            btnShowReport.TabIndex = 2;
            btnShowReport.Text = "تقرير";
            btnShowReport.UseVisualStyleBackColor = true;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 111);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(1396, 538);
            dgv.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(952, 683);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(184, 31);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "..................................";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1165, 683);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 6;
            label1.Text = "اجمالي المبيعات";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1315, 43);
            label2.Name = "label2";
            label2.Size = new Size(95, 31);
            label2.TabIndex = 7;
            label2.Text = "من تاريخ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(976, 42);
            label3.Name = "label3";
            label3.Size = new Size(100, 31);
            label3.TabIndex = 8;
            label3.Text = "الى تاريخ";
            // 
            // frm_rpt_Invoice
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 741);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(dgv);
            Controls.Add(btnShowReport);
            Controls.Add(EndDate);
            Controls.Add(StartDate);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frm_rpt_Invoice";
            Text = "تقرير المبيعات";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker StartDate;
        private DateTimePicker EndDate;
        private Button btnShowReport;
        private DataGridView dgv;
        private Label lblTotal;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}