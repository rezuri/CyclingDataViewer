using System.Collections.Generic;
using System.Xml.Serialization;

namespace CyclingDataViewer.GPX
{
    public class Activity
    {
        [XmlAttribute("Sport")]
        public string Sport { get; set; }

        [XmlElement("Lap")]
        public Lap Lap { get; set; }

        [XmlElement("Id")]
        public string Id { get; set; }
    }

    public class Lap
    {
        [XmlElement("Track")]
        public Track Track { get; set; }
    }

    public class Track
    {
        [XmlElement("Trackpoint")]
        public List<Trackpoint> Trackpoint { get; set; }
    }

    [XmlRoot(ElementName = "TrainingCenterDatabase", Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public class TrainingCenterDatabase
    {
        [XmlElement("Activities")]
        public Activities Activities { get; set; }
    }

    public class Activities
    {
        [XmlElement("Activity")]
        public List<Activity> Activity { get; set; }
    }
}   
