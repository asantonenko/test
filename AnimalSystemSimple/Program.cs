using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalSystemSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat("Mr. Mistoffelees"));
            animals.Add(new Cat("Missy"));
            animals.Add(new Dog("Lassie"));
            Console.WriteLine("Let's talk");
            try
            {
                for (int counter=1; counter <=10; counter++)
                {
                    Console.WriteLine("  ***  Turn  {0}  ****", counter);
                    foreach (Animal animal in animals)
                        Console.WriteLine("{0}: {1}", animal, animal.talk());
                    animals.Sort(); 
                    //Animal should implement IComparable, otherwise runtime error
                }    
            }
            catch(Exception e)
            {
                Console.WriteLine("Some error occurs: {0}", e.Message);
            }
        }
    }
}
