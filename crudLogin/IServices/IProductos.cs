using crudLogin.Data.Entities;

namespace crudLogin.IServices
{
    public interface IProductos
    {
        Task<List<ProductosEnty>> GetAll();
        void Save(ProductosEnty oProducto);
        void Update(ProductosEnty oProducto);
        Task<string> Delete(int id);
    }
}