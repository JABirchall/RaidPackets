
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Normalization
{
	public abstract class UserNormalizable<T> : INormalizable<SharedModel.Meta.Normalization.INormalizableContext>
		where T : class, new()
	{
		// Fields
		private static T _instance;
	
		// Properties
		public static T Instance { get; }
	
		// Constructors
		protected UserNormalizable() {}
	
		// Methods
		public abstract INEvent<INormalizableContext> GetNextEvent(INormalizableContext cx, DateTime time);
	}
}
