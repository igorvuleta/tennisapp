using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TennisAppV2.Src.Common.Models
{
    [Table("Court")]
    public class Court
    {
        [PrimaryKey, AutoIncrement]
        public int _Id { get; set; }
        public string CourtName { get; set; }
        public string CourtAdress { get; set; }
        public string CourtCountry { get; set; }
        public DateTime DateEstablished { get; set; }
        public string CourtType { get; set; }

    }
}
