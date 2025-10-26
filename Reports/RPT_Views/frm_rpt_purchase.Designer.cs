namespace Compu_Pos.Reports.RPT_Views
{
    partial class frm_rpt_purchase
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
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // StartDate
            // 
            StartDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StartDate.CustomFormat = "dd-MM-yyyy";
            StartDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            StartDate.Format = DateTimePickerFormat.Custom;
            StartDate.Location = new Point(1034, 54);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(238, 39);
            StartDate.TabIndex = 0;
            // 
            // EndDate
            // 
            EndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EndDate.CustomFormat = "dd-MM-yyyy";
            EndDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EndDate.Format = DateTimePickerFormat.Custom;
            EndDate.Location = new Point(588, 54);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(265, 39);
            EndDate.TabIndex = 1;
            // 
            // btnShowReport
            // 
            btnShowReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowReport.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowReport.Location = new Point(408, 51);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(117, 48);
            btnShowReport.TabIndex = 2;
            btnShowReport.Text = "عرض التقرير";
            btnShowReport.UseVisualStyleBackColor = true;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 128);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(1365, 533);
            dgv.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(1077, 692);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(132, 29);
            lblTotal.TabIndex = 5;
            lblTotal.Text = ".................";
            // 
            // frm_rpt_purchase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 744);
            Controls.Add(lblTotal);
            Controls.Add(dgv);
            Controls.Add(btnShowReport);
            Controls.Add(EndDate);
            Controls.Add(StartDate);
            Name = "frm_rpt_purchase";
            Text = "frm_rpt_purchase";
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
    }
}