using Domain.Models;
using Infrastructure.Services;

var service = new StudentService();

// var student=new Student()
// {
//     Address = "Dushanbe",
//     Age = 19,
//     FirstName = "Qurbonali",
//     LastName = "Nazarov",
//     PhoneNumber = "+992007992757"
// };
//
// var addStudent = service.AddStudent(student);
// Console.WriteLine(addStudent);

var getStudents = service.GetStudents();
foreach (var student in getStudents)
{
    Console.WriteLine($"Id: {student.Id} | " +
                      $"FirstName: {student.FirstName} | " +
                      $"LastName: {student.LastName} | " +
                      $"PhoneNumber: {student.PhoneNumber} |" +
                      $" Age: {student.Age} | " +
                      $"Address: {student.Address}");
}