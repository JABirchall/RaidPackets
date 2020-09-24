
using System;
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
	public class UpdateHeroRatingRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int HeroId;
		[Json]
		// [Key]
		public Dictionary<HeroRatingType, HeroRatingMark> MarksByRating;
	
		// Constructors
		public UpdateHeroRatingRequestDto() {}
	}
}
