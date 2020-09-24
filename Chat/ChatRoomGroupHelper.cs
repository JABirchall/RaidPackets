
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Chat
{
	public static class ChatRoomGroupHelper
	{
		// Fields
		private const string LocalizationTemplate = "l10n:chat/chat-room-group-name?id={0}#label";
	
		// Extension methods
		public static string GetName(this ChatRoomGroup chatRoomGroup) => default;
		public static string ToLocalizationKey(this ChatRoomGroup chatRoomGroup) => default;
	}
}
