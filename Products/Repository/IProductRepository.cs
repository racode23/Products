using Microsoft.AspNetCore.Mvc;

namespace Products.Repository
{
    public interface IProductRepository<T>
    {
        List<T> getAll();
        T getById(int id);

        List<T> insert(T entity);

        // List<T> Delete(int id);

        // List<T> Update(T Entity);
    }
}
