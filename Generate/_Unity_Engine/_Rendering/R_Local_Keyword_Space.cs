
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.LocalKeywordSpace
	/// </summary>
    public partial class RLocalKeywordSpace : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.LocalKeywordSpace);
            }
        }

        public RLocalKeywordSpace() : base("UnityEngine.Rendering.LocalKeywordSpace")
        {
        }

        public RLocalKeywordSpace(System.Object instance) : base("UnityEngine.Rendering.LocalKeywordSpace")
		{
            SetInstance(instance);
		}

        public RLocalKeywordSpace(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLocalKeywordSpace(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.IntPtr m_KeywordSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_KeywordSpace;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_KeywordSpace
		{
			get
			{
				if(r_Fm_KeywordSpace == null)
				{
					r_Fm_KeywordSpace = new(this, "m_KeywordSpace");
				}
				return r_Fm_KeywordSpace;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword[] keywords
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RLocalKeyword> r_Pkeywords;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RLocalKeyword> RPkeywords
		{
			get
			{
				if(r_Pkeywords == null)
				{
					r_Pkeywords = new(this, "keywords", -1);
				}
				return r_Pkeywords;
			}
		}

		/// <summary>
		/// System.String[] keywordNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PkeywordNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPkeywordNames
		{
			get
			{
				if(r_PkeywordNames == null)
				{
					r_PkeywordNames = new(this, "keywordNames", -1);
				}
				return r_PkeywordNames;
			}
		}

		/// <summary>
		/// UInt32 keywordCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PkeywordCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPkeywordCount
		{
			get
			{
				if(r_PkeywordCount == null)
				{
					r_PkeywordCount = new(this, "keywordCount", -1);
				}
				return r_PkeywordCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword[] GetKeywords()
		/// </summary>
		protected RMethod r_MGetKeywords;
		public virtual RMethod RMGetKeywords
		{
			get
			{
				if(r_MGetKeywords == null)
				{
					r_MGetKeywords = new(this, "GetKeywords", 0);
				}
				return r_MGetKeywords;
			}
		}

		/// <summary>
		/// System.String[] GetKeywordNames()
		/// </summary>
		protected RMethod r_MGetKeywordNames;
		public virtual RMethod RMGetKeywordNames
		{
			get
			{
				if(r_MGetKeywordNames == null)
				{
					r_MGetKeywordNames = new(this, "GetKeywordNames", 0);
				}
				return r_MGetKeywordNames;
			}
		}

		/// <summary>
		/// UInt32 GetKeywordCount()
		/// </summary>
		protected RMethod r_MGetKeywordCount;
		public virtual RMethod RMGetKeywordCount
		{
			get
			{
				if(r_MGetKeywordCount == null)
				{
					r_MGetKeywordCount = new(this, "GetKeywordCount", 0);
				}
				return r_MGetKeywordCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword GetKeyword(System.String)
		/// </summary>
		protected RMethod r_MGetKeyword_String;
		public virtual RMethod RMGetKeyword_String
		{
			get
			{
				if(r_MGetKeyword_String == null)
				{
					r_MGetKeyword_String = new(this, "GetKeyword", 0, typeof(System.String));
				}
				return r_MGetKeyword_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword FindKeyword(System.String)
		/// </summary>
		protected RMethod r_MFindKeyword_String;
		public virtual RMethod RMFindKeyword_String
		{
			get
			{
				if(r_MFindKeyword_String == null)
				{
					r_MFindKeyword_String = new(this, "FindKeyword", 0, typeof(System.String));
				}
				return r_MFindKeyword_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_MEquals_Object;
		public virtual RMethod RMEquals_Object
		{
			get
			{
				if(r_MEquals_Object == null)
				{
					r_MEquals_Object = new(this, "Equals", 0, typeof(System.Object));
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.LocalKeywordSpace)
		/// </summary>
		protected RMethod r_MEquals_LocalKeywordSpace;
		public virtual RMethod RMEquals_LocalKeywordSpace
		{
			get
			{
				if(r_MEquals_LocalKeywordSpace == null)
				{
					r_MEquals_LocalKeywordSpace = new(this, "Equals", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace));
				}
				return r_MEquals_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rendering.LocalKeywordSpace, UnityEngine.Rendering.LocalKeywordSpace)
		/// </summary>
		protected static RMethod r_Mop_Equality_LocalKeywordSpace_LocalKeywordSpace;
		public static RMethod RMop_Equality_LocalKeywordSpace_LocalKeywordSpace
		{
			get
			{
				if(r_Mop_Equality_LocalKeywordSpace_LocalKeywordSpace == null)
				{
					r_Mop_Equality_LocalKeywordSpace_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "op_Equality", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace), typeof(UnityEngine.Rendering.LocalKeywordSpace));
				}
				return r_Mop_Equality_LocalKeywordSpace_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.LocalKeywordSpace, UnityEngine.Rendering.LocalKeywordSpace)
		/// </summary>
		protected static RMethod r_Mop_Inequality_LocalKeywordSpace_LocalKeywordSpace;
		public static RMethod RMop_Inequality_LocalKeywordSpace_LocalKeywordSpace
		{
			get
			{
				if(r_Mop_Inequality_LocalKeywordSpace_LocalKeywordSpace == null)
				{
					r_Mop_Inequality_LocalKeywordSpace_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "op_Inequality", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace), typeof(UnityEngine.Rendering.LocalKeywordSpace));
				}
				return r_Mop_Inequality_LocalKeywordSpace_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_MGetHashCode;
		public virtual RMethod RMGetHashCode
		{
			get
			{
				if(r_MGetHashCode == null)
				{
					r_MGetHashCode = new(this, "GetHashCode", 0);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword[] GetKeywords_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef)
		/// </summary>
		protected static RMethod r_MGetKeywords_Injected_Ref_LocalKeywordSpace;
		public static RMethod RMGetKeywords_Injected_Ref_LocalKeywordSpace
		{
			get
			{
				if(r_MGetKeywords_Injected_Ref_LocalKeywordSpace == null)
				{
					r_MGetKeywords_Injected_Ref_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "GetKeywords_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType());
				}
				return r_MGetKeywords_Injected_Ref_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// System.String[] GetKeywordNames_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef)
		/// </summary>
		protected static RMethod r_MGetKeywordNames_Injected_Ref_LocalKeywordSpace;
		public static RMethod RMGetKeywordNames_Injected_Ref_LocalKeywordSpace
		{
			get
			{
				if(r_MGetKeywordNames_Injected_Ref_LocalKeywordSpace == null)
				{
					r_MGetKeywordNames_Injected_Ref_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "GetKeywordNames_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType());
				}
				return r_MGetKeywordNames_Injected_Ref_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// UInt32 GetKeywordCount_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef)
		/// </summary>
		protected static RMethod r_MGetKeywordCount_Injected_Ref_LocalKeywordSpace;
		public static RMethod RMGetKeywordCount_Injected_Ref_LocalKeywordSpace
		{
			get
			{
				if(r_MGetKeywordCount_Injected_Ref_LocalKeywordSpace == null)
				{
					r_MGetKeywordCount_Injected_Ref_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "GetKeywordCount_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType());
				}
				return r_MGetKeywordCount_Injected_Ref_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Void GetKeyword_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef, System.String, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected static RMethod r_MGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword;
		public static RMethod RMGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword
		{
			get
			{
				if(r_MGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword == null)
				{
					r_MGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "GetKeyword_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType(), typeof(System.String), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
				}
				return r_MGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_MToString;
		public virtual RMethod RMToString
		{
			get
			{
				if(r_MToString == null)
				{
					r_MToString = new(this, "ToString", 0);
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_MFinalize;
		public virtual RMethod RMFinalize
		{
			get
			{
				if(r_MFinalize == null)
				{
					r_MFinalize = new(this, "Finalize", 0);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_MGetType;
		public virtual RMethod RMGetType
		{
			get
			{
				if(r_MGetType == null)
				{
					r_MGetType = new(this, "GetType", 0);
				}
				return r_MGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MMemberwiseClone;
		public virtual RMethod RMMemberwiseClone
		{
			get
			{
				if(r_MMemberwiseClone == null)
				{
					r_MMemberwiseClone = new(this, "MemberwiseClone", 0);
				}
				return r_MMemberwiseClone;
			}
		}


        public virtual UnityEngine.Rendering.LocalKeyword[] GetKeywords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetKeywords.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.LocalKeyword[])___result;
        }


        public virtual System.String[] GetKeywordNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetKeywordNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.UInt32 GetKeywordCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetKeywordCount.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual UnityEngine.Rendering.LocalKeyword GetKeyword(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetKeyword_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.LocalKeyword)___result;
        }


        public virtual UnityEngine.Rendering.LocalKeyword FindKeyword(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFindKeyword_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.LocalKeyword)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.LocalKeywordSpace @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rhs};
            var ___result = RMEquals_LocalKeywordSpace.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.LocalKeywordSpace @lhs, UnityEngine.Rendering.LocalKeywordSpace @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_LocalKeywordSpace_LocalKeywordSpace.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.LocalKeywordSpace @lhs, UnityEngine.Rendering.LocalKeywordSpace @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_LocalKeywordSpace_LocalKeywordSpace.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Rendering.LocalKeyword[] GetKeywords_Injected(ref UnityEngine.Rendering.LocalKeywordSpace @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMGetKeywords_Injected_Ref_LocalKeywordSpace.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (UnityEngine.Rendering.LocalKeyword[])___result;
        }


        public static System.String[] GetKeywordNames_Injected(ref UnityEngine.Rendering.LocalKeywordSpace @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMGetKeywordNames_Injected_Ref_LocalKeywordSpace.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (System.String[])___result;
        }


        public static System.UInt32 GetKeywordCount_Injected(ref UnityEngine.Rendering.LocalKeywordSpace @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMGetKeywordCount_Injected_Ref_LocalKeywordSpace.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (System.UInt32)___result;
        }


        public static void GetKeyword_Injected(ref UnityEngine.Rendering.LocalKeywordSpace @_unity_self, System.String @name, out UnityEngine.Rendering.LocalKeyword @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @name, @ret};
            var ___result = RMGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];
			@ret = (UnityEngine.Rendering.LocalKeyword)___parameters[2];

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
