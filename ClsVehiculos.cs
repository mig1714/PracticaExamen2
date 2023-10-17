using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen2
{
    internal class ClsVehiculos
    {

        static int cantidad = 0;

        //ARRAYS
        static string[] todosVehiculos = new string[cantidad];
        static string[] tiposVehiculos = new string[4] { "Moto", "Liviano", "Camión", "Autobus" };

        static string[] caseta = new string[cantidad];
        static float[] montos = new float[cantidad];

        static float[] pagado = new float[cantidad];

        static string[] placa = new string[cantidad];

        static float[] vueltos = new float[cantidad];

        static string[] facturas = new string[cantidad];



        //Atributos

        static string placaVehiculo = "";

        static int numeroFactura = 0;

        static int opcionVehiculo = 0;

        static string numeroCaseta = "";

        static float montoPagar = 0f;

        static string vehiculo = "";

        static float montoPagado = 0f;

        static float vuelto = 0f;

        static int factura = 0;



        //Metodos

        public static void inicializar()

        {

            Console.WriteLine("Digite la cantidad de vehiculos a ingresar");
            int.TryParse(Console.ReadLine(), out cantidad);
            Console.WriteLine("Cantidad: " + cantidad);

            /*for (int i = 0; i < cantidad; i++)
            {
                todosVehiculos[i] = "";
                



            }*/


            todosVehiculos = Enumerable.Repeat("", cantidad).ToArray();


            placa = Enumerable.Repeat("", cantidad).ToArray();
            caseta = Enumerable.Repeat("", cantidad).ToArray();
            montos = Enumerable.Repeat(0f, cantidad).ToArray();
            pagado = Enumerable.Repeat(0f, cantidad).ToArray();
            placa = Enumerable.Repeat("", cantidad).ToArray();
            vueltos = Enumerable.Repeat(0f, cantidad).ToArray();
            facturas = Enumerable.Repeat("", cantidad).ToArray();







        }


        //Ingresar vehiculo
        public static void IngresarVehiculo()
        {



            for (int i = 0; i < cantidad; i++)

            {


                ClsVehiculos.escogerVehiculo();

                Console.WriteLine("Opcion vehiculo: "+opcionVehiculo);




                if (opcionVehiculo == 5)
                {

                    ClsMenuPrincipal menu = new ClsMenuPrincipal();
                    menu.Desplegar();

                    //Modificar();


                }
                else if (opcionVehiculo == 1)
                {


                    numeroFactura++;
                    Console.WriteLine("Factura: " + numeroFactura);

                    facturas[i] = (numeroFactura).ToString();
                    Console.WriteLine("Digite el número de placa");
                    placaVehiculo = Console.ReadLine();
                    placa[i] = placaVehiculo;

                    opcionVehiculo = 0;
                    vehiculo = tiposVehiculos[opcionVehiculo];
                    tiposVehiculos[i] = vehiculo;


                    montoPagar = 500f;

                    montos[i] = montoPagar;
                    Console.WriteLine("Debe pagar: " + montoPagar);


                    Console.WriteLine("Digite el monto con el que va a pagar: ");
                    float.TryParse(Console.ReadLine(), out montoPagado);
                    pagado[i] = montoPagado;
                    Console.WriteLine("Monto pagado: " + montoPagado);
                    Console.WriteLine("Vuelto: " + Operacion());
                    vueltos[i] = Operacion();


                    Console.WriteLine("Digite el número de caseta 1, 2, o 3");
                    numeroCaseta = Console.ReadLine();
                    caseta[i] = numeroCaseta;




                }
                else if (opcionVehiculo == 2)

                {



                    numeroFactura++;
                    Console.WriteLine("Factura: " + numeroFactura);

                    facturas[i] = (numeroFactura).ToString();
                    Console.WriteLine("Digite el número de placa");
                    placaVehiculo = Console.ReadLine();
                    placa[i] = placaVehiculo;

                    opcionVehiculo = 1;
                    vehiculo = tiposVehiculos[opcionVehiculo];
                    tiposVehiculos[i] = vehiculo;


                    montoPagar = 700f;

                    montos[i] = montoPagar;
                    Console.WriteLine("Debe pagar: " + montoPagar);


                    Console.WriteLine("Digite el monto con el que va a pagar: ");
                    float.TryParse(Console.ReadLine(), out montoPagado);
                    pagado[i] = montoPagado;
                    Console.WriteLine("Monto pagado: " + montoPagado);
                    Console.WriteLine("Vuelto: " + Operacion());
                    vueltos[i] = Operacion();


                    Console.WriteLine("Digite el número de caseta 1, 2, o 3");
                    numeroCaseta = Console.ReadLine();
                    caseta[i] = numeroCaseta;


                }
                else if (opcionVehiculo == 3)

                {
                    numeroFactura++;
                    Console.WriteLine("Factura: " + numeroFactura);

                    facturas[i] = (numeroFactura).ToString();
                    Console.WriteLine("Digite el número de placa");
                    placaVehiculo = Console.ReadLine();
                    placa[i] = placaVehiculo;

                    opcionVehiculo = 2;
                    vehiculo = tiposVehiculos[opcionVehiculo];
                    tiposVehiculos[i] = vehiculo;


                    montoPagar = 2700f;

                    montos[i] = montoPagar;
                    Console.WriteLine("Debe pagar: " + montoPagar);


                    Console.WriteLine("Digite el monto con el que va a pagar: ");
                    float.TryParse(Console.ReadLine(), out montoPagado);
                    pagado[i] = montoPagado;
                    Console.WriteLine("Monto pagado: " + montoPagado);
                    Console.WriteLine("Vuelto: " + Operacion());
                    vueltos[i] = Operacion();


                    Console.WriteLine("Digite el número de caseta 1, 2, o 3");
                    numeroCaseta = Console.ReadLine();
                    caseta[i] = numeroCaseta;


                }

                else if (opcionVehiculo == 4)

                {
                    numeroFactura++;
                    Console.WriteLine("Factura: " + numeroFactura);

                    facturas[i] = (numeroFactura).ToString();
                    Console.WriteLine("Digite el número de placa");
                    placaVehiculo = Console.ReadLine();
                    placa[i] = placaVehiculo;

                    opcionVehiculo = 3;
                    vehiculo = tiposVehiculos[opcionVehiculo];
                    tiposVehiculos[i] = vehiculo;


                    montoPagar = 3700f;

                    montos[i] = montoPagar;
                    Console.WriteLine("Debe pagar: " + montoPagar);


                    Console.WriteLine("Digite el monto con el que va a pagar: ");
                    float.TryParse(Console.ReadLine(), out montoPagado);
                    pagado[i] = montoPagado;
                    Console.WriteLine("Monto pagado: " + montoPagado);
                    Console.WriteLine("Vuelto: " + Operacion());
                    vueltos[i] = Operacion();


                    Console.WriteLine("Digite el número de caseta 1, 2, o 3");
                    numeroCaseta = Console.ReadLine();
                    caseta[i] = numeroCaseta;




                }
            }
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(placa[i]);

            }



        }

        public static int escogerVehiculo()

        {
            

                Console.WriteLine("Digite: ");
                Console.WriteLine("1-Moto");
                Console.WriteLine("2-Liviano");
                Console.WriteLine("3-Camión Pesado");
                Console.WriteLine("4-Autobus");
                Console.WriteLine("5-Salir");
                int.TryParse(Console.ReadLine(), out opcionVehiculo);

                



            

            if (opcionVehiculo == 5)
            {
                ClsMenuPrincipal menu = new ClsMenuPrincipal();
                menu.Desplegar();
            }


            return opcionVehiculo;





        }

        public static void MostrarReportes()
        {

            /*foreach (var item in todosVehiculos)
            {
                Console.WriteLine("Item :");

            }*/
            float total = 0f;

            for (int i = 0; i < montos.Length; i++)
            {

                float suma = 0f;
                total += suma + montos[i];
            }
            for (int i = 0; i < placa.Length; i++)
            {


                Console.WriteLine("REPORTE");

                Console.WriteLine("==================================================================================================");
                Console.Write("N Factura" + "     ");
                Console.Write("Placa" + "     ");
                Console.Write("Tipo Vehiculo" + "     ");
                Console.Write("Caseta" + "     ");
                Console.Write("Monto Pagar" + "     ");
                Console.Write("Paga con" + "     ");
                Console.WriteLine("Vuelto" + "     ");
                Console.WriteLine("===============================================================================================");
                Console.Write(facturas[i] + "            ");
                Console.Write(placa[i] + "            ");
                Console.Write(tiposVehiculos[i] + "            ");
                Console.Write(caseta[i] + "            ");
                Console.Write(montos[i] + "            ");
                Console.Write(pagado[i] + "        ");
                Console.WriteLine(vueltos[i] + "            ");
              
               

            }
            Console.WriteLine("===============================================================================================");
            Console.Write("Cantidad de vehículos: " + todosVehiculos.Length + "                          ");
            Console.WriteLine("Total: " + total);

            Console.WriteLine("===============================================================================================");
        }

        public static float Operacion()
        {
            Console.WriteLine("Operacion");

            if (vehiculo.Equals("Moto"))

            {


                if (montoPagado >= montoPagar)
                {
                    vuelto = montoPagado - montoPagar;
                    //Console.WriteLine("Vuelto: "+vuelto);


                }
                else if (montoPagado < montoPagar)
                {
                    Console.WriteLine("Valor erroneo");



                }


            }

            else if (vehiculo.Equals("Liviano"))

            {


                if (montoPagado >= montoPagar)
                {
                    vuelto = montoPagado - montoPagar;
                    //Console.WriteLine("Vuelto: "+vuelto);


                }
                else if (montoPagado < montoPagar)
                {
                    Console.WriteLine("Valor erroneo");



                }
            }

            else if (vehiculo.Equals("Camión"))

            {


                if (montoPagado >= montoPagar)
                {
                    vuelto = montoPagado - montoPagar;
                    Console.WriteLine("Vuelto: " + vuelto);
                    //Console.WriteLine("Vuelto: "+vuelto);


                }
                else if (montoPagado < montoPagar)
                {
                    Console.WriteLine("Valor erroneo");



                }


            }

            else if (vehiculo.Equals("Autobus"))

            {


                if (montoPagado >= montoPagar)
                {
                    vuelto = montoPagado - montoPagar;
                    //Console.WriteLine("Vuelto: "+vuelto);


                }
                else if (montoPagado < montoPagar)
                {
                    Console.WriteLine("Valor erroneo");



                }




            }




            return vuelto;



        }

        public static void MostrarVehiculo()

        {
            float total = 0f;

            for (int i = 0; i < montos.Length; i++)
            {

                float suma = 0f;
                total += suma + montos[i];
            }
            Console.WriteLine("Ingrese la placa a consultar");
            string placaBuscar = Console.ReadLine();

            for (int i = 0; i < placa.Length; i++)
            {
                if (placa[i].Equals(placaBuscar))

                {

                    Console.WriteLine("====================Reporte placa " + placaBuscar + "=====================================================");
                    Console.Write("N Factura" + "     ");
                    Console.Write("Placa" + "     ");
                    Console.Write("Tipo Vehiculo" + "     ");
                    Console.Write("Caseta" + "     ");
                    Console.Write("Monto Pagar" + "     ");
                    Console.Write("Paga con" + "     ");
                    Console.WriteLine("Vuelto" + "     ");
                    Console.WriteLine("===============================================================================================");
                    Console.Write(facturas[i] + "            ");
                    Console.Write(placa[i] + "            ");
                    Console.Write(tiposVehiculos[i] + "            ");
                    Console.Write(caseta[i] + "            ");
                    Console.Write(montos[i] + "            ");
                    Console.Write(pagado[i] + "        ");
                    Console.WriteLine(vueltos[i] + "            ");


                }
                Console.WriteLine("===============================================================================================");
                /*
                 Console.Write("Cantidad de vehículos: " + todosVehiculos.Length + "                          ");
                Console.WriteLine("Total: " + total);

                Console.WriteLine("===============================================================================================");
               */


            }


        }

        public static void Modificar()

        {

            Console.WriteLine("Ingrese la placa a consultar");
            string placaBuscar = Console.ReadLine();

            for (int i = 0; i < placa.Length; i++)
            {

                if (placa[i].Equals(placaBuscar))
                {
                    ClsVehiculos.escogerVehiculo();
                    //tiposVehiculos[i] = tiposVehiculos[opcionVehiculo];

                    if (opcionVehiculo == 1)
                    {





                        opcionVehiculo = 0;
                        vehiculo = tiposVehiculos[opcionVehiculo];
                        tiposVehiculos[i] = vehiculo;


                        montoPagar = 500f;

                        montos[i] = montoPagar;
                        Console.WriteLine("Debe pagar: " + montoPagar);


                        Console.WriteLine("Digite el monto con el que va a pagar: ");
                        float.TryParse(Console.ReadLine(), out montoPagado);
                        pagado[i] = montoPagado;
                        Console.WriteLine("Monto pagado: " + montoPagado);
                        Console.WriteLine("Vuelto: " + Operacion());
                        vueltos[i] = Operacion();


                        Console.WriteLine("Digite el número de caseta 1, 2, o 3");
                        numeroCaseta = Console.ReadLine();
                        caseta[i] = numeroCaseta;




                    }
                    else if (opcionVehiculo == 2)

                    {






                        opcionVehiculo = 1;
                        vehiculo = tiposVehiculos[opcionVehiculo];
                        tiposVehiculos[i] = vehiculo;


                        montoPagar = 700f;

                        montos[i] = montoPagar;
                        Console.WriteLine("Debe pagar: " + montoPagar);


                        Console.WriteLine("Digite el monto con el que va a pagar: ");
                        float.TryParse(Console.ReadLine(), out montoPagado);
                        pagado[i] = montoPagado;
                        Console.WriteLine("Monto pagado: " + montoPagado);
                        Console.WriteLine("Vuelto: " + Operacion());
                        vueltos[i] = Operacion();


                        Console.WriteLine("Digite el número de caseta 1, 2, o 3");
                        numeroCaseta = Console.ReadLine();
                        caseta[i] = numeroCaseta;


                    }
                    else if (opcionVehiculo == 3)

                    {



                        opcionVehiculo = 2;
                        vehiculo = tiposVehiculos[opcionVehiculo];
                        tiposVehiculos[i] = vehiculo;


                        montoPagar = 2700f;

                        montos[i] = montoPagar;
                        Console.WriteLine("Debe pagar: " + montoPagar);


                        Console.WriteLine("Digite el monto con el que va a pagar: ");
                        float.TryParse(Console.ReadLine(), out montoPagado);
                        pagado[i] = montoPagado;
                        Console.WriteLine("Monto pagado: " + montoPagado);
                        Console.WriteLine("Vuelto: " + Operacion());
                        vueltos[i] = Operacion();


                        Console.WriteLine("Digite el número de caseta 1, 2, o 3");
                        numeroCaseta = Console.ReadLine();
                        caseta[i] = numeroCaseta;


                    }

                    else if (opcionVehiculo == 4)

                    {



                        opcionVehiculo = 3;
                        vehiculo = tiposVehiculos[opcionVehiculo];
                        tiposVehiculos[i] = vehiculo;


                        montoPagar = 3700f;

                        montos[i] = montoPagar;
                        Console.WriteLine("Debe pagar: " + montoPagar);


                        Console.WriteLine("Digite el monto con el que va a pagar: ");
                        float.TryParse(Console.ReadLine(), out montoPagado);
                        pagado[i] = montoPagado;
                        Console.WriteLine("Monto pagado: " + montoPagado);
                        Console.WriteLine("Vuelto: " + Operacion());
                        vueltos[i] = Operacion();


                        Console.WriteLine("Digite el número de caseta 1, 2, o 3");
                        numeroCaseta = Console.ReadLine();
                        caseta[i] = numeroCaseta;




                    }






                }
            else
            {

                Console.WriteLine("Valor ingresado no existe");

            }

            }



        }



    }
    
}
