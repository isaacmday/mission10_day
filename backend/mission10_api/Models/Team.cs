using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mission10_api.Models;

public partial class Team
{
    [Key]
    [Required]
    public int TeamId { get; set; }

    [Required]
    public string TeamName { get; set; }

    public int? CaptainId { get; set; }

    //public virtual ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();

    //public virtual ICollection<TourneyMatch> TourneyMatchEvenLaneTeams { get; set; } = new List<TourneyMatch>();

    //public virtual ICollection<TourneyMatch> TourneyMatchOddLaneTeams { get; set; } = new List<TourneyMatch>();
}
