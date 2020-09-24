
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.AutoOpen.Conditions.Builder;
using SharedModel.Meta.AutoOpen.Groups;



namespace SharedModel.Meta.AutoOpen.Conditions
{
	public static class ConditionBuilderExtensions
	{
		// Extension methods
		public static ConditionBuilder DaysSinceLastSignIn(this ConditionBuilder self, int min) => default;
		public static ConditionBuilder DaysSinceRegistration(this ConditionBuilder self, int min) => default;
		public static ConditionBuilder AllianceMembership(this ConditionBuilder self) => default;
		public static ConditionBuilder Level(this ConditionBuilder self, int from, int to) => default;
		public static ConditionBuilder LifeTimeValue(this ConditionBuilder self, int from, int to) => default;
	}
}
