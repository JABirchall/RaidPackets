
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Battle.Core.Result;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Alliances.Activity;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Alliances
{
	public static class AllianceExtensions
	{
		// Fields
		private const string ForbiddenSpecialSymbols = "[`~!@#$%^&*()-+=\\\\|\\[{\\]};:\'\\\",<.>/?\u20AC\u20BD^(?";
		private const string WhiteSpacesSymbols = "\\s";
	
		// Methods
		private static Func<UserDailyActivityInfo> BuildUserDailyActivityInfo() => default;
	
		// Extension methods
		public static UserAllianceActivityData AddBattleResult(this UserAllianceActivityData data, DateTime now, AreaTypeId areaId, BattleResultType resultType) => default;
		public static int GetBattleCount(this UserAllianceActivityData data, DateTime date, AreaTypeId areaTypeId) => default;
		public static UserAllianceActivityData AddOnlineTime(this UserAllianceActivityData data, DateTime now, long diffTimeMs) => default;
		public static IUndoState CheckIn(this UserAllianceActivityData data, DateTime now) => default;
		public static void BuildAllianceActivityDataIfNeeded(this UserAllianceActivityData data) {}
		public static int? GetStarsForDate(this UserAllianceData data, DateTime now) => default;
		public static void AssertNameIsValid(this AllianceSettings settings, string newName, string name, Func<string, bool> isCensored) {}
		public static void AssertAbbreviationIsValid(this AllianceSettings settings, string newAbbreviation, string abbreviation, Func<string, bool> isCensored) {}
		public static void AssertMessageOfTheDayIsValid(this AllianceSettings settings, string message, Func<string, bool> isCensored) {}
		public static void AssertDescriptionIsValid(this AllianceSettings settings, string description, Func<string, bool> isCensored) {}
		public static void AssertAllianceRequestMessageIsValid(this AllianceSettings settings, string description, Func<string, bool> isCensored) {}
	}
}
