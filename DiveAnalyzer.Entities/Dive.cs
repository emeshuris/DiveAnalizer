using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DiveAnalyzer.Entities
{
    public partial class Dive
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string Identifier { get; set; }
        public string Units { get; set; }
        public DateTime DiveStart { get; set; }
        public string DecoModel { get; set; }
        public List<DivePoint> DivePoints { get; set; }
    }

    public class DivePoint
    {
        public ushort Time { get; set; }

        /// <remarks/>
        public decimal Depth { get; set; }

        /// <remarks/>
        public decimal Pressure { get; set; }

        /// <remarks/>
        public string Alarm { get; set; }

        /// <remarks/>
        public object Extra { get; set; }

        /// <remarks/>
        public decimal Temperature { get; set; }

        /// <remarks/>
        public decimal PPO2 { get; set; }
        /// <remarks/>
        public byte NDT { get; set; }
    }
}
