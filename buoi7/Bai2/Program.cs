using System;


// Bai 2 and Bai 4
namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Trung",1994, 339);
            student.display();
            

            Teacher teacher  = new Teacher("Hoa",1989, 339, "English");
            teacher.display();
        }
    }
     class Person
    {
   
        protected string name;

        protected int bornYear;
 
     
 
 
        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int bornYear)
        {
            this.name = name;
            this.bornYear = bornYear;
        }
        public string Name{ get {return name;} set { name = value;} }
        public int BornYear { get {return bornYear;} set { bornYear = value;} }
        protected void Infor(){
            Console.WriteLine($"Name: {Name}, Birth Year: {BornYear}");
        }
  
    }
    class Teacher : Person{
        private int idTeacher;
        private string subject;
        public Teacher(string name, int birthYear, int idTeacher,string subject) : base(name, birthYear)
        { this.idTeacher = idTeacher;this.subject = subject;}
        public void display(){
            Console.WriteLine("Teacher information");
            base.Infor();
            Console.WriteLine($"Id : {ID}, Subject: {Subject}");
        }
         public int ID { get {return idTeacher;} set { idTeacher = value;} }
         public string Subject { get {return subject;} set { subject = value;} }

    }   
    class Student : Person{
        private int idStudent;
        public Student(string name, int birthYear, int idStudent) : base(name, birthYear){ this.idStudent = idStudent;}
        public void display(){
            Console.WriteLine("Sutdent information");
            base.Infor();
            Console.WriteLine($"Id : {ID}");
        }
         public int ID { get {return idStudent;} set { idStudent = value;} }

    }    
}
