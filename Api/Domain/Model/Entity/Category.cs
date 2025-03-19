using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model.Entity
{
    [Table("Category")]
    public class Category : BaseEntity
    {

        #region Public properties

        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; } = string.Empty;

        #endregion


        #region Relation

        //[JsonIgnore]
        //public ICollection<Category> Categories { get; set; } = null!;

        #endregion

    }
}
