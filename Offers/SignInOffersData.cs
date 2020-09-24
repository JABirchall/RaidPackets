
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Offers.Dto;



namespace SharedModel.Meta.Offers
{
	[MessagePackObject]
	public class SignInOffersData
	{
		// Fields
		[Json]
		// [Key]
		public List<OpenOfferDto> Offers;
		[Json]
		// [Key]
		public OfferSettings Settings;
	
		// Constructors
		public SignInOffersData() {}
	}
}
