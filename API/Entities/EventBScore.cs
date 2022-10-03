using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class EventBScore
    {
        public int Id { get; set; }
        public Archer Archer { get; set; }
        public int ArcherId { get; set; }
        public int TargetA { get; set; }
        public int TargetB { get; set; }
        public int TargetC { get; set; }
        public int TargetD { get; set; }
        public int TargetE { get; set; }
        public float TimePenalty { get; set; }
        public float GetTotalScoreB()
        {
            return (TargetA + TargetB + TargetC + TargetD + TargetE) - TimePenalty;
        }
    }
}