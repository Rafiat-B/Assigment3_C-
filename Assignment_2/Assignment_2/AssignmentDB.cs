using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    internal class AssignmentDB
    {
        private static List<Assignments> assignments = new List<Assignments>();
        public static void AddScore(Assignments assignment)
        {
            if (assignments == null)
            {
                assignments = new List<Assignments>();
            }
            assignments.Add(assignment);
        }

        public static void RemoveScore(Assignments assignment)
        {
            assignments.Remove(assignment);
        }

        public static void UpdateScore(double oldScore, double newScore)
        {
            Assignments ass = assignments.Find(x => x.ScoreObtained == oldScore);
            if (ass == null)
            {
                MessageBox.Show("Input assignment id");
            }
            else
            {
                ass.ScoreObtained = newScore;
            }

        }
        public static List<Assignments> GetAll()
        {
            return assignments;
        }
    }
}
