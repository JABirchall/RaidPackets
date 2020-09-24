
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Payments.Data
{
	public class TransactionAlreadyProcessedException : Exception
	{
		// Constructors
		public TransactionAlreadyProcessedException() {}
	}
}
