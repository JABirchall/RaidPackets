
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Artifacts
{
	public enum ArtifactStatKindId
	{
		Unknown = 0,
		HealthFlat = 1,
		HealthPerc = 2,
		AttackFlat = 3,
		AttackPerc = 4,
		DefenceFlat = 5,
		DefencePerc = 6,
		Speed = 7,
		Resistance = 8,
		Accuracy = 9,
		CriticalChance = 10,
		CriticalDamage = 11,
		CriticalHeal = 12
	}
}
