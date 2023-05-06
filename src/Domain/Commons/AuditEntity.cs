﻿namespace Domain.Commons
{
	public abstract class AuditEntity
	{
		public DateTime Created { get; set; }

		public string CreatedBy { get; set; }

		public DateTime? LastModified { get; set; }

		public string LastModifiedBy { get; set; }
	}
}