using EFDBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBF
{
    internal class CRUD
    {
        public void AddNewDept()
        {
            using (var context = new EmployeeMgmtContext())
            {
                var dept = new Dept()
                {
                    Deptno = 10,
                    Dname="HR"
                    
                };
                context.Depts.Add(dept);
                context.SaveChanges();
            }
        }

        public void UpdateDept() 
        {
            var context = new EmployeeMgmtContext();
            var seldept=context.Depts.FirstOrDefault(d => d.Deptno == 10);
            seldept.Dname = "DEV";
            context.SaveChanges();

        }

        public void DeleteDept()
        {
            var context = new EmployeeMgmtContext();
            var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 10);
            context.Depts.Remove(seldept);
            context.SaveChanges();
        }

        
    }
}
