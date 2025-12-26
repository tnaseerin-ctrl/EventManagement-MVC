using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

public class BookingController : Controller
{
    SqlConnection con = new SqlConnection(
    ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);

    public ActionResult BookEvent() { return View(); }

    [HttpPost]
    public ActionResult BookEvent(DateTime BookingDate, string EventType, string VenueType, int NoOfGuest)
    {
        int b = (int)Session["BookingNo"];

        // Update booking date
        SqlCommand cmdDate = new SqlCommand(
         "update BookingMaster set BookingDate=@d where BookingNo=@b", con);
        cmdDate.Parameters.AddWithValue("@d", BookingDate);
        cmdDate.Parameters.AddWithValue("@b", b);
        con.Open();
        cmdDate.ExecuteNonQuery();
        con.Close();

        // Insert event details
        SqlCommand cmd = new SqlCommand(
         "insert into BookingEvent values(@b,@e,@v,@g)", con);
        cmd.Parameters.AddWithValue("@b", b);
        cmd.Parameters.AddWithValue("@e", EventType);
        cmd.Parameters.AddWithValue("@v", VenueType);
        cmd.Parameters.AddWithValue("@g", NoOfGuest);
        con.Open(); 
        cmd.ExecuteNonQuery();
        con.Close();

        return RedirectToAction("BookFood", "Food");
    }

    public ActionResult FinalSummary() { return View(); }

    public ActionResult AllBookings()
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from BookingMaster", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return View(dt);
    }

    public ActionResult Cancel(int id)
    {
        con.Open();
        new SqlCommand("delete from BookingLighting where BookingNo=" + id, con).ExecuteNonQuery();
        new SqlCommand("delete from BookingFood where BookingNo=" + id, con).ExecuteNonQuery();
        new SqlCommand("delete from BookingEvent where BookingNo=" + id, con).ExecuteNonQuery();
        new SqlCommand("delete from BookingMaster where BookingNo=" + id, con).ExecuteNonQuery();
        con.Close();
        return RedirectToAction("AllBookings");
    }
}