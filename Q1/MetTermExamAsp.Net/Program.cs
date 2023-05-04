// See https://aka.ms/new-console-template for more information
using Students; 
var NewStudents = new List<Student>
{
    new Student{
        Id = 1 ,
        First_Name = "moahfds",
        Family_Name = "sdflih;lg",
        Current_Section = 22,
        Sections_Count= 30   
    } ,
    new Student{
        Id = 2 ,
        First_Name = "moahfds",
        Family_Name = "sdflih;lg",
        Current_Section = 2,
        Sections_Count= 3
    }
};
Console.WriteLine("Welcome To Students Object !");
Console.WriteLine("----------------------------");

foreach (var student in NewStudents)
{
    Console.WriteLine("Starts new student");
    Console.WriteLine("----------------------------");
    Console.WriteLine("Student ID : "+ student.Id );
    Console.WriteLine("Student First Name  : " + student.First_Name);
    Console.WriteLine("Student Family Name : " + student.Family_Name);
    Console.WriteLine("Student Current Section : " + student.Current_Section);
    Console.WriteLine("Student Sections Count : " +student.Sections_Count);



}