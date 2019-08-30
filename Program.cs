using System;

namespace VarPratice
{
    class Program
    {
        static void Main(string[] args)
        {
          int myAge = 19; 
          int myBirthYear = 2000;
          string myHighSchoolName  = "Warhill High School";
          int yearIGraduated = 2019;
          string myMomName = "Karin";
          string myDadName = "Kevin";
          int numOfCredits = 13;
          string nameOfPrograms = "Mobile Application Development";
          string myFirstName = "Conor"; 
          string myLastName = "Doherty";



            Console.WriteLine("Hi my name is "+myFirstName +" " +myLastName + " and I am "+myAge + " years old"); 
            Console.WriteLine("");
            Console.WriteLine("I went to "+myHighSchoolName + " And I graduated in "+yearIGraduated + 
              " After that, I decided to come to NTID for college. Both my Mom "+myMomName + " and Dad "+myDadName + 
              "thought NTID would be a great choice for me.");

           
            Console.WriteLine("");
            Console.WriteLine("So now I'm a student here at RIT/NTID. I'm in the "+nameOfPrograms + " program, taking "+numOfCredits +
            " thats pretty crazy for someone who was born in "+myBirthYear );
        }
    }
}
