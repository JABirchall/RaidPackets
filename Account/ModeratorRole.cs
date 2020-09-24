
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Account
{
	public enum ModeratorRole
	{
		NotModerator = 0,
		ChatModerator = 1,
		HiddenChatModerator = 2,
		GameModerator = 11,
		HiddenGameModerator = 12
	}
}
