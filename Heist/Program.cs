using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
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

            TeamMember.AnnounceMember();
        }
    }
}
