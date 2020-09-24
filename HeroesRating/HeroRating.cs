
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.HeroesRating.Enums;



namespace SharedModel.Meta.HeroesRating
{
	[MessagePackObject]
	public class HeroRating
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<HeroRatingType, HeroRatingInfo> Marks;
	
		// Constructors
		public HeroRating() {}
	}
}
