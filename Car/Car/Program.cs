using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
      
            static void Main(string[] args)
            {
                Car auto = new Car();
            auto.namemark = "BMW";
            auto.age = 10 ;
            auto.type = "Saloon";
            auto.weight = 2;
            auto.color = "grey";
            auto.Info();

                Console.ReadKey();

            }
        }
    }
    class Car
    {
        public string namemark;
        public int age;
        public string type;
        public int weight;
        public string color;







        public void Info()
        {
            Console.WriteLine($"{namemark} - {age} - {type} - {weight} - {color}");
        }
    }

