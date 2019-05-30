using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp8
{
    public class Empleado
    {
        public enum Nombre { Fabio, Alex, Fede, silvia }
        public enum Apellido { Soto, Cordoba, Perez, Mamani }
        public enum Trabajo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador }
        public enum Estado { casado, soltero }
        public enum Genero { femenino, masculino }



        // fechanac = new DateTime(1,5,1998);

       public Nombre nombre;
       public Apellido apellido;
       public DateTime fechNac;//fecha de nacimiento
       public Estado civil;
       public Genero sexo;
       public DateTime fechIngreso; //fecha de ingreso a la empresa
       public double sueldoB;
       public Trabajo cargo;
       public int edad;
       public int antiguedad;
       public int jub;//jubilacion
       public double salario;

        public void cargarDatos ()
        {
            Random aleatorio = new Random();
            nombre = (Nombre)aleatorio.Next(0, 4);
            apellido = (Apellido)aleatorio.Next(0, 4);
            DateTime start = new DateTime(1995, 1, 1);
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            fechNac = start.AddDays (aleatorio.Next(range));
            civil = (Estado)aleatorio.Next(0, 2);
            sexo = (Genero)aleatorio.Next(0, 2);
            fechIngreso = start.AddDays(aleatorio.Next(range));
            sueldoB = aleatorio.Next(0, 5000);
            cargo = (Trabajo)aleatorio.Next(0, 5);
            antiguedad = DateTime.Today.AddTicks(-fechIngreso.Ticks).Year ;
            edad = DateTime.Today.AddTicks(-fechNac.Ticks).Year - 1;
            switch (sexo)
            {
                case 0: jub = DateTime.Today.AddTicks(- fechNac.Ticks).Year - 60; break;
                case (Genero)1:  jub = DateTime.Today.AddTicks(- fechNac.Ticks).Year - 65; break;
            }
            //CALCULO EL SALARIO
            double adicional;
            if ( antiguedad < 21)
            {
                
                adicional = ((sueldoB * 0.02) * (antiguedad));
                switch (cargo)
                {
                    case (Trabajo)2:
                    case (Trabajo)3: adicional = +(adicional * 0.5); break;
                        //default:;break;
                }
                switch (civil)
                {
                    case (Estado)0: adicional = +50000; break;
                }
                salario = sueldoB + adicional;
            }
            else
            {
                adicional = (sueldoB * 0.25);
                salario = adicional + sueldoB;
            }
        }
      
    }
}
