using crudLogin.Data.Entities;
using crudLogin.IServices;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace crudLogin.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class AProductos : ControllerBase
    {
       IProductos _productos;
        public AProductos(IProductos productos) 
        {
        _productos = productos;
        } 

        //Get Productos
        [HttpGet ("Obtener todos los productos")]
        public async Task<List<ProductosEnty>> GetAll()
        {
            return await _productos.GetAll();
        }


        // POST api/<AProductos>
        [HttpPost("Guardar producto")]
        public void Post([FromForm] ProductosEnty oProducto)
        {
            if (oProducto.id == null)
            {
                _productos.Save(oProducto);
            }
            else { 
            _productos.Update(oProducto);
            }
        }
     

        // DELETE api/<AProductos>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return await _productos.Delete(id);
        }
    }
}
