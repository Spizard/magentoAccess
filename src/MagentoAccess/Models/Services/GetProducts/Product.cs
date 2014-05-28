﻿namespace MagentoAccess.Models.Services.GetProducts
{
	public class Product
	{
		public string EntityId { get; set; }
		public string Sku { get; set; }
		public decimal Price { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}