
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Fuse.Static
{
	[MessagePackObject]
	public class StaticFuseData
	{
		// Fields
		[Json]
		// [Key]
		public List<FuseHeroRecipe> HeroRecipes;
		[Json]
		// [Key]
		public List<FuseResourceRecipe> ResourceRecipes;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<int, FuseHeroRecipe> _recipesByHeroId;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<ResourceTypeId, FuseResourceRecipe> _recipesByResourceId;
	
		// Constructors
		public StaticFuseData() {}
	
		// Methods
		public void Cache() {}
		private void RemoveUnCheckedHeroes() {}
		private void SetHeroRecipesParents() {}
		public FuseHeroRecipe GetHeroRecipe(int outputHeroId, bool throwExceptionIfNotFound = true) => default;
		public FuseResourceRecipe GetResourceRecipe(ResourceTypeId outputResourceId, bool throwExceptionIfNotFound = true) => default;
	}
}
