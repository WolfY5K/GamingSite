using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamingSite.Models
{
    public class Series
    {
        public int SeriesID { get; set; }
        public League League { get; set; }
        public int TeamOneID { get; set; }
        public int TeamTwoID { get; set; }
        public int MatchOneID { get; set; }
        public int? MatchTwoID { get; set; }
        public int? MatchThreeID { get; set; }
        public int? MatchFourID { get; set; }
        public int? MatchFiveID { get; set; }
    }
}