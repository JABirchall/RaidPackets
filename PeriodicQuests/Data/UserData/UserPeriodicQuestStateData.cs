
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.PeriodicQuests.Data;
using SharedModel.Meta.Quests.Data;



namespace SharedModel.Meta.PeriodicQuests.Data.UserData
{
	[MessagePackObject]
	public class UserPeriodicQuestStateData
	{
		// Fields
		[Json]
		// [Key]
		public int QuestId;
		[Json]
		// [Key]
		public bool IsReceivedBonus;
		[Json]
		// [Key]
		public PeriodicQuestStateId QuestStateId;
		[Json]
		// [Key]
		public QuestState QuestState;
	
		// Properties
		[Json]
		// [Key]
		public PeriodicQuestGroupId GroupId { get; set; }
		[Json]
		// [Key]
		public DateTime DeadLine { get; set; }
		[Json]
		// [Key]
		public PeriodicQuestData QuestStaticData { get; set; }
		[IgnoreMember]
		[JsonSkip]
		public PeriodicQuestsPackId QuestsPackId { get; private set; }
	
		// Constructors
		public UserPeriodicQuestStateData() {}
	
		// Methods
		public static UserPeriodicQuestStateData Create(PeriodicQuestGroupId groupId, PeriodicQuestsPackId questsPackId, DateTime deadLine, PeriodicQuestData staticData) => default;
	}
}
