
using System;
using System.Collections.Generic;
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
	public class UserGameSettings
	{
		// Fields
		[Json]
		// [Key]
		public string LocaleName;
		[Json]
		// [Key]
		public string Name;
		[Json]
		// [Key]
		public UserAvatarId Avatar;
		[Json]
		// [Key]
		public string CustomAvatarUrl;
		[Json]
		// [Key]
		public int ChangeNameCount;
		[Json]
		// [Key]
		public int ChangeAvatarCount;
		[Json]
		// [Key]
		public List<Avatar> Avatars;
		[Json]
		// [Key]
		public int? AvatarIdMigrationOnly;
	
		// Constructors
		public UserGameSettings() {}
	}
}
