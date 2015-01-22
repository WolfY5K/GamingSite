using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GamingSite.DAL;
using GamingSite.Models;
using GamingSite.ViewModels;

namespace GamingSite.Controllers
{
    public class ResultsController : Controller
    {

        private ResultsContext db = new ResultsContext();

        //
        // GET: /Results/
        public ActionResult Index()
        {
            var modelList = new List<Result>();
            
            foreach (var s in db.SeriesCollection)
            {
                //Grab all matches in the current series
                var matches = db.Matches.Where(m => m.SeriesID == s.SeriesID).ToList();

                modelList.Add(new Result
                {
                    TeamOneName = db.Teams.Where(tn => tn.TeamID == s.TeamOneID).FirstOrDefault().TeamName,
                    TeamTwoName = db.Teams.Where(tn => tn.TeamID == s.TeamTwoID).FirstOrDefault().TeamName,
                    League = s.League,
                    Maps = matches.Select(m => m.Map).ToList(),
                    TeamOneScores = new List<int>(),
                    TeamTwoScores = new List<int>()
                });

                var result = modelList.Last();

                PopulateTeamOneScores(result, matches, s);
                PopulateTeamTwoScores(result, matches, s);
                
            }

            return View(modelList);
        }

        /// <summary>
        /// Sum and Populate the scores for team one in this series.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="matches"></param>
        /// <param name="s"></param>
        private void PopulateTeamTwoScores(Result result, List<Match> matches, Series s)
        {
            foreach (var match in matches)
            {
                if (match.CTFirstTeamID == s.TeamTwoID)
                {
                    result.TeamTwoScores.Add(match.CTFH + match.TSH);
                }
                else
                {
                    result.TeamTwoScores.Add(match.TFH + match.CTSH);
                }
            }
        }

        /// <summary>
        /// Sum and Populate the scores for team two in this series.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="matches"></param>
        /// <param name="s"></param>
        private void PopulateTeamOneScores(Result result, List<Match> matches, Series s)
        {
            foreach (var match in matches)
            {
                if (match.CTFirstTeamID == s.TeamOneID)
                {
                    result.TeamOneScores.Add(match.CTFH + match.TSH);
                }
                else
                {
                    result.TeamOneScores.Add(match.TFH + match.CTSH);
                }
            }
        }

	}
}