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
            new Models.Degree {DegreeId=1, DegreeAbrrev = "ACS+2", DegreeName = "MS ACS +2" },
            new Models.Degree {DegreeId=2, DegreeAbrrev = "ACS+DB", DegreeName = "MS ACS +DB"},
            new Models.Degree {DegreeId=3, DegreeAbrrev = "ACS+NF", DegreeName ="MS ACS+NF"},
            new Models.Degree {DegreeId=4, DegreeAbrrev ="ACS", DegreeName  ="MS ACS" }

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
                    new Models.Requirement {RequirementId=460,RequirementAbbrev ="DB",RequirementName ="44-460 Database"},
        new Models.Requirement {RequirementId=356,RequirementAbbrev ="NF",RequirementName="44-356 Network Fundamemtals"},
        new Models.Requirement {RequirementId=542,RequirementAbbrev="OOP",RequirementName="44-542 OOP with Java"},
        new Models.Requirement {RequirementId=563,RequirementAbbrev="Web apps",RequirementName="44-563 Web apps"},
        new Models.Requirement {RequirementId=560,RequirementAbbrev="ADB",RequirementName="44-560 ADB"},
        new Models.Requirement {RequirementId=555,RequirementAbbrev="NS",RequirementName="44-555 Network Security"},
        new Models.Requirement {RequirementId=618,RequirementAbbrev="PM",RequirementName="44-618 PM"},
        new Models.Requirement {RequirementId=1,RequirementAbbrev="Mobile",RequirementName="44-643 or 44-644"},
new Models.Requirement {RequirementId=664,RequirementAbbrev="UX",RequirementName="44-664 UX"},
new Models.Requirement {RequirementId=10,RequirementAbbrev="E1",RequirementName="Elective 1"},
new Models.Requirement {RequirementId=20,RequirementAbbrev="E2",RequirementName="Elective 2"},
new Models.Requirement {RequirementId=691,RequirementAbbrev="GDP1",RequirementName="GDP1"},
new Models.Requirement {RequirementId=692,RequirementAbbrev="GDP2",RequirementName="GDP2"},


                };
                Console.WriteLine($"Inserted {requirements.Length} new Requirements");

                foreach (Models.Requirement r in requirements)
                {
                    context.Requirements.Add(r);
                }
                context.SaveChanges();

            }

            if (context.DegreeRequirements.Any())
            {
                Console.WriteLine(" DegreeRequirement already exist");
            }
            else
            {
                var DegreeRequirements = new Models.DegreeRequirement[]
                {
           new Models.DegreeRequirement {DegreeRequirementId=1,DegreeId=1,RequirementId=460, RequirementName="44-460 Database"},
new Models.DegreeRequirement {DegreeRequirementId=2,DegreeId=1,RequirementId=356, RequirementName="44-356 Network Fundamemtals"},
new Models.DegreeRequirement {DegreeRequirementId=3,DegreeId=1,RequirementId=542, RequirementName="44-542 OOP with Java"},
new Models.DegreeRequirement {DegreeRequirementId=4,DegreeId=1,RequirementId=563, RequirementName="44-563 Web apps"},
new Models.DegreeRequirement {DegreeRequirementId=5,DegreeId=1,RequirementId=560, RequirementName="44-560 ADB"},
new Models.DegreeRequirement {DegreeRequirementId=6,DegreeId=1,RequirementId=555, RequirementName="44-555 Network Security"},
new Models.DegreeRequirement {DegreeRequirementId=7,DegreeId=1,RequirementId=618, RequirementName="44-618 PM"},
new Models.DegreeRequirement {DegreeRequirementId=8,DegreeId=1,RequirementId=1, RequirementName="44-643 or 44-644"},
new Models.DegreeRequirement {DegreeRequirementId=9,DegreeId=1,RequirementId=664, RequirementName="44-664 UX"},
new Models.DegreeRequirement {DegreeRequirementId=10,DegreeId=1,RequirementId=10, RequirementName="Elective 1"},
new Models.DegreeRequirement {DegreeRequirementId=11,DegreeId=1,RequirementId=20, RequirementName="Elective 2"},
new Models.DegreeRequirement {DegreeRequirementId=12,DegreeId=1,RequirementId=691, RequirementName="GDP1"},
new Models.DegreeRequirement {DegreeRequirementId=13,DegreeId=1,RequirementId=692, RequirementName="GDP2"},
new Models.DegreeRequirement {DegreeRequirementId=14,DegreeId=2,RequirementId=460, RequirementName="44-460 Database"},
new Models.DegreeRequirement {DegreeRequirementId=15,DegreeId=2,RequirementId=542, RequirementName="44-542 OOP with Java"},
new Models.DegreeRequirement {DegreeRequirementId=16,DegreeId=2,RequirementId=563, RequirementName="44-563 Web apps"},
new Models.DegreeRequirement {DegreeRequirementId=17,DegreeId=2,RequirementId=560, RequirementName="44-560 ADB"},
new Models.DegreeRequirement {DegreeRequirementId=18,DegreeId=2,RequirementId=555, RequirementName="44-555 Network Security"},
new Models.DegreeRequirement {DegreeRequirementId=19,DegreeId=2,RequirementId=618, RequirementName="44-618 PM"},
new Models.DegreeRequirement {DegreeRequirementId=20,DegreeId=2,RequirementId=1, RequirementName="44-643 or 44-644"},
new Models.DegreeRequirement {DegreeRequirementId=21,DegreeId=2,RequirementId=664, RequirementName="44-664 UX"},
new Models.DegreeRequirement {DegreeRequirementId=22,DegreeId=2,RequirementId=10, RequirementName="Elective 1"},
new Models.DegreeRequirement {DegreeRequirementId=23,DegreeId=2,RequirementId=20, RequirementName="Elective 2"},
new Models.DegreeRequirement {DegreeRequirementId=24,DegreeId=2,RequirementId=691, RequirementName="GDP1"},
new Models.DegreeRequirement {DegreeRequirementId=25,DegreeId=2,RequirementId=692, RequirementName="GDP2"},
new Models.DegreeRequirement {DegreeRequirementId=26,DegreeId=3,RequirementId=356, RequirementName="44-356 Network Fundamemtals"},
new Models.DegreeRequirement {DegreeRequirementId=27,DegreeId=3,RequirementId=542, RequirementName="44-542 OOP with Java"},
new Models.DegreeRequirement {DegreeRequirementId=28,DegreeId=3,RequirementId=563, RequirementName="44-563 Web apps"},
new Models.DegreeRequirement {DegreeRequirementId=29,DegreeId=3,RequirementId=560, RequirementName="44-560 ADB"},
new Models.DegreeRequirement {DegreeRequirementId=30,DegreeId=3,RequirementId=555, RequirementName="44-555 Network Security"},
new Models.DegreeRequirement {DegreeRequirementId=31,DegreeId=3,RequirementId=618, RequirementName="44-618 PM"},
new Models.DegreeRequirement {DegreeRequirementId=32,DegreeId=3,RequirementId=1, RequirementName="44-643 or 44-644"},
new Models.DegreeRequirement {DegreeRequirementId=33,DegreeId=3,RequirementId=664, RequirementName="44-664 UX"},
new Models.DegreeRequirement {DegreeRequirementId=34,DegreeId=3,RequirementId=10, RequirementName="Elective 1"},
new Models.DegreeRequirement {DegreeRequirementId=35,DegreeId=3,RequirementId=20, RequirementName="Elective 2"},
new Models.DegreeRequirement {DegreeRequirementId=36,DegreeId=3,RequirementId=691, RequirementName="GDP1"},
new Models.DegreeRequirement {DegreeRequirementId=37,DegreeId=3,RequirementId=692, RequirementName="GDP2"},
new Models.DegreeRequirement {DegreeRequirementId=38,DegreeId=4,RequirementId=542, RequirementName="44-542 OOP with Java"},
new Models.DegreeRequirement {DegreeRequirementId=39,DegreeId=4,RequirementId=563, RequirementName="44-563 Web apps"},
new Models.DegreeRequirement {DegreeRequirementId=40,DegreeId=4,RequirementId=560, RequirementName="44-560 ADB"},
new Models.DegreeRequirement {DegreeRequirementId=41,DegreeId=4,RequirementId=555, RequirementName="44-555 Network Security"},
new Models.DegreeRequirement {DegreeRequirementId=42,DegreeId=4,RequirementId=618, RequirementName="44-618 PM"},
new Models.DegreeRequirement {DegreeRequirementId=43,DegreeId=4,RequirementId=1, RequirementName="44-643 or 44-644"},
new Models.DegreeRequirement {DegreeRequirementId=44,DegreeId=4,RequirementId=664, RequirementName="44-664 UX"},
new Models.DegreeRequirement {DegreeRequirementId=45,DegreeId=4,RequirementId=10, RequirementName="Elective 1"},
new Models.DegreeRequirement {DegreeRequirementId=46,DegreeId=4,RequirementId=20, RequirementName="Elective 2"},
new Models.DegreeRequirement {DegreeRequirementId=47,DegreeId=4,RequirementId=691, RequirementName="GDP1"},
new Models.DegreeRequirement {DegreeRequirementId=48,DegreeId=4,RequirementId=692, RequirementName="GDP2" }

              


            };
                Console.WriteLine($"Inserted {DegreeRequirements.Length} new DegreeRequirements");

                foreach (Models.DegreeRequirement d in DegreeRequirements)
                {
                    context.DegreeRequirements.Add(d);
                }
                context.SaveChanges();

            }
            if (context.Students.Any())
            {
                Console.WriteLine(" Students already exist");
            }
            else
            {
                var Students = new Models.Student[]
                {
            new Models.Student{StudentId=531494,FirstName="Shivani",LastName="Busireddy",Snumber="S531494",NineOneNineNumber=919564348},
new Models.Student{StudentId=531503,FirstName="Santosh", LastName="Muchkur",Snumber="S531503",NineOneNineNumber=919561527},
new Models.Student{StudentId=531384,FirstName="Srimai Reddy", LastName="Yanala",Snumber="s531384",NineOneNineNumber=919561950},
new Models.Student{StudentId=533707,FirstName="Lakshmi Seshu",LastName="Kalvakuri",Snumber="s533707",NineOneNineNumber=919571235},
new Models.Student{StudentId=531507,FirstName="Vijay",LastName="Thupakala",Snumber="S531507",NineOneNineNumber=919564693},

                };
                Console.WriteLine($"Inserted {Students.Length} new degrees");

                foreach (Models.Student d in Students)
                {
                    context.Students.Add(d);
                }
                context.SaveChanges();

            }
            if (context.DegreePlans.Any())
            {
                Console.WriteLine(" DegreePlan already exist");
            }
            else
            {
                var DegreePlans = new Models.DegreePlan[]
                {
        new Models.DegreePlan{DegreePlanId=12,DegreeId=1,StudentId="S531494",DegreePlanAbbrev="NSO",DegreePlanName="No summer off"},
new Models.DegreePlan{DegreePlanId=13,DegreeId=1,StudentId="S531494",DegreePlanAbbrev="SO",DegreePlanName="summer off"},
new Models.DegreePlan{DegreePlanId=14,DegreeId=1,StudentId="s531507",DegreePlanAbbrev="SO",DegreePlanName="summer off"},
new Models.DegreePlan{DegreePlanId=15,DegreeId=1,StudentId="s531507",DegreePlanAbbrev="NSO",DegreePlanName="No summer off"},
new Models.DegreePlan{DegreePlanId=16,DegreeId=1,StudentId="s533707",DegreePlanAbbrev="SO",DegreePlanName="summer off"},
new Models.DegreePlan{DegreePlanId=17,DegreeId=1,StudentId="s533707",DegreePlanAbbrev="NSO",DegreePlanName="No summer off"},
new Models.DegreePlan{DegreePlanId=18,DegreeId=1,StudentId="s531384",DegreePlanAbbrev="NSO",DegreePlanName="No summer off"},
new Models.DegreePlan{DegreePlanId=19,DegreeId=1,StudentId="s531384",DegreePlanAbbrev="SO",DegreePlanName="summer off"},
new Models.DegreePlan{DegreePlanId=20,DegreeId=1,StudentId="S531503",DegreePlanAbbrev="NSO",DegreePlanName="No summer off"},
new Models.DegreePlan{DegreePlanId=21,DegreeId=1,StudentId="s531503",DegreePlanAbbrev="SO",DegreePlanName="summer off"},

                };
                Console.WriteLine($"Inserted {DegreePlans.Length} new DegreePlans");

                foreach (Models.DegreePlan d in DegreePlans)
                {
                    context.DegreePlans.Add(d);
                }
                context.SaveChanges();

            }


            if (context.DegreePlanTermRequirements.Any())
            {
                Console.WriteLine("DegreePlanTermRequirements already exist");
            }
            else
            {
                var degreePlanTermRequirements = new Models.DegreePlanTermRequirement[]
                {
                    new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=1,DegreePlanId=20,TermId=1,RequirementId=460},
                    new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=2,DegreePlanId=20,TermId=1,RequirementId=356},
                    new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=3,DegreePlanId=20,TermId=1,RequirementId=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=4,DegreePlanId=20,TermId=1,RequirementId=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=5,DegreePlanId=20,TermId=2,RequirementId=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=6,DegreePlanId=20,TermId=2,RequirementId=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=7,DegreePlanId=20,TermId=2,RequirementId=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=8,DegreePlanId=20,TermId=3,RequirementId=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=9,DegreePlanId=20,TermId=3,RequirementId=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=10,DegreePlanId=20,TermId=3,RequirementId=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=11,DegreePlanId=20,TermId=4,RequirementId=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=12,DegreePlanId=20,TermId=4,RequirementId=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=13,DegreePlanId=20,TermId=5,RequirementId=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=14,DegreePlanId=21,TermId=1,RequirementId=460},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=15,DegreePlanId=21,TermId=1,RequirementId=356},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=16,DegreePlanId=21,TermId=1,RequirementId=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=17,DegreePlanId=21,TermId=1,RequirementId=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=18,DegreePlanId=21,TermId=2,RequirementId=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=19,DegreePlanId=21,TermId=2,RequirementId=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=20,DegreePlanId=21,TermId=2,RequirementId=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=21,DegreePlanId=21,TermId=4,RequirementId=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=22,DegreePlanId=21,TermId=4,RequirementId=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=23,DegreePlanId=21,TermId=4,RequirementId=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=24,DegreePlanId=21,TermId=5,RequirementId=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=25,DegreePlanId=21,TermId=5,RequirementId=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=26,DegreePlanId=21,TermId=5,RequirementId=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=27,DegreePlanId=12,TermId=1,RequirementId=460},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=28,DegreePlanId=12,TermId=1,RequirementId=356},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=29,DegreePlanId=12,TermId=1,RequirementId=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=30,DegreePlanId=12,TermId=1,RequirementId=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=31,DegreePlanId=12,TermId=2,RequirementId=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=32,DegreePlanId=12,TermId=2,RequirementId=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=33,DegreePlanId=12,TermId=2,RequirementId=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=34,DegreePlanId=12,TermId=3,RequirementId=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=35,DegreePlanId=12,TermId=3,RequirementId=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=36,DegreePlanId=12,TermId=4,RequirementId=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=37,DegreePlanId=12,TermId=4,RequirementId=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=38,DegreePlanId=12,TermId=4,RequirementId=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=39,DegreePlanId=12,TermId=5,RequirementId=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=40,DegreePlanId=13,TermId=1,RequirementId=460},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=41,DegreePlanId=13,TermId=1,RequirementId=356},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=42,DegreePlanId=13,TermId=1,RequirementId=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=43,DegreePlanId=13,TermId=1,RequirementId=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=44,DegreePlanId=13,TermId=3,RequirementId=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=45,DegreePlanId=13,TermId=3,RequirementId=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=46,DegreePlanId=13,TermId=3,RequirementId=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=47,DegreePlanId=13,TermId=4,RequirementId=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=48,DegreePlanId=13,TermId=4,RequirementId=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=49,DegreePlanId=13,TermId=4,RequirementId=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=50,DegreePlanId=13,TermId=5,RequirementId=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=51,DegreePlanId=13,TermId=5,RequirementId=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=52,DegreePlanId=13,TermId=5,RequirementId=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=53,DegreePlanId=18,TermId=1,RequirementId=460},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=54,DegreePlanId=18,TermId=1,RequirementId=356},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=55,DegreePlanId=18,TermId=1,RequirementId=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=56,DegreePlanId=18,TermId=1,RequirementId=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=57,DegreePlanId=18,TermId=2,RequirementId=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=58,DegreePlanId=18,TermId=2,RequirementId=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=59,DegreePlanId=18,TermId=2,RequirementId=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=60,DegreePlanId=18,TermId=3,RequirementId=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=61,DegreePlanId=18,TermId=3,RequirementId=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=62,DegreePlanId=18,TermId=4,RequirementId=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=63,DegreePlanId=18,TermId=4,RequirementId=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=64,DegreePlanId=18,TermId=4,RequirementId=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=65,DegreePlanId=18,TermId=5,RequirementId=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=66,DegreePlanId=19,TermId=1,RequirementId=460},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=67,DegreePlanId=19,TermId=1,RequirementId=356},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=68,DegreePlanId=19,TermId=1,RequirementId=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=69,DegreePlanId=19,TermId=1,RequirementId=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=70,DegreePlanId=19,TermId=3,RequirementId=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=71,DegreePlanId=19,TermId=3,RequirementId=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=72,DegreePlanId=19,TermId=3,RequirementId=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=73,DegreePlanId=19,TermId=4,RequirementId=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=74,DegreePlanId=19,TermId=4,RequirementId=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=75,DegreePlanId=19,TermId=4,RequirementId=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=76,DegreePlanId=19,TermId=5,RequirementId=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=77,DegreePlanId=19,TermId=5,RequirementId=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=78,DegreePlanId=19,TermId=5,RequirementId=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=79,DegreePlanId=16,TermId=1,RequirementId=460},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=80,DegreePlanId=16,TermId=1,RequirementId=356},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=81,DegreePlanId=16,TermId=1,RequirementId=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=82,DegreePlanId=16,TermId=1,RequirementId=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=83,DegreePlanId=16,TermId=2,RequirementId=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=84,DegreePlanId=16,TermId=2,RequirementId=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=85,DegreePlanId=16,TermId=2,RequirementId=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=86,DegreePlanId=16,TermId=3,RequirementId=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=87,DegreePlanId=16,TermId=3,RequirementId=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=88,DegreePlanId=16,TermId=3,RequirementId=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=89,DegreePlanId=16,TermId=4,RequirementId=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=90,DegreePlanId=16,TermId=4,RequirementId=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=91,DegreePlanId=16,TermId=5,RequirementId=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=92,DegreePlanId=17,TermId=1,RequirementId=460},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=93,DegreePlanId=17,TermId=1,RequirementId=356},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=94,DegreePlanId=17,TermId=1,RequirementId=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=95,DegreePlanId=17,TermId=1,RequirementId=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=96,DegreePlanId=17,TermId=2,RequirementId=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=97,DegreePlanId=17,TermId=2,RequirementId=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=98,DegreePlanId=17,TermId=2,RequirementId=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=99,DegreePlanId=17,TermId=4,RequirementId=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=100,DegreePlanId=17,TermId=4,RequirementId=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=101,DegreePlanId=17,TermId=4,RequirementId=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=102,DegreePlanId=17,TermId=5,RequirementId=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=103,DegreePlanId=17,TermId=5,RequirementId=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=104,DegreePlanId=17,TermId=5,RequirementId=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=105,DegreePlanId=14,TermId=1,RequirementId=460},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=106,DegreePlanId=14,TermId=1,RequirementId=356},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=107,DegreePlanId=15,TermId=1,RequirementId=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=108,DegreePlanId=15,TermId=1,RequirementId=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=109,DegreePlanId=15,TermId=2,RequirementId=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=110,DegreePlanId=15,TermId=2,RequirementId=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=111,DegreePlanId=15,TermId=2,RequirementId=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=112,DegreePlanId=15,TermId=3,RequirementId=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=113,DegreePlanId=15,TermId=3,RequirementId=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=114,DegreePlanId=15,TermId=4,RequirementId=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=115,DegreePlanId=15,TermId=4,RequirementId=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=116,DegreePlanId=15,TermId=4,RequirementId=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=117,DegreePlanId=15,TermId=5,RequirementId=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=118,DegreePlanId=15,TermId=1,RequirementId=460},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=119,DegreePlanId=15,TermId=1,RequirementId=356},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=120,DegreePlanId=15,TermId=1,RequirementId=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=121,DegreePlanId=15,TermId=1,RequirementId=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=122,DegreePlanId=15,TermId=3,RequirementId=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=123,DegreePlanId=15,TermId=3,RequirementId=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=124,DegreePlanId=15,TermId=3,RequirementId=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=125,DegreePlanId=15,TermId=4,RequirementId=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=126,DegreePlanId=15,TermId=4,RequirementId=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=127,DegreePlanId=15,TermId=4,RequirementId=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=128,DegreePlanId=15,TermId=5,RequirementId=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=129,DegreePlanId=15,TermId=5,RequirementId=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=130,DegreePlanId=15,TermId=5,RequirementId=692},


                };
                Console.WriteLine($"Inserted {degreePlanTermRequirements.Length} new DegreePlanTermRequirement");

                foreach (Models.DegreePlanTermRequirement dp in degreePlanTermRequirements)
                {
                    context.DegreePlanTermRequirements.Add(dp);
                }
                context.SaveChanges();

            }

            

            

             if (context.StudentTerms.Any())
            {
                Console.WriteLine(" StudentTerms already exist");
            }
            else
            {
                var StudentTerms = new Models.StudentTerm[]
                {
           new Models.StudentTerm{StudentTermId=1,StudentId=531494,TermId=1,TermAbbrev="S18",TermLabel="Spring 2018"},
new Models.StudentTerm{StudentTermId=2,StudentId=531494,TermId=2,TermAbbrev="Su18",TermLabel="Summer 2018"},
new Models.StudentTerm{StudentTermId=3,StudentId=531494,TermId=3,TermAbbrev="F18",TermLabel="Fall 2018"},
new Models.StudentTerm{StudentTermId=4,StudentId=531494,TermId=4,TermAbbrev="S19",TermLabel="Spring 2019"},
new Models.StudentTerm{StudentTermId=5,StudentId=531494,TermId=5,TermAbbrev="Su19",TermLabel="Summer2019"},
new Models.StudentTerm{StudentTermId=6,StudentId=531503,TermId=1,TermAbbrev="F17",TermLabel="Fall 2017"},
new Models.StudentTerm{StudentTermId=7,StudentId=531503,TermId=2,TermAbbrev="S18",TermLabel="Spring 2018"},
new Models.StudentTerm{StudentTermId=8,StudentId=531503,TermId=3,TermAbbrev="Su18",TermLabel="Summer 2018"},
new Models.StudentTerm{StudentTermId=9,StudentId=531503,TermId=4,TermAbbrev="F18",TermLabel="Fall 2018"},
new Models.StudentTerm{StudentTermId=10,StudentId=531503,TermId=5,TermAbbrev="S19",TermLabel="Spring 2019"},
new Models.StudentTerm{StudentTermId=11,StudentId=531384,TermId=1,TermAbbrev="S18",TermLabel="Fall 2019"},
new Models.StudentTerm{StudentTermId=12,StudentId=531384,TermId=2,TermAbbrev="Su18",TermLabel="Spring 2020"},
new Models.StudentTerm{StudentTermId=13,StudentId=531384,TermId=3,TermAbbrev="F18",TermLabel="Summer 2020"},
new Models.StudentTerm{StudentTermId=14,StudentId=531384,TermId=4,TermAbbrev="S19",TermLabel="Fall 2020"},
new Models.StudentTerm{StudentTermId=15,StudentId=531384,TermId=5,TermAbbrev="Su19",TermLabel="Spring 2021"},
new Models.StudentTerm{StudentTermId=16,StudentId=533707,TermId=1,TermAbbrev="F18",TermLabel="Fall 2018"},
new Models.StudentTerm{StudentTermId=17,StudentId=533707,TermId=2,TermAbbrev="S19",TermLabel="spring 2019"},
new Models.StudentTerm{StudentTermId=18,StudentId=533707,TermId=3,TermAbbrev="Su19",TermLabel="summer 2019"},
new Models.StudentTerm{StudentTermId=19,StudentId=533707,TermId=4,TermAbbrev="F19",TermLabel="Fall 2019"},
new Models.StudentTerm{StudentTermId=20,StudentId=533707,TermId=5,TermAbbrev="S20",TermLabel="Spring 2020"},
new Models.StudentTerm{StudentTermId=21,StudentId=531507,TermId=1,TermAbbrev="S19",TermLabel="Spring 2019"},
new Models.StudentTerm{StudentTermId=22,StudentId=531507,TermId=2,TermAbbrev="Su19",TermLabel="Summer 2019"},
new Models.StudentTerm{StudentTermId=23,StudentId=531507,TermId=3,TermAbbrev="F19",TermLabel="Fall 2019"},
new Models.StudentTerm{StudentTermId=24,StudentId=531507,TermId=4,TermAbbrev="S20",TermLabel="Spring 2020"},
new Models.StudentTerm{StudentTermId=25,StudentId=531507,TermId=5,TermAbbrev="Su20",TermLabel="Summer 2020"},


                };
                Console.WriteLine($"Inserted {StudentTerms.Length} new StudentTerms");

                foreach (Models.StudentTerm d in StudentTerms)
                {
                    context.StudentTerms.Add(d);
                }
                context.SaveChanges();

            }



        }
    }
}
