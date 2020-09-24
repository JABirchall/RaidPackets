
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Forge
{
	[MessagePackObject]
	public class ForgeRewards
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<ResourceTypeId, int> Rewards;
	
		// Constructors
		public ForgeRewards() {}
	}
}
