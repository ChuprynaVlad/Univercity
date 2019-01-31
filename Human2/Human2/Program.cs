using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human tom = new Human();
            tom.name = "Tom";
            tom.age = 22;
            tom.sex = "male";
            tom.weight = 75;
            tom.Info();

                Console.ReadKey();
          
        }
    }
}
class Human
{
   public string name;
    public int age;
    public string sex;
    public int weight;
    




    public void Info()
    {
        Console.WriteLine($"{name} - {age} - {sex} - {weight}");
    }
}
