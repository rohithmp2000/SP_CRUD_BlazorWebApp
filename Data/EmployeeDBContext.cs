using Microsoft.EntityFrameworkCore;

namespace SP_CRUD.Data
{
    public class EmployeeDBContext :DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options):base(options) 
        { 
                   
        }

        public DbSet<EmpModel> Employees { get; set; }
    }
} 
