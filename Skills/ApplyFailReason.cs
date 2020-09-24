
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Skills
{
	public enum ApplyFailReason
	{
		None = 0,
		Resisted = 1,
		Blocked = 2,
		MaxEffectLimitReached = 3,
		AlreadyHasStrongerEffect = 4,
		AlreadyHasLongerEffect = 5,
		StackLimitReached = 6,
		ReviveBlocked = 7
	}
}
