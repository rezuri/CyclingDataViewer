using System.Xml.Serialization;

namespace CyclingDataViewer.GPX
{
    public class Trackpoint
    {
        [XmlElement("Time")]
        public string Time { get; set; }

        [XmlElement("HeartRateBpm")]
        public HeartRateBpm HeartRate { get; set; }

        [XmlElement("Cadence")]
        public string Cadence { get; set; }

        [XmlElement("Extensions")]
        public Extensions Extensions { get; set; }
    }

    public class HeartRateBpm
    {
        [XmlElement("Value")]
        public string Value { get; set; }
    }

    public class Extensions
    {
        [XmlElement(ElementName = "TPX", Namespace = "http://www.garmin.com/xmlschemas/ActivityExtension/v2")]
        public Tpx Tpx { get; set; }
    }

    public class Tpx
    {
        [XmlElement("Speed")]
        public string Speed { get; set; }

        [XmlElement("Watts")]
        public string Watts { get; set; }
    }
}
