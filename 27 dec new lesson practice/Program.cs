using System;

namespace _27_dec_new_lesson_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.Name = "Hikmet";
            human1.Surname = "Abbasov";
            human1.Age = 45;
            Console.WriteLine(human1.GetInfo());

            Student student1 = new Student();
            student1.Name = "Kazim";
            student1.Surname = "Abbasov";
            student1.Age = 24;
            student1.GroupNo = "P232";
            Console.WriteLine(student1.GetInfo());

            
        }
    }
}

