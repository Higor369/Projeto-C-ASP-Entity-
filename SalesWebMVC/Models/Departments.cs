﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departments()
        {

        }

        public Departments(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSaller(Seller seller)
        {
            this.Sellers.Add(seller);
        }
        public void RemoveSeller(Seller seller)
        {
            this.Sellers.Remove(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return this.Sellers.Sum(seller => seller.TotalSales(initial, final)); // pega o total da venda de cada vendedor e soma tudo
        }

    }
}
