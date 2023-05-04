using TeacherApi;
var builder = WebApplication.CreateBuilder(args);
var teachers = new List<Teacher>
{
    new Teacher {
        Id  = 1 ,
        FirstName = "mohd" ,
        LastName ="mod" ,
        Level = 5
    } ,
    new Teacher {
        Id = 2 ,
        FirstName = "moahfds",
        LastName = "sdflih;lg",
        Level = 22
    }
};
var app = builder.Build();

app.MapGet("/api/teacher", () => teachers);
// app.MapGet("",() => "Hello World ");
app.Run();