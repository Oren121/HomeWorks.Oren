using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWorks
{
    public class HW4
    {
        public static void Run()
        {
            #region Targil 1 CustomerType
            /*Console.WriteLine("product Price?");
            double productPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("customer type?");
            Console.WriteLine("1) Regular");
            Console.WriteLine("2) Subscriber");
            Console.WriteLine("3) Gold");
            CustomerType customer = CustomerType.temp;
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    customer = CustomerType.Regular;
                    break;
                case "2":
                    customer = CustomerType.Subscriber;
                    break;
                case "3":
                    customer = CustomerType.Gold;
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            if (customer != CustomerType.temp)
            {
                double price = DiscountCalc(customer, productPrice);
                Console.WriteLine($"product price after discount is: {price}");
            }*/
            #endregion
            StudentGradesManager();

        }

        private static double DiscountCalc(CustomerType customer, double productPrice)
        {

            double Discount = (double)customer;
            double DiscountPrice = productPrice - (Discount / 100 * productPrice);
            return DiscountPrice;
        }

        static void StudentGradesManager()
        {
            List<string> CountriesList = new List<string>();
            bool showMenu = true;
            List<string> IdsList = new List<string>() { "1234567", "4345345", "2343434" };
            List<string> NamesList = new List<string>() { "Dani Shovevani", "Gabi Gabot", "Uri Buri" };
            List<int> GradesList = new List<int>() { 95, 100, 88 };
            List<StudentType> TypeList = new List<StudentType>() { StudentType.InnerStudent, StudentType.ExternalStudent, StudentType.InnerStudent };

            while (showMenu)
            {
                showMenu = StudentMainMenu(IdsList, NamesList, GradesList, TypeList);
            }
        }
        private static bool StudentMainMenu(List<string> IdsList, List<string> NamesList, List<int> GradesList, List<StudentType> TypeList)
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
                    if (NewStudent.Count == 3)
                    {
                        IdsList.Add(NewStudent[0]);
                        NamesList.Add(NewStudent[1]);
                        GradesList.Add(0);
                        object NewType;
                        if (Enum.TryParse(typeof(StudentType), NewStudent[2], out NewType))
                        {
                            TypeList.Add((StudentType)NewType);
                        }

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
                    ReadGrades(IdsList, NamesList, GradesList, TypeList);
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
                        TypeList.RemoveAt(IndexToRemove);
                    }
                    Console.WriteLine("--------------");

                    return true;
                case "5":
                    PrintByName(IdsList, NamesList, GradesList, TypeList);
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

        private static void PrintByName(List<string> idsList, List<string> namesList, List<int> gradesList, List<StudentType> TypeList)
        {
            Console.WriteLine("Enter Student name to print:");
            string UserInput = Console.ReadLine();
            if (namesList.Contains(UserInput))
            {
                int IndexToprint = namesList.FindIndex(x => x == UserInput);

                Console.Write($"IdList          NamesList:         Grade:");
                Console.WriteLine();
                Console.Write($"{idsList[IndexToprint]}          {namesList[IndexToprint]}         {gradesList[IndexToprint]}          {TypeList[IndexToprint]}");
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
                Console.WriteLine("--------------");
                return -1;
            }

        }

        private static void ReadGrades(List<string> idsList, List<string> namesList, List<int> gradesList, List<StudentType> TypeList)
        {
            Console.Write($"IdList          NamesList:         Grade:            Student Type:");
            for (int i = 0; i < idsList.Count; i++)
            {
                Console.WriteLine();
                Console.Write($"{idsList[i]}          {namesList[i]}         {gradesList[i]}          {TypeList[i]}");
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
                    Console.WriteLine("--------------");
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
                    Console.WriteLine("--------------");
                    return newstudent;
                }

            }
            Console.WriteLine("Student name?");
            string StudentName = Console.ReadLine();
            Console.WriteLine("Student type?");
            Console.WriteLine("1) External Student");
            Console.WriteLine("2) Inner Student");
            string StudentTypeInp = Console.ReadLine();
            switch (StudentTypeInp)
            {
                case "1":
                    if (StudentID.Length > 1 && StudentName.Length > 1)
                    {
                        StudentTypeInp = StudentType.ExternalStudent.ToString();
                        newstudent.Add(StudentID);
                        newstudent.Add(StudentName);
                        newstudent.Add(StudentTypeInp);
                        return newstudent;
                    }
                    break;
                case "2":
                    if (StudentID.Length > 1 && StudentName.Length > 1)
                    {
                        StudentTypeInp = StudentType.ExternalStudent.ToString();
                        newstudent.Add(StudentID);
                        newstudent.Add(StudentName);
                        newstudent.Add(StudentTypeInp);
                        return newstudent;
                    }
                    break;
                default:
                    return newstudent;
            }
            return newstudent;
        }
    }
    public enum CustomerType
    {
        Regular = 10,
        Subscriber = 25,
        Gold = 35,
        temp,
    }
    public enum StudentType
    {
        ExternalStudent,
        InnerStudent,
        temp,
    }

}
