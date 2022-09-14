using ODataDemo.Models;

namespace ODataDemo.Services
{

    public class StudentService : IStudentService
    {
        public IQueryable<Student> RetrieveAllStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Aman",
                    Score = 200
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Nikita",
                    Score = 160
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Nancy",
                    Score = 170
                }
            }.AsQueryable(); ;
        }
    }
}
