using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masters.Data
{
    public class DbInitializer
    {

        public static void Initialize(ApplicationDbContext context)
        {
            // context.Database.EnsureCreated();

            // Look for any students.
            if (context.Degrees.Any())
            {
                Console.WriteLine(" Degrees already exist");
            }
            else
            {
                var degrees = new Models.Degree[]
                {
            new Models.Degree {DegreeID=1, DegreeAbrrev = "ACS+2", DegreeName = "MS ACS +2" },
            new Models.Degree {DegreeID=2, DegreeAbrrev = "ACS+DB", DegreeName = "MS ACS +DB"},
            new Models.Degree {DegreeID=3, DegreeAbrrev = "ACS+NF", DegreeName ="MS ACS+NF"},
            new Models.Degree {DegreeID=4, DegreeAbrrev ="ACS", DegreeName  ="MS ACS" }

                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees");

                foreach (Models.Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();

            }
            if (context.Requirements.Any())
            {
                Console.WriteLine("Requirements already exist");
            }
            else
            {
                var requirements = new Models.Requirement[]
                {

           
                };
                Console.WriteLine($"Inserted {requirements.Length} new Requirements");

                foreach (Models.Requirement r in requirements)
                {
                    context.Degrees.Add(r);
                }
                context.SaveChanges();

            }



        }
    }
}
