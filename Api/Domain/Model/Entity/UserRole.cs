using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model.Entity
{
    public class UserRole : BaseEntity
    {

        #region Public properties

        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; } = string.Empty;

        #endregion


        #region Relation

        #endregion

    }
}
