using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;

public class FoodController : Controller
{
    SqlConnection con = new SqlConnection(
    ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);

    public ActionResult BookFood() { return View(); }

    [HttpPost]
    public ActionResult BookFood(string FoodType, string MealType, string DishType, string Items)
    {
        int b = (int)Session["BookingNo"];
        SqlCommand cmd = new SqlCommand(
        "insert into BookingFood values(@b,@f,@m,@d,@i)", con);
        cmd.Parameters.AddWithValue("@b", b);
        cmd.Parameters.AddWithValue("@f", FoodType);
        cmd.Parameters.AddWithValue("@m", MealType);
        cmd.Parameters.AddWithValue("@d", DishType);
        cmd.Parameters.AddWithValue("@i", Items);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        return RedirectToAction("BookLighting", "Lighting");
    }
}