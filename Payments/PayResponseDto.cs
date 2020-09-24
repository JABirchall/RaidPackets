
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Payments
{
	public class PayResponseDto
	{
		// Fields
		[Json]
		public int Code;
		[Json]
		public string Description;
	
		// Constructors
		public PayResponseDto() {}
	}
}
