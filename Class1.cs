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

        // Método para listar los pacientes
        public void ListarPacientes()
        {
            if (pacientes.Count == 0)
            {
                Console.WriteLine("No hay pacientes registrados.");
            }
            else
            {
                Console.WriteLine("Lista de pacientes:");
                foreach (var paciente in pacientes)
                {
                    Console.WriteLine(paciente.ToString());
                }
            }
        }

        // Otros métodos para buscar pacientes, agregar doctores, etc.
    }
}
