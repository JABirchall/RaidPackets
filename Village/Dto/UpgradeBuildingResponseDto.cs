
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Village.Dto
{
	[MessagePackObject]
	public class UpgradeBuildingResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public Resources Price;
	
		// Constructors
		public UpgradeBuildingResponseDto() {}
	}
}
