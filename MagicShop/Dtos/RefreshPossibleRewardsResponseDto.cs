
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.MagicShop;



namespace SharedModel.Meta.MagicShop.Dtos
{
	[MessagePackObject]
	public class RefreshPossibleRewardsResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public List<MagicShopItem> Items;
		[Json]
		// [Key]
		public DateTime LastRefreshTime;
	
		// Constructors
		public RefreshPossibleRewardsResponseDto() {}
	}
}
