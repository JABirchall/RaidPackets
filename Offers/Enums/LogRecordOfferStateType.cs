
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Offers.Enums
{
	public enum LogRecordOfferStateType
	{
		NewGiveOffer = 1,
		EmptyGiveOffer = 2,
		GiveOfferRead = 11,
		OpenOfferRead = 12,
		OpenCategory = 21,
		ClickDetails = 22,
		ClickBuy = 23,
		ClickClose = 30,
		ClickCancel = 31
	}
}
