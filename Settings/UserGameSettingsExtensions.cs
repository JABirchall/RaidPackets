
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Settings
{
	public static class UserGameSettingsExtensions
	{
		// Fields
		private const string ForbiddenSpecialCharacters = "[\"<>\'\u2018\uFFFD";
	
		// Extension methods
		public static void AssertUserNameIsValid(this UserGameSettings gameSettings, string newUserName, UserSettings userSettings, Func<string, bool> nameCensored) {}
	}
}
