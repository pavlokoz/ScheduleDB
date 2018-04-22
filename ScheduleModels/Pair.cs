using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleModels
{
    public class Pair
    {
        public string Day { get; set; }

        public int NumberOfPair { get; set; }

        public string Type { get; set; }

        public string Subject { get; set; }

        public IList<string> Tutors { get; set; }

        public IList<string> Groups { get; set; }

        public IList<int> Auditoriums { get; set; }
    }
}
