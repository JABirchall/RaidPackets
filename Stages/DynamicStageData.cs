
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Stages.Entities;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class DynamicStageData
	{
		// Fields
		[Json]
		// [Key]
		public FractionWarData FractionWarData;
	
		// Constructors
		public DynamicStageData() {}
	}
}
