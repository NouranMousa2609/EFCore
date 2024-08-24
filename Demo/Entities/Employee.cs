using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    //EF support 4 ways for mapping
    //1.by Convension
    //2.Data Annotation
    //3.fluent APIs ->DBContext:Override OnModelCreating()


    ///Poco Class
    ///Plain Old C# (CLR) object

    //1.by Convension
    //internal class Employee
    //{
    //    public int Id { get; set; }         // Public numeric property named "Id" || "EmployeeId" -->PK[Identity]

    //    public string? Name { get; set; }    //string->nvarchar[max] //Reference type :Allow null[optional]

    //    public double Salary { get; set; }  //value type     : not allow null[required]

    //    public int? Age { get; set; }       // nullable<int> :Allow null [optional]
    //}

    //2.Data Annotation

    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//(1,1)
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]

        public string? Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public double Salary { get; set; }

        [Range(22, 60)]
        public int? Age { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }

    }


}
