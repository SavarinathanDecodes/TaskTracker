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
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Email of the user
        /// </summary>
        public string Email { get; set; } = string.Empty;

        #endregion
    }
}
