using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLase5ObjetosPOO.Clases
{
    public  class Usuario
    {
        private  string name; 
        private string lastName;
        private int dni;
        private string email;
        private int age;
        private string adress;


        public string Name        
        {
            get
            {
                string nameMay = name.ToUpper();

                return nameMay;
            }
            set
            {

                name = value;

            }
        }
  

        public int Dni
        {
            get
            {


                return dni;
            }
            set
            {
                

                dni=value;

            }
        }

    


        public Usuario(string name, string lastName, int dni, string email, int age, string adress) {

            this.name = name;
            this.lastName = lastName;
            this.dni = dni;
            this.email = email;
            this.age = age;
            this.adress = adress;

        }


        public bool EsMayorEdad() {

            bool esMayor;
            esMayor = this.age > 18;
            return esMayor;
        }

        public void CambiarDireccion() {

            bool ciclo = true;
          

            while (ciclo)
            {

                Console.WriteLine($"Esta es tu direccion actual: {this.adress}");
                Console.WriteLine($"Desea cambiarla? (Y) (N)");

                char respuesta = Convert.ToChar(Console.ReadLine().ToUpper());

                if (respuesta == 'Y')
                {
                    Console.WriteLine("Ingrese la nueva direccion:");
                    string? newAdress = Console.ReadLine();

                    if (newAdress == "" || newAdress==null) { 
                        Console.WriteLine("no se recibio una direccion valida");
                        continue; 
                    };
                    this.adress = newAdress;
                    
                    Console.WriteLine($"tu nueva direccion es: {this.adress}");
                    ciclo = false;
                    break;

                }

                if(respuesta == 'N')
                {
                    Console.WriteLine($"Tu direccion se mantiene: {this.adress}");
                    ciclo= false;
                    break;

                }
                else
                {
                    Console.WriteLine("Ingrese Y o N como opcion valida!");
                    continue;
                }
            }  
        }

        public void EsGmail()
        {

            if (this.email.Contains("@gmail"))
            {
                Console.WriteLine("Es Gmail!");
            }
            else
            {
                Console.WriteLine("No es Gmail");
            }
           
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Tu nombre es: {this.name} \n Tu apellido es: {this.lastName} \n Tu DNI es: {this.dni} \n Tu Email es: {this.email} \n Tu Direccion es: {this.adress}");
        }
    }
}
