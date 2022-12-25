using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.LocalKeywordSpace
	/// </summary>
    public partial class RLocalKeywordSpace : RMember //
    {

		/// <summary>
		/// System.IntPtr m_KeywordSpace
		/// </summary>
		protected RField r_m_KeywordSpace;
		public virtual RField Rm_KeywordSpace
		{
			get
			{
				if(r_m_KeywordSpace == null)
				{
					r_m_KeywordSpace = new(this, "m_KeywordSpace");
					r_m_KeywordSpace.SetBelong(this.instance);
				}
				return r_m_KeywordSpace;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword[] keywords
		/// </summary>
		protected RPropertyArray<RUnityEngine.RRendering.RLocalKeyword> r_keywords;
		public virtual RPropertyArray<RUnityEngine.RRendering.RLocalKeyword> Rkeywords
		{
			get
			{
				if(r_keywords == null)
				{
					r_keywords = new(this, "keywords", -1);
					r_keywords.SetBelong(this.instance);
				}
				return r_keywords;
			}
		}

		/// <summary>
		/// System.String[] keywordNames
		/// </summary>
		protected RPropertyArray<RProperty> r_keywordNames;
		public virtual RPropertyArray<RProperty> RkeywordNames
		{
			get
			{
				if(r_keywordNames == null)
				{
					r_keywordNames = new(this, "keywordNames", -1);
					r_keywordNames.SetBelong(this.instance);
				}
				return r_keywordNames;
			}
		}

		/// <summary>
		/// UInt32 keywordCount
		/// </summary>
		protected RProperty r_keywordCount;
		public virtual RProperty RkeywordCount
		{
			get
			{
				if(r_keywordCount == null)
				{
					r_keywordCount = new(this, "keywordCount", -1);
					r_keywordCount.SetBelong(this.instance);
				}
				return r_keywordCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword[] GetKeywords()
		/// </summary>
		protected RMethod r_RGetKeywords;
		public virtual RMethod RGetKeywords
		{
			get
			{
				if(r_RGetKeywords == null)
				{
					r_RGetKeywords = new(this, "GetKeywords", 0);
					r_RGetKeywords.SetBelong(this.instance);
				}
				return r_RGetKeywords;
			}
		}

		/// <summary>
		/// System.String[] GetKeywordNames()
		/// </summary>
		protected RMethod r_RGetKeywordNames;
		public virtual RMethod RGetKeywordNames
		{
			get
			{
				if(r_RGetKeywordNames == null)
				{
					r_RGetKeywordNames = new(this, "GetKeywordNames", 0);
					r_RGetKeywordNames.SetBelong(this.instance);
				}
				return r_RGetKeywordNames;
			}
		}

		/// <summary>
		/// UInt32 GetKeywordCount()
		/// </summary>
		protected RMethod r_RGetKeywordCount;
		public virtual RMethod RGetKeywordCount
		{
			get
			{
				if(r_RGetKeywordCount == null)
				{
					r_RGetKeywordCount = new(this, "GetKeywordCount", 0);
					r_RGetKeywordCount.SetBelong(this.instance);
				}
				return r_RGetKeywordCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword GetKeyword(System.String)
		/// </summary>
		protected RMethod r_RGetKeyword_String;
		public virtual RMethod RGetKeyword_String
		{
			get
			{
				if(r_RGetKeyword_String == null)
				{
					r_RGetKeyword_String = new(this, "GetKeyword", 0, typeof(System.String));
					r_RGetKeyword_String.SetBelong(this.instance);
				}
				return r_RGetKeyword_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword FindKeyword(System.String)
		/// </summary>
		protected RMethod r_RFindKeyword_String;
		public virtual RMethod RFindKeyword_String
		{
			get
			{
				if(r_RFindKeyword_String == null)
				{
					r_RFindKeyword_String = new(this, "FindKeyword", 0, typeof(System.String));
					r_RFindKeyword_String.SetBelong(this.instance);
				}
				return r_RFindKeyword_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.LocalKeywordSpace)
		/// </summary>
		protected RMethod r_REquals_LocalKeywordSpace;
		public virtual RMethod REquals_LocalKeywordSpace
		{
			get
			{
				if(r_REquals_LocalKeywordSpace == null)
				{
					r_REquals_LocalKeywordSpace = new(this, "Equals", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace));
					r_REquals_LocalKeywordSpace.SetBelong(this.instance);
				}
				return r_REquals_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rendering.LocalKeywordSpace, UnityEngine.Rendering.LocalKeywordSpace)
		/// </summary>
		protected static RMethod r_Rop_Equality_LocalKeywordSpace_LocalKeywordSpace;
		public static RMethod Rop_Equality_LocalKeywordSpace_LocalKeywordSpace
		{
			get
			{
				if(r_Rop_Equality_LocalKeywordSpace_LocalKeywordSpace == null)
				{
					r_Rop_Equality_LocalKeywordSpace_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "op_Equality", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace), typeof(UnityEngine.Rendering.LocalKeywordSpace));
					r_Rop_Equality_LocalKeywordSpace_LocalKeywordSpace.SetBelong(null);
				}
				return r_Rop_Equality_LocalKeywordSpace_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.LocalKeywordSpace, UnityEngine.Rendering.LocalKeywordSpace)
		/// </summary>
		protected static RMethod r_Rop_Inequality_LocalKeywordSpace_LocalKeywordSpace;
		public static RMethod Rop_Inequality_LocalKeywordSpace_LocalKeywordSpace
		{
			get
			{
				if(r_Rop_Inequality_LocalKeywordSpace_LocalKeywordSpace == null)
				{
					r_Rop_Inequality_LocalKeywordSpace_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "op_Inequality", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace), typeof(UnityEngine.Rendering.LocalKeywordSpace));
					r_Rop_Inequality_LocalKeywordSpace_LocalKeywordSpace.SetBelong(null);
				}
				return r_Rop_Inequality_LocalKeywordSpace_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword[] GetKeywords_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef)
		/// </summary>
		protected static RMethod r_RGetKeywords_Injected_Ref_LocalKeywordSpace;
		public static RMethod RGetKeywords_Injected_Ref_LocalKeywordSpace
		{
			get
			{
				if(r_RGetKeywords_Injected_Ref_LocalKeywordSpace == null)
				{
					r_RGetKeywords_Injected_Ref_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "GetKeywords_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType());
					r_RGetKeywords_Injected_Ref_LocalKeywordSpace.SetBelong(null);
				}
				return r_RGetKeywords_Injected_Ref_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// System.String[] GetKeywordNames_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef)
		/// </summary>
		protected static RMethod r_RGetKeywordNames_Injected_Ref_LocalKeywordSpace;
		public static RMethod RGetKeywordNames_Injected_Ref_LocalKeywordSpace
		{
			get
			{
				if(r_RGetKeywordNames_Injected_Ref_LocalKeywordSpace == null)
				{
					r_RGetKeywordNames_Injected_Ref_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "GetKeywordNames_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType());
					r_RGetKeywordNames_Injected_Ref_LocalKeywordSpace.SetBelong(null);
				}
				return r_RGetKeywordNames_Injected_Ref_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// UInt32 GetKeywordCount_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef)
		/// </summary>
		protected static RMethod r_RGetKeywordCount_Injected_Ref_LocalKeywordSpace;
		public static RMethod RGetKeywordCount_Injected_Ref_LocalKeywordSpace
		{
			get
			{
				if(r_RGetKeywordCount_Injected_Ref_LocalKeywordSpace == null)
				{
					r_RGetKeywordCount_Injected_Ref_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "GetKeywordCount_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType());
					r_RGetKeywordCount_Injected_Ref_LocalKeywordSpace.SetBelong(null);
				}
				return r_RGetKeywordCount_Injected_Ref_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Void GetKeyword_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef, System.String, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected static RMethod r_RGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword;
		public static RMethod RGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword
		{
			get
			{
				if(r_RGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword == null)
				{
					r_RGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "GetKeyword_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType(), typeof(System.String), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_RGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword.SetBelong(null);
				}
				return r_RGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
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

        public virtual UnityEngine.Rendering.LocalKeyword[] GetKeywords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetKeywords.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.LocalKeyword[])___result;
        }


        public virtual System.String[] GetKeywordNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetKeywordNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.UInt32 GetKeywordCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetKeywordCount.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual UnityEngine.Rendering.LocalKeyword GetKeyword(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetKeyword_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.LocalKeyword)___result;
        }


        public virtual UnityEngine.Rendering.LocalKeyword FindKeyword(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFindKeyword_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.LocalKeyword)___result;
        }


        public virtual System.Boolean Equals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.LocalKeywordSpace  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rhs};
            var ___result = REquals_LocalKeywordSpace.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.LocalKeywordSpace  @lhs, UnityEngine.Rendering.LocalKeywordSpace  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_LocalKeywordSpace_LocalKeywordSpace.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.LocalKeywordSpace  @lhs, UnityEngine.Rendering.LocalKeywordSpace  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_LocalKeywordSpace_LocalKeywordSpace.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Rendering.LocalKeyword[] GetKeywords_Injected(ref UnityEngine.Rendering.LocalKeywordSpace  @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetKeywords_Injected_Ref_LocalKeywordSpace.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (UnityEngine.Rendering.LocalKeyword[])___result;
        }


        public static System.String[] GetKeywordNames_Injected(ref UnityEngine.Rendering.LocalKeywordSpace  @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetKeywordNames_Injected_Ref_LocalKeywordSpace.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (System.String[])___result;
        }


        public static System.UInt32 GetKeywordCount_Injected(ref UnityEngine.Rendering.LocalKeywordSpace  @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetKeywordCount_Injected_Ref_LocalKeywordSpace.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (System.UInt32)___result;
        }


        public static void GetKeyword_Injected(ref UnityEngine.Rendering.LocalKeywordSpace  @_unity_self, System.String  @name, out UnityEngine.Rendering.LocalKeyword  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @name, @ret};
            var ___result = RGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];
			ret = (UnityEngine.Rendering.LocalKeyword)___parameters[2];

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
