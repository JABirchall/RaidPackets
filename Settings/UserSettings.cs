
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Logging.ClientActions;



namespace SharedModel.Meta.Settings
{
	[MessagePackObject]
	public class UserSettings
	{
		// Fields
		[Json]
		// [Key]
		public int NameMinCharsCount;
		[Json]
		// [Key]
		public int NameMaxCharsCount;
		[Json]
		// [Key]
		public int NewUserGems;
		[Json]
		// [Key]
		public int NewUserSilver;
		[Json]
		// [Key]
		public int NewUserArenaTokens;
		[Json]
		// [Key]
		public int NewUserAutoBattleTickets;
		[Json]
		// [Key]
		public bool StaticDataLoadingEnabled;
		[Json]
		// [Key]
		public bool UseGameDataValidation;
		[Json]
		// [Key]
		public List<LogRecordClientActionType> DisabledClientLogTypes;
		[Json]
		// [Key]
		public bool AutoDeletionEnabled;
	
		// Constructors
		public UserSettings() {}
	}
}
