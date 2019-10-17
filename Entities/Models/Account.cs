using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("account")]
    public class Account
    {
        [Key]
        public Guid AccountId { get; set; }
 
        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }
 
        [Required(ErrorMessage = "Account type is required")]
        [StringLength(60, ErrorMessage = "Account type can't be longer than 60 characters")]
        public string AccountType { get; set; }
 
        [Required(ErrorMessage = "Owner Id is required")]
        public Guid OwnerId { get; set; }
    }
}