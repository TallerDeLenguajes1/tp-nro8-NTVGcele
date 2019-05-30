using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp8
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            int cant = 2;
            //Console.Write("ingrese la cantidad de empleados: ");
            //cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                Empleado nuevo = new Empleado();
                nuevo.cargarDatos();
                listaEmpleados.Add(nuevo);
            }
            int e = 1;
            string EmpleadoTexto = "";
            string AgregarText = "";//Para agregar texto en el archivo creado
            foreach (Empleado lectura in listaEmpleados)
            {
                
                Console.Write("\n\n PERSONA: " + e);
                EmpleadoTexto += lectura.nombre.ToString() + ";";
                AgregarText += lectura.nombre.ToString() + ";";
                Console.Write("\n Nombre: {0}", lectura.nombre);

                EmpleadoTexto += lectura.apellido.ToString() + ";";
                AgregarText += lectura.apellido.ToString() + ";";
                Console.Write("\n Apellido: " + lectura.apellido);

                EmpleadoTexto += lectura.fechNac.ToString() + ";";
                AgregarText += lectura.fechNac.ToString() + ";";
                Console.Write("\n Fecha de nacimiento: " + lectura.fechNac);

                EmpleadoTexto += lectura.civil.ToString() + ";";
                AgregarText += lectura.civil.ToString() + ";";
                Console.Write("\n Estado Civil: " + lectura.civil);

                EmpleadoTexto += lectura.sexo.ToString() + ";";
                AgregarText += lectura.sexo.ToString() + ";";
                Console.Write("\n Sexo: " + lectura.sexo);

                EmpleadoTexto += lectura.fechIngreso.ToString() + ";";
                AgregarText += lectura.fechIngreso.ToString() + ";";
                Console.Write("\n Fecha de ingreso a la empresa: " + lectura.fechIngreso);

                EmpleadoTexto += lectura.sueldoB.ToString() + ";";
                AgregarText += lectura.sueldoB.ToString() + ";";
                Console.Write("\n Sueldo basico: " + lectura.sueldoB);

                EmpleadoTexto += lectura.cargo.ToString() + ";";
                AgregarText += lectura.cargo.ToString() + ";";
                Console.Write("\n Cargo: " + lectura.cargo);

                EmpleadoTexto += lectura.edad.ToString() + ";";
                AgregarText += lectura.edad.ToString() + ";";
                Console.Write("\n Edad: " + lectura.edad);

                EmpleadoTexto += lectura.antiguedad.ToString() + ";";
                AgregarText += lectura.antiguedad.ToString() + ";";
                Console.Write("\n Antiguedad: " + lectura.antiguedad);

                EmpleadoTexto += lectura.salario.ToString() + Environment.NewLine;
                AgregarText += lectura.salario.ToString() + Environment.NewLine;
                Console.Write("\n Salario: " + lectura.salario);
                //EmpleadoTexto += "\n";
                e = e + 1;
            }
            System.Console.ReadKey();

            Console.ReadKey();
            // UTILIZO SYSTEM.IO.Directory
            string BuscandoCarpeta = @"c:\repo8\";
            if (!Directory.Exists(BuscandoCarpeta))
            {
                Directory.CreateDirectory(BuscandoCarpeta);

            }
            Console.WriteLine();


            string rutaDeAchivo = @"c:\repo8\Prueba.CVS";
            // UTILIZO SYSTEM.IO.file
            //File.Create(rutaDeAchivo); // Crea un archivo Prueba .csv

            //if (File.Exists(rutaDeAchivo)) //Comprueba si existe el archivo
            //{
               //ESCRIBI EN EL ARCHIVO
               /* File.WriteAllText(rutaDeAchivo, EmpleadoTexto);
                Console.WriteLine("Existe Prueba.CVS");*/
            //}
            //AGREGO TEXTO EN EL ARCHIVO CRECADO
            string agregar = AgregarText + Environment.NewLine;
            File.AppendAllText(rutaDeAchivo, agregar);
           // string readText = File.ReadAllText(rutaDeAchivo);
            //Console.WriteLine(readText);

            string [] disco = { @"c:\BackUpAgenda", @"d:\BackUpAgenda" };
            int P;
            Console.Write("Escriba 0 si desea guardar el archivo en Disco C o 1 si desea guardar el archivo en Disco E: ");
            P = int.Parse(Console.ReadLine());
            if(!Directory.Exists(disco[P])){
                Directory.CreateDirectory(disco[P]);
            }
            string rutaNuevaCarpeta = disco[P] + @"\copia.CVS";
            string agregarcopia = AgregarText + Environment.NewLine;
            File.AppendAllText(rutaNuevaCarpeta, agregarcopia);
            Console.Write("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

            string readTextcopia = File.ReadAllText(rutaNuevaCarpeta);

            Console.WriteLine(readTextcopia);


            Console.ReadKey();
        }
    }
}
