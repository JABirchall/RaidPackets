
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Settings
{
	[MessagePackObject]
	public class SocialNetworkSettings
	{
		// Fields
		[Json]
		// [Key]
		public string YouTube;
		[Json]
		// [Key]
		public string Facebook;
		[Json]
		// [Key]
		public string Discord;
		[Json]
		// [Key]
		public string Forum;
	
		// Constructors
		public SocialNetworkSettings() {}
	}
}
