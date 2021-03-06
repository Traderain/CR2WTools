
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CMenuTimeScaleParam : CObject, IMenuTimeParam
	{
		[W3Type("timeScale")]
		public float TimeScale { get; set; }

		[W3Type("multiplicative")]
		public bool Multiplicative { get; set; }

	}
}
