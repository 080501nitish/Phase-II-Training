using EFDBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF
{
    internal class EmployeeCRUD
    {
        public void AddNewEmployee()
        {
            using (var context = new EmployeeMgmtContext())
            {
                var emp = new Emp()
                {
                    Empno = 1,
                    Ename = "Nitish",
                    Deptno = 1,
                    Addr="Coimbatore"

                };
                context.Emps.Add(emp);
                context.SaveChanges();
            };
        }

        public void UpdateEmployee()
        {
            var context = new EmployeeMgmtContext();
            var selemp = context.Emps.FirstOrDefault(d => d.Empno == 1);
            selemp.Ename = "Nitish Kumar";
            context.SaveChanges();
        }

        public void DeleteEmployee()
        {
            var context = new EmployeeMgmtContext();
            var selemp = context.Emps.FirstOrDefault(d => d.Empno == 1);
            context.Emps.Remove(selemp);
            context.SaveChanges();
        }
    }
}

