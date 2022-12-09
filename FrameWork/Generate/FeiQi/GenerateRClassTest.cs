using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System.IO;
using SMFrame.Editor.Refleaction.RUnityEngine;

namespace SMFrame.Editor.Refleaction
{

	class ATestGenericMethod
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
       // [MenuItem("Tools/generate a file")]
        static void f()
        {
            UnityCSReflectionPath = $"{Application.dataPath}/Script/UnityCsReflection/";


            _waitToGenerate.Clear();
            _cacheType.Clear();
			LoadReplace();

			AddGenerateClass(typeof(GameObject));
            GenerateClasses();
			SaveReplace();
			Debug.Log(_cacheType.Count);
            AssetDatabase.Refresh();
        }

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
			UnityCSReflectionPath = $"{Application.dataPath}/Script/UnityCsReflection/";
			LoadReplace();
			string s = "adfsdsdf.,1.\\q\\qeqqwe\\~";
			LegalName(s);

			// TODO
			// 1. 类中类
			var type = typeof(s.ins);
            //         Debug.Log(type.Name + "  " + type.FullName + "  " + type.ToString());
            //         Debug.Log(ReleactionUtils.GetType(" SMFrame.Editor.Refleaction.GenerateRClass+s+ins"));

            //// 2.泛型
            //type = typeof(Dictionary<,>);
            //Debug.Log(type.Name + "  " + type.FullName + "  " + type.ToString());
            //         Debug.Log(ReleactionUtils.GetType("System.Collections.Generic.Dictionary`2"));

            // 3.接口里面的xxx.xxx
            //type = typeof(DateTime);
            //var m = type.GetMethod("System.IConvertible.ToBoolean", RType.flags);
            //Debug.Log(m);

			// 4.数组

            //Debug.Log(type+ " ----  " + type.Name + " ----  " + type.GetGenericArguments().Length);
            Generate(typeof(DateTime));
			SaveReplace();
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

		//[MenuItem("Tools/TestGameObject")]
		static void TestGameObject()
		{
			GameObject go = GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Cube);
			RGameObject rgo = new RGameObject(go);
			var t= rgo.GetComponent<Transform>();
			Debug.Log(t, t);
		}

		//[MenuItem("Tools/TestVector")]
		static void TestVector()
		{
			Vector3 v = new Vector3(100, 22, 3);
			RVector3 rv = new RVector3(v);
			
			Debug.Log(rv.normalized.Value + "  " + v.normalized);
		}

		[MenuItem("Tools/NewGenerate")]
		static void GenerateNewWay()
		{
			GenerateInput.UnityCSReflectionPath = $"{Application.dataPath}/Script/UnityCsReflection/";


			
			GenerateInput.Generate(typeof(GameObject));
		}

		[MenuItem("Tools/TestNewWay")]
		static void TestNewWay()
		{
			ATestGenericMethod a = new();
			//RATestGenericMethod ra = new(a);
			//Debug.Log(ra.sdfsdf.Value + "  " + RATestGenericMethod.qeqwe.Value);
		}
	}
}
