using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogtPara
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inform user of areas
            Console.WriteLine("We do work in the following areas: ");
            DisplayArea();

            Console.WriteLine("\nThe following have been added: ");
            DisplayInfo("John Jacob", "Billy Carl", "Count Dracula");

        }

        /// <summary>
        /// A method that takes a generic array to loop through
        /// </summary>
        /// <typeparam name="T">A generic array</typeparam>
        /// <param name="info">Information provided as an unspecified amount</param>
        public static void DisplayInfo<T>(params T[] info)
        {
            // Display info on the information passed in
            foreach (var item in info)
            {
                Console.WriteLine(item);

            }
        }

        /// <summary>
        /// The states that the company does work in
        /// </summary>
        enum AreaOfService
        {
            California,
            Delaware,
            Washington,
            West_Virginia

        }

        public static void DisplayArea()
        {
            // Areas of work
            foreach (var area in Enum.GetNames(typeof(AreaOfService)))
            {
                Console.WriteLine(area);
            }

        }
    }
}
