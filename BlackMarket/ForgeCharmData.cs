
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Forge.Static;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class ForgeCharmData
	{
		// Fields
		[Json]
		// [Key]
		public ForgeCharmTypeId TypeId;
		[Json]
		// [Key]
		public ForgeCharmProbabilities Probabilities;
	
		// Constructors
		public ForgeCharmData() {}
	}
}
