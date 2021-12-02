using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_demo_1.Models;

namespace Wpf_demo_1.DB
{
    public class localDB
    {
        public localDB()
        {
            Init();
        }
        private List<Student> Students;
        private void Init()
        {
            Students = new List<Student>();
            for (int i = 0; i < 30; i++)
            {
                Students.Add(
                    new Student
                    {
                        Id = i,
                        Name = $"Sample{i}"
                    }
                );
            }
        }
        public List<Student> GetStudents()
        {
            return Students;
        }

        public void AddStudent(Student stu)
        {
            Students.Add(stu);
        }

        public void DelStudent(int id)
        {
            var model = Students.FirstOrDefault(t => t.Id.Equals(id));
            if (model != null)
            {
                Students.Remove(model);
            }
        }

        public List<Student> GetStudentsByName(string name)
        {
            return Students.Where(t => t.Name.Contains(name)).ToList();
        }

        public Student GetStudentById(int id) {
            var model = Students.FirstOrDefault(t=>t.Id.Equals(id));
            if (model != null) {
                return new Student
                {
                    Id = model.Id,

                    Name = model.Name

                };
            }
            return null;
        }
    }


}
