
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Village
{
	[MessagePackObject]
	public class BuildingLevelInfo
	{
		// Fields
		[Json]
		// [Key]
		public Resources Price;
		[Json]
		// [Key]
		public BuildingOpenCondition Condition;
		[Json]
		// [Key]
		public GemsMineInfo GemsMineInfo;
	
		// Constructors
		public BuildingLevelInfo() {}
	}
}
