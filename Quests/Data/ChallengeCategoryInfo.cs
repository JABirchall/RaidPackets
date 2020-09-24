
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Quests;



namespace SharedModel.Meta.Quests.Data
{
	[MessagePackObject]
	public class ChallengeCategoryInfo
	{
		// Fields
		[Json]
		// [Key]
		public ChallengeQuestCategoryId Id;
		[Json]
		// [Key]
		public int PartsCount;
	
		// Constructors
		public ChallengeCategoryInfo() {}
	}
}
