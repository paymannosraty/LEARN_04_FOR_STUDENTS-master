namespace Models
{
	public class Person : BaseEntity
	{
		public Person() : base()
		{
		}

		/// <summary>
		/// Age
		/// </summary>
		[System.ComponentModel.DataAnnotations.Range
			(minimum: 1, maximum: 100)]
		public int Age { get; set; }

		/// <summary>
		/// FullName
		/// </summary>
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		public string FullName { get; set; }

		/// <summary>
		/// IsSupervisor
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required]
		public bool IsSupervisor { get; set; }
	}
}
