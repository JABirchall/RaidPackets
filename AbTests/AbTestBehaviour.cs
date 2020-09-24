
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AbTests
{
	[MessagePackObject]
	public class AbTestBehaviour
	{
		// Fields
		[Json]
		// [Key]
		public bool? RaiseAncientShardChances;
		[Json]
		// [Key]
		public bool? RaiseVoidShardChances;
		[Json]
		// [Key]
		public bool? RaiseLegendaryShardChances;
	
		// Constructors
		public AbTestBehaviour() {}
	}
}
