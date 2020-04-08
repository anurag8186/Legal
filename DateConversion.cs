using System;
using System.Data;
using System.Configuration;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for DateConversion
/// </summary>
public class DateConversion
{
    public string getDateString(string date)
    {
        if (!string.IsNullOrEmpty(date))
        {
            string date1 = "";
            //DateTime Date = DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime Date = DateTime.Parse(date, System.Globalization.CultureInfo.InvariantCulture);
            date1 = Date.ToString("dd/MM/yyyy");


            string a = date1.Substring(0, 10);
            if (a == "01-01-2000")
            {
                a = "";
                return a;
            }
            else
            {
                return a;
            }

        }
        return "";
    }

    public string ChkDate(string date)
    {
        string date1 = "";
        DateTime Date;
        if (string.IsNullOrEmpty(date))
        {
            date1 = "01/01/1900";
        }
        else
        {
            string[] a = new string[6];
            a = date.Split('-');
            int l = a.Length;
            if (l > 1)
            {
                Date = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                date1 = Date.ToString("MM/dd/yyyy");
            }
            else
            {
                Date = DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                date1 = Date.ToString("MM/dd/yyyy");
            }
        }


        return date1;
    }
}
