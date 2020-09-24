
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Common.Exceptions;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.HeroesRating
{
	public static class HeroRatingExtensions
	{
		// Fields
		private static readonly Dictionary<int, HeroGrade> MinGradeAllowedForRateByRarity;
	
		// Constructors
		static HeroRatingExtensions() {}
	
		// Extension methods
		public static void AssertCanRateHero(this UserHeroData data, int heroId, DateTime now) {}
		public static HeroGrade AllowedMinGradeForRate(this UserHeroData data, int typeId) => default;
		private static LogicErrorCode? CanRateHero(this UserHeroData data, int heroId, DateTime now) => default;
	}
}
