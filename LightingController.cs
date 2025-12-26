using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;

public class LightingController : Controller
{
    SqlConnection con = new SqlConnection(
        ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);

    public ActionResult BookLighting()
    {
        return View();
    }

    [HttpPost]
    public ActionResult BookLighting(string LightType, string LightName)
    {
        //  VERY IMPORTANT
        if (Session["BookingNo"] == null)
        {
            return RedirectToAction("Login", "Account");
        }

        int b = (int)Session["BookingNo"];

        SqlCommand cmd = new SqlCommand(
            "insert into BookingLighting values(@b,@t,@n)", con);
        cmd.Parameters.AddWithValue("@b", b);
        cmd.Parameters.AddWithValue("@t", LightType);
        cmd.Parameters.AddWithValue("@n", LightName);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        //  MUST go to FinalSummary
        return RedirectToAction("FinalSummary", "Booking");
    }
}