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
			// 0、如果需要用到dll的别名，可以在这里注册。（因为不知道怎么反射dll的alias名，先用笨方法，手动注册了）
			ModuleAliasConfig.Set("", "");
			// 1、指定生成代码的文件夹路径
			GenerateRtype.UnityCSReflectionPath = $"{Application.dataPath}/UnityCsReflection/";
			// 2、添加需要生成的类，重载了三种接口，这是其中传入类型名字的接口，其余两种是传类型列表，传实例列表
			GenerateRtype.Generate(new List<string> { "UnityType", "ComponentDropdownItem", "AddComponentWindow", "PackageManagerWindow" });
		}
	}
}
