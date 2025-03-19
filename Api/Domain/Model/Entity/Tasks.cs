using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Model.Entity
{
    [Table("Task")]
    public class Tasks : BaseEntity
    {

        #region Public properties

        [ForeignKey("Priority")]
        [Column(TypeName = "INT")]
        public int PriorityId { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Title { get; set; } = string.Empty;

        [Column(TypeName = "VARCHAR(500)")]
        public string Discription { get; set; } = string.Empty;

        [Column(TypeName = "DATETIME")]
        public DateTime Startdate { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime TargetDate { get; set; }

        #endregion


        #region Relation

        //[JsonIgnore]
        //public ICollection<Tasks> Task { get; set; } = null!;

        [JsonIgnore]
        public virtual Priority Priority { get; set; } = null!;

        #endregion

    }
}
