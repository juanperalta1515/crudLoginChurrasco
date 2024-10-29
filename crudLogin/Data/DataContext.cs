using crudLogin.Data.Entities;
using crudLogin.Data;

using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace crudLogin.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public Microsoft.EntityFrameworkCore.DbSet<ProductosEnty> Productos {get; set;}

    }
}
