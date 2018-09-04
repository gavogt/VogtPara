using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace VogtPara
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inform user of areas
            Console.WriteLine("We do work in the following areas...");

            // Areas of work
            foreach (var area in Enum.GetNames(typeof(AreaOfService)))
            {
                Console.WriteLine(area);
            }

            DisplayInfo("John Jacob", "Billy Carl", "Count Dracula");

        }

        /// <summary>
        /// A method that takes a generic array to loop through
        /// </summary>
        /// <typeparam name="T">A generic array</typeparam>
        /// <param name="info">Information provided</param>
        public static void DisplayInfo<T>(params T[] info)
        {
            // Display info on the information passed in
            foreach (var item in info)
            {
                Console.WriteLine(item);

            }
        }

        /// <summary>
        /// Enumerate through the states that the company does work
        /// </summary>
        enum AreaOfService
        {
            California,
            Delaware,
            Washington,
            West_Virginia

        }
    }
}
