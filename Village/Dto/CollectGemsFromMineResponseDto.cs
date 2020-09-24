
using System;
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
	public class CollectGemsFromMineResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public Account.Resources Resources;
		[Json]
		// [Key]
		public double ExcessHours;
	
		// Constructors
		public CollectGemsFromMineResponseDto() {}
	}
}
