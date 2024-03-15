using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mission10_api.Models;

public partial class Team
{
    [Key]
    [Required]
    public int TeamID { get; set; }

    [Required]
    public string TeamName { get; set; }

    public int? CaptainID { get; set; }
}
