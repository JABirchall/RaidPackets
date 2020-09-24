
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Settings
{
	[MessagePackObject]
	public class Avatar
	{
		// Fields
		[Json]
		// [Key]
		public UserAvatarId Id;
		[Json]
		// [Key]
		public bool Seen;
	
		// Constructors
		public Avatar() {}
	}
}
