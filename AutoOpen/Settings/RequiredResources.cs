
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.AutoOpen.Settings
{
	[MessagePackObject]
	public class RequiredResources
	{
		// Fields
		[Json]
		// [Key]
		public ResourceTypeId TypeId;
		[Json]
		// [Key]
		public int Count;
	
		// Constructors
		public RequiredResources() {}
	}
}
