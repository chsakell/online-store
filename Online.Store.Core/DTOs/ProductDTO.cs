using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online.Store.Core.DTOs
{
    public class ProductDTO
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "productId")]
        public string ProductId { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "mainCategory")]
        public string MainCategory { get; set; }

        [JsonProperty(PropertyName = "taxTarifCode")]
        public int TaxTarifCode { get; set; }

        [JsonProperty(PropertyName = "supplier")]
        public string Supplier { get; set; }

        [JsonProperty(PropertyName = "weightMeasure")]
        public decimal WeightMeasure { get; set; }

        [JsonProperty(PropertyName = "weightUnit")]
        public string WeightUnit { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "dateOfSale")]
        public DateTime DateOfSale { get; set; }

        [JsonProperty(PropertyName = "productPicUrl")]
        public string ProductPicUrl { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "uom")]
        public string UoM { get; set; }

        [JsonProperty(PropertyName = "currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        [JsonProperty(PropertyName = "width")]
        public decimal Width { get; set; }

        [JsonProperty(PropertyName = "depth")]
        public decimal Depth { get; set; }

        [JsonProperty(PropertyName = "height")]
        public decimal Height { get; set; }

        [JsonProperty(PropertyName = "dimUnit")]
        public string DimUnit { get; set; }
    }
}
