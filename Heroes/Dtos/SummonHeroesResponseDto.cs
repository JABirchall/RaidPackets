
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Heroes.Dtos
{
	[MessagePackObject]
	public class SummonHeroesResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public List<SummonedHeroInfo> Heroes;
		[Json]
		// [Key]
		public Resources TotalActivationPrice;
	
		// Constructors
		public SummonHeroesResponseDto() {}
	}
}
