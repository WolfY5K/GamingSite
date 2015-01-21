using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamingSite.Models
{
    public class Match
    {
        public int MatchID { get; set; }
        public int SeriesCollectionID { get; set; }
        public Map Map { get; set; }
        public int CTFirstTeamID { get; set; }
        public int CTFH { get; set; }
        public int TFH { get; set; }
        public int CTSH { get; set; }
        public int TSH { get; set; }

        public virtual ICollection<Series> SeriesCollection { get; set; }
    }
}