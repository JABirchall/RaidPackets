
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Artifacts.Sets;



namespace SharedModel.Meta.Masteries
{
	[MessagePackObject]
	public class StaticMasteryData
	{
		// Fields
		[Json]
		// [Key]
		public Account.Resources ResetPrice;
		public const int BonusSourceArtifactSet = -1;
		[Json]
		// [Key]
		public MasterySettings Settings;
		[Json]
		// [Key]
		public List<MasteryType> MasteryTypes;
		[Json]
		// [Key]
		public List<MasteryLimit> MasteryLimits;
		[Json]
		// [Key]
		public Dictionary<int, ArtifactSetStatBonus> MasteryBonusById;
		[IgnoreMember]
		[JsonSkip]
		public int MaxMasteriesCount;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<MasteryPointType, int> MaxMasteryPoints;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, MasteryType> MasteryById;
	
		// Constructors
		public StaticMasteryData() {}
	
		// Methods
		public MasteryType GetMastery(int typeId, bool throwExceptionIfNotFound = true) => default;
		public void Cache() {}
	}
}
