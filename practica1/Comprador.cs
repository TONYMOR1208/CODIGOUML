using System;
using System.Collections.Generic;
using System.Text;

namespace practica1
{
    class Comprador:persona
    {

        public int edad { get; set; }
        public string direccion { get; set; }
        public string codigo_postal { get; set; }
        public string salario { get; set; }

        public Comprador(int ID, int Cedula, string Nombre, string correo, double Telefono, int edad, string direccion, string codigo_postal, string salario)
            :base(ID, Cedula, Nombre, correo, Telefono)
        {
            this.edad = edad;
            this.direccion = direccion;
            this.codigo_postal = codigo_postal;
            this.salario = salario;
        }

        
        
        public void imprimir()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("FICHA DEL COMPRADOR");
            Console.WriteLine("----------------------");
            Console.WriteLine("Identificacion: " + ID);
            Console.WriteLine("Numero de Cedula " + Cedula);
            Console.WriteLine("Nombre : " + Nombre);
            Console.WriteLine("Apellidos :" );
            Console.WriteLine("Edad  :" + edad);
            Console.WriteLine("Correo Electronico :" + correo);
            Console.WriteLine("Numero de telefono :" + Telefono);
            Console.WriteLine("Direccion del domicilio :" + direccion);
            Console.WriteLine("Codigo postal :" + codigo_postal);
            Console.WriteLine("Salario :" + salario);





        }
        public void elegir_vehiculo(){
        }
        public void probar_vehiculo()
        {
        }
        public void comprar_vehiculo()
        {

        }
        public void usar()
        {

        }
    }
    
}
