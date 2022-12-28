using System;
namespace menutask
{
	public class Notebook
	{
		

            internal class Notebook : Product
        {
            public Notebook(string name, double price) : base(name, price)
            {

            }

            public Notebook(string name, double price, byte ram) : base(name, price)
            {
                this.RAM = ram;
            }
            public byte RAM = 4;

        }
    
	}
}

