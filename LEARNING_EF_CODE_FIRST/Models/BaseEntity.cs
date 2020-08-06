namespace Models

{
	public abstract class BaseEntity : object
	{
		public BaseEntity() : base()
		{
			Id = System.Guid.NewGuid();

			CreateDate = System.DateTime.Now;

			LastModifiedDate = System.DateTime.Now;

		}
		public System.Guid Id { get; set; }

		public System.DateTime CreateDate { get; set; }

		public System.DateTime LastModifiedDate { get; set; }
	}
}
