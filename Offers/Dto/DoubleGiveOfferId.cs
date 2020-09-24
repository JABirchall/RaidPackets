
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class DoubleGiveOfferId
	{
		// Fields
		[Json]
		// [Key]
		public int FirstId;
		[Json]
		// [Key]
		public int SecondId;
	
		// Constructors
		public DoubleGiveOfferId() {}
	}
}
