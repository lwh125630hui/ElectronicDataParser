using System.Collections.Generic;

namespace ElectronicDataParser
{
    class Segment
    {
        public int SegmentId { get; set; }

        public List<Qualifier> qualifier = new List<Qualifier>();

        public List<Element> elements = new List<Element>();

    }
}
