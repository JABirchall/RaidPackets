
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Offers.Enums
{
	public enum OfferStateId
	{
		New = 1,
		Read = 5,
		OpenDetails = 6,
		ClickBuy = 7,
		Bought = 8,
		Closed = 10
	}
}
