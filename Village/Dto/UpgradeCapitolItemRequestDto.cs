
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;
using SharedModel.Meta.Account;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Village.Dto
{
	[MessagePackObject]
	public class UpgradeCapitolItemRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public Element Element;
		[Json]
		// [Key]
		public StatKindId StatKindId;
		[Json]
		// [Key]
		public ResourceTypeId ResourceTypeId;
		[Json]
		// [Key]
		public Resources ConvertedPrice;
	
		// Constructors
		public UpgradeCapitolItemRequestDto() {}
	}
}
