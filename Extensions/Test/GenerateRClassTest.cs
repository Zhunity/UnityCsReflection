using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
#endif

namespace Hvak.Editor.Refleaction
{
	/// <summary>
	/// 生成器测试用的普通类型。
	/// </summary>
	class ATest
	{
		int a = 2;

		void Log()
		{
			Debug.Log("Log ATest");
		}
	}

	/// <summary>
	/// 生成器测试用的普通类型，包含字段、属性和嵌套对象。
	/// </summary>
	class BTest
	{
		string str = "hello world!";

		ATest aTest
		{
			get; set;
		} = new ATest();
	}

	/// <summary>
	/// RType 生成与调用测试入口。
	/// 注意：本文件默认不引用生成后的 R 命名空间，避免 Generate 目录为空时导致 Unity 编译失败。
	/// </summary>
	static class Test
	{
		[MenuItem("Tools/NewGenerate")]
		static void GenerateNewWay()
		{
			// 如果需要用到 dll 的 alias，可以在这里注册。
			ModuleAliasConfig.Set(string.Empty, string.Empty);

			// 指向当前插件目录，生成结果会放到 Assets/UnityCsReflection/Generate 下。
			GenerateRtype.UnityCSReflectionPath = $"{Application.dataPath}/UnityCsReflection/";

			// 生成测试类型和常用 Unity Editor 类型的 RType。
			GenerateRtype.Generate(new List<string>
			{
				"UnityType",
				"ComponentDropdownItem",
				"AddComponentWindow",
				"PackageManagerWindow",
				"BTest",
			});
		}

#if UNITY_CS_REFLECTION_GENERATED_TEST
		[MenuItem("Tools/Test Generate")]
		static void TestRType()
		{
			// 打开 UNITY_CS_REFLECTION_GENERATED_TEST 宏前，请先执行 Tools/NewGenerate 并确保生成代码已编译通过。
			var bTest = new BTest();
			var rBTest = new Hvak.Editor.Refleaction.RHvak.REditor.RRefleaction.RBTest(bTest);
			Debug.Log(rBTest.RFstr.Value);
			Debug.Log(rBTest.RPaTest.RFa.Value);
			rBTest.RPaTest.Log();
		}
#endif
	}
}