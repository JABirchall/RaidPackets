
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Chat
{
	public enum AdministrativeChatMessageType
	{
		ArtifactUpgraded = 1,
		ArtifactAcquired = 2,
		ArtifactPowerUpped = 3,
		HeroAcquired = 100,
		HeroFused = 101,
		HeroAwaken = 102,
		HeroRankedUp = 103,
		ChannelChanged = 900,
		JoinedAllianceChat = 950,
		Notification = 1000,
		AllianceMessageOfTheDay = 1100,
		DefeatAllianceBoss = 1200,
		BanChat = 1301,
		BanAccount = 1302,
		UnBan = 1310
	}
}
