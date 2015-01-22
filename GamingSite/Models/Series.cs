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

        public virtual List<Match> Matches { get; set; }
    }
}