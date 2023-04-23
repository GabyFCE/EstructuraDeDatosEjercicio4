using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosEjercicio4
{
    internal static class ModuloPersona
    {
        internal static void Alta()
        {
            List<PersonaEnt> personas = new List<PersonaEnt>();

            while (true)
            {
                //1) Pedir los datos para construir un objeto auto
                //2) agregarlo a la lista
                //3)preguntarle al usuario si quiere seguir o no,
                //4)si no, por ahora terminamos.
                //5)si si, seguimos

                PersonaEnt nuevaPersona = IngresarPersona();
                personas.Add(nuevaPersona);
                Console.WriteLine("Se ha agregado una nueva persona.");
                Console.WriteLine($"Cantidad: {personas.Count}");

                Console.WriteLine("¿Desea continuar agregando personas? [S/N]");
                string continuar = null;
                while (continuar != "S" && continuar != "N")
                {
                    continuar = Console.ReadLine();
                }

                if (continuar == "N")
                {
                    break;
                }
            }

            PersonaEnt IngresarPersona()
            {
                PersonaEnt persona = new PersonaEnt();

                while (true)
                {

                    //Documento

                    persona.Documento = Ingreso.EnteroLargo("el documento", 1_000_000, 99_000_000);
                    
                    //Nombre
                    persona.Nombre = Ingreso.Cadena("el nombre", 1, 30, soloLetras: true);

                    //Apellido
                    persona.Apellido = Ingreso.Cadena("el apellido", 1, 30, soloLetras: true);

                    //Telefono
                    List<TelefonoEnt> telefonos = new List<TelefonoEnt>();
                    while (true)
                    {
                        
                        string respuesta;
                        TelefonoEnt telefono = IngresarTelefono();
                        telefonos.Add(telefono);
                        Console.WriteLine("Tiene más telefonos para ingresar[S/N]");
                        respuesta = Console.ReadLine();
                        while (respuesta != "S" && respuesta != "N")
                        {
                            respuesta = Console.ReadLine();
                        }
                        if(respuesta == "N")
                        {
                            break;
                        }

                    }
                    persona.Telefonos = telefonos;



                    if (!persona.ValidarPersona(out string error))
                    {
                        Console.WriteLine(error);
                        continue;
                    }

                    break;
                }

                return persona;
            }

            TelefonoEnt IngresarTelefono()
            {

                TelefonoEnt telefono = new TelefonoEnt();
                while (true)
                {

                    Console.WriteLine("Ingrese Datos del telefono. Indique como tipo 'CASA/TRABAJO/OTRO");
                    telefono.Tipo = Ingreso.Cadena("tipo de telefono", 1, 15, soloLetras: true);
                    telefono.CodigoPais = Ingreso.Entero("codigo de país", 0, 99);
                    telefono.CodigoArea = Ingreso.Entero("codigo de área", 0, 99);
                    telefono.NumeroTelefono = Ingreso.EnteroLargo("Numero de telefono", 100_000, 99_000_000);

                    if (!telefono.ValidarTelefono(out string errortelefono))
                    {
                        Console.WriteLine(errortelefono);
                        continue;
                    }
                    break;

                }

                return telefono;

            }

        }

        internal static void Baja()
        {
            throw new NotImplementedException();
        }

        internal static void Modificar()
        {
            throw new NotImplementedException();
        }
    }
}
