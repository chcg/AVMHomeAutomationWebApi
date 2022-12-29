﻿using System.Xml.Serialization;

namespace AVMHomeAutomation
{
    public class Temperature
    {
        /// <summary>
        /// Value in 0.1 ° C, negative and positive values possible
        /// </summary>
        [XmlElement("celsius")]
        public XmlTemperature Celsius { get; set; }

        /// <summary>
        /// Value in 0.1 ° C, negative and positive values possible
        /// </summary>
        [XmlElement("offset")]
        public XmlTemperature Offset { get; set; }
    }
}
