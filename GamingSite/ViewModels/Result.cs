using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GamingSite.Models;

namespace GamingSite.ViewModels
{
    public class Result
    {
            public string TeamOneName { get; set; }
            public string TeamTwoName { get; set; }
            public League League { get; set; }
            public List<int> TeamOneScores { get; set; }
            public List<int> TeamTwoScores { get; set; }
            public List<Map> Maps { get; set; }
    }
}