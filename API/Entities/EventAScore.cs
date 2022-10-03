using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class EventAScore
    {
        public int Id { get; set; }
        public int ArcherId { get; set; }
        public string ArcherName { get; set; }
        public int TargetA { get; set; }
        public int TargetB { get; set; }
        public int TargetC { get; set; }
        public int TargetD { get; set; }
        public int TargetE { get; set; }
        public int TargetF { get; set; }

        public int GetTotalScoreA()
        {
            return TargetA + TargetB + TargetC + TargetD + TargetE + TargetF;
        }
    }
}