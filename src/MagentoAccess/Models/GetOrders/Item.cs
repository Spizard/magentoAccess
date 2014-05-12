﻿namespace MagentoAccess.Models.GetOrders
{
	public class Item
	{
		public string ItemId { get; set; }
		public string ParentItemId { get; set; }
		public string Sku { get; set; }
		public string Name { get; set; }
		public decimal QtyCanceled { get; set; }
		public decimal QtyInvoiced { get; set; }
		public decimal QtyOrdered { get; set; }
		public decimal QtyRefunded { get; set; }
		public decimal QtyShipped { get; set; }
		public decimal Price { get; set; }
		public decimal BasePrice { get; set; }
		public decimal OriginalPrice { get; set; }
		public decimal BaseOriginalPrice { get; set; }
		public decimal TaxPercent { get; set; }
		public decimal TaxAmount { get; set; }
		public decimal BaseTaxAmount { get; set; }
		public decimal DscountAmount { get; set; }
		public decimal BaseDiscountAmount { get; set; }
		public decimal RowTotal { get; set; }
		public decimal BaseRowTotal { get; set; }
		public decimal PriceInclTax { get; set; }
		public decimal BasePriceInclTax { get; set; }
		public decimal RawTotalInclTax { get; set; }
		public decimal BaseRowTotalInclTax { get; set; }
	}
}