using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Players.Models
{
    public class Player
    {
      public long ID { get; set; }

      [Required]
      public string FirstName { get; set; }

      [Required]
      public string LastName { get; set; }
    }
    
}