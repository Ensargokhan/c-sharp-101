using System;

<<<<<<< HEAD
namespace csharp_enum
=======
namespace encapsulation
>>>>>>> c36f4a0b00d4e2b4111f45b8642cff77b5e6e5ed
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine(Gunler.pazar);
            Console.WriteLine((int)Gunler.cumartesi);
        }
    }
    enum Gunler
    {
        pazartesi,
        sali,
        carsamba,
        persembe,
        cuma,
        cumartesi,
        pazar
    }
}
=======
            Student student = new Student();
            student.Name = "ensar";
            student.Surname = "gökhan";
            student.StudentNo = 203311019;
            student.Grade = 5;
            student.GetStudentInfo();

            student.IncreaseGrade();
            student.GetStudentInfo();

            Student student1 = new Student("ensar", "gökhan", 115, 1);
            student1.DecreaseGrade();
            student1.GetStudentInfo();

        }
    }
    class Student
    {
        private string name;
        private string surname;
        private int studentNo;
        private int grade;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int StudentNo { get => studentNo; set => studentNo = value; }
        public int Grade
        {
            get => grade;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("sınıf en az 1 olabilir");
                }
                else
                    grade = value;
            }
        }

        public Student(string name, string surname, int studentNo, int grade)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
            Grade = grade;
        }
        public Student() { }

        public void GetStudentInfo()
        {
            Console.WriteLine("Öğrenci Adı: {0}", this.Name);
            Console.WriteLine("Öğrenci Soyadı: {0}", this.Surname);
            Console.WriteLine("Öğrenci Numarası: {0}", this.StudentNo);
            Console.WriteLine("Öğrenci Sınıfı: {0}", this.Grade);
        }
        public void IncreaseGrade()
        {
            this.Grade = this.Grade + 1;
        }
        public void DecreaseGrade()
        {
            this.Grade = this.Grade - 1;
        }
    }
}
>>>>>>> c36f4a0b00d4e2b4111f45b8642cff77b5e6e5ed
