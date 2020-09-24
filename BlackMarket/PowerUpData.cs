
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;
using SharedModel.Meta.Account;
using SharedModel.Meta.Artifacts;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class PowerUpData
	{
		// Fields
		[Json]
		// [Key]
		public ArtifactRankId RankId;
		[Json]
		// [Key]
		public StatKindId StatId;
		[Json]
		// [Key]
		public bool IsAbsolute;
		[Json]
		// [Key]
		public double MinValue;
		[Json]
		// [Key]
		public double MaxValue;
		[Json]
		// [Key]
		public double Step;
		[Json]
		// [Key]
		public Account.Resources SellPrice;
		[Json]
		// [Key]
		public Account.Resources UsePrice;
		[IgnoreMember]
		[JsonSkip]
		public List<double> PossibleValues;
	
		// Constructors
		public PowerUpData() {}
		public PowerUpData(ArtifactRankId rankId, StatKindId statId, bool isAbsolute, double minValue, double maxValue, double step, Account.Resources usePrice, Account.Resources sellPrice) {}
		public PowerUpData(ArtifactRankId rankId) {}
	
		// Methods
		public void Cache() {}
	}
}
