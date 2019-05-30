using System.Collections.Generic;

namespace ElectronicDataParser
{
    class Element
    {
        public int elementId { get; set; }

        public List<SubElement> subElements = new List<SubElement>();

    }
}
