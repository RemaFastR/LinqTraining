using LinqTraining.Models;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTraining.ViewModels
{
    public class StudentsViewModel : BaseViewModel
    {
        private List<Student> AllStudents { get; set; }

        private List<Student> students;
        public List<Student> Students
        {
            get => students;
            set { students = value; OnPropertyChanged(); }
        }

        public DelegateCommand SortByAgeCommand { get; set; }
        public DelegateCommand GetStarterListCommand { get; set; }

        public StudentsViewModel()
        {
            GetStudents();
            SortByAgeCommand = new DelegateCommand(SortByAge);
            GetStarterListCommand = new DelegateCommand(GetStudents);
        }

        private void GetStudents()
        {
            Random random = new Random();
            AllStudents = new List<Student>();
            for (int i = 0; i < 30; i++)
            {
                AllStudents.Add(new Student() { Name = $"Name{random.Next(1,55)}", SurName = $"SurName{random.Next(1,255)}", Age = random.Next(18,27) });
            }
            Students = AllStudents;
        }

        private void SortByAge()
        {
            Students = AllStudents.OrderByDescending(student => student.Age).ToList();
        }
    }
}
