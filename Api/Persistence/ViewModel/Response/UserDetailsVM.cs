namespace Persistence.ViewModel.Response
{
    public class UserDetailsVM
    {

        /// <summary>
        /// Id of the record
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the user
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Email of the user
        /// </summary>
        public string Email { get; set; } = string.Empty;

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
    }
}
