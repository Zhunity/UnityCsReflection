using SMFrame.Editor.Refleaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Tilemaps
{
	public class RSceneViewGridManager : RType
	{
		RMethod _drawGrid;

		public RSceneViewGridManager() : base("SceneViewGridManager")
		{
			_drawGrid = new RMethod(this, "DrawGrid");
		}

		public void DrawGrid(GridLayout gridLayout)
		{
			_drawGrid.Invoke(gridLayout);
		}
	}
}