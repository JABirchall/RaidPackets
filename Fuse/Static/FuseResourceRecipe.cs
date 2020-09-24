
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Fuse.Static
{
	[MessagePackObject]
	public class FuseResourceRecipe
	{
		// Fields
		[Json]
		// [Key]
		public Resources Output;
		[Json]
		// [Key]
		public Resources Material;
		[Json]
		// [Key]
		public Resources Price;
	
		// Constructors
		public FuseResourceRecipe() {}
		public FuseResourceRecipe(Resources output, Resources material, Resources price) {}
	}
}
