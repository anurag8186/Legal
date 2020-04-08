using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Globalization;

/// <summary>
/// Summary description for Utility
/// </summary>
/// 

namespace DataUtility
{    
    public class Utility
    {
        string dbconnection = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        public DateTime FormateDate(Object obj)
        {
            IFormatProvider culture = new CultureInfo("fr-FR", true);
            if (obj == null || Convert.IsDBNull(obj) || obj.ToString().Trim() == string.Empty)
                return GetMinDateTime();
            else
                return DateTime.ParseExact(obj.ToString(), "dd/MM/yyyy", culture);
        }

        private DateTime GetMinDateTime()
        {
            return DateTime.Parse("01/jan/1900");
        }

        public DataTable GetDataTable(string strQuery)
        {            
            SqlConnection conn = new SqlConnection(dbconnection);
            SqlDataAdapter sda = new SqlDataAdapter(strQuery, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}