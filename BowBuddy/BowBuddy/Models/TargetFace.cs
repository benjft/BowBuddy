using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace BowBuddy.Models {
    [Table("target_face")]
    public class TargetFace {
        [PrimaryKey, AutoIncrement]
        public int? Id { get; set; }

        public string Name { get; set; } = "";

        [OneToMany]
        public List<TargetFaceZone> Zones { get; set; } = new List<TargetFaceZone>();
    }
}