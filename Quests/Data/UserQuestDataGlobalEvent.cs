
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
	public class UserQuestDataGlobalEvent
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<QuestCategoryId, List<int>> QuestCompletedIdsByCategoryId;
		[Json]
		// [Key]
		public List<int> SeenSoloEventTeaserPrototypeIds;
		[Json]
		// [Key]
		public List<int> SeenTournamentTeaserPrototypeIds;
		[Json]
		// [Key]
		public List<int> FirstSeenSoloEventTeaserPrototypeIds;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, int> TournamentPointsByStateId;
	
		// Constructors
		public UserQuestDataGlobalEvent() {}
	
		// Methods
		public bool CompletedQuest(QuestCategoryId categoryId, int id) => default;
	}
}
