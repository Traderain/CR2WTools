
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public interface IGuiResource
	{
		Array<Ptr<CGraphBlock>> ResourceBlocks { get; set; }
	}
}
