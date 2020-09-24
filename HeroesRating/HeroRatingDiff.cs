
using System;
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
	public class HeroRatingDiff
	{
		// Fields
		[Json]
		// [Key]
		public HeroRatingType RatingType;
		[Json]
		// [Key]
		public bool RankedBefore;
		[Json]
		// [Key]
		public int Diff;
	
		// Constructors
		public HeroRatingDiff() {}
		public HeroRatingDiff(HeroRatingType ratingType, bool rankedBefore, int diff) {}
	}
}
