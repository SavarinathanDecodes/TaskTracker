using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Model.Entity
{
    [Table("TaskByCategory")]
    public class TaskByCategory : BaseEntity
    {

        #region Public properties

        [ForeignKey("Category")]
        [Column(TypeName = ("INT"))]
        public int CategoryId { get; set; }

        [ForeignKey("Task")]
        [Column(TypeName = ("INT"))]
        public int TaskId { get; set; }

        #endregion


        #region Relation

        [JsonIgnore]
        public virtual Category Category { get; set; } = null!;

        [JsonIgnore]
        public virtual Tasks Task { get; set; } = null!;

        #endregion

    }
}
