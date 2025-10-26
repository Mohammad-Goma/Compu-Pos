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

    public class ClassLoading
    {
        //private SqlCommand cmd;
        //private SqlDataReader dr;

        public void loadSystemOptions()
        {
            //cmd = new SqlCommand("SELECT TOP 1 * FROM Options", adoClass.sqlCn);
            //dr = null;
            //try
            //{
            //    if (adoClass.sqlCn.State != ConnectionState.Open) adoClass.sqlCn.Open();
            //    dr = cmd.ExecuteReader();
            //    Declarations.systemOptions = new Dictionary<string, object>();
            //    while (dr.Read())
            //    {
            //        for (int i = 0; i < dr.FieldCount; i++)
            //        {
            //            Declarations.systemOptions.Add(dr.GetName(i), dr[dr.GetName(i)]);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{ MessageBox.Show(ex.Message); }
            //finally { adoClass.sqlCn.Close(); }
        }
    }
}
