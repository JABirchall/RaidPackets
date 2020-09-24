
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Battle
{
	[MessagePackObject]
	public class BattleJournalZendeskSettings
	{
		// Fields
		[Json]
		// [Key]
		public string Subject;
		[Json]
		// [Key]
		public string[] Tags;
	
		// Constructors
		public BattleJournalZendeskSettings() {}
	}
}
