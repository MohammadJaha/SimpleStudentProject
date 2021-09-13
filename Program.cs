using System;

namespace SimpleStudentProject
{
    class SimpleStudentProject
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Students Marks Program");
            Console.WriteLine("");

            var names = new string[1];//array for names
            var marks = new double[1];//array for marks

            var TemNames = new string[1];//temporer array for names
            var TemMarks = new double[1];//temporer array for marks

            var number = 1;//array size

            var win = "";//passed or failed

            for (var i = 1; i != 0;)//entering infinte students
            {
                TemNames = new string[number];
                TemMarks = new double[number];

                if (number == 1)
                {
                }
                else
                {
                    for (var w = 0; w < (number - 1); w++)//save old array to temporer array
                    {
                        TemNames[w] = names[w];
                        TemMarks[w] = marks[w];
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("Enter 1 to add new Student or 0 to Exit");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (i == 1)
                {

                    names = new string[number]; //change arrays size
                    marks = new double[number];

                    for (var k = 0; k < number; k++)//save temporer array to new array
                    {
                        names[k] = TemNames[k];
                        marks[k] = TemMarks[k];
                    }

                    names[(number - 1)] = name();//add new name to the array
                    marks[(number - 1)] = mark();//add new mark to the array

                    number++;//array size +1

                }
                else if (i == 0)
                {

                }
                else
                {
                    Console.WriteLine("Worng Enter");
                }

            }
            if (number == 1)//if no entry
                Console.WriteLine("No Entry");
            else//printing reasults
            {
                Console.WriteLine("Name    Marks     Dgree");
                for (var r = 0; r < (number - 1); r++)
                {
                    if (marks[r] >= 60.0)//check if pass
                        win = "Passed";
                    else
                        win = "Failed";
                    Console.WriteLine("{0}    {1}     {2}", names[r], marks[r], win);//print
                }
            }

        }

        static String name()//Enter Student Name
        {
            Console.WriteLine("Please Enter Student Name");
            var a = Console.ReadLine();
            return a;

        }

        static double mark()
        {
            Console.WriteLine("Please Enter Student Mark");//Enter Student Mark
            var a = Convert.ToDouble(Console.ReadLine());
            return a;
        }
    }
}
