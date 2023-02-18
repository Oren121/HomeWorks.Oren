using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWorks
{
    public enum CategoryEnum
    {
        General =0,
        QA = 1,
        DotNet = 2,
        DevOps = 3,
        Graphics = 4,
        WebMaster = 5
    }

    /// <summary>
    /// Course Class
    /// </summary>
    public class Course
    {
        //--Private Fields
        private int id;
        private string title;
        private string description;
        private CategoryEnum category;
        private List<string> students;

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="category"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="students"></param>
        public Course(int id, CategoryEnum category,string title,string description,List<string> students)
        {
            //Defaults Values
            //this because id is also in parameter of constructor
            this.id = id;
            id = ValidateId(id);
            Category = category;
            Title = title;
            Description = description;
            //Initialize List With new
            this.students = students;
        }

        private static int ValidateId(int id)
        {
            if (id < 0)
                id = 0;
            return id;
        }

        /// <summary>
        /// Default Empty Constructor
        /// </summary>
        public Course()
        {
            //Defaults Values
            id = 0;
            category = CategoryEnum.General;
            title = "";
            description = "";
            //Initialize List With new
            students = new List<string>();
        }


      /// <summary>
      /// 
      /// </summary>
        public int Id
        {
            get
            {
                return id;
            }

        }


        //public int Id { get => id; set => id = value; }

        /// <summary>
        /// Title Of Course Property
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        /// <summary>
        /// Description Of Course Property
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        /// <summary>
        /// Category Of Course Property
        /// </summary>
        public CategoryEnum Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        /// <summary>
        /// List Of Students Property
        /// </summary>
        public List<string> Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
            }
        }


        public int StudentsCount
        {
            get { return students.Count; }
        }

  

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string DisplayCourseInfo()
        {

            string courseInfoText = $"id:{id}\ntitle:{title}\ndesc:{description}\ncategory:{category}\n";
            courseInfoText += "Students:\n";
            int index = 0;
            foreach (string studentName in this.students)
            {
                index++;
                courseInfoText += " "+index +"."+ studentName + "\n";
            }
            return courseInfoText;
        }

    }
}
