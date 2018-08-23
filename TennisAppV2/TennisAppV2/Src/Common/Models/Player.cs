using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TennisAppV2.Src.Common.Models
{
    [Table("Player")]
    public class Player
    {
        [PrimaryKey, AutoIncrement]
        public int _Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
    }
}
