
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Products
{
	[MessagePackObject]
	public class ProductSettings
	{
		// Fields
		[Json]
		// [Key]
		public ProductPrice[] AndroidProductPrices;
		[Json]
		// [Key]
		public ProductPrice[] IosProductPrices;
	
		// Constructors
		public ProductSettings() {}
	}
}
