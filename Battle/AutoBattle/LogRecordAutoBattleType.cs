
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Battle.AutoBattle
{
	public enum LogRecordAutoBattleType
	{
		Start = 1,
		StopOnMaxLevel = 2,
		StopAfterDefeat = 3,
		StopByUser = 4,
		FightLimitReached = 5,
		EnergyEnded = 6,
		ConnectionError = 7,
		GameClosed = 8,
		FinishByCachedClientResult = 9,
		DungeonIsClosedByOpenDay = 10
	}
}
