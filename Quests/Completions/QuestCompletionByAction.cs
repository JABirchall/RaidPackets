
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Alliances;
using SharedModel.Meta.MagicShop;
using SharedModel.Meta.Quests;
using SharedModel.Meta.Quests.Data;
using SharedModel.Meta.SessionChests;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByAction
	{
		// Fields
		[Json]
		// [Key]
		public int CountRequired;
		[Json]
		// [Key]
		public int CountCollected;
		[Json]
		// [Key]
		public QuestCompletionByActionCode Code;
	
		// Constructors
		public QuestCompletionByAction() {}
	
		// Methods
		public bool IsCompleted(UserAllianceData allianceData, UserMagicShopData magicShopData, UserSessionChestData sessionChestData, ComplexSource source) => default;
		public QuestCompletionProgress CalcProgress(UserAllianceData allianceData, UserMagicShopData magicShopData, UserSessionChestData sessionChestData, ComplexSource source) => default;
		public QuestCompletionByAction Clone() => default;
	}
}
