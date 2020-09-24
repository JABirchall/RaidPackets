
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class HeroRankUpData
	{
		// Fields
		[Json]
		// [Key]
		public HeroGrade Grade;
	
		// Constructors
		public HeroRankUpData() {}
		public HeroRankUpData(HeroGrade grade) {}
	}
}
