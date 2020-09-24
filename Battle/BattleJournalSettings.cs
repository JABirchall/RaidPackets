
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Journal;



namespace SharedModel.Meta.Battle
{
	[MessagePackObject]
	public class BattleJournalSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public int Revision;
		[Json]
		// [Key]
		public int MaxCommandsCount;
		[Json]
		// [Key]
		public int MaxStorageSize;
		[Json]
		// [Key]
		public BattleJournalMode DefaultMode;
		[Json]
		// [Key]
		public bool SkipLogsWithoutException;
		[Json]
		// [Key]
		public BattleJournalZendeskSettings Zendesk;
	
		// Constructors
		public BattleJournalSettings() {}
	}
}
