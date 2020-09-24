
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Battle
{
	public enum BattleRequestSourceId
	{
		None = 0,
		BattleMapDialog = 1,
		ArtifactSuggestion = 2,
		TavernAscendHero = 3,
		MasteriesOverlay = 4,
		BattleFinishedDialog = 5,
		QuestsDialog = 6,
		Fuse = 7,
		WebView = 8,
		SourceReceiving = 9,
		BattleFinishStoryline = 10,
		BattleFinishFactionWars = 11,
		BattleFinishDungeons = 12,
		DungeonsMap = 13,
		StorylineMap = 14
	}
}
