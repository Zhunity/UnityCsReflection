using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SMFrame.Editor.Refleaction;

namespace SMFrame.Editor
{
	/// <summary>
	/// ComponentItem的对象的对象
	/// </summary>
	public class RComponentDropdownItem : RType
	{
		// ComponentItem在AddComponentWindow显示的名字
		public RProperty displayName;

		public RComponentDropdownItem(string name) : base(name)
		{
			displayName = new RProperty(this, "name");
		}
	}
}
