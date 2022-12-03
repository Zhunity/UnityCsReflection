using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System.IO;

namespace SMFrame.Editor.Refleaction
{

	class A
	{

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
        [MenuItem("Tools/generate a file")]
        static void f()
        {
            UnityCSReflectionPath = $"{Application.dataPath}/Script/UnityCsReflection/";


            _waitToGenerate.Clear();
            _cacheType.Clear();
			LoadReplace();

			AddGenerateClass(typeof(GameObject));
            GenerateClasses();
			SaveReplace();
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
		
		[MenuItem("Tools/ra invoke")]
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
            //var m = type.GetMethod("System.IConvertible.ToBoolean", Class.flags);
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
            //         A a = new A();
            //         RA ra = new RA();
            //         ra.SetInstance(a);
            //         ra.N();

            //Debug.Log(ra.N(new int[] { }));
        }
    }
}
