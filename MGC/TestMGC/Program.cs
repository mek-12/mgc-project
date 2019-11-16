using MGC.DAL.Abstract;
using MGC.DAL.Concrete.EFCore;
using MGC.ENTITY.MProducts.MComputer;
using System;
using System.Reflection;

namespace TestMGC
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var repository = GeneratorRepository.GetRepositoryFromEntityName(typeof(Computer).ToString());

            Assembly assem = typeof(Program).Assembly;
            var computerType = typeof(Computer);
            var computerType2 = assem.GetType("MGC.ENTITY.MProducts.MComputer.Computer");
            /*
            if(repository == null)
            {
                Console.WriteLine(computerType.ToString());
                Console.WriteLine("It is null");
            }
            */
            Console.WriteLine(computerType);
            Console.WriteLine(computerType2);
            Console.ReadLine();
        }
    }
}
