using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GamingSite.Models;

namespace GamingSite.DAL
{
    public class ResultsInitializer : System.Data.Entity.DropCreateDatabaseAlways<ResultsContext>
    {
        protected override void Seed(ResultsContext context)
        {
            var teams = new List<Team>
            {
                new Team { TeamID = 1, TeamName = "LDLC" },
                new Team { TeamID = 2, TeamName = "Fnatic" },
                new Team { TeamID = 3, TeamName = "Virtus Pro" },
                new Team { TeamID = 4, TeamName = "NIP" }
            };

            teams.ForEach(t => context.Teams.Add(t));
            context.SaveChanges();

            var matches = new List<Match>
            {
                new Match { MatchID = 1, SeriesID = 1, Map = Map.Cache, CTFirstTeamID = 1, CTFH = 9, TFH = 6, CTSH = 10, TSH = 3 },
                new Match { MatchID = 2, SeriesID = 1, Map = Map.Dust2, CTFirstTeamID = 2, CTFH = 7, TFH = 8, CTSH = 8, TSH = 3 },
                new Match { MatchID = 3, SeriesID = 1, Map = Map.Mirage, CTFirstTeamID = 1, CTFH = 4, TFH = 11, CTSH = 5, TSH = 6 },
                new Match { MatchID = 4, SeriesID = 2, Map = Map.Inferno, CTFirstTeamID = 3, CTFH = 6, TFH = 9, CTSH = 7, TSH = 2 },
                new Match { MatchID = 5, SeriesID = 2, Map = Map.Season, CTFirstTeamID = 4, CTFH = 13, TFH = 2, CTSH = 10, TSH = 3 },
                new Match { MatchID = 6, SeriesID = 2, Map = Map.Nuke, CTFirstTeamID = 3, CTFH = 14, TFH = 1, CTSH = 10, TSH = 2 }
            };

            var seriesCollection = new List<Series>
            {
                new Series { SeriesID = 1, League = League.ESEA, TeamOneID = 1, TeamTwoID = 2, Matches = matches.Where(m => m.SeriesID == 1).ToList() },
                new Series { SeriesID = 2, League = League.ESL, TeamOneID = 3, TeamTwoID = 4, Matches = matches.Where(m => m.SeriesID == 2).ToList() }
            };

            seriesCollection.ForEach(s => context.SeriesCollection.Add(s));
            context.SaveChanges();
        }
    }
}