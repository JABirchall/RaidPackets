
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Village;



namespace SharedModel.Meta.Village.Dto
{
	[MessagePackObject]
	public class UpgradeBuildingRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public BuildingTypeId TypeId;
	
		// Constructors
		public UpgradeBuildingRequestDto() {}
	}
}
