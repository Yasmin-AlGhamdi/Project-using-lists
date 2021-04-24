using System;
using System.Collections.Generic;

namespace Project_2
{
    class Program
    {
        
        static int students(List<int> grades, int gradeSearch)
        {
            int counter = 0;
            foreach(var grade in grades)
            {
                if (grade == gradeSearch)
                {
                    counter++;
                }
            }
            return counter;
        }
        
        static void Main(string[] args)
        {
            List<string> studentName = new List<string>();
            List<int> studentGrade = new List<int>();
            string answer = "yes";


            while(answer=="yes" || answer=="Yes")
            {
              
                 Console.WriteLine("Student Name: ");
                 studentName.Add(Console.ReadLine());

                 Console.WriteLine("Student grade: ");
                 studentGrade.Add(int.Parse((Console.ReadLine())));

                 Console.WriteLine("Add another student? (Yes/No) ");
                 answer = Console.ReadLine();

            }
            if (answer == "no" || answer == "No")
            {
                for (int i = 0; i < studentName.Count; i++)
                {
                    Console.WriteLine("Student Name: " + studentName[i] + " Student Grade: " + studentGrade[i]);
                }


                Console.WriteLine("Enter the grade to search: ");
                int gradeSearch = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Number of students with grade {0} is: {1}", gradeSearch, students(studentGrade, gradeSearch));
            }
            else
                Console.WriteLine("Inavalid input");

            Console.ReadKey();
        }
    }
}
