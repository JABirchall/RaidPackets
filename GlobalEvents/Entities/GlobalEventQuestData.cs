
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Quests.Data;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventQuestData
	{
		// Fields
		[Json]
		// [Key]
		public Quest Quest;
	
		// Constructors
		public GlobalEventQuestData() {}
	}
}
