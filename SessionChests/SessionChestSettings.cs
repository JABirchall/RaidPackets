
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.SessionChests
{
	[MessagePackObject]
	public class SessionChestSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool SessionChestsEnabled;
	
		// Constructors
		public SessionChestSettings() {}
	}
}
