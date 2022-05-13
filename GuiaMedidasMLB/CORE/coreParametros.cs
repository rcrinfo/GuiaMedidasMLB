using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaMedidasMLB.CORE
{
    public class coreParametros
    {
        public List<Parametro> Parametros;

        public void AddWithValue(string _name, object _value)
        {
            var p = new Parametro
            {
                Name = _name,
                Value = _value
            };

            if (Parametros == null)
            {
                Parametros = new List<Parametro>();
            }

            Parametros.Add(p);
        }

        public class Parametro
        {
            public string Name { get; set; }
            public object Value { get; set; }
        }
    }
}
