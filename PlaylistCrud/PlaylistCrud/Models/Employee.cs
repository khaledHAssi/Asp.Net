using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlaylistCrud.Models
{
    [Table("Employees",Schema ="HR")]
    public class Employee
    {

        [Key]
        [Display(Name = "id")]
        public int EmployeeId { get; set; }
 // the entityFramworkCore know thats the id culomns are autoincrement after the first use of 
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        [Display(Name = "Name")]
        [Column(TypeName ="varchar(250)")]
        public string EmployeeName { get; set; } = string.Empty;
        //the variables by default required so we put empty to make it null
        [Display(Name ="Image")]
        [Column(TypeName ="varchar(250)")]
            
        public string? ImgUser { get;set; }  // ؟ to make it nullable

        //the double by default required
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)] 
        public DateTime BirthDate { get; set; }

        [Display(Name ="Salary")]
        [Column(TypeName= "decimal(12,2)")]
        public decimal Salary { get; set; }

        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MMMMM-yyyy}")] //to make it like Date
        public DateTime HiringDate { get; set; }
        [Required]
        [Display(Name ="National ID")]
        [MaxLength(14)]
        [MinLength(14)]
        [Column(TypeName ="varchar(14)")]
        public String NationalId { get; set; }
    
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]

        public Department Department { get; set; }


    }
}
