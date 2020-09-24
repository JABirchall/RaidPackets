
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Quests.Dtos
{
	[MessagePackObject]
	public class CloseQuestDto
	{
		// Fields
		[Json]
		// [Key]
		public int QuestId;
	
		// Constructors
		public CloseQuestDto() {}
	}
}
