using System;

namespace AdministracionSanatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia del sistema del sanatorio
            SistemaSanatorio sistema = new SistemaSanatorio();

            // Dar de alta algunos pacientes
            sistema.DarDeAltaPaciente("12345678", "Juan Perez", "555-1234");
            sistema.DarDeAltaPaciente("23456789", "Maria Lopez", "555-5678");

            // Listar los pacientes registrados
            sistema.ListarPacientes();
        }
    }
}
