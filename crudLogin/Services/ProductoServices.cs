using crudLogin.Data;
using crudLogin.Data.Entities;
using crudLogin.IServices;


using Microsoft.EntityFrameworkCore;

using System.Reflection.Metadata.Ecma335;

namespace crudLogin.Services
{
    public class ProductoServices : IProductos
    {
        
        private readonly DataContext _context;
        public ProductoServices(DataContext Context)
        {
            _context = Context;
        }

        public async Task<string> Delete(int id)
        {
            var producto = await _context.Productos.FirstOrDefaultAsync(x => x.id == id);
            if (producto != null) { 
            _context.Productos.Remove(producto);
               _context.SaveChanges();  
            }
            return "Delete";
        }

        public async Task<List<ProductosEnty>> GetAll()
        {
            return await _context.Productos.ToListAsync();
        }

        public void Save(ProductosEnty oProducto)
        {
            _context.Productos.Add(oProducto);
            _context.SaveChanges();
        }

        public void Update(ProductosEnty oProducto)
        {
            _context.Productos.Update(oProducto);
            _context.SaveChanges();
        }
    }
}
