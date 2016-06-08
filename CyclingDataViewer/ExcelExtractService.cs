using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using CyclingDataViewer.GPX;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Rental.Model.Extraction;

namespace CyclingDataViewer
{
    public static class ExcelExtractService
    {


        public static List<CyclingData> OpenExcelWorkbook(string file)
        {
            var serializer = new XmlSerializer(typeof (TrainingCenterDatabase));
            TrainingCenterDatabase data;

            using (var fs = new FileStream(file, FileMode.Open))
            {
                data = (TrainingCenterDatabase) serializer.Deserialize(fs);
            }

            var mappedData = new List<CyclingData>();

            foreach (var act in data.Activities.Activity)
            {
                foreach (var track in act.Lap.Track.Trackpoint)
                {
                    mappedData.Add(new CyclingData
                    {
                        Time = DateTime.Parse(track.Time),
                        Cadence = int.Parse(track.Cadence),
                        Heartrate = int.Parse(track.HeartRate.Value),
                        Power = int.Parse(track.Extensions.Tpx.Watts),
                        Speed = double.Parse(track.Extensions.Tpx.Speed)
                    });
                }
            }

            return mappedData;
        }
    }
}
