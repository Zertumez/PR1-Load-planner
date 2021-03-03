using System;

namespace PR1_Load_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Objetos objeto1 = new Objetos("Barril", "B", 70, 2);
            Objetos objeto2 = new Objetos("Bolsa de chatarra", "BC", 20, 1);
            Objetos objeto3 = new Objetos("Bolsa con plantas", "BP", 3, 2);
            Objetos objeto4 = new Objetos("Caja ligera", "C1", 5, 1);
            Objetos objeto5 = new Objetos("Caja pesada", "C2", 15, 1);
            Objetos objeto6 = new Objetos("Caja vacía", "C3", 0.2, 1);
            Objetos objeto7 = new Objetos("Silla", "S", 4, 2);

            // Aquí se encuentra el arreglo donde se cambian de lugar los objetos.
            Objetos[,] vehiculo = new Objetos[3, 4]    {{null, objeto4, objeto6, null}, 
                                                     {objeto3, objeto5, objeto7, objeto1}, 
                                                     {objeto3, objeto2, objeto7, objeto1}};
            
            Console.WriteLine("");
            Console.WriteLine("El acomodo de los objetos es el siguiente:");
            Console.WriteLine("");

            Console.WriteLine("                       _____________________________________");
            Console.WriteLine("             _______  |                                     |");
            Console.Write("            / _____ | | ");
            
            Console.Write("           ");
            for (int i = 0; i < 4; i++)
            {
                if (vehiculo[0, 0+i] == null)
                {
                Console.Write("XX");
                }
                else
                {
                Console.Write(vehiculo[0, i+0].abreviacion);
                }
                Console.Write("   ");
            }

            Console.WriteLine("");

            Console.WriteLine("           / /(__) || |                                     |");
            Console.Write("  ________/ / |OO| || | ");

            Console.Write("           ");
            for (int i = 0; i < 4; i++)
            {
                if (vehiculo[1, 0+i] == null)
                {
                Console.Write("XX");
                }
                else
                {
                Console.Write(vehiculo[1, i+0].abreviacion);
                }
                Console.Write("   ");
            }

            Console.WriteLine("");

            Console.WriteLine(" |         |-------|| |                                     |");
            Console.Write("(|         |     -.|| | ");

            Console.Write("           ");
            for (int i = 0; i < 4; i++)
            {
                if (vehiculo[2, 0+i] == null)
                {
                Console.Write("XX");
                }
                else
                {
                Console.Write(vehiculo[2, i+0].abreviacion);
                }
                Console.Write("   ");
            }

            Console.WriteLine("");

            Console.WriteLine(@" |  ____   \       ||_|                                     |");
            Console.WriteLine(@"/| / __ \   |______||                    / __ \   / __ \     ");
            Console.WriteLine(@"\|| /  \ |______________________________| /  \ |_| /  \ |___|");
            Console.WriteLine(@"   | () |                                | () |   | () |    ");
            Console.WriteLine(@"    \__/                                  \__/     \__/     ");
            Console.WriteLine("");

            int objetosSiendoAplastados = 0;

            if (vehiculo[1,0].abreviacion != vehiculo[2,0].abreviacion)
            {
                if (vehiculo[1,0].pesoDelObjeto > vehiculo[2,0].pesoDelObjeto)
            {
                Console.WriteLine("El objeto " + vehiculo[2,0].nombre + " está siendo aplastado.");
                objetosSiendoAplastados++;
                Console.WriteLine("");
            }
            }

            for (int i = 0; i < 2 ; i++)
            {
                if (vehiculo[i+0,1].abreviacion != vehiculo[i+1,1].abreviacion)
                {
                     if (vehiculo[i+0,1].pesoDelObjeto > vehiculo[i+1,1].pesoDelObjeto)
                    {
                     Console.WriteLine("El objeto " + vehiculo[i+1,1].nombre + " está siendo aplastado.");
                     Console.WriteLine("");
                     objetosSiendoAplastados++;
                    }
                }
            }
            
            if(((vehiculo[0,1].abreviacion != vehiculo[1,1].abreviacion) && (vehiculo[1,1].abreviacion != vehiculo[2,1].abreviacion)) && ((vehiculo[0,1].abreviacion == vehiculo[1,1].abreviacion) || (vehiculo[1,1].abreviacion == vehiculo[2,1].abreviacion)))
            {
            Console.WriteLine("De este/estos objetos aplastado/s, el objeto: " + vehiculo[2,1].nombre + ", está siendo aplastado por el peso sumado de los dos objetos que tiene arriba.");
            Console.WriteLine("");
            }


            for (int i = 0; i < 2 ; i++)
            {
                if (vehiculo[i+0,2].abreviacion != vehiculo[i+1,2].abreviacion)
                {
                     if (vehiculo[i+0,2].pesoDelObjeto > vehiculo[i+1,2].pesoDelObjeto)
                    {
                     Console.WriteLine("El objeto " + vehiculo[i+1,2].nombre + " está siendo aplastado.");
                     Console.WriteLine("");
                     objetosSiendoAplastados++;
                    }
                }
            }
            
            if(((vehiculo[0,2].abreviacion != vehiculo[1,2].abreviacion) && (vehiculo[1,2].abreviacion != vehiculo[2,2].abreviacion)) && ((vehiculo[0,2].abreviacion == vehiculo[1,2].abreviacion) || (vehiculo[1,2].abreviacion == vehiculo[2,2].abreviacion)))
            {
            Console.WriteLine("De este/estos objetos aplastado/s, el objeto: " + vehiculo[2,1].nombre + ", está siendo aplastado por el peso sumado de los dos objetos que tiene arriba.");
            Console.WriteLine("");
            }
            

            if (vehiculo[1,3].abreviacion != vehiculo[2,3].abreviacion)
            {
                if (vehiculo[1,3].pesoDelObjeto > vehiculo[2,3].pesoDelObjeto)
            {
                Console.WriteLine("El objeto " + vehiculo[2,3].nombre + " está siendo aplastado.");
                Console.WriteLine("");
                objetosSiendoAplastados++;
            }
            }


            if (objetosSiendoAplastados == 0)
            {
                Console.WriteLine("Ningún objeto fue aplastado, todo quedó bien acomodado.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("La cantidad total de objetos aplastados es de: " + objetosSiendoAplastados + " objetos.");
                Console.WriteLine("");
            }
        }
    }
}