using DataAccess;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqEjemplos
{
    public class LinqTypeOf
    {
        public IList MixedList { get; set; }
        public LinqTypeOf()
        {
            MixedList = new ArrayList();
            MixedList.Add(0);
            MixedList.Add("One");
            MixedList.Add("Two");
            MixedList.Add(3);
            MixedList.Add(new Persona() { Apellido = "Gallardini", Nombre = "Luciano" });
        }
        public IEnumerable ComoSql()
        {
            return from s in MixedList.OfType<string>()
                            select s;
            
        }
        public IEnumerable FuncionFlecha()
        {
            return MixedList.OfType<string>();
        }
    }
}
