
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Quests
{
	public enum GlobalEventAction
	{
		Hero_LevelUp = 1,
		Hero_RankUp = 2,
		Hero_Ascend = 3,
		Hero_SkillLevelUp = 4,
		Hero_Summon = 5,
		Hero_Fuse = 6,
		Hero_Receive = 7,
		Hero_Assemble = 8,
		Artifact_Collect = 21,
		Artifact_Upgrade = 22,
		Shards_Open = 31,
		ResourceReceive_ArenaMedals = 41,
		Battle_Story = 50,
		Battle_Dungeon = 51,
		Battle_Arena = 52,
		Battle_DungeonReward = 53
	}
}
