
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Masteries
{
	[MessagePackObject]
	public class MasteryLimit
	{
		// Fields
		[Json]
		// [Key]
		public int MaxInRow;
		[Json]
		// [Key]
		public int MaxInTree;
	
		// Constructors
		public MasteryLimit() {}
		public MasteryLimit(int maxInRow, int maxInTree) {}
	}
}
