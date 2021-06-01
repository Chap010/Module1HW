using System;

namespace Module1HW
{
    class Program
    {
        static void Main(string[] args)

        {


            MyMethod();
            Console.ReadLine();
          


        }

        public static void MyMethod()

        {
            string swSchool = "Cool Humble " + "Teachers";
            int computerLabs = 37;                                  // Total Computers systems
            int medicalLabs = 13;                                   // Total Medical Labs
            int result = medicalLabs * computerLabs;

            bool isItTrue = true;
            isItTrue = medicalLabs <= computerLabs;               // Comparing Is There enough
                                                                  

            Console.WriteLine(isItTrue + " There are Enough Computers For Students");
            Console.WriteLine(swSchool);
            Console.WriteLine(result + " Labs");                // multiply labs
            Console.WriteLine(result / 2 + " Labs");            // dividing labs
        }

    }

}






