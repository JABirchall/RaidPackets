
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Masteries
{
	[MessagePackObject]
	public class MasteryType
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public Dictionary<MasteryPointType, int> Price;
		[Json]
		// [Key]
		public List<int> ParentIds;
		[Json]
		// [Key]
		public List<int> ChildIds;
		[IgnoreMember]
		[JsonSkip]
		private List<MasteryType> _parents;
		[IgnoreMember]
		[JsonSkip]
		private List<MasteryType> _childs;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public MasteryTreeId TreeId { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int Row { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int Column { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public List<MasteryType> Parents { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public List<MasteryType> Childs { get => default; }
	
		// Constructors
		public MasteryType() {}
		public MasteryType(MasteryTreeId treeId, int row, int column, Dictionary<MasteryPointType, int> price) {}
	
		// Methods
		public static MasteryType Attack(int row, int column, Dictionary<MasteryPointType, int> price) => default;
		public static MasteryType Defence(int row, int column, Dictionary<MasteryPointType, int> price) => default;
		public static MasteryType Support(int row, int column, Dictionary<MasteryPointType, int> price) => default;
		public MasteryType Clone() => default;
	}
}
