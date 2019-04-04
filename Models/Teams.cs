using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

//In order to get the players on the team we need to reference the Players
//Maybe this is how you do it? 
//using Players.Models;

namespace TeamsApi.Models
{
  public class Team
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    //public List<Player> Players {get; set;}

  }

}