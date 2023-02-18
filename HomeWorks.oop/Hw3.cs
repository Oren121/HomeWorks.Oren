using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWorks
{
    public class HW3
    {
        public static void Run()
        {

            //DrawRectangleBorder();
            //CreateList();
            //CountriesNamesManager();
            //StudentGradesManager();
            classwork();
        }

        private static void classwork()
        {
            Console.WriteLine("Enter float number");
            string UserInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(UserInput))
            {
                if (float.TryParse(UserInput, out float value))
                {
                    float Res = value * 100;
                    Console.WriteLine(Res + "%");
                }
                else
                {
                    Console.WriteLine("False input!");
                    classwork();
                }
            }
            else
            {
                Console.WriteLine("Must input something");
                classwork();
            }

        }

        static void StudentGradesManager()
        {
            List<string> CountriesList = new List<string>();
            bool showMenu = true;
            List<string> IdsList = new List<string>() { "1234567", "4345345", "2343434" };
            List<string> NamesList = new List<string>() { "Dani Shovevani", "Gabi Gabot", "Uri Buri" };
            List<int> GradesList = new List<int>() { 95, 100, 88 };

            while (showMenu)
            {
                showMenu = StudentMainMenu(IdsList, NamesList, GradesList);
            }
        }
        private static bool StudentMainMenu(List<string> IdsList, List<string> NamesList, List<int> GradesList)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add New Student to lists");
            Console.WriteLine("2) Update Grade for student");
            Console.WriteLine("3) Show all grades ");
            Console.WriteLine("4) Remove student");
            Console.WriteLine("5) Print student grade by name");
            Console.WriteLine("6) Clear console");
            Console.WriteLine("7) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    List<string> NewStudent = AddStudent(IdsList);
                    if (NewStudent.Count == 2)
                    {
                        IdsList.Add(NewStudent[0]);
                        NamesList.Add(NewStudent[1]);
                        GradesList.Add(0);
                        Console.WriteLine("--------------");

                    }
                    return true;
                case "2":
                    List<string> NewGrade = GradeUpdate(IdsList);
                    if (NewGrade.Count == 2)
                    {
                        int index = int.Parse(NewGrade[0]);
                        int Grade = int.Parse(NewGrade[1]);
                        GradesList[index] = Grade;
                        Console.WriteLine("--------------");
                    }
                    return true;
                case "3":
                    ReadGrades(IdsList, NamesList, GradesList);
                    Console.WriteLine();
                    Console.WriteLine("--------------");

                    return true;
                case "4":
                    int IndexToRemove = RemoveStudent(IdsList);
                    if (IndexToRemove > 0)
                    {
                        IdsList.RemoveAt(IndexToRemove);
                        NamesList.RemoveAt(IndexToRemove);
                        GradesList.RemoveAt(IndexToRemove);
                    }
                    Console.WriteLine("--------------");

                    return true;
                case "5":
                    PrintByName(IdsList, NamesList, GradesList);
                    Console.WriteLine("--------------");
                    return true;
                case "6":
                    Console.Clear();
                    return true;
                case "7":
                    return false;
                default:
                    return true;
            }
        }

        private static void PrintByName(List<string> idsList, List<string> namesList, List<int> gradesList)
        {
            Console.WriteLine("Enter Student name to print:");
            string UserInput = Console.ReadLine();
            if (namesList.Contains(UserInput))
            {
                int IndexToprint = namesList.FindIndex(x => x == UserInput);

                Console.Write($"IdList          NamesList:         Grade:");
                Console.WriteLine();
                Console.Write($"{idsList[IndexToprint]}          {namesList[IndexToprint]}         {gradesList[IndexToprint]}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Cound not find student name.");
                Console.WriteLine("--------------");

            }
        }
        private static int RemoveStudent(List<string> idsList)
        {
            Console.WriteLine("Enter Student ID to remove:");
            string UserInput = Console.ReadLine();
            if (idsList.Contains(UserInput))
            {


                int IndexToRemove = idsList.FindIndex(x => x == UserInput);
                return IndexToRemove;
            }
            else
            {
                Console.WriteLine("Cound not find student ID.");
                return -1;
            }

        }

        private static void ReadGrades(List<string> idsList, List<string> namesList, List<int> gradesList)
        {
            Console.Write($"IdList          NamesList:         Grade:");
            for (int i = 0; i < idsList.Count; i++)
            {
                Console.WriteLine();
                Console.Write($"{idsList[i]}          {namesList[i]}         {gradesList[i]}");
                Console.WriteLine();
            }
        }

        private static List<string> GradeUpdate(List<string> idsList)
        {
            List<string> UpdatedGrade = new List<string>();
            Console.WriteLine("Enter Student ID:");
            string StudentID = Console.ReadLine();
            if (StudentID != null)
            {
                int index = idsList.FindIndex(x => x == StudentID);
                if (index != -1)
                {
                    Console.WriteLine("Enter Student new grade:");
                    string NewGrade = Console.ReadLine();
                    if (int.TryParse(NewGrade, out int grade))
                    {
                        if (grade >= 0 && grade <= 100)
                        {
                            UpdatedGrade.Add(index.ToString());
                            UpdatedGrade.Add(NewGrade);
                            return UpdatedGrade;
                        }
                        else
                        {
                            Console.WriteLine("Grade has to be beteew 0-100");
                        }
                        return UpdatedGrade;
                    }
                    return UpdatedGrade;
                }
                else
                {
                    Console.WriteLine("Cound not find student ID.");
                    return UpdatedGrade;
                }
            }
            else { return UpdatedGrade; }
        }

        private static List<string> AddStudent(List<string> IdsList)
        {
            List<string> newstudent = new List<string>();
            Console.WriteLine("Student ID?");
            string StudentID = Console.ReadLine();
            if (StudentID != null)
            {
                if (IdsList.Contains(StudentID))
                {
                    Console.WriteLine("Student ID alreadt exist in the system!");
                    return newstudent;
                }

            }
            Console.WriteLine("Student name?");
            string StudentName = Console.ReadLine();
            if (StudentID.Length > 1 && StudentName.Length > 1)
            {
                newstudent.Add(StudentID);
                newstudent.Add(StudentName);
                return newstudent;
            }
            else { return newstudent; }
        }

        static void CountriesNamesManager()
        {
            List<string> CountriesList = new List<string>();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(CountriesList);
            }
        }
        private static bool MainMenu(List<string> CountriesList)
        {

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add new contry");
            Console.WriteLine("2) Remove contry");
            Console.WriteLine("3) Find coutry by first Letter");
            Console.WriteLine("4) Find coutry by full name");
            Console.WriteLine("5) Read full list");
            Console.WriteLine("6) Clear console");
            Console.WriteLine("7) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CountriesList = Add(CountriesList);
                    return true;
                case "2":
                    CountriesList = Remove(CountriesList);
                    return true;
                case "3":
                    SearchFirstLetter(CountriesList, false);
                    return true;
                case "4":
                    SearchFirstLetter(CountriesList, true);
                    return true;
                case "5":
                    ReadList(CountriesList);
                    return true;
                case "6":
                    Console.Clear();

                    return true;
                case "7":
                    return false;
                default:
                    return true;
            }
        }

        private static List<string> Add(List<string> CountriesList)
        {
            Console.WriteLine("Enter the contry you want to add: ");
            string newContry = Console.ReadLine();
            newContry = newContry.ToLower();
            newContry = char.ToUpper(newContry[0]) + newContry.Substring(1);

            if (!CountriesList.Contains(newContry))
            {
                CountriesList.Add(newContry);
                Console.WriteLine($"Contry {newContry} added to the list!");
                Console.WriteLine("--------------");
                return CountriesList;
            }
            else
            {
                Console.WriteLine("Contry already exists in the list!");
                Console.WriteLine("--------------");
                return CountriesList;
            }
        }
        private static List<string> Remove(List<string> CountriesList)
        {
            Console.WriteLine("Enter the contry you want to remove: ");
            string userInput = Console.ReadLine();
            if (userInput == null || userInput.Length == 0)
            {
                Console.WriteLine("Empty input!");
                Console.WriteLine("--------------");
                return CountriesList;
            }
            else
            {
                userInput = userInput.ToLower();
                userInput = char.ToUpper(userInput[0]) + userInput.Substring(1);
                if (CountriesList.Contains(userInput))
                {
                    CountriesList.Remove(userInput);
                    Console.WriteLine($"{userInput} has been removed");
                    Console.WriteLine("--------------");
                    return CountriesList;
                }
                else
                {
                    Console.WriteLine("Contry does not exists in the list!");
                    Console.WriteLine("--------------");
                    return CountriesList;
                }
            }
        }

        private static void SearchFirstLetter(List<string> CountriesList, bool fullName)
        {
            List<string> SearchRes = new();
            Console.WriteLine("Enter the search line:");
            string userInput = Console.ReadLine();
            if (userInput == null || userInput.Length == 0)
            {
                Console.WriteLine("Empty search input!");
                Console.WriteLine("--------------");
            }
            else
            {

                userInput = userInput.ToLower();
                userInput = char.ToUpper(userInput[0]) + userInput.Substring(1);
                if (fullName)
                {
                    SearchRes = CountriesList.FindAll(x => x == userInput);
                    if (SearchRes.Count > 0)
                    {
                        Console.WriteLine($"Found {userInput} in the list");
                        Console.WriteLine("--------------");

                    }
                    else
                    {
                        Console.WriteLine($"Could not find {userInput} in the list");
                        Console.WriteLine("--------------");

                    }
                }
                else
                {
                    if (userInput.Length == 1)
                    {
                        SearchRes = CountriesList.FindAll(x => x[0] == userInput[0]);
                        Console.WriteLine("--------------");
                        SearchRes.ForEach(x => Console.WriteLine(x));
                        Console.WriteLine("--------------");
                    }
                    else
                    {
                        Console.WriteLine("Must input only 1 letter");
                        Console.WriteLine("--------------");

                    }
                }


            }

        }
        private static void ReadList(List<string> CountriesList)
        {
            Console.WriteLine("--------------");
            for (int i = 0; i < CountriesList.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {CountriesList[i]}");
            }
            Console.WriteLine("--------------");
        }
        private static void CreateList()
        {
            List<object> list = new List<object>()
            { "Israel"  ,  95  ,   "Moshe" , 100 , "Oren", 90, "Matan" , 99, "Nissim", 80};
            int highestScore = 0;
            string bestStudent = "";
            int AVG = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(list[i] + "     ");
                    //is even
                }
                else
                {
                    Console.Write(list[i] + "     ");
                    int score = (int)list[i];
                    string student = (string)list[i - 1];
                    AVG += score;
                    if (score > highestScore)
                    {
                        highestScore = score;
                        bestStudent = student;
                    }
                    Console.WriteLine();
                    //is odd
                }
            }
            AVG = AVG / (list.Count / 2);
            Console.WriteLine($"average of all grades: {AVG}");
            Console.WriteLine($"student that have the best grade: {bestStudent}");
        }

        private static void DrawRectangleBorder()
        {
            Console.WriteLine("Enter Rectangle height");
            string heightInput = Console.ReadLine();
            Console.WriteLine("Enter Rectangle width");
            string widthInput = Console.ReadLine();
            Console.WriteLine("Enter Rectangle symbol filler");
            string symbolInput = Console.ReadLine();
            Console.WriteLine("Rectangle description? (full/empty)");
            string fullInput = Console.ReadLine();

            if (int.TryParse(heightInput, out int height) &&
                int.TryParse(widthInput, out int width) &&
                char.TryParse(symbolInput, out char tav))
            {
                if (height >= 2 && width >= 2)
                {
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (fullInput.ToLower() == "full")
                            {
                                Console.Write(tav);
                            }
                            else if (fullInput.ToLower() == "empty")
                            {
                                if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                                {
                                    Console.Write(tav);
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("False Rectangle description!");
                                Console.WriteLine("Please try again.");
                                DrawRectangleBorder();
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"hight:{height} X width:{width}");
                    if (fullInput.ToLower() == "full")
                    {
                        Console.WriteLine($"Area = {height * width}");
                    }
                    else if (fullInput.ToLower() == "empty")
                    {
                        Console.WriteLine($"perimeter  = {(height * 2) + (width * 2)}");
                    }


                }
                else
                {
                    Console.WriteLine("height or width cant be less then 2!");
                    DrawRectangleBorder();
                }
            }
            else
            {
                Console.WriteLine("One or more of the inputs is false!");
                Console.WriteLine("Please try again.");
                DrawRectangleBorder();
            }
        }
    }
}
