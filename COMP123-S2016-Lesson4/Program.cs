using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This is driver class(program.cs file)
 * Author:Chinatsu Kawakami
 * 
 * 
 */
namespace COMP123_S2016_Lesson4
{
    /**
     * This is the "driver class" for our Program
     * @class Program
     */
    public class Program
    {
        /**
         * The main metod for our driver class Program
         * 
         * @mathod Main
         * @pram {string()} args
         */
        static void Main(string[] args)
        {
           

         //create instance of the student

            Student tommy = new Student("Tommy",20,"123456");

           // tommy.Age = 20;
           //tommy.Name = "Tommy";
            tommy.SaysHello();
            Console.WriteLine();
            tommy.Studies();
            Console.WriteLine();
            //create instance of the teacher class
            Teacher tom = new Teacher("Tom",47,"T1234456789");
            tom.SaysHello();
            Console.WriteLine();
            tom.Teaches();
        }
    }
}
