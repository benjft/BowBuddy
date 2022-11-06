using BowBuddy.Enums;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace BowBuddy.Models {
    [Table("round_template_section")]
    public class RoundTemplateSection {
        [PrimaryKey, AutoIncrement]
        public int? Id { get; set; }

        [ForeignKey(typeof(RoundTemplate))]
        public int RoundTemplateId { get; set; }
        
        public int Order { get; set; }
        
        public int Distance { get; set; }
        public LengthUnits DistanceUnits { get; set; } = LengthUnits.Meters;
        
        public int EndSize { get; set; }
        public int EndCount { get; set; }
        
        [ForeignKey(typeof(TargetFace))]
        public int TargetFaceId { get; set; }
        [ManyToOne]
        public TargetFace? TargetFace { get; set; }
        public int TargetFaceSize { get; set; }
        public LengthUnits TargetFaceSizeUnits { get; set; }
    }
}