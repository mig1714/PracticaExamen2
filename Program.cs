using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsMenuPrincipal menu = new ClsMenuPrincipal();
            menu.Desplegar();
            /*ClsVehiculos.inicializar();
            ClsVehiculos.IngresarVehiculo();
            ClsVehiculos.Modificar();
            ClsVehiculos.MostrarReportes();*/
            
            Console.ReadLine();
            
        }
    }
}
