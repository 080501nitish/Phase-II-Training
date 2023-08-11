using EFCF.Context;
using EFCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF
{
    internal class CRUD
    {
        public void AddNewDept()
        {
            using (var context = new EmployeeManagement())
            {
                var dept = new Dept()
                {
                    Deptno = 12,
                    Dname = "Developer"
                };
                context.Depts.Add(dept);
                context.SaveChanges();
            };
        }

        public void UpdateDept()
        {
            var context = new EmployeeManagement();
            var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 10);
            seldept.Dname = "Architect";
            context.SaveChanges();
        }

        public void DeleteDept()
        {
            var context = new EmployeeManagement();
            var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 10);
            context.Depts.Remove(seldept);
            context.SaveChanges();
        }
    }
}
