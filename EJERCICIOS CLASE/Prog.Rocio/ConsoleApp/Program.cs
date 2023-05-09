using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaClases;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Principal principal = new Principal();

            Paciente pacienteAgregado = new Paciente();
            Console.WriteLine("Ingrese los datos del Paciente");

            Console.WriteLine("Coloque el DNI");
            pacienteAgregado.DNI = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre");
            pacienteAgregado.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            pacienteAgregado.Apellido = Console.ReadLine();
            Console.WriteLine("coloque la fecha de nacimiento");
            pacienteAgregado.FechaNacimiento = DateTime.Parse(Console.ReadLine());


            principal.AltaPaciente(pacienteAgregado.DNI, pacienteAgregado.Nombre, pacienteAgregado.Apellido, pacienteAgregado.FechaNacimiento);


            Medico medicoAgregado = new Medico();
            Console.WriteLine("Ingrese los datos del Medico");

            Console.WriteLine("Coloque el DNI");
            medicoAgregado.DNI = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre");
            medicoAgregado.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            medicoAgregado.Apellido = Console.ReadLine();
            Console.WriteLine("coloque la fecha de nacimiento");
            medicoAgregado.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("coloque la especialidad");
            medicoAgregado.Especialidad = Console.ReadLine();


            principal.AltaMedico(medicoAgregado.DNI, medicoAgregado.Nombre, medicoAgregado.Apellido, medicoAgregado.FechaNacimiento,medicoAgregado.Especialidad);


            Historial historialAgregado = new Historial();
            Console.WriteLine("Ingrese los datos para el Historial");

            Console.WriteLine("Coloque el DNI");
            historialAgregado.DNI = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre");
            historialAgregado.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            historialAgregado.Apellido = Console.ReadLine();
            Console.WriteLine("coloque la fecha de nacimiento");
            historialAgregado.FechayHora = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("coloque la especialidad");
            historialAgregado.ObraSocial = Console.ReadLine();


            principal.AltaHistorial(historialAgregado.DNI, historialAgregado.Nombre, historialAgregado.Apellido, historialAgregado.FechayHora, historialAgregado.ObraSocial);



        }
    }
}
