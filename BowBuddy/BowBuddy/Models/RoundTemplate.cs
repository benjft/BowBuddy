using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace BowBuddy.Models {
    
    public class RoundTemplate {
        [PrimaryKey, AutoIncrement]
        public int? Id { get; set; }
        
        public string RoundName { get; set; } = "";
        
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<RoundTemplateSection> Sections { get; set; } = new List<RoundTemplateSection>();
    }
}