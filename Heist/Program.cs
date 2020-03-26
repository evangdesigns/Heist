using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {

            var ATeam = new List<TeamMember>();
            var IsDone = false;
            
            while (!IsDone)
            {
                Console.WriteLine("Plan Your Heist");
                Console.WriteLine("What is Your Team Member's Name");
                var MemberName = Console.ReadLine();

                Console.WriteLine("What is Your Team Member's Skill Level");
                var SkillLevel = Console.ReadLine();

                string CourageFactor;
                bool IsCourageFactorOutOfRange;
                do
                {
                    Console.WriteLine("What is Your Team Member's Courage Factor (Please enter an decimal between 0.0 and 2.0)");
                    CourageFactor = Console.ReadLine();
                    IsCourageFactorOutOfRange = decimal.Parse(CourageFactor) < 0.0m || decimal.Parse(CourageFactor) > 2.0m;
                }
                while (IsCourageFactorOutOfRange);
                var TeamMember = new TeamMember(MemberName, SkillLevel, CourageFactor);
                ATeam.Add(TeamMember);

                Console.WriteLine("Do you know where your chidren are? Y/N");
                var answer = (Console.ReadLine());

                if (answer.ToLower() == "n")
                {
                    IsDone = true;
                }
            }

            Console.WriteLine(ATeam.Count);

            foreach(var teamMember in ATeam)
            {
                teamMember.AnnounceMember();
            }

            
        
        }
    }
}
