
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Account;
using SharedModel.Meta.Effects;
using SharedModel.Meta.Offers;



namespace SharedModel.Meta.Normalization
{
	public class NEventUser : NEventBase, INEventUser
	{
		// Constructors
		public NEventUser() {} // Dummy constructor
		public NEventUser(DateTime time) {}
	
		// Methods
		public void Process(INormalizableContext cx, DateTime fromTime) {}
		protected virtual void PreProcess(INormalizableContext cx, DateTime fromTime) {}
		protected virtual void PostProcess(INormalizableContext cx, DateTime fromTime) {}
		internal static void NormalizeEnergy(UserAccount account, DateTime fromTime, DateTime toTime) {}
		internal static void NormalizeTokens(UserAccount account, DateTime fromTime, DateTime toTime) {}
		internal static void NormalizeArena3X3Tokens(UserAccount account, DateTime fromTime, DateTime toTime) {}
		internal static void NormalizeAllianceBossKeys(UserAccount account, DateTime fromTime, DateTime toTime) {}
		internal static void NormalizeAutoBattleTickets(UserAccount account, UserEffectData effectData, DateTime now) {}
		internal static void NormalizeOfferWithDynamicPrice(UserOfferData offerData, DateTime toTime) {}
	}
}
