using System;
using System.Collections.Generic;

namespace GamingSite.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }

        public virtual ICollection<Series> SeriesCollection { get; set; }
    }
}