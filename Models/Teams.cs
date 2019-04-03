using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Players.Models;

namespace Teams.Models
{
  public class Team
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public List<Player> Players {get; set;}

  }

}