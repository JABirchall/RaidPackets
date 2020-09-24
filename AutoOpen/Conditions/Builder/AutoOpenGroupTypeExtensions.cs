
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.AutoOpen.Groups;



namespace SharedModel.Meta.AutoOpen.Conditions.Builder
{
	public static class AutoOpenGroupTypeExtensions
	{
		// Extension methods
		public static AutoOpenGroupType Requiring(this AutoOpenGroupType self, Action<ConditionBuilder> build) => default;
	}
}
