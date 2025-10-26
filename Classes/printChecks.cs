//using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Compu_Pos.Classes
{
    public class printChecks
    {
        //    private SqlDataAdapter adapter;
        //    private SqlCommand cmd;
        //    private SqlDataReader dr;

        //    public void runPrintCheck(int checkId)
        //    {
        //        cmd = new SqlCommand("SELECT * FROM vwChecks where id = '" + checkId + "'", adoClass.sqlCn);
        //        dr = null;
        //        dsChecks checks = new dsChecks();
        //        try
        //        {
        //            if (adoClass.sqlCn.State != ConnectionState.Open) adoClass.sqlCn.Open();
        //            dr = cmd.ExecuteReader();
        //            while (dr.Read())
        //            {
        //                DataRow dro = checks.Tables["dtCheck"].NewRow();
        //                dro["Id"] = dr["id"];
        //                dro["CheckDate"] = dr["checkDate"];
        //                dro["CheckToal"] = dr["totalCheck"];
        //                dro["ItemId"] = dr["ItemId"];
        //                dro["ItemName"] = dr["DES"];
        //                dro["ItemQTY"] = dr["QTY"];
        //                dro["ItemPrice"] = dr["price"];
        //                dro["ItemTotalPrice"] = dr["totalPrice"];
        //                checks.Tables["dtCheck"].Rows.Add(dro);
        //            }
        //        }
        //        catch (Exception ex)
        //        { MessageBox.Show(ex.Message); }
        //        finally { adoClass.sqlCn.Close(); }
        //        FormReports rptForm = new FormReports();
        //        rptForm.mainReport.LocalReport.ReportEmbeddedResource = "SmartPOS.Reports.rptCheck.rdlc";
        //        rptForm.mainReport.LocalReport.DataSources.Clear();
        //        rptForm.mainReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", checks.Tables["dtCheck"]));
        //        ReportParameter[] reportParameters = new ReportParameter[4];
        //        reportParameters[0] = new ReportParameter("Line1", declarations.systemOptions["receiptLine1"].ToString());
        //        reportParameters[1] = new ReportParameter("Line2", declarations.systemOptions["receiptLine2"].ToString());
        //        reportParameters[2] = new ReportParameter("RestaurntName", declarations.systemOptions["RestName"].ToString());
        //        byte[] imageBytes = (byte[])declarations.systemOptions["logo"];
        //        reportParameters[3] = new ReportParameter("img", Convert.ToBase64String(imageBytes));
        //        if (bool.Parse(declarations.systemOptions["PrintToPrinter"].ToString()))
        //        {
        //            LocalReport report = new LocalReport();
        //            string path = Application.StartupPath + @"\Reports\rptCheck.rdlc";
        //            report.ReportPath = path;
        //            report.DataSources.Clear();
        //            report.DataSources.Add(new ReportDataSource("DataSet1", checks.Tables["dtCheck"]));
        //            report.SetParameters(reportParameters);
        //            PrintersClass.PrintToPrinter(report);
        //        }
        //        else
        //        {
        //            rptForm.mainReport.LocalReport.SetParameters(reportParameters);
        //            rptForm.ShowDialog();
        //        }
        //    }

        //    public void runSaleReports(DateTime _from, DateTime _to)
        //    {
        //        string viewTxt = "Select * From vwSaleChecks Where checkDate between '" + _from.ToString("yyyy-MM-dd") + "' AND  '" + _to.ToString("yyyy-MM-dd") + "' ";
        //        adapter = new SqlDataAdapter(viewTxt, adoClass.sqlCn);
        //        daReports reports = new daReports();
        //        try
        //        {
        //            adapter.Fill(reports.Tables["vwSaleChecks"]);
        //        }
        //        catch (Exception ex)
        //        { MessageBox.Show(ex.Message); }
        //        FormReports rptForm = new FormReports();
        //        rptForm.mainReport.LocalReport.ReportEmbeddedResource = "SmartPOS.Reports.saleReport.rdlc";
        //        rptForm.mainReport.LocalReport.DataSources.Clear();
        //        rptForm.mainReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", reports.Tables["vwSaleChecks"]));
        //        ReportParameter[] reportParameters = new ReportParameter[4];
        //        reportParameters[0] = new ReportParameter("From", _from.ToString("yyyy-MM-dd"));
        //        reportParameters[1] = new ReportParameter("To", _to.ToString("yyyy-MM-dd"));
        //        reportParameters[2] = new ReportParameter("RestName", declarations.systemOptions["RestName"].ToString());
        //        byte[] imageBytes = (byte[])declarations.systemOptions["logo"];
        //        reportParameters[3] = new ReportParameter("img", Convert.ToBase64String(imageBytes));
        //        rptForm.mainReport.LocalReport.SetParameters(reportParameters);
        //        rptForm.ShowDialog();
        //    }


        //    public void runSaleDetailsReport(DateTime _from, DateTime _to)
        //    {
        //        string viewTxt = "Select * From vwSaleDetails Where checkDate between '" + _from.ToString("yyyy-MM-dd") + "' AND  '" + _to.ToString("yyyy-MM-dd") + "' ";
        //        adapter = new SqlDataAdapter(viewTxt, adoClass.sqlCn);
        //        daReports reports = new daReports();
        //        try
        //        {
        //            adapter.Fill(reports.Tables["vwSaleDetails"]);
        //        }
        //        catch (Exception ex)
        //        { MessageBox.Show(ex.Message); }
        //        FormReports rptForm = new FormReports();
        //        rptForm.mainReport.LocalReport.ReportEmbeddedResource = "SmartPOS.Reports.saleDetailsReport.rdlc";
        //        rptForm.mainReport.LocalReport.DataSources.Clear();
        //        rptForm.mainReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", reports.Tables["vwSaleDetails"]));
        //        ReportParameter[] reportParameters = new ReportParameter[4];
        //        reportParameters[0] = new ReportParameter("From", _from.ToString("yyyy-MM-dd"));
        //        reportParameters[1] = new ReportParameter("To", _to.ToString("yyyy-MM-dd"));
        //        reportParameters[2] = new ReportParameter("RestName", declarations.systemOptions["RestName"].ToString());
        //        byte[] imageBytes = (byte[])declarations.systemOptions["logo"];
        //        reportParameters[3] = new ReportParameter("img", Convert.ToBase64String(imageBytes));
        //        rptForm.mainReport.LocalReport.SetParameters(reportParameters);
        //        rptForm.ShowDialog();

        //    }


        //    public void runSaleByItemReport(DateTime _from, DateTime _to, string CatId)
        //    {
        //        string viewTxt = "Select * From vwSaleByItem Where checkDate between '" + _from.ToString("yyyy-MM-dd") + "' AND  '" + _to.ToString("yyyy-MM-dd") + "' ";
        //        viewTxt += " AND id = '" + CatId + "' ";
        //        adapter = new SqlDataAdapter(viewTxt, adoClass.sqlCn);
        //        daReports reports = new daReports();
        //        try
        //        {
        //            adapter.Fill(reports.Tables["vwSaleByItem"]);
        //        }
        //        catch (Exception ex)
        //        { MessageBox.Show(ex.Message); }
        //        FormReports rptForm = new FormReports();
        //        rptForm.mainReport.LocalReport.ReportEmbeddedResource = "SmartPOS.Reports.saleByItemReport.rdlc";
        //        rptForm.mainReport.LocalReport.DataSources.Clear();
        //        rptForm.mainReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", reports.Tables["vwSaleByItem"]));
        //        ReportParameter[] reportParameters = new ReportParameter[4];
        //        reportParameters[0] = new ReportParameter("From", _from.ToString("yyyy-MM-dd"));
        //        reportParameters[1] = new ReportParameter("To", _to.ToString("yyyy-MM-dd"));
        //        reportParameters[2] = new ReportParameter("RestName", declarations.systemOptions["RestName"].ToString());
        //        byte[] imageBytes = (byte[])declarations.systemOptions["logo"];
        //        reportParameters[3] = new ReportParameter("img", Convert.ToBase64String(imageBytes));
        //        rptForm.mainReport.LocalReport.SetParameters(reportParameters);
        //        rptForm.ShowDialog();

        //    }
        //}
        //internal class printChecks
        //{
    }
}
