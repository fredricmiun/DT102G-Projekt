using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lager.Models;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Lager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DataSet ds = new DataSet();
            SqlConnection dbConnection = new SqlConnection();
            dbConnection.ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-Lager-1A73B396-D556-4555-8EC1-C11202FD4C91;Trusted_Connection=True;MultipleActiveResultSets=true";
            //dbConnection.ConnectionString = "Server=tcp:lager20200314111437dbserver.database.windows.net,1433;Initial Catalog=Lager20200314111437_db;Persist Security Info=False;User ID=frfr1800;Password=Hejsan123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            String sqlString = "Select * FROM dbo.Items";
            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(dbCommand);
            try
            {
                dbConnection.Open();
                adapter.Fill(ds);
            }
            catch (Exception e)
            {
                ViewBag.i = e.Message;
            }
            finally
            {
                dbConnection.Close();
            }
            
            return View(ds);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
