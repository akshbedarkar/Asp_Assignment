using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoredProcedure1.Models
{
    public class FootBallMatch
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Remote("Prediction", "Predict", ErrorMessage = "Please Enter only Integer Values")]
        public int MatchId { get; set; }


        [Required]
        public string TeamName1 { get; set; }


        [Required]
        public string TeamName2 { get; set; }


        [Required]
        public string Status { get; set; }




        public string WinningTeam { get; set; }



        [Required]
        public int points { get; set; }
    }
}