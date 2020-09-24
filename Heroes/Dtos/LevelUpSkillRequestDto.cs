
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.BlackMarket;



namespace SharedModel.Meta.Heroes.Dtos
{
	[MessagePackObject]
	public class LevelUpSkillRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int HeroId;
		[Json]
		// [Key]
		public int[] HeroInventoryIds;
		[Json]
		// [Key]
		public BlackMarketItemId[] BmiTypeIds;
	
		// Constructors
		public LevelUpSkillRequestDto() {}
	}
}
