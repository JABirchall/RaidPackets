
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Common.Logging;



namespace SharedModel.Meta.Normalization
{
	public class NEventBase : INEvent
	{
		// Fields
		public static readonly ISharedLog Log;
	
		// Properties
		public DateTime Time { get; private set; }
	
		// Constructors
		protected NEventBase(DateTime time) {}
		protected NEventBase() {}
		static NEventBase() {}
	
		// Methods
		protected void NormalizeTime(INormalizableContext cx, DateTime fromTime) {}
	}
}
