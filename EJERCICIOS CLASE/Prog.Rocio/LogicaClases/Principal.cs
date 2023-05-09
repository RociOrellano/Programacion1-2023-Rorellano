using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases
{
    public class Principal
    {
        List<Paciente> ListaPaciente = new List<Paciente>();
        List<Medico> ListaMedico = new List<Medico>();
        List<Historial> ListaHistorial = new List<Historial>();

        public void AltaPaciente(int dni, string nombre, string apellido, DateTime fechanac)
        {
            Paciente Nuevopaciente = new Paciente();
            Nuevopaciente.DNI = dni;
            Nuevopaciente.Nombre = nombre;
            Nuevopaciente.Apellido = apellido;
            Nuevopaciente.FechaNacimiento = fechanac;
            ListaPaciente.Add(Nuevopaciente);
        }

        public void AltaMedico(int dni, string nombre, string apellido, DateTime fechanac, string especialidad)
        {
            Medico Nuevomedico = new Medico();
            Nuevomedico.DNI = dni;
            Nuevomedico.Nombre = nombre;
            Nuevomedico.Apellido = apellido;
            Nuevomedico.FechaNacimiento = fechanac;
            Nuevomedico.Especialidad = especialidad;
            ListaMedico.Add(Nuevomedico);
        }

        public void AltaHistorial(int dni, string nombre, string apellido, DateTime fechayhora, string obrasocial)
        {
            Historial Nuevohistorial  = new Historial();

            Nuevohistorial.DNI = dni;
            Nuevohistorial.Nombre = nombre;
            Nuevohistorial.Apellido = apellido;
            Nuevohistorial.FechayHora = fechayhora;
            Nuevohistorial.ObraSocial = obrasocial; 
            ListaHistorial.Add(Nuevohistorial);
        }

    }
}
