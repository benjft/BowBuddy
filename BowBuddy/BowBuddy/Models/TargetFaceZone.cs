using SQLite;
using SQLiteNetExtensions.Attributes;

namespace BowBuddy.Models {
    [Table("target_face_zone")]
    public class TargetFaceZone {
        [PrimaryKey, AutoIncrement]
        public int? Id { get; set; }
        
        [ForeignKey(typeof(TargetFace))]
        public int TargetFaceId { get; set; }
        
        public int Order { get; set; }
        public int Score { get; set; }
        public double Radius { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double BoundaryWidth { get; set; }
        public int Colour { get; set; }
        public int BoundaryColour { get; set; }
    }
}