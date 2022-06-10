using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Models
{
	public class Value
	{
		public int Id { get; set; }
		public string Sku { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public string Notes { get; set; } = string.Empty;
		public decimal Score { get; set; }
		public bool IsAccepted { get; set; }

		public int TypeId { get; set; }
		[JsonIgnore]
		public virtual Type? Type { get; set; }

		
	}
}	