
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.BlackMarket;



namespace SharedModel.Meta.DevPopup
{
	[MessagePackObject]
	public class AddBlackMarketItemByKindIdRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public BlackMarketItemKindId KindId;
	
		// Constructors
		public AddBlackMarketItemByKindIdRequestDto() {}
	}
}
