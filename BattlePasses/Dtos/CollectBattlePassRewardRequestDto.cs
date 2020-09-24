
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.BattlePasses;



namespace SharedModel.Meta.BattlePasses.Dtos
{
	[MessagePackObject]
	public class CollectBattlePassRewardRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int Level;
		[Json]
		// [Key]
		public BattlePassTypeId BattlePassTypeId;
	
		// Constructors
		public CollectBattlePassRewardRequestDto() {}
	}
}
