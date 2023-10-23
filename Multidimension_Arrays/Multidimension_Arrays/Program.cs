namespace Multidimension_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] ford = { "Mustand", "F-150", "Explorer" };
            String[] chevy = { "Corvette", "Camaro", "Silverado" };
            String[] toyota = { "Corolla", "Camry", "Rav4" };
            String[] bmw = { "E-90", "Compact", "E-46" };


            String[,] parkingLot = { { "Mustand", "F-150", "Explorer" },
                                     { "Corvette", "Camaro", "Silverado" } ,
                                     { "Corolla", "Camry", "Rav4" },
                                     { "E-90", "Compact", "E-46" }
                                     };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";
            parkingLot[3, 1] = "GT";

            /*
            foreach (String car in parkingLot)
            {
                Console.WriteLine(car);

            }*/


            
            for (int i=0; i<parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i,j] + " ");
                }
                Console.WriteLine();
            }
            
            
        }
    }
}