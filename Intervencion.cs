using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public class Intervencion
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Especialidad { get; set; }
        public double Arancel { get; set; }

        public Intervencion(string codigo, string descripcion, string especialidad, double arancel)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Especialidad = especialidad;
            Arancel = arancel;
        }
    }
}
