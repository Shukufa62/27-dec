using System;
namespace _27_dec_new_lesson_practice
{
	public class Human
	{
		public string Name;
		public string Surname;
		public byte Age;

		public virtual string GetInfo()
		{
			return $"Fullname:{Name} {Surname}-Age:{Age}";
		}
	}
}

