using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlaylistCrud.Models
{
    [Table("Departments",Schema ="HR")]
    public class Department
    {
        [Key] //to generate autoincrement id
        [Display (Name="id")]//his name is id
        public byte DepartmentId{ get; set; }
        [Required,MaxLength(100)]//validate the name value 
        //its recommended thing to use maxlength to your strings
        [Display(Name = "Department Name")]//his name is Department Name
        [Column(TypeName="Varchar(200)")]//it type
        public string DepartmentName { get; set; } = string.Empty;//nullable
    }
}
