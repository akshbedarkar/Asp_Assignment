using StoredProcedure1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoredProcedure1.Controllers
{
    public class HomeController : Controller
    {
        DataContext obj=new DataContext();
        public ActionResult Index()
        {
            var data=obj.footBallMatches.ToList();
            
            return View(data);
        }

        public ActionResult Create()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult Create(FootBallMatch f)
        {
            
            SqlParameter para1 = new SqlParameter("@TeamName1", f.TeamName1);
            SqlParameter para2 = new SqlParameter("@TeamName2", f.TeamName2);
            SqlParameter para3 = new SqlParameter("@Status", f.Status);
            SqlParameter para4 = new SqlParameter("@WinningTeam", f.WinningTeam);
            SqlParameter para5 = new SqlParameter("@points", f.points);



            obj.Database.SqlQuery<StoredProcedure1.Models.FootBallMatch>("exec EnterDetails1 @TeamName1 , @TeamName2, @Status, @WinningTeam,@points ", para1, para2, para3, para4, para5).SingleOrDefault();

            return RedirectToAction("Index");
        }



    }
}