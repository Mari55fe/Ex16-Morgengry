using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
    public class CourseRepository
    {
        
        private List<Course> courses;

        public CourseRepository()
        {
            courses = new List<Course>();
        }
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string itemId)
        {
            Course resultat = null;

            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Name.Equals(itemId))
                {
                    resultat = courses[i];
                }
            }
            return resultat;
        }
        public double GetTotalValue()
        {
            double total = 0;

            for (int i = 0; i < courses.Count; i++)
            {
                total += Utility.GetValueOfCourse(courses[i]); //+= betyder at man lægger til
            }
            return total;
        }
    
    }
}
