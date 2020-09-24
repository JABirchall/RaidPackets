
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Alliances.Boss
{
	[MessagePackObject]
	// [RemovedJson]
	public class AllianceBoss
	{
		// Fields
		[Json]
		// [Key]
		public AllianceBossTypeId Id;
		[Json]
		// [Key]
		public int HealthLeft;
		[Json]
		// [Key]
		public int DamageTaken;
		[Json]
		// [Key]
		public Dictionary<long, AllianceBossShortInfo> AttackInfoByUserId;
		[Json]
		// [Key]
		public Element Element;
		[Json]
		// [Key]
		public long Revision;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool IsDefeated { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public AllianceBossType Type { get => default; }
	
		// Constructors
		public AllianceBoss() {}
	}
}
