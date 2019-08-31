using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context; // dependicia para acesso ao banco 

        public SellerService(SalesWebMVCContext context) //sempre necesario criar um contrutor recebendo todos os argumentos não lista
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList<Seller>(); //acessa tabela de vendedores e converte em lista 
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
