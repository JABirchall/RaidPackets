
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.MagicShop.Dtos
{
	[MessagePackObject]
	public class BuyItemRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
	
		// Constructors
		public BuyItemRequestDto() {}
	}
}
