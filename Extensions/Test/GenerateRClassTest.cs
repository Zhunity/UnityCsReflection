using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
#endif
using System.Reflection;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Hvak.Editor.Refleaction.RSystem.RReflection;
using UnityEngine.UI;

namespace Hvak.Editor.Refleaction
{
	static class Test
	{ 
		[MenuItem("Tools/NewGenerate")]
		static void GenerateNewWay()
		{
			GenerateInput.UnityCSReflectionPath = $"{Application.dataPath}/UnityCsReflection/";

			GenerateInput.Generate(new List<string> { "UnityType", "ComponentDropdownItem", "AddComponentWindow", "PackageManagerWindow" });
		}
	}
}
