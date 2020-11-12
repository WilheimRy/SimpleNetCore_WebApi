using ForexAppApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForexAppApi.Data
{
    public class DbInitializer
    {
        public static void Initialize(ForexDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.ForexDetails.Any())
            {
                return;   // DB has been seeded
            }

            var forexDetails = new ForexDetail[]
            {
                //new Student{FirstName="Carson",Surname="Alexander", Age = 30, GradeLevel = 'A'},
                //new Student{FirstName="Meredith",Surname="Alonso",Age = 33, GradeLevel = 'B'},
                //new Student{FirstName="Arturo",Surname="Anand",Age = 31, GradeLevel = 'C'},
                //new Student{FirstName="Gytis",Surname="Barzdukas",Age = 29, GradeLevel = 'D'},
                //new Student{FirstName="Yan",Surname="Li",Age = 28, GradeLevel = 'A'},
                //new Student{FirstName="Peggy",Surname="Justice",Age = 27, GradeLevel = 'B'},
            };
            foreach (var fx in forexDetails)
            {
                context.ForexDetails.Add(fx);
            }
            context.SaveChanges();
        }
    }
}
