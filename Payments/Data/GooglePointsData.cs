
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Payments.Data
{
	public class GooglePointsData
	{
		// Fields
		[Json]
		public int Points;
		[Json]
		public string ProductId;
		[Json]
		public string PrizeStr;
	
		// Constructors
		public GooglePointsData() {}
	}
}
