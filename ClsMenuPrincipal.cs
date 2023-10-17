using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen2
{
    internal class ClsMenuPrincipal
    {
        public void Desplegar() 
        {
            int opcion = 0;

            
            do

            {
                Console.WriteLine("1-Digite para inicializar");
                Console.WriteLine("2-Digite para ingresar vehiculo");
                Console.WriteLine("3-Consulta Vehículos Número de placa");
                Console.WriteLine("4-Mostrar Reportes");
                Console.WriteLine("5-Modificar");

                Console.WriteLine("6-Salir");
                int.TryParse(Console.ReadLine(), out opcion);

           
                switch (opcion) 
                {

                case 1: ClsVehiculos.inicializar(); break;
                case 2: ClsVehiculos.IngresarVehiculo(); break;
                case 3: ClsVehiculos.MostrarVehiculo(); break;
                case 4: ClsVehiculos.MostrarReportes(); break;
                case 5: ClsVehiculos.Modificar(); break;


                }


            } while (opcion != 6);
        }
    }
}
