
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.HeroesRating
{
	[MessagePackObject]
	public class HeroRatingSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public double HeroRatingUpdateCooldownMinutes;
		[Json]
		// [Key]
		public double RatingsCacheUpdateCooldownMinutes;
	
		// Constructors
		public HeroRatingSettings() {}
	}
}
