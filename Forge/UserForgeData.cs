
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Forge
{
	[MessagePackObject]
	public class UserForgeData
	{
		// Fields
		[Json]
		// [Key]
		public bool FirstTimeRewardTaken;
	
		// Constructors
		public UserForgeData() {}
	}
}
