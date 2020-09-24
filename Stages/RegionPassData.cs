
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Effects;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class RegionPassData
	{
		// Fields
		[Json]
		// [Key]
		public Resources Price;
		[Json]
		// [Key]
		public UserEffectTypeId UserEffectType;
	
		// Constructors
		public RegionPassData() {}
	}
}
