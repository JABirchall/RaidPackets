
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Fuse.Static
{
	[MessagePackObject]
	public class FuseHeroRecipe
	{
		// Fields
		[Json]
		// [Key]
		public List<FuseHeroMaterial> HeroMaterials;
		[Json]
		// [Key]
		public HeroGrade OutputHeroGrade;
		[Json]
		// [Key]
		public int OutputHeroId;
		[Json]
		// [Key]
		public Account.Resources Price;
		[Json]
		// [Key]
		public int? UsageLimit;
		[Json]
		// [Key]
		public DateTime? AvailableFrom;
		[Json]
		// [Key]
		public DateTime? AvailableTo;
		[IgnoreMember]
		[JsonSkip]
		public HashSet<FuseHeroRecipe> ParentRecipes;
	
		// Constructors
		public FuseHeroRecipe() {}
	}
}
