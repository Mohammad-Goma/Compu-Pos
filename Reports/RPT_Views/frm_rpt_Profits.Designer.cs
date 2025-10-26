namespace Compu_Pos.Reports.RPT_Views
{
    partial class frm_rpt_Profits
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
            btnShowReport = new Button();
            StartDate = new DateTimePicker();
            EndDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dgv = new DataGridView();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnShowReport
            // 
            btnShowReport.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowReport.Location = new Point(342, 23);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(190, 51);
            btnShowReport.TabIndex = 0;
            btnShowReport.Text = "عرض التقرير";
            btnShowReport.UseVisualStyleBackColor = true;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // StartDate
            // 
            StartDate.CustomFormat = "dd-MM-yyyy";
            StartDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            StartDate.Format = DateTimePickerFormat.Custom;
            StartDate.Location = new Point(1023, 29);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(220, 39);
            StartDate.TabIndex = 1;
            // 
            // EndDate
            // 
            EndDate.CustomFormat = "dd-MM-yyyy";
            EndDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EndDate.Format = DateTimePickerFormat.Custom;
            EndDate.Location = new Point(596, 29);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(228, 39);
            EndDate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1249, 32);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 3;
            label1.Text = "من تاريخ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(830, 32);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 4;
            label2.Text = "الى تاريخ";
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 109);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(1336, 550);
            dgv.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(1038, 692);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(119, 32);
            lblTotal.TabIndex = 6;
            lblTotal.Text = ".....................";
            // 
            // frm_rpt_Profits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 751);
            Controls.Add(lblTotal);
            Controls.Add(dgv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EndDate);
            Controls.Add(StartDate);
            Controls.Add(btnShowReport);
            Name = "frm_rpt_Profits";
            Text = "تقرير الارباح";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowReport;
        private DateTimePicker StartDate;
        private DateTimePicker EndDate;
        private Label label1;
        private Label label2;
        private DataGridView dgv;
        private Label lblTotal;
    }
}