using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RepositoryPattern.Models
{
      [Table("account")]
        public class Account
        {
            [Key]
            public Guid AccountId { get; set; }

            [Required(ErrorMessage = "Date created is required")]
            public DateTime DateCreated { get; set; }

            [Required(ErrorMessage = "Account type is required")]
            public string AccountType { get; set; }

            [Required(ErrorMessage = "Customer Id is required")]
            public Guid CustomerId { get; set; }
        }
    }
}
