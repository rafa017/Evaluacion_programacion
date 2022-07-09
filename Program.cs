using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("data.txt");
            string line = sr.ReadLine();
            double maximo = 0.0, minimo = 10000.0;
            List<data> datos = new List<data>();
            //data[] arrayData = new data[200];
            //APERTURA MAXIMO  MINIMO CIERRE
            double[] APERTURA = new double[200];
            double[] MAXIMO = new double[200];
            double[] MINIMO = new double[200];
            double[] CIERRE = new double[200];

            int contador = 0;
            while (line != null)
            {
                var dataLinea = line.Split(';');
                //*********Con arreglo de objetos
                /*arrayData[contador] = new data();
                arrayData[contador].APERTURA = double.Parse(dataLinea[0]);
                arrayData[contador].MAXIMO = double.Parse(dataLinea[1]);
                arrayData[contador].MINIMO = double.Parse(dataLinea[2]);
                arrayData[contador].CIERRE = double.Parse(dataLinea[3]);*/

                //*********Con arreglos separados
                APERTURA[contador] = double.Parse(dataLinea[0]);
                MAXIMO[contador] = double.Parse(dataLinea[1]);
                MINIMO[contador] = double.Parse(dataLinea[2]);
                CIERRE[contador] = double.Parse(dataLinea[3]);
                //*********Con lista de objetos
                data item = new data();
                item.APERTURA = double.Parse(dataLinea[0]);
                item.MAXIMO = double.Parse(dataLinea[1]);
                item.MINIMO = double.Parse(dataLinea[2]);
                item.CIERRE = double.Parse(dataLinea[3]);
                datos.Add(item);
                line = sr.ReadLine();
                contador++;
            }
            Console.WriteLine("APERTURA - MAXIMO - MINIMO - CIERRE");
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine(APERTURA[i] + "  " + MAXIMO[i] + "  " + MINIMO[i] + "  " + CIERRE[i]);
            }


            Console.WriteLine("APERTURA");
            for (int i = 0; i < APERTURA.Length; i += 11)
            {
                if (APERTURA[i] > maximo)
                {
                    maximo = APERTURA[i];
                    Console.WriteLine(maximo);
                }
            }
            for (int i = 0; i < APERTURA.Length; i+=18)
            {
                if (APERTURA[i] < maximo)
                {
                    minimo = APERTURA[i];
                    Console.WriteLine(minimo);
                }
            }

            Console.WriteLine("-----------------------MAXIMO-------------------");

            Console.WriteLine("MAXIMO");
            for (int i = 0; i < MAXIMO.Length; i+=2)
            {
                if(MAXIMO[i] > maximo)
                {
                    maximo = MAXIMO[i];
                    Console.WriteLine(maximo);
                }
            }
            for (int i = 10; i < MAXIMO.Length; i+=11)
            {
                if (MAXIMO[i] < maximo)
                {
                    minimo = MAXIMO[i];
                    Console.WriteLine(minimo);
                }
            }

            Console.WriteLine("-------------------MINIMO-----------------------");
            Console.WriteLine("MINIMO");
           
            for (int i = 0; i < MINIMO.Length; i+=10)
            {
                if(MINIMO[i] < maximo)
                {
                    minimo = MINIMO[i];
                    Console.WriteLine(minimo);
                }
            }

            Console.WriteLine("-----------------CIERRE-------------------------");
            Console.WriteLine("CIERRE");
            for (int i = 0; i < CIERRE.Length; i++)
            {
                if(CIERRE[i] < maximo)
                {
                    maximo = CIERRE[i];
                    Console.WriteLine(maximo);
                }
            }
            for (int i = 0; i < CIERRE.Length; i++)
            {
                if(CIERRE[i] < maximo)
                {
                    minimo = CIERRE[i];
                }
            }
            













            /*for (int i = 0; i < 200; i++)
            {
                Console.WriteLine(arrayData[i].APERTURA + " " + arrayData[i].MAXIMO + " " + arrayData[i].MINIMO + " " + arrayData[i].CIERRE);
            }*/

            /*Console.WriteLine("-----------------APERTURA-------------------");
            foreach (var item in datos)
            {
                Console.WriteLine(item.APERTURA);
                //Console.WriteLine(item.MAXIMO);
                //Console.WriteLine(item.MINIMO);
                //Console.WriteLine(item.CIERRE);
            }
         
            Console.WriteLine("------------------MAXIMO--------------------");
            foreach (var item in datos)
            {
                Console.WriteLine(item.MAXIMO);
            }
            Console.WriteLine("------------------MINIMO--------------------");
            foreach (var item in datos)
            {
                Console.WriteLine(item.MINIMO);
            }
            Console.WriteLine("-----------------CIERRE---------------------");
            foreach (var item in datos)
            {
                Console.WriteLine(item.CIERRE);
            }*/


            Console.ReadKey();
        }
    }
}
