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
using Hvak.Editor.Refleaction.RHvak.REditor.RRefleaction;

namespace Hvak.Editor.Refleaction
{

	class ATest
	{
		int a = 2;

		void Log()
		{
			Debug.Log("Log ATest");
		}
	}

	class BTest
	{
		string str = "hello world!";

		ATest aTest
		{
			get; set;
		} = new ATest();
	}

	static class Test
	{ 
		[MenuItem("Tools/NewGenerate")]
		static void GenerateNewWay()
		{
			// 0、如果需要用到dll的别名，可以在这里注册。（因为不知道怎么反射dll的alias名，先用笨方法，手动注册了）
			ModuleAliasConfig.Set("", "");
			// 1、指定生成代码的文件夹路径
			GenerateRtype.UnityCSReflectionPath = $"{Application.dataPath}/Script/UnityCsReflection/";
			// 2、添加需要生成的类，重载了三种接口，这是其中传入类型名字的接口，其余两种是传类型列表，传实例列表
			GenerateRtype.Generate(new List<string> { "UnityType", "ComponentDropdownItem", "AddComponentWindow", "PackageManagerWindow", "BTest" });
		}

		[MenuItem("Tools/Test Generate")]
		static void TestRType()
		{
			// 1、这里虽然是直接new了一个BTest，但是现实情况可能通过其他手段拿到的BTest实例
			BTest bTest = new BTest();
			// 2、new一个RBTest，并把BTest的实例传进去
			RBTest rBTest = new RBTest(bTest);
			// 3、尝试调用通过RBTest来调用BTest里面的private field
			Debug.Log(rBTest.RFstr.Value);
			// 4、尝试调用通过RBTest来调用BTest里面的private property
			Debug.Log(rBTest.RPaTest.RFa.Value);
			// 5、尝试调用通过RBTest来调用BTest里面的private method
			rBTest.RPaTest.Log();
		}
	}
}
