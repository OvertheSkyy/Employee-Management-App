using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_Management_App.Models
{
    public class Home
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Required]
        [StringLength(15)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Required]
        [StringLength(11)]
        public string ContactNo { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
