using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;

public class AccountController : Controller
{
    SqlConnection con = new SqlConnection(
    ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);

    public ActionResult Login() { return View(); }

    [HttpPost]
    public ActionResult Login(string Username, string Password)
    {
        SqlCommand cmd = new SqlCommand(
        "select * from Users where Username=@u and Password=@p", con);
        cmd.Parameters.AddWithValue("@u", Username);
        cmd.Parameters.AddWithValue("@p", Password);
        con.Open();
        var dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Session["user"] = Username;
            con.Close();

            SqlCommand c2 = new SqlCommand(
            "insert into BookingMaster(Username) output inserted.BookingNo values(@u)", con);
            c2.Parameters.AddWithValue("@u", Username);
            con.Open();
            Session["BookingNo"] = (int)c2.ExecuteScalar();
            con.Close();

            return RedirectToAction("BookEvent", "Booking");
        }
        con.Close();
        return View();
    }
}