﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosEjercicio4
{
    internal class MenuPrincipal
    {
        /*
        public static PersonaEnt UsuarioActual { get; private set; }

        public static void Login(string usuario, string password)
        {
            //Ejemplo: en un sistema completo de alguna manera obtenemos el usuario
            //(de un archivo, una BBDD, etc.)
            PersonaEnt persona = new();

            UsuarioActual = persona;
        }
        */

        public static void Mostrar()
        {
            Console.WriteLine("Menu principal");
            Console.WriteLine("1-Alta de persona");
            Console.WriteLine("2-Baja de persona");
            Console.WriteLine("3-Modificar de persona");
            Console.WriteLine("4-Salir");

            while (true)
            {
                Console.WriteLine("Ingrese su opción:");
                var ingreso = Console.ReadLine();
                if (!int.TryParse(ingreso, out int opcion))
                {
                    Console.WriteLine("Ingrese un numero válido");
                    continue;
                }

                if (opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Ingrese 1-4");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        ModuloPersona.Alta();
                        break;

                    case 2:
                        ModuloPersona.Baja();
                        break;

                    case 3:
                        ModuloPersona.Modificar();
                        break;

                    case 4: //finalizar
                        return;
                }
            }
        }
    }
}
