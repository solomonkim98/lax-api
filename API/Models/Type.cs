using System;
namespace API.Models
{
	public class Type
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;

		public virtual List<Value> Values { get; set; }
	}
}

