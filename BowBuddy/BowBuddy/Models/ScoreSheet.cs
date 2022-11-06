using System;
using System.Collections.Generic;
using System.ComponentModel;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace BowBuddy.Models {
    [Table("score_sheet")]
    public class ScoreSheet {
        [PrimaryKey]
        [AutoIncrement]
        [ReadOnly(true)]
        public int? Id { get; set; }

        public string Title { get; set; } = "";

        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}