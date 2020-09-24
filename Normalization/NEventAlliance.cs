
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Normalization
{
	public class NEventAlliance : NEventBase, INEventAlliance
	{
		// Constructors
		public NEventAlliance() {} // Dummy constructor
		public NEventAlliance(DateTime time) {}
	
		// Methods
		public void Process(INormalizableContext cx, DateTime fromTime) {}
		protected virtual void PreProcess(INormalizableContext cx, DateTime fromTime) {}
		protected virtual void PostProcess(INormalizableContext cx, DateTime fromTime) {}
	}
}
