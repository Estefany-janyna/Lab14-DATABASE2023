using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taipe14.DataContext;
using Taipe14.Models;


namespace Taipe14.Services
{
    internal class CompraService
    {
        private readonly AppDbContext _context;

        public CompraService() => _context = App.GetContext();

        public bool Create(Compra item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Comprar.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool CreateRange(List<Compra> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.Comprar.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Compra> Get()
        {
            return _context.Comprar.ToList();
        }


        public List<Compra> GetByText(string text)
        {
            return _context.Comprar.Where(x => x.Cliente == text).ToList();
        }

        internal object GetByText(object value)
        {
            throw new NotImplementedException();
        }
    }
}
