
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Heroes.Dtos
{
	[MessagePackObject]
	public class BuyInventorySlotsRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public ResourceTypeId BuyResourceType;
	
		// Constructors
		public BuyInventorySlotsRequestDto() {}
	}
}
