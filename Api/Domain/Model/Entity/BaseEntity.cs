using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model.Entity
{
    /// <summary>
    /// Common base entity
    /// </summary>
    public class BaseEntity
    {
        #region Public properties

        /// <summary>
        /// Id of the record
        /// </summary>
        [Key]
        [Column("Id", Order = 1, TypeName = "INT")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Who creating the record
        /// </summary>
        public string CreatedBy { get; set; } = string.Empty;

        /// <summary>
        /// When creating the record
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Who updating the record
        /// </summary>
        public string UpdatedBy { get; set; } = string.Empty;

        /// <summary>
        /// When updating the record
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        #endregion
    }
}
