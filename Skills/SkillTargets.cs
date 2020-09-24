
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Skills
{
	public enum SkillTargets
	{
		Producer = 0,
		AliveAllies = 1,
		AliveEnemies = 2,
		DeadAllies = 3,
		DeadEnemies = 4,
		AllAllies = 5,
		AllEnemies = 6,
		AliveAlliesExceptProducer = 7
	}
}
