namespace Compu_Pos.Views
{
    partial class frm_RevenueService
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
            btn_report = new Button();
            startDate = new DateTimePicker();
            endDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TotalSales = new Label();
            TotalSalesReturns = new Label();
            TotalPurchases = new Label();
            TotalPurchaseReturns = new Label();
            NetProfit = new Label();
            SuspendLayout();
            // 
            // btn_report
            // 
            btn_report.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btn_report.Location = new Point(51, 32);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(166, 58);
            btn_report.TabIndex = 0;
            btn_report.Text = "تقرير مفصل";
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
            // 
            // startDate
            // 
            startDate.CustomFormat = "dd-MM-yyyy";
            startDate.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(691, 38);
            startDate.Name = "startDate";
            startDate.Size = new Size(208, 45);
            startDate.TabIndex = 1;
            // 
            // endDate
            // 
            endDate.CustomFormat = "dd-MM-yyyy";
            endDate.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(301, 37);
            endDate.Name = "endDate";
            endDate.Size = new Size(208, 45);
            endDate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(905, 38);
            label1.Name = "label1";
            label1.Size = new Size(119, 40);
            label1.TabIndex = 3;
            label1.Text = "من تاريخ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(515, 39);
            label2.Name = "label2";
            label2.Size = new Size(124, 40);
            label2.TabIndex = 4;
            label2.Text = "الى تاريخ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(822, 187);
            label3.Name = "label3";
            label3.Size = new Size(212, 40);
            label3.TabIndex = 5;
            label3.Text = "إجمالي المبيعات";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(709, 278);
            label4.Name = "label4";
            label4.Size = new Size(325, 40);
            label4.TabIndex = 6;
            label4.Text = "إجمالي مرتجعات المبيعات";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(791, 369);
            label5.Name = "label5";
            label5.Size = new Size(233, 40);
            label5.TabIndex = 7;
            label5.Text = "إجمالي المشتريات";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(704, 460);
            label6.Name = "label6";
            label6.Size = new Size(346, 40);
            label6.TabIndex = 8;
            label6.Text = "إجمالي مرتجعات المشتريات";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(166, 202);
            label7.Name = "label7";
            label7.Size = new Size(156, 40);
            label7.TabIndex = 9;
            label7.Text = "صافي الربح";
            // 
            // TotalSales
            // 
            TotalSales.AutoSize = true;
            TotalSales.Location = new Point(560, 202);
            TotalSales.Name = "TotalSales";
            TotalSales.Size = new Size(60, 20);
            TotalSales.TabIndex = 10;
            TotalSales.Text = ".................";
            // 
            // TotalSalesReturns
            // 
            TotalSalesReturns.AutoSize = true;
            TotalSalesReturns.Location = new Point(560, 293);
            TotalSalesReturns.Name = "TotalSalesReturns";
            TotalSalesReturns.Size = new Size(60, 20);
            TotalSalesReturns.TabIndex = 11;
            TotalSalesReturns.Text = ".................";
            // 
            // TotalPurchases
            // 
            TotalPurchases.AutoSize = true;
            TotalPurchases.Location = new Point(560, 384);
            TotalPurchases.Name = "TotalPurchases";
            TotalPurchases.Size = new Size(60, 20);
            TotalPurchases.TabIndex = 12;
            TotalPurchases.Text = ".................";
            // 
            // TotalPurchaseReturns
            // 
            TotalPurchaseReturns.AutoSize = true;
            TotalPurchaseReturns.Location = new Point(560, 475);
            TotalPurchaseReturns.Name = "TotalPurchaseReturns";
            TotalPurchaseReturns.Size = new Size(60, 20);
            TotalPurchaseReturns.TabIndex = 13;
            TotalPurchaseReturns.Text = ".................";
            // 
            // NetProfit
            // 
            NetProfit.AutoSize = true;
            NetProfit.Location = new Point(214, 293);
            NetProfit.Name = "NetProfit";
            NetProfit.Size = new Size(60, 20);
            NetProfit.TabIndex = 14;
            NetProfit.Text = ".................";
            // 
            // frm_RevenueService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 559);
            Controls.Add(NetProfit);
            Controls.Add(TotalPurchaseReturns);
            Controls.Add(TotalPurchases);
            Controls.Add(TotalSalesReturns);
            Controls.Add(TotalSales);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(btn_report);
            Name = "frm_RevenueService";
            Text = "خدمة إرجاع التقرير المفصل";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_report;
        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label TotalSales;
        private Label TotalSalesReturns;
        private Label TotalPurchases;
        private Label TotalPurchaseReturns;
        private Label NetProfit;
    }
}