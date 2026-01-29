
using System;
using System.IO;
namespace BlocDeNotas
{
    public class Jugada
    {
        public static void Cargar()
        {
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Presione una tecla para la jugada numero " + (f + 1) + " ...");
                Console.ReadLine();
                for (int c = 0; c < 5; c++)
                {
                    Variables.Array[f, c] = Variables.numero.Next(1, 7);
                    switch (Variables.Array[f, c])
                    {
                        case 1:
                            Variables.C1 = Variables.C1 + 1;
                            break;
                        case 2:
                            Variables.C2 = Variables.C2 + 1;
                            break;
                        case 3:
                            Variables.C3 = Variables.C3 + 1;
                            break;
                        case 4:
                            Variables.C4 = Variables.C4 + 1;
                            break;
                        case 5:
                            Variables.C5 = Variables.C5 + 1;
                            break;
                        case 6:
                            Variables.C6 = Variables.C6 + 1;
                            break;
                    }
                }
            }
            Console.Write("\n");
            Variables.Archivo.Write("\n");
        }
    }
}