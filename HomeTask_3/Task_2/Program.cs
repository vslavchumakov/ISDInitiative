using System;
namespace Task_2
{
    #region Hometask_03_2
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Create a class that represents the class Classroom.
    // Create a class Pupil. In the body of the class create the methods
    // void Study(), void Read(), void Write(), void Relax().
    // Create 3 derived classes ExcelentPupil, GoodPupil, BadPupil  from the  base class Pupil
    // and redefine each of the methods, depending on the student's progress.
    // The class constructor ClassRoom accepts arguments of type Pupil, the class must consist of 4 students.
    // Provide the possibility that the user can pass 2 or 3 arguments.
    // Print out information about how all students of the ClassRoom class can learn, read, write, rest.
    //
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            // Create classroom with four pupils, user inputs three pupils 
            ClassRoom instanceClass1 = new ClassRoom
                    (
                      new BadPupil("Vasya Pupkin"),
                      new GoodPupil("Anna Vasechkina"),
                      new ExcelentPupil("Denis Vladimirov")
                    );
            // Display grade table of the class
            Console.WriteLine("Grade table of the class:");
            Console.WriteLine(new string('-', 10));
            instanceClass1.Study();
            Console.WriteLine(new string('-', 10));
            instanceClass1.Read();
            Console.WriteLine(new string('-', 10));
            instanceClass1.Write();
            Console.WriteLine(new string('-', 10));
            instanceClass1.Relax();
            //Delay
            Console.ReadKey();
        }
    }
}
