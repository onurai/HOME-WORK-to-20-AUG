using System;

namespace HOME_WORK__to_20_AUG
{
    // 1. first_class_method_tostring---------------------------------------------------------------------------------------------------------

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        int total = 3;
    //        Person[] persons = new Person[total];

    //        for (int i = 0; i < total; i++)
    //        {
    //            persons[i] = new Person()
    //            {
    //                Name = Console.ReadLine()
    //            };


    //        };

    //        for (int i = 0; i < total; i++)
    //        {
    //            Console.WriteLine(persons[i].ToString());
    //        }

    //        Console.ReadLine();
    //    }
    //}
    //public class Person
    //{
    //    public string Name;

    //    public override string ToString()
    //    {
    //        return "Hello! My name is " + Name;
    //    }
    //}


    // 2. constructors_destructors--------------------------------------------------------------------------------


    //public class Constructors_And_Destructors
    //{
    //    public static void Main(string[] args)
    //    {
    //        int total = 3;
    //        Person[] persons = new Person[total];

    //        for (int i = 0; i < total; i++)
    //        {
    //            persons[i] = new Person(Console.ReadLine());
    //        }

    //        for (int i = 0; i < total; i++)
    //        {
    //            Console.WriteLine(persons[i].ToString());
    //        }
    //    }

    //    public class Person
    //    {
    //        public string Name;

    //        public Person(string name)
    //        {
    //            Name = name;
    //        }
    //        public override string ToString()
    //        {
    //            return "Hello! My name is " + Name;
    //        }

    //        ~Person()
    //        {
    //            Name = string.Empty;
    //        }
    //    }
    //}


    // 3. class_person_student_and_teacher-----------------------------------------------------------------------------------------------------


    //public class StudentAndTeacherTest
    //{
    //    public static void Main()
    //    {
    //        Person myPerson = new Person();
    //        myPerson.Greet();

    //        Student myStudent = new Student();
    //        myStudent.SetAge(21);
    //        myStudent.Greet();
    //        myStudent.ShowAge();
    //        myStudent.Study();

    //        Teacher myTeacher = new Teacher();
    //        myTeacher.SetAge(30);
    //        myTeacher.Greet();
    //        myTeacher.Explain();
    //    }
    //}

    //public class Person
    //{
    //    protected int age;

    //    public void Greet()
    //    {
    //        Console.WriteLine("Hello!");
    //    }

    //    public void SetAge(int n)
    //    {
    //        age = n;
    //    }
    //}

    //public class Student : Person
    //{
    //    public void Study()
    //    {
    //        Console.WriteLine("I'm studying");
    //    }

    //    public void ShowAge()
    //    {
    //        Console.WriteLine("My age is {0} years old", age);
    //    }
    //}

    //public class Teacher : Person
    //{
    //    public void Explain()
    //    {
    //        Console.WriteLine("I'm explaining");
    //    }
    //}


    // 4. photo_book_class------------------------------------------------------------------------------------------------------------------------------


    //public class PhotoBookTest
    //{
    //    public static void Main()
    //    {
    //        PhotoBook myAlbum1 = new PhotoBook();
    //        Console.WriteLine(myAlbum1.GetNumberPages());

    //        PhotoBook myAlbum2 = new PhotoBook(24);
    //        Console.WriteLine(myAlbum2.GetNumberPages());

    //        SuperPhotoBook myBigPhotoAlbum1 = new SuperPhotoBook();
    //        Console.WriteLine(myBigPhotoAlbum1.GetNumberPages());
    //    }
    //}

    //public class PhotoBook
    //{
    //    protected int numPages;

    //    public PhotoBook()
    //    {
    //        numPages = 16;
    //    }

    //    public PhotoBook(int numPages)
    //    {
    //        this.numPages = numPages;
    //    }

    //    public int GetNumberPages()
    //    {
    //        return numPages;
    //    }
    //}

    //public class SuperPhotoBook : PhotoBook
    //{
    //    public SuperPhotoBook()
    //    {
    //        numPages = 64;
    //    }
    //}

    // 5. inheritance_of_objects----------------------------------------------------------------------------------------------------------------------------


    //public class InheritanceObjects
    //{
    //    public static void Main(string[] args)
    //    {
    //        int total = 3;
    //        Person[] persons = new Person[total];

    //        for (int i = 0; i < total; i++)
    //        {
    //            if (i == 0)
    //            {
    //                persons[i] = new Teacher(Console.ReadLine());
    //            }
    //            else
    //            {
    //                persons[i] = new Student(Console.ReadLine());
    //            }
    //        }

    //        for (int i = 0; i < total; i++)
    //        {
    //            if (i == 0)
    //            {
    //                ((Teacher)persons[i]).Explain();

    //            }
    //            else
    //            {
    //                ((Student)persons[i]).Study();
    //            }
    //        }
    //    }

    //    public class Person
    //    {
    //        protected string Name { get; set; }

    //        public Person(string name)
    //        {
    //            Name = name;
    //        }

    //        public override string ToString()
    //        {
    //            return "Hello! My name is " + Name;
    //        }

    //        ~Person()
    //        {
    //            Name = string.Empty;
    //        }
    //    }

    //    public class Teacher : Person
    //    {
    //        public Teacher(string name) : base(name)
    //        {
    //            Name = name;
    //        }

    //        public void Explain()
    //        {
    //            Console.WriteLine("Explain");
    //        }
    //    }

    //    public class Student : Person
    //    {
    //        public Student(string name) : base(name)
    //        {
    //            Name = name;
    //        }

    //        public void Study()
    //        {
    //            Console.WriteLine("Study");
    //        }
    //    }
    //}
}
