using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ActiveDirectoryMicroservice.Models
{
 
        [Index(nameof(Email), IsUnique = true)]
        public class User
        {

        [Key]
        public Guid CId { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Name { get; set; }


    }
    
}
