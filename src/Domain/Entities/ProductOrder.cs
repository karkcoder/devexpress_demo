using Domain.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class ProductOrder : AuditEntity
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
		public int OrderId { get; set; }

		[MaxLength(50)]
		public string ProductName { get; set; }

		[MaxLength(300)]
		public string ProductDescription { get; set; }

		public float ProductPrice { get; set; }
		public int Quantity { get; set; }

		[MaxLength(50)]
		public string CustomerName { get; set; }

		[MaxLength(50)]
		public string CustomerEmail { get; set; }

		[MaxLength(50)]
		public string CustomerAddress { get; set; }

		[MaxLength(50)]
		public string CustomerCity { get; set; }

		[MaxLength(50)]
		public string CustomerState { get; set; }

		public int CustomerZip { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime ShippingDate { get; set; }

		[MaxLength(50)]
		public string ShippingMethod { get; set; }

		[MaxLength(50)]
		public string PaymentMethod { get; set; }

		[MaxLength(50)]
		public string PaymentStatus { get; set; }

		public float TaxRate { get; set; }
		public float ShippingCost { get; set; }
		public float TotalCost { get; set; }
	}
}