using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRegistration.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [CpfVerificator]
        public string Cpf { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [BindProperty, DataType(DataType.Date)]
        [Min18YearsIfACustomer]
        public DateTime Birthday { get; set; }
        
        [Column(TypeName = "nvarchar(10)")]
        public string Gender { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }

}