
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.HeroesRating
{
	[MessagePackObject]
	public class SignInHeroRatingData
	{
		// Fields
		[Json]
		// [Key]
		public HeroRatingSettings HeroRatingSettings;
		[Json]
		// [Key]
		public Dictionary<int, HeroRating> Ratings;
	
		// Constructors
		public SignInHeroRatingData() {}
	}
}
