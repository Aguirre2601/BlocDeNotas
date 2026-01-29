using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlocDeNotas
{
    class Program
    {
        public static void Main(string[] args)
        {
            string hora = "";
            string fecha = "";
            Variables.Archivo = File.AppendText("Texto.txt");
            hora = DateTime.Now.ToString("hh:mm:ss");
            fecha = DateTime.Now.ToShortDateString();
            Console.WriteLine("" + hora + "  " + fecha + "\n");
            Variables.Archivo.Write("\n" + "" + hora + "  " + fecha + "\n");
            Variables.C1 = 0;
            Variables.C2 = 0;
            Variables.C3 = 0;
            Variables.C4 = 0;
            Variables.C5 = 0;
            Variables.C6 = 0;
            Variables.numero = new Random();
            Variables.Array = new int[5, 5];
            Variables.Archivo.Write("Ejercicio de bloc de notas");
            Jugada.Cargar();
            Tiro(Variables.Array);
            Console.Write("1 = {0} veces\n", Variables.C1);
            Variables.Archivo.Write("1 = {0} veces\n", Variables.C1);
            Console.Write("2 = {0} veces\n", Variables.C2);
            Variables.Archivo.Write("2 = {0} veces\n", Variables.C2);
            Console.Write("3 = {0} veces\n", Variables.C3);
            Variables.Archivo.Write("3 = {0} veces\n", Variables.C3);
            Console.Write("4 = {0} veces\n", Variables.C4);
            Variables.Archivo.Write("4 = {0} veces\n", Variables.C4);
            Console.Write("5 = {0} veces\n", Variables.C5);
            Variables.Archivo.Write("5 = {0} veces\n", Variables.C5);
            Console.Write("6 = {0} veces\n", Variables.C6);
            Variables.Archivo.Write("6 = {0} veces\n", Variables.C6);
            Console.Write("\n Presione cualquier tecla para SALIR");
            Variables.Archivo.Close();
            Console.ReadKey();
        }
        public static void Tiro(int[,] Array)
        {
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Tiro " + (f + 1) + ": ");
                Variables.Archivo.Write("Tiro " + (f + 1) + ": ");
                for (int c = 0; c < 5; c++)
                {
                    Console.Write("  " + Array[f, c]);
                    Variables.Archivo.Write("  " + Array[f, c]);
                }
                Console.Write("\n");
                Variables.Archivo.Write("\n");
            }
            Console.Write("\n");
            Variables.Archivo.Write("\n");
        }
    }
}
