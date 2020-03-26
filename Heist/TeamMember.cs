using System;
using System.Collections.Generic;
using System.Text;

namespace Heist
{
    class TeamMember
    {

        public string Name { get; set; }
        public string SkillLevel { get; set; }
        string CourageFactor { get; set; }

        public TeamMember(string memberName, string skillLevel, string courageFactor)
        {
            Name = memberName;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }



        public void AnnounceMember()
        {
            Console.WriteLine($"Introducing {Name} who's skill level is a whopping {SkillLevel} and who's courage factor is {CourageFactor}");
        }
    }
}
