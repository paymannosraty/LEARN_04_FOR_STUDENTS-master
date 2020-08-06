namespace Models
{
    public class User : BaseEntity
    {
        public User() : base()
        {
        }
        /// <summary>
        /// FullName
        /// </summary>
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string FullName { get; set; }

        /// <summary>
        /// UserName
        /// </summary>
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 20)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string Username { get; set; }


    }
}
