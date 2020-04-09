﻿using SMFrame;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

namespace SMFrame.Editor.Extension
{
	public class SceneGrid : Singleton<SceneGrid>
	{
		RSceneViewGridManager manager = new RSceneViewGridManager();
		Grid grid;

		public void Init()
		{
			grid = Object.FindObjectOfType<Grid>();
		}

		public void OnSceneGUI()
		{
			if(grid == null)
			{
				return;
			}
			manager.DrawGrid(grid);
		}
	}
}