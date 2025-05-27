using System;
using System.Collections.Generic;

namespace AdministracionSanatorio
{
    public class SistemaSanatorio
    {
        private List<Paciente> pacientes;
        private List<Doctor> doctores;

        public SistemaSanatorio()
        {
            pacientes = new List<Paciente>();
            doctores = new List<Doctor>();
        }

        // Método para dar de alta un paciente
        public void DarDeAltaPaciente(string documentoIdentidad, string nombreApellido, string telefono)
        {
            Paciente pacienteExistente = pacientes.Find(p => p.DocumentoIdentidad == documentoIdentidad);
            if (pacienteExistente != null)
            {
                Console.WriteLine("El paciente ya está registrado.");
            }
            else
            {
                Paciente nuevoPaciente = new Paciente(documentoIdentidad, nombreApellido, telefono);
                pacientes.Add(nuevoPaciente);
                Console.WriteLine("Paciente dado de alta con éxito.");
            }
        }

        // Método para buscar un paciente
        public Paciente BuscarPacientePorDocumento(string documentoIdentidad)
        {
            return pacientes.Find(p => p.DocumentoIdentidad == documentoIdentidad);
        }

        // Método para agregar un doctor
        public void AgregarDoctor(Doctor doctor)
        {
            doctores.Add(doctor);
        }

        // Método para obtener la lista de pacientes
        public List<Paciente> ObtenerPacientes()
        {
            return pacientes;
        }

        // Método para obtener la lista de doctores
        public List<Doctor> ObtenerDoctores()
        {
            return doctores;
        }

        // Puedes agregar más métodos según lo necesites (como programar una intervención, generar reportes, etc.)
    }
}
