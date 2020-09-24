
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Masteries;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class MasteryData
	{
		// Fields
		[Json]
		// [Key]
		public MasteryPointType MasteryType;
	
		// Constructors
		public MasteryData() {}
	}
}
