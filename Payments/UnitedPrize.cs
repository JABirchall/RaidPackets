
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Payments
{
	[MessagePackObject]
	public class UnitedPrize
	{
		// Fields
		[Json]
		// [Key]
		public UserPrize PrimaryPrize;
		[Json]
		// [Key]
		public UserPrize SecondaryPrize;
	
		// Constructors
		public UnitedPrize() {}
	
		// Methods
		public UnitedPrize Clone() => default;
	}
}
