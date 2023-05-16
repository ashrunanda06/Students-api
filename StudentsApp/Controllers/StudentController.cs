using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    [HttpPost]
    public IActionResult RetrieveStudents()
    {
        var students = new List<Student>();

        // Create the first student
        var alice = new Student
        {
            Name = "Alice",
            Age = 20,
            Hobbies = new List<string> { "reading", "swimming", "coding" }
        };
        students.Add(alice);

        // Create the second student
        var bob = new Student
        {
            Name = "Bob",
            Age = 22,
            Hobbies = new List<string> { "painting", "dancing", "singing" }
        };
        students.Add(bob);

        var responseObj = new
        {
            students = students
        };

        return Ok(responseObj);
    }
}

