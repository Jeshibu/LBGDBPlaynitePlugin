﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace LBGDBMetadata.LaunchBox.Metadata
{
    [XmlRoot(ElementName = "GameAlternateName")]
    public class GameAlternateName
    {
        [Key]
        public int ID { get; set; }

        [XmlElement(ElementName = "DatabaseID")]
        public long DatabaseID { get; set; }
        public Game Game { get; set; }

        [XmlElement(ElementName = "AlternateName")]
        public string AlternateName { get; set; }

        [XmlElement(ElementName = "Region")]
        public string Region { get; set; }
    }
}