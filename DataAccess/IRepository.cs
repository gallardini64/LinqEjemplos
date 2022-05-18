using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IRepository
    {
        public IEnumerable<Empleado> GetAll();
    }
}
