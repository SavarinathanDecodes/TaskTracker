using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model.Entity
{
    [Table("Priority")]
    public class Priority : BaseEntity
    {

        #region Public properties

        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; } = string.Empty;

        #endregion


        #region Relation

        //[JsonIgnore]
        //public ICollection<Priority> Priorities { get; set; } = null!;

        #endregion

    }
}
