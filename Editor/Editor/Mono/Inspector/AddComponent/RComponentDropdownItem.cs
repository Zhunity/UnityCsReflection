using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SMFrame.Editor.Refleaction;

namespace SMFrame.Editor
{
	/// <summary>
	/// ComponentItem的对象的对象
	/// </summary>
	public class RComponentDropdownItem : Class
	{
		// ComponentItem在AddComponentWindow显示的名字
		public Property displayName;

		public RComponentDropdownItem(string name) : base(name)
		{
			displayName = new Property(this, "name");
		}
	}
}
