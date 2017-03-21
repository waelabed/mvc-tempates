using mvc_app5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_app5.Controllers
{
    public class TeamsController : Controller
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        // GET: Teams
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TeamVm team)
        {
            ModelState.Remove("Img");
            if (ModelState.IsValid)
            {
                team.img = team.imgAttach.FileName;
                _context.Teams.Add(Parse(team));
                _context.SaveChanges();
                // upload image

                team.imgAttach.SaveAs(Server.MapPath("~/images/teams/"+team.img));
                return View();
            }
            return View();
        }
        private Team Parse(TeamVm item)
        {
            Team details = new Models.Team
            {
                FacebookUrl=item.FacebookUrl,
                GooglePlusUrl=item.GooglePlusUrl,
                img=item.img,
                Name=item.Name,
                TwitterUrl=item.TwitterUrl,
                TeamId=item.TeamId
            };
            return details;
        }
        public ActionResult GetTeams()
        {
            var teams = _context.Teams.ToList().OrderByDescending(t=>t.TeamId);
            return PartialView("GetTeams",teams.Take(4)) ;
        }
    }
}