
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Common.UserEdit;



namespace SharedModel.Meta.Account
{
	[MessagePackObject]
	public class Resources : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public readonly Dictionary<ResourceTypeId, double> RawValues;
		[JsonSkip]
		public static readonly Resources Zero;
		[JsonSkip]
		public static readonly IEnumerable<ResourceTypeId> ResourceTypes;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<ResourceTypeId, double> ToRawValues { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double Energy { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double Silver { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double Tokens { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double Arena3X3ShopCurrency { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double Arena3X3Tokens { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double Gems { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double AutoBattleTickets { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double MedalBronze { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double MedalSilver { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double MedalGold { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double AllianceBossKey { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<ResourceTypeId, double> ForgeMaterials { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double Magisteel { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double Corehammer { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double SoulstoneRare { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double SoulstoneEpic { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double SoulstoneLeg { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double BloodstoneRare { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double BloodstoneEpic { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double BloodstoneLeg { get => default; }
	
		// Constructors
		public Resources() {}
		[SerializationConstructor]
		public Resources(Dictionary<ResourceTypeId, double> v) {}
		private Resources(int bronze, int silver, int gold) {}
		public Resources(ResourceTypeId typeId, double value) {}
		public Resources(Resources other) {}
		static Resources() {}
	
		// Methods
		public ResourceTypeId GetSingle() => default;
		public Dictionary<ResourceTypeId, double> GetEssences() => default;
		public int GetLowEssencesCount() => default;
		public int GetMidEssencesCount() => default;
		public Dictionary<ResourceTypeId, double> GetMedals() => default;
		public int GetTotalConvertedBronzeMedalsCount() => default;
		public int GetFirstConvertedBronzeMedalsCount() => default;
		public IUndoState AddResource(ResourceTypeId resourceTypeId, double value) => default;
		public IUndoState Substract(ResourceTypeId resourceTypeId, double value) => default;
		public double GetResource(ResourceTypeId resourceTypeId) => default;
		public void SetResource(ResourceTypeId resourceTypeId, double value) {}
		public static Resources operator +(Resources r1, Resources r2) => default;
		public static Resources operator -(Resources r1) => default;
		public static Resources operator -(Resources r1, Resources r2) => default;
		public static Resources operator *(Resources r, double scale) => default;
		public static Resources operator *(Resources r, int scale) => default;
		public static Resources operator /(Resources r, int divide) => default;
		public static int operator /(Resources r1, Resources r2) => default;
		public static bool operator >(Resources r1, Resources r2) => default;
		public static bool operator <(Resources r1, Resources r2) => default;
		public static bool operator >=(Resources r1, Resources r2) => default;
		public static bool operator <=(Resources r1, Resources r2) => default;
		public static bool operator ==(Resources r1, Resources r2) => default;
		public static bool operator !=(Resources r1, Resources r2) => default;
		public override bool Equals(object other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
		public override string ToString() => default;
		public void AssertEquals(Resources r) {}
		public Resources Clone() => default;
		public bool Contains(params ResourceTypeId[] resourceTypeIds) => default;
		public bool CanSubtract(Resources r) => default;
		public bool GreaterAny(Resources other) => default;
		public bool IsEmpty() => default;
		public bool IsNegative() => default;
		public IUndoState EvenNegative() => default;
		public Resources RemoveEmpty() => default;
		public static Resources FromAll(double value) => default;
		public static Resources FromEnergy(double energy) => default;
		public static Resources FromSilver(double silver) => default;
		public static Resources FromTokens(double tokens) => default;
		public static Resources FromArena3X3Tokens(double tokens) => default;
		public static Resources FromArena3X3ShopCurrency(double currency) => default;
		public static Resources FromGems(double gems) => default;
		public static Resources FromBossKeys(double keys) => default;
		public static Resources FromArenaMedals(int bronze, int silver, int gold) => default;
		public static Resources FromArenaMedalsSilverGold(int silver, int gold) => default;
		public static Resources FromArenaMedalsGold(int gold) => default;
		public static Resources FromAutoBattleTickets(double tickets) => default;
		public static Resources FromCorehammer(double corehammer) => default;
		public static Resources[] ConvertFromSilverArray(double[] silver) => default;
		public static Resources[] ConvertFromEnergyArray(double[] energy) => default;
		public static Resources[] ConvertFromGemArray(double[] gems) => default;
		public static Resources[] ConvertFromTokenArray(double[] tokens) => default;
	}
}
