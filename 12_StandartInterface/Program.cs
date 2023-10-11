using System.Collections;

namespace _12_StandartInterface
{
    class StudentCard : ICloneable
    {
        public int Number { get; set; }//111111 - 111111
        public string Series { get; set; }//

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Student Card : {Number} - {Series}";
        }
    }
    class Student : IComparable<Student>, ICloneable
    {
        public string FirstName { get; set; }//Tom - 00x25563  -  00x25563
        public string LastName { get; set; }//Dicson - 00x1475 - 00x1475
        public DateTime Birthdate { get; set; }//2000-5-7 - 2000-5-7
        public StudentCard StudentCard { get; set; }//00x852369 - 00x852369

        public object Clone()
        {
            Student clone = (Student) this.MemberwiseClone();
            clone.StudentCard = (StudentCard)this.StudentCard.Clone();
            //clone.StudentCard = new StudentCard
            //{
            //    Number = this.StudentCard.Number,
            //    Series = this.StudentCard.Series
            //};

            return clone;
        }

        public int CompareTo(Student? other)
        {
            return this.LastName.CompareTo(other.LastName);
        }

        //public int CompareTo(object? obj)
        //{
        //    if(obj is Student)
        //    {
        //          return LastName.CompareTo( (obj as Student).LastName);
        //    }
        //    throw new NotImplementedException();
        //}

        public override string ToString()
        {
            return $"FirstName : {FirstName}. LastName {LastName}. " +
                $"Birth : {Birthdate.ToShortDateString()}\nStudent Card {StudentCard}\n";
        }
    }

    class Auditory : IEnumerable
    {
        Student[] students =
        {
            new Student
            {
                 FirstName = "Bill",
                 LastName = "Tomson",
                 Birthdate = new DateTime(2005, 4,7),
                 StudentCard = new StudentCard(){ Number = 123456, Series = "AA"}
            },
            new Student
            {
                 FirstName = "Olga",
                 LastName = "Ivanchuk",
                 Birthdate = new DateTime(2003,10,17),
                 StudentCard = new StudentCard(){ Number = 321456, Series = "BA"}
            },
            new Student
            {
                 FirstName = "Candice",
                 LastName = "Leman",
                 Birthdate = new DateTime(2006, 3,12),
                 StudentCard = new StudentCard(){ Number = 7412585, Series = "AA"}
            },
            new Student
            {
                 FirstName = "Nicol",
                 LastName = "Taylor",
                 Birthdate = new DateTime(2004, 7,14),
                 StudentCard = new StudentCard(){ Number = 963258, Series = "BK"}
            }
        };

        public IEnumerator GetEnumerator()
        {
           return students.GetEnumerator();
        }
        public void Sort()
        {
            Array.Sort(students);
        }
        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students, comparer);
        }
    }
    class FirstNameComparer : IComparer<Student>
    {
        //public int Compare(object? x, object? y)
        //{
        //    if(x is Student && y is Student)
        //    {
        //        return (x as Student).FirstName.CompareTo((y as Student).FirstName);
        //    }
        //    throw new NotImplementedException();
        //}
        public int Compare(Student? x, Student? y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }
    class BirthdayComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.Birthdate.CompareTo(y.Birthdate);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                FirstName = "Bill",
                LastName = "Tomson",
                Birthdate = new DateTime(2005, 4, 7),
                StudentCard = new StudentCard() { Number = 123456, Series = "AA" }
            };
            Console.WriteLine(student);
            Console.WriteLine("---------------------------------------------------");
            Student copy = (Student) student.Clone();
            Console.WriteLine(copy);

            Console.WriteLine("---------------------------------------------------");
            copy.StudentCard.Number = 111111;
            copy.FirstName = "Ivan";
            Console.WriteLine("------------After change -----------");
            Console.WriteLine(student);
            Console.WriteLine(copy);

            //ICloneable
            Auditory auditory = new Auditory();
            Console.WriteLine("List of students : ");
            foreach (Student st in auditory)
            {
                Console.WriteLine(st);
            }

            auditory.Sort();
            foreach (Student st in auditory)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("---------------------------------------------");
            auditory.Sort(new FirstNameComparer());
            foreach (Student st in auditory)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("------------------------------------------------");
            auditory.Sort(new BirthdayComparer());
            foreach (Student st in auditory)
            {
                Console.WriteLine(st);
            }
         
        }
    }
}