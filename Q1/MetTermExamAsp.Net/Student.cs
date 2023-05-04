using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Students
{
    public class Student
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Family_Name { get; set;}
        public int Current_Section { get; set; }
        public int Sections_Count { get; set;} = 0;
    }

}
