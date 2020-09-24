
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Alliances;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Alliances.Boss
{
	[MessagePackObject]
	// [RemovedJson]
	public class AllianceBossType
	{
		// Fields
		[Json]
		// [Key]
		public AllianceBossTypeId Id;
		[Json]
		// [Key]
		public int Health;
		[Json]
		// [Key]
		public int HeroTypeId;
		[Json]
		// [Key]
		public int Level;
		[Json]
		// [Key]
		public Dictionary<AllianceBossDamageDealtRange, AllianceRewardTypeId> RewardTypeIdByRange;
		[Json]
		// [Key]
		public Dictionary<Element, int> StageIdByElement;
	
		// Constructors
		public AllianceBossType() {}
	}
}
