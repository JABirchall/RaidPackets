
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.HeroesRating
{
	[MessagePackObject]
	public class HeroRatingInfo
	{
		// Fields
		[Json]
		// [Key]
		public int TotalMarks;
		[Json]
		// [Key]
		public double SumMarks;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public double Mark { get => default; }
	
		// Constructors
		public HeroRatingInfo() {}
		public HeroRatingInfo(int totalMarks, double sumMarks) {}
	}
}
