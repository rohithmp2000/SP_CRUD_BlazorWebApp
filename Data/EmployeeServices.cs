using Microsoft.EntityFrameworkCore;

namespace SP_CRUD.Data 
{
    public class EmployeeServices
    {
        protected readonly EmployeeDBContext dbContext;

        public EmployeeServices(EmployeeDBContext db)
        {
            dbContext = db;
        }

        //-------------------------------
        //CRUD Operations

        //Create an employee
        public string CreateEmp(EmpModel empobj) 
        {
            dbContext.Database.ExecuteSqlRaw("exec addemp {0},{1},{2};", empobj.emp_name, empobj.emp_designation, empobj.emp_salary);
            return "Saved Successfully";
        }

        //Read all employees
        public EmpModel[] ReadAllEmp()
        {
            var emplist = dbContext.Employees.FromSqlRaw<EmpModel>("exec allemp;").ToArray();
            return emplist;
        }

        //Read employee by id
        public EmpModel Readbyid(int id) 
        {
            var employee = dbContext.Employees.FromSqlRaw<EmpModel>("exec empbyid {0};",id).ToList().SingleOrDefault();
            return employee;
        }

        //Update employee
        public string UpdateEmp(EmpModel empobj) 
        {
            dbContext.Database.ExecuteSqlRaw("exec updateemp {0},{1},{2},{3};",empobj.emp_id, empobj.emp_name, empobj.emp_designation, empobj.emp_salary);
            return "Updated Successfully";
        }

        //Delete employee
        public string DeleteEmp(EmpModel empobj) 
        {
            dbContext.Database.ExecuteSqlRaw("exec deleteemp {0};", empobj.emp_id);
            return "Delete Successfully";
        }
    }
}
