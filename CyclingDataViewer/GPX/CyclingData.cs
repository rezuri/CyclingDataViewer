using System;

namespace CyclingDataViewer.GPX
{
    public class CyclingData
    {
        public DateTime Time { get; set; }
        public int Cadence { get; set; }
        public int Heartrate { get; set; }
        public int Power { get; set; }
        public double Speed { get; set; }
    }
}
