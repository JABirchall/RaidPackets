
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Quests;



namespace SharedModel.Meta.Quests.Dtos
{
	[MessagePackObject]
	public class TryCompleteQuestDto
	{
		// Fields
		[Json]
		// [Key]
		public QuestCompletionByClientCode Code;
		[Json]
		// [Key]
		public long Param;
	
		// Constructors
		public TryCompleteQuestDto() {}
	}
}
