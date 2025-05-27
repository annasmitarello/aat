using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public class Paciente
    {
        public string DocumentoIdentidad { get; set; }
        public string NombreApellido { get; set; }
        public string Telefono { get; set; }
        public List<Intervencion> IntervencionesRealizadas { get; set; } = new List<Intervencion>();
        public ObraSocial ObraSocial { get; set; }

        public Paciente(string documentoIdentidad, string nombreApellido, string telefono)
        {
            DocumentoIdentidad = documentoIdentidad;
            NombreApellido = nombreApellido;
            Telefono = telefono;
        }

        public void RegistrarObraSocial(string nombreObraSocial, double cobertura)
        {
            ObraSocial = new ObraSocial(nombreObraSocial, cobertura);
        }

        public void AgregarIntervencion(Intervencion intervencion)
        {
            IntervencionesRealizadas.Add(intervencion);
        }

        // Sobrescribir ToString para mostrar la información del paciente
        public override string ToString()
        {
            string obraSocialInfo = ObraSocial != null ? $"{ObraSocial.Nombre} - Cobertura: {ObraSocial.Cobertura}%" : "Sin obra social";
            return $"DNI: {DocumentoIdentidad} | Nombre: {NombreApellido} | Teléfono: {Telefono} | Obra Social: {obraSocialInfo}";
        }
    }

    public class ObraSocial
    {
        public string Nombre { get; set; }
        public double Cobertura { get; set; }

        public ObraSocial(string nombre, double cobertura)
        {
            Nombre = nombre;
            Cobertura = cobertura;
        }
    }
}
}

