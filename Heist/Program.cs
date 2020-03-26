using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");
            Console.WriteLine("Enter the Bank Difficulty Level");
            var BankDifficultyLevel = int.Parse(Console.ReadLine());


            var ATeam = new List<TeamMember>();
            var IsDone = false;
            
            while (!IsDone)
            {
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

                Console.WriteLine("Would you like to add another team member? Y/N");
                var answer = (Console.ReadLine());

                if (answer.ToLower() == "n")
                {
                    IsDone = true;
                }
            }
            Console.WriteLine("Hey yo bitch, how many time you wanna do dis thang?");
            var YoBitch = Console.ReadLine();

            var SuccessfulRun = 0;
            var FailedRun = 0;

            for (int i = 0; i < int.Parse(YoBitch); i++)
            {
                Random random = new Random();
                var luckValue = random.Next(-10, 11);

                var NewBankDifficultyLevel = BankDifficultyLevel + luckValue;
                int TotalSkillLevel = 0;
                foreach (var teamMember in ATeam)
                {
                    TotalSkillLevel += int.Parse(teamMember.SkillLevel);
                }

                Console.WriteLine($"Your Team's combined skill level is {TotalSkillLevel} and the difficulty level is {NewBankDifficultyLevel}");

                if (NewBankDifficultyLevel <= TotalSkillLevel)
                {
                    
                    SuccessfulRun += 1;
                }
                else
                {
                    FailedRun += 1;
                }
            }

            Console.WriteLine(@$"You successfully passed {SuccessfulRun} times.
And you just plain sucked {FailedRun} times.");

            Console.ReadLine();
        }
    }
}