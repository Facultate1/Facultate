using MPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
namespace MpiNetHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            using (new MPI.Environment(ref args))
            {
                Console.WriteLine("I'm {0} of {1}",
                    MPI.Communicator.world.Rank,
                    MPI.Communicator.world.Size);
            }
        }
    }
}
*/

namespace MpiSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numere = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int suma = 0;

            using (new MPI.Environment(ref args))
            {
                Intracommunicator comm = MPI.Communicator.world;

                for (int proces = 0; proces <= comm.Size - 1; proces++)
                {
                    if (comm.Rank == 0)
                    {
                        for (int i = 1; i < comm.Size; i++)
                        {
                            suma += comm.Receive<int>(i, 0);
                        }

                        Console.WriteLine("Suma este: " + suma);
                    }
                }
            }
        }
    }
}