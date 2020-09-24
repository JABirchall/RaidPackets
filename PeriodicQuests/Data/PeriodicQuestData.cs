
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.PeriodicQuests.Data
{
	[MessagePackObject]
	public class PeriodicQuestData
	{
		// Fields
		[Json]
		// [Key]
		public PeriodicQuestPrototypeId PrototypeId;
		[Json]
		// [Key]
		public int NeedCollectPoints;
		[Json]
		// [Key]
		public PeriodicQuestFilter Filter;
		[Json]
		// [Key]
		public UserPrize Prize;
	
		// Constructors
		public PeriodicQuestData() {}
		public PeriodicQuestData(PeriodicQuestPrototypeId prototypeId, int needCollectPoints, UserPrize prize) {}
		public PeriodicQuestData(PeriodicQuestPrototypeId prototypeId, int needCollectPoints) {}
	
		// Methods
		public PeriodicQuestData Clone() => default;
		public override string ToString() => default;
	}
}
