using Microsoft.AspNetCore.Mvc;
using Products.Data;
using Products.Models;

namespace Products.Repository
{
    public class ProductRepository : IProductRepository<Product>
    {
        private AppDbContext _AppDbContet;
        public ProductRepository(AppDbContext AppDbContext)
        {
            _AppDbContet=AppDbContext;
        }
        //public List<Product> Delete(int id)
       // {

            


       // }

        public List<Product> getAll()
        {
            return  _AppDbContet.Products.ToList();
        }

        public Product getById(int id)
        {
            return _AppDbContet.Products.FirstOrDefault(e => e.id == id);
        }

        public List<Product> insert(Product entity)
        {
            _AppDbContet.Products.Add(entity);
            _AppDbContet.SaveChanges();
            return _AppDbContet.Products.ToList();
        }

        //public List<Product> Update(Product Entity)
       // {
        //    return;
        //}
    }

    
}
