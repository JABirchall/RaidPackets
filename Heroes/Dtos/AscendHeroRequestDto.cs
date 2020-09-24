
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Heroes.Dtos
{
	[MessagePackObject]
	public class AscendHeroRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int HeroId;
		[Json]
		// [Key]
		public Account.Resources AscendingPrice;
	
		// Constructors
		public AscendHeroRequestDto() {}
	}
}
