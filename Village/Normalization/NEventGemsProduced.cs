
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Normalization;



namespace SharedModel.Meta.Village.Normalization
{
	public class NEventGemsProduced : NEventUser
	{
		// Fields
		private readonly int _producedGems;
	
		// Constructors
		public NEventGemsProduced() {} // Dummy constructor
		public NEventGemsProduced(int producedGems, DateTime time) {}
	
		// Methods
		protected override void PostProcess(INormalizableContext cx, DateTime time) {}
	}
}
