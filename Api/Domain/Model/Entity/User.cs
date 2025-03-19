using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model.Entity
{
    /// <summary>
    /// Entity for maintain user details
    /// </summary>
    [Table("User")]
    public class User : BaseEntity
    {
        #region Public properties

        /// <summary>
        /// Name of the user
        /// </summary>
        [Column(TypeName = ("VARCHAR(50)"))]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Email of the user
        /// </summary>
        [Column(TypeName = ("VARCHAR(50)"))]
        public string Email { get; set; } = string.Empty;

        #endregion

        #region Relation

        //[JsonIgnore]
        //public ICollection<User> Users { get; set; } = null!;

        #endregion
    }
}
