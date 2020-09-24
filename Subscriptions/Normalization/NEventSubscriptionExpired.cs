
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Normalization;
using SharedModel.Meta.Subscriptions.Data;



namespace SharedModel.Meta.Subscriptions.Normalization
{
	public class NEventSubscriptionExpired : NEventUser
	{
		// Fields
		private readonly Subscription _subscription;
	
		// Constructors
		public NEventSubscriptionExpired() {} // Dummy constructor
		public NEventSubscriptionExpired(DateTime time, Subscription subscription) {}
	
		// Methods
		protected override void PostProcess(INormalizableContext cx, DateTime time) {}
	}
}
