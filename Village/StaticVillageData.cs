
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


// [assembly: AssemblyCompany]
// [assembly: AssemblyConfiguration]
// [assembly: AssemblyCopyright]
// [assembly: AssemblyDescription]
// [assembly: AssemblyFileVersion]
// [assembly: AssemblyProduct]
// [assembly: AssemblyTitle]
// [assembly: AssemblyTrademark]
// [assembly: CompilationRelaxations]
// [assembly: ComVisible]
// [assembly: Debuggable]
// [assembly: Guid]
// [assembly: InternalsVisibleTo]
[assembly: RuntimeCompatibility]

namespace SharedModel.Meta.Village
{
	[MessagePackObject]
	public class StaticVillageData
	{
		// Fields
		[Json]
		// [Key]
		public VillageSettings Settings;
		[Json]
		// [Key]
		public List<BuildingType> BuildingTypes;
		[Json]
		// [Key]
		public Dictionary<StatKindId, List<BonusValue>> CapitolBonusByStatKind;
		[Json]
		// [Key]
		public List<Account.Resources> CapitolBonusUpgradePrices;
		[Json]
		// [Key]
		public int GemMineRemindLevel;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<BuildingTypeId, BuildingType> _buildingTypeById;
	
		// Constructors
		public StaticVillageData() {}
	
		// Methods
		public void Cache() {}
		public BuildingType GetBuildingType(BuildingTypeId id, bool throwExceptionIfNotFound = true) => default;
	}
}
