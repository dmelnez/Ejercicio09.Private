using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso09.C_.Servicios
{
    internal class OperativaImplemntacon : OperativaInterfaz
    {
        string fraseUsuario;

        public string solicitarFrase()
        {

            Console.WriteLine("INTRODUZCA UNA FRASE: ");
            fraseUsuario = Console.ReadLine();
            reemplazarVocales();
            fraseDividida();
            creacionYEscrituraFicher();
            vocalesFaltantes();

            return fraseUsuario;

        }

        // Metodo encargado de Reemplazar las Vocales por el caracter '*'
        private void reemplazarVocales()
        {



            string conjuntoDeVocales = "aeiou";


            for (int i = 0; i < conjuntoDeVocales.Length ; i++)
            {

                fraseUsuario = fraseUsuario.Replace(conjuntoDeVocales[i], '*');

            }




        }

        String[] fraseDividadArray;
        // Metodo encargado de Divir la Frase en un Array, divido por el cacter ' '
        private void fraseDividida()
        {

            // Division de la Frase en Base al caracter ' '
            fraseDividadArray = fraseUsuario.Split(' ');   

        }

        // Creacion de un Fichero ,y escritura en el mismo en base al Array Anteriormente generado
        private void creacionYEscrituraFicher()
        {

            DateTime fechaFichero = DateTime.Today;

            string nombreFichero = fechaFichero.ToString("dd-MM-yyyy") + ".txt";


       
            using (StreamWriter sw = new StreamWriter(nombreFichero, false))
            {

                for (int i = 0; i < fraseDividadArray.Length ; i++)
                {
                    sw.WriteLine(fraseDividadArray[i]);

                }

              

            }

            
           



            // Metodo encargado de Leer las dos ultimas Lineas de un Fichero.
            string[] leerLineas = File.ReadAllLines(nombreFichero);

            

                for (int i = leerLineas.Length -2; i < leerLineas.Length; i++)
                {
               
                    Console.WriteLine(leerLineas[i]);
                
                }

            


        }


        private void vocalesFaltantes()
        {
            // Solicitar al Usuario el Numero de vocales Faltantes
            Console.WriteLine("Nº De Vocales Faltantes: ");
            int vocalesFaltantes = Convert.ToInt32(Console.ReadLine());


            int vocalesRealesFaltantes = 0;

            for (int i = 0; i < fraseUsuario.Length; i++)
            {

                if (fraseUsuario[i] == '*')
                {
                    vocalesRealesFaltantes++;

                }

            }
           
            bool cerrarAplicacion = false;
            if(vocalesFaltantes == vocalesRealesFaltantes)
            {

                do
                {
                    Console.WriteLine("[INFO] - Respuesta Correcta");
                    Console.WriteLine("Introduce una Vocal: ");
                    char caracterAReeemplazar = Convert.ToChar(Console.ReadLine());



                }

                while (true);

            }


            else
            {

                Console.WriteLine("[INFO] - Respuesta Incorrecta");
               

            }



        }




       





     }



}

