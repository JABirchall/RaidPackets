
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Battle.Arena3x3
{
	[MessagePackObject]
	public class Arena3X3LeaguesInfo
	{
		// Fields
		[Json]
		// [Key]
		public int BronzeIICapacity;
		[Json]
		// [Key]
		public int BronzeIIICapacity;
		[Json]
		// [Key]
		public int BronzeIVCapacity;
		[Json]
		// [Key]
		public int SilverICapacity;
		[Json]
		// [Key]
		public int SilverIICapacity;
		[Json]
		// [Key]
		public int SilverIIICapacity;
		[Json]
		// [Key]
		public int SilverIVCapacity;
		[Json]
		// [Key]
		public int GoldICapacity;
		[Json]
		// [Key]
		public int GoldIICapacity;
		[Json]
		// [Key]
		public int GoldIIICapacity;
		[Json]
		// [Key]
		public int GoldIVCapacity;
		[Json]
		// [Key]
		public int BronzeIUpCount;
		[Json]
		// [Key]
		public int BronzeIIUpCount;
		[Json]
		// [Key]
		public int BronzeIIDownCount;
		[Json]
		// [Key]
		public int BronzeIIIUpCount;
		[Json]
		// [Key]
		public int BronzeIIIDownCount;
		[Json]
		// [Key]
		public int BronzeIVUpCount;
		[Json]
		// [Key]
		public int BronzeIVDownCount;
		[Json]
		// [Key]
		public int SilverIUpCount;
		[Json]
		// [Key]
		public int SilverIDownCount;
		[Json]
		// [Key]
		public int SilverIIUpCount;
		[Json]
		// [Key]
		public int SilverIIDownCount;
		[Json]
		// [Key]
		public int SilverIIIUpCount;
		[Json]
		// [Key]
		public int SilverIIIDownCount;
		[Json]
		// [Key]
		public int SilverIVUpCount;
		[Json]
		// [Key]
		public int SilverIVDownCount;
		[Json]
		// [Key]
		public int GoldIUpCount;
		[Json]
		// [Key]
		public int GoldIDownCount;
		[Json]
		// [Key]
		public int GoldIIUpCount;
		[Json]
		// [Key]
		public int GoldIIDownCount;
		[Json]
		// [Key]
		public int GoldIIIUpCount;
		[Json]
		// [Key]
		public int GoldIIIDownCount;
		[Json]
		// [Key]
		public int GoldIVDownCount;
	
		// Constructors
		public Arena3X3LeaguesInfo() {}
	}
}
