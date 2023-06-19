using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1.Models.Domain
{
  public class User
  {
    public Guid Id { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "Password length required at least 6")]
    public string? Password { get; set; }
  }
}