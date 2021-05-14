using System;

namespace Module1HW
{
    class Program
    {
        static void Main(string[] args)
        {
            string swSchool = "Cool Humble " + "Teachers";
            int computerLabs = 37;                                  // Total Computers systems
            int medicalLabs = 13;                                   // Total Medical Labs
            int result = medicalLabs + computerLabs;                // Adding Both Totals


            Console.WriteLine(swSchool);
            Console.WriteLine(result);
            Console.WriteLine(result / 2);

            bool isItTrue = true;
            isItTrue = medicalLabs <= computerLabs;               // Comparing Is There enough Computers
            Console.WriteLine(isItTrue + " There are Enough Computers For Students");
        }  
    }

}



