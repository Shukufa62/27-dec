using System;
namespace _27_dec_new_lesson_practice
{
	public class Student:Human
	{
		public string GroupNo;
        public override string GetInfo()
        {
            return $"Fullname:{Name} {Surname}-Age:{Age}-groupno:{GroupNo}"; 
        }
    }
}

