using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Assignments
    {
        public string AssignmentId { get; }
        public double ScoreObtained { get; set; }
        public double MaxScore { get; set; }
        public Assignments(string assignmentId, double scoreObtained, double maxScore)
        {
            AssignmentId = assignmentId;
            ScoreObtained = scoreObtained;
            MaxScore = maxScore;
        }

        public override string ToString()
        {
            return $"Assignment ID: {AssignmentId}, Score Obtained: {ScoreObtained}, Max Score: {MaxScore}";
        }
    }
}

