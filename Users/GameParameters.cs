
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Common.Localization;
using SharedModel.Meta.AbTests;
using SharedModel.Meta.Alliances;
using SharedModel.Meta.AutoOpen.Settings;
using SharedModel.Meta.Battle;
using SharedModel.Meta.BattlePasses;
using SharedModel.Meta.Debug;
using SharedModel.Meta.Fuse;
using SharedModel.Meta.GlobalEvents.Entities;
using SharedModel.Meta.GlobalMessages;
using SharedModel.Meta.GlobalRatings;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.LoyaltyProgram.Data;
using SharedModel.Meta.Masteries;
using SharedModel.Meta.Network.Failover;
using SharedModel.Meta.Network.Settings;
using SharedModel.Meta.Notifications;
using SharedModel.Meta.PerformanceMeter;
using SharedModel.Meta.PeriodicQuests.Data;
using SharedModel.Meta.Quests.Data;
using SharedModel.Meta.RateGame;
using SharedModel.Meta.ServiceMessages;
using SharedModel.Meta.SessionChests;
using SharedModel.Meta.Settings;
using SharedModel.Meta.Shards;
using SharedModel.Meta.Zendesk;



namespace SharedModel.Meta.Users
{
	[MessagePackObject]
	// [RemovedJson]
	public class GameParameters
	{
		// Fields
		[Json]
		// [Key]
		public bool IsDevServer;
		[Json]
		// [Key]
		public string AppKey;
		[Json]
		// [Key]
		public QuestSettings QuestSettings;
		[Json]
		// [Key]
		public PeriodicQuestSettingsClient PeriodicQuestSettings;
		[Json]
		// [Key]
		public AdvancedDailyQuestSettings AdvancedDailyQuestSettings;
		[Json]
		// [Key]
		public SessionChestSettings SessionChestSettings;
		[Json]
		// [Key]
		public AbTestSettings AbTestSettings;
		[Json]
		// [Key]
		public GlobalMessageSettings GlobalMessageSettings;
		[Json]
		// [Key]
		public HeroSettings HeroSettings;
		[Json]
		// [Key]
		public UxCamSettings UxCamSettings;
		[Json]
		// [Key]
		public ClientLoggingSettings ClientLoggingSettings;
		[Json]
		// [Key]
		public ClientNetworkFailoverSettings NetworkFailoverSettings;
		[Json]
		// [Key]
		public BattleSettings BattleSettings;
		[Json]
		// [Key]
		public MasterySettings MasterySettings;
		[Json]
		// [Key]
		public LoyaltyProgramSettings LoyaltyProgramSettings;
		[Json]
		// [Key]
		public FuseSettings FuseSettings;
		[Json]
		// [Key]
		public ShardSettings ShardSettings;
		[Json]
		// [Key]
		public RateGameSettings RateGameSettings;
		[Json]
		// [Key]
		public AllianceSettings AllianceSettings;
		[Json]
		// [Key]
		public LocalizationSettings LocalizationSettings;
		[Json]
		// [Key]
		public NotificationsSettings NotificationsSettings;
		[Json]
		// [Key]
		public AutoOpenSettings AutoOpenSettings;
		[Json]
		// [Key]
		public GuideSettings GuideSettings;
		[Json]
		// [Key]
		public DebugSettings DebugSettings;
		[Json]
		// [Key]
		public ZendeskSettings ZendeskSettings;
		[Json]
		// [Key]
		public GlobalEventsSettings GlobalEventsSettings;
		[Json]
		// [Key]
		public GlobalRatingSettings GlobalRatingSettings;
		[Json]
		// [Key]
		public SocialNetworkSettings SocialNetworkSettings;
		[Json]
		// [Key]
		public UserSettings UserSettings;
		[Json]
		// [Key]
		public ServiceMessagesSettings ServiceMessagesSettings;
		[Json]
		// [Key]
		public double OnlineUsersRefreshDurationMs;
		[Json]
		// [Key]
		public PerformanceMeterSettings PerformanceMeterSettings;
		[Json]
		// [Key]
		public bool DisableLOHGCAfterLogin;
		[Json]
		// [Key]
		public bool DisableNewActionRecordsLogs;
		[Json]
		// [Key]
		public bool NewCensorEnabled;
		[Json]
		// [Key]
		public ClientSettings ClientSettings;
		[Json]
		// [Key]
		public MessagePackSettings MessagePack;
		[Json]
		// [Key]
		public BattlePassSettings BattlePassSettings;
		[Json]
		// [Key]
		public bool AdjustUninstallNotificationsEnabled;
		[Json]
		// [Key]
		public PreEditDuringWizard PreEditDuringWizard;
		[Json]
		// [Key]
		public bool ModerationToolEnabled;
	
		// Constructors
		public GameParameters() {}
	}
}
