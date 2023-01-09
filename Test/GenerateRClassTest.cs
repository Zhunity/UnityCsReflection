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
using SMFrame.Editor.Refleaction.RSystem.RReflection;
using UnityEngine.UI;

namespace SMFrame.Editor.Refleaction
{

	public class ATestGenericMethod
	{
		static int qeqwe = 345345345;
		string sdfsdf = "wffewfwefwefwef";

		string s { get { return "rrrrr"; } }

		int this[int x]
		{
			get
			{
				return x + 999;
			}
		}

		string this[string s]
		{
			get
			{
				return "ssss" + s;
			}
		}

		public static float N<T>(int e, out T a, ref float b, in long c, params bool[][][] d)
		{
			a = default;
			return 1;
		}

		public void N()
		{
			Debug.Log("no param");
		}

		public string N<T>(T[] a = default)
		{
			return "12312312";
		}

		public int N(ref string[] s)
		{
			return 1111;
		}

		public void N<a, b, c, d, e, f, g>(Dictionary<a, int> s, b[] asdf, HashSet<Dictionary<e, c[]>> wer)
		{
			Debug.Log("N ???");
		}

		public string N<T, U>(T a, U b)
		{
			return "wwwww";
		}

		/// <summary>
		/// out找不到
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		public string N(out bool a)
		{
			a = true;
			return "out bool";
		}

		public string N(ref int a)
		{
			a = 234234;
			return "ref www";
		}

		public string N(bool a)
		{
			a = true;
			return "iiiii";
		}

		public string N(bool[][][][] a)
		{
			return "12312312";
		}

		public string N(in Dictionary<int[], List<string[][]>>[][] a)
		{
			return "Dictionary<int[], List<string[][]>>[][]";
		}

		public int N<T, U, A, z>(Dictionary<T, U> www, A fff, float e)
		{
			return 999;
		}

		public string N(ref List<int> a)
		{
			return "12312312";
		}
	}

    public partial class GenerateRClass
    {

        class s : IDisposable
        {
             void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }

            void Dispose()
            {

            }

            public class ins {

            }

        }
        class g<T> { }
		
		//[MenuItem("Tools/ra invoke")]
		static void G()
		{
			

			// TODO
			// 1. 类中类
			var type = typeof(s.ins);
            //         Debug.Log(type.Name + "  " + type.FullName + "  " + type.ToString());
            //         Debug.Log(ReflectionUtils.GetType(" SMFrame.Editor.Refleaction.GenerateRClass+s+ins"));

            //// 2.泛型
            //type = typeof(Dictionary<,>);
            //Debug.Log(type.Name + "  " + type.FullName + "  " + type.ToString());
            //         Debug.Log(ReflectionUtils.GetType("System.Collections.Generic.Dictionary`2"));

            // 3.接口里面的xxx.xxx
            //type = typeof(DateTime);
            //var m = type.GetMethod("System.IConvertible.ToBoolean", RType.flags);
            //Debug.Log(m);

			// 4.数组

            //Debug.Log(type+ " ----  " + type.Name + " ----  " + type.GetGenericArguments().Length);
         
			AssetDatabase.Refresh();
            //a<int> ss = new a<int> ();
            //RSMFrame.REditor.RRefleaction.Ra<int> test = new();
            //test.SetBelong(ss);
            //Debug.Log( test.ToString());
            //         ATestGenericMethod a = new ATestGenericMethod();
            //         RA ra = new RA();
            //         ra.SetInstance(a);
            //         ra.N();

            //Debug.Log(ra.N(new int[] { }));
        }

		class testItem
		{
			public int this[int a]
			{
				get
				{
					return 1;
				}
			}
		}

		//[MenuItem("Tools/Matrix4x4e")]
		static void Mat()
		{
			var t = typeof(Matrix4x4);
			//var p = t.GetProperties(RType.flags);
			//foreach(var item in p)
			//{
			//	Debug.Log(item.GetMethod + "  " + item.SetMethod);
			//}
			var p1 = t.GetProperty("Item", RType.flags, null, null, new Type[] { typeof(int)}, null); ;
			var p2 = t.GetProperty("Item", RType.flags, null, null, new Type[] { typeof(int), typeof(int) }, null);
			Debug.Log(p1 + "  " + p2);
		}

		[MenuItem("Tools/NewGenerate")]
		static void GenerateNewWay()
		{
			GenerateInput.UnityCSReflectionPath = $"{Application.dataPath}/Script/UnityCsReflection/";

			GenerateInput.Generate(new List<string> { "UnityType", "ComponentDropdownItem", "AddComponentWindow" });
		}

		public class outest
		{
			public class inner : ATestGenericMethod
			{
				public class innest<U> where U : outest
				{
					public class moreInnest<T> where T : struct
					{
						inner field;
					}

					public class anotherInnest { }
				}
			}
			inner aaa;
			List<int> list;

			HashSet<string> s
			{ get; set; }

			T gT<T>(T g) where T : new()
			{
				return default;
			}
		}

		class aBase
		{
			public void newmethod()
			{

			}

			public virtual void virtualmethod()
			{

			}
		}

		class child : aBase
		{
			public new void newmethod()
			{

			}

			public override void virtualmethod()
			{
				base.virtualmethod();
			}
		}

		[MenuItem("Tools/TestNewWay")]
		static void TestNewWay()
		{
			//Type t = typeof(child);
			//var m = t.GetMethods(RType.flags);
			//foreach(var s in m )
			//{
			//	Debug.Log(s.ToString() + " " + s.IsHideBySig + "  " + s.DeclaringType);
			//}

			GenerateInput.UnityCSReflectionPath = $"{Application.dataPath}/Script/UnityCsReflection/";




			GenerateInput.Generate(typeof(UnityEngine.UIElements.Slider));
			//GenerateInput.Generate(typeof(outest.inner.innest<>.anotherInnest), false);
		}

		[MenuItem("Tools/test generic")]
		static void SHow()
		{
			// 因为只有set函数，所以就一定有一个参数
			var t = ReflectionUtils.GetType("System.Threading.StackCrawlMark");
			var p = t.GetProperties(RType.flags);
			foreach(var itm in p)
			{
				var m = itm.GetMethod == null ? itm.SetMethod : itm.GetMethod;
				Debug.Log(itm.Name + "  " + itm.GetIndexParameters().Length + "  " + m.Name + "  " + m.GetParameters().Length + "  " + itm.DeclaringType);
			}

			var ss = t.GetProperty("FromByteArray", RType.flags, null, null, new Type[] { typeof(System.Boolean) }, null);
			Debug.Log(ss);
		}


		class e
		{
			public event Action OnTextChanged;
		}
		[MenuItem("Tools/test event")]
		static void TestEvent()
		{
			var t = typeof(e);
			var m = t.GetMembers();
			foreach(var i in m)
			{
				Debug.Log(i + "  " + i.MemberType);
			}

			var fields = t.GetFields(RType.flags);
			foreach(var fs in fields)
			{
				Debug.Log(fs.Name + "  " + fs.MemberType + " " + fs.FieldType);
			}

			var f = t.GetField("OnTextChanged");
			var e = t.GetEvent("OnTextChanged");
			Debug.Log("f " + f);
			Debug.Log("e " + e);
		}
	}
}
