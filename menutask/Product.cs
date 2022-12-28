﻿using System;
namespace menutask
{
	public class Product
	{
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name;
        public double Price;

        public string GetInfo()
        {
            return $"Name: {Name} - Price: {Price}";
        }
    }
}

