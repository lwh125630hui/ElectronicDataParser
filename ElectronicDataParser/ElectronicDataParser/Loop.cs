using System.Collections.Generic;

namespace ElectronicDataParser
{
    class Loop
    {
        public int LoopId { get; set; }

        public List<Segment> segments = new List<Segment>();
    }
}
