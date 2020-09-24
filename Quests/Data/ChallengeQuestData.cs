
using System;
using System.Collections.Generic;
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
	public class ChallengeQuestData
	{
		// Fields
		[Json]
		// [Key]
		public List<ChallengeCategoryInfo> CategoryInfosV1;
		[Json]
		// [Key]
		public List<ChallengeCategoryInfo> CategoryInfosV2;
		[Json]
		// [Key]
		public Dictionary<int, int> ArtifactChallengesV2PartsByV1Parts;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<ChallengeQuestCategoryId, ChallengeCategoryInfo> CategoryInfoV1ById;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<ChallengeQuestCategoryId, ChallengeCategoryInfo> CategoryInfoV2ById;
	
		// Constructors
		public ChallengeQuestData() {}
	
		// Methods
		public void Cache() {}
	}
}
