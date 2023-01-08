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
		protected RMethod r_GetKeywords;
		public virtual RMethod RGetKeywords
		{
			get
			{
				if(r_GetKeywords == null)
				{
					r_GetKeywords = new(this, "GetKeywords", 0);
					r_GetKeywords.SetBelong(this.instance);
				}
				return r_GetKeywords;
			}
		}

		/// <summary>
		/// System.String[] GetKeywordNames()
		/// </summary>
		protected RMethod r_GetKeywordNames;
		public virtual RMethod RGetKeywordNames
		{
			get
			{
				if(r_GetKeywordNames == null)
				{
					r_GetKeywordNames = new(this, "GetKeywordNames", 0);
					r_GetKeywordNames.SetBelong(this.instance);
				}
				return r_GetKeywordNames;
			}
		}

		/// <summary>
		/// UInt32 GetKeywordCount()
		/// </summary>
		protected RMethod r_GetKeywordCount;
		public virtual RMethod RGetKeywordCount
		{
			get
			{
				if(r_GetKeywordCount == null)
				{
					r_GetKeywordCount = new(this, "GetKeywordCount", 0);
					r_GetKeywordCount.SetBelong(this.instance);
				}
				return r_GetKeywordCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword GetKeyword(System.String)
		/// </summary>
		protected RMethod r_GetKeyword_String;
		public virtual RMethod RGetKeyword_String
		{
			get
			{
				if(r_GetKeyword_String == null)
				{
					r_GetKeyword_String = new(this, "GetKeyword", 0, typeof(System.String));
					r_GetKeyword_String.SetBelong(this.instance);
				}
				return r_GetKeyword_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword FindKeyword(System.String)
		/// </summary>
		protected RMethod r_FindKeyword_String;
		public virtual RMethod RFindKeyword_String
		{
			get
			{
				if(r_FindKeyword_String == null)
				{
					r_FindKeyword_String = new(this, "FindKeyword", 0, typeof(System.String));
					r_FindKeyword_String.SetBelong(this.instance);
				}
				return r_FindKeyword_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.LocalKeywordSpace)
		/// </summary>
		protected RMethod r_Equals_LocalKeywordSpace;
		public virtual RMethod REquals_LocalKeywordSpace
		{
			get
			{
				if(r_Equals_LocalKeywordSpace == null)
				{
					r_Equals_LocalKeywordSpace = new(this, "Equals", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace));
					r_Equals_LocalKeywordSpace.SetBelong(this.instance);
				}
				return r_Equals_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rendering.LocalKeywordSpace, UnityEngine.Rendering.LocalKeywordSpace)
		/// </summary>
		protected static RMethod r_op_Equality_LocalKeywordSpace_LocalKeywordSpace;
		public static RMethod Rop_Equality_LocalKeywordSpace_LocalKeywordSpace
		{
			get
			{
				if(r_op_Equality_LocalKeywordSpace_LocalKeywordSpace == null)
				{
					r_op_Equality_LocalKeywordSpace_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "op_Equality", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace), typeof(UnityEngine.Rendering.LocalKeywordSpace));
					r_op_Equality_LocalKeywordSpace_LocalKeywordSpace.SetBelong(null);
				}
				return r_op_Equality_LocalKeywordSpace_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.LocalKeywordSpace, UnityEngine.Rendering.LocalKeywordSpace)
		/// </summary>
		protected static RMethod r_op_Inequality_LocalKeywordSpace_LocalKeywordSpace;
		public static RMethod Rop_Inequality_LocalKeywordSpace_LocalKeywordSpace
		{
			get
			{
				if(r_op_Inequality_LocalKeywordSpace_LocalKeywordSpace == null)
				{
					r_op_Inequality_LocalKeywordSpace_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "op_Inequality", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace), typeof(UnityEngine.Rendering.LocalKeywordSpace));
					r_op_Inequality_LocalKeywordSpace_LocalKeywordSpace.SetBelong(null);
				}
				return r_op_Inequality_LocalKeywordSpace_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LocalKeyword[] GetKeywords_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef)
		/// </summary>
		protected static RMethod r_GetKeywords_Injected_Ref_LocalKeywordSpace;
		public static RMethod RGetKeywords_Injected_Ref_LocalKeywordSpace
		{
			get
			{
				if(r_GetKeywords_Injected_Ref_LocalKeywordSpace == null)
				{
					r_GetKeywords_Injected_Ref_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "GetKeywords_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType());
					r_GetKeywords_Injected_Ref_LocalKeywordSpace.SetBelong(null);
				}
				return r_GetKeywords_Injected_Ref_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// System.String[] GetKeywordNames_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef)
		/// </summary>
		protected static RMethod r_GetKeywordNames_Injected_Ref_LocalKeywordSpace;
		public static RMethod RGetKeywordNames_Injected_Ref_LocalKeywordSpace
		{
			get
			{
				if(r_GetKeywordNames_Injected_Ref_LocalKeywordSpace == null)
				{
					r_GetKeywordNames_Injected_Ref_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "GetKeywordNames_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType());
					r_GetKeywordNames_Injected_Ref_LocalKeywordSpace.SetBelong(null);
				}
				return r_GetKeywordNames_Injected_Ref_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// UInt32 GetKeywordCount_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef)
		/// </summary>
		protected static RMethod r_GetKeywordCount_Injected_Ref_LocalKeywordSpace;
		public static RMethod RGetKeywordCount_Injected_Ref_LocalKeywordSpace
		{
			get
			{
				if(r_GetKeywordCount_Injected_Ref_LocalKeywordSpace == null)
				{
					r_GetKeywordCount_Injected_Ref_LocalKeywordSpace = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "GetKeywordCount_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType());
					r_GetKeywordCount_Injected_Ref_LocalKeywordSpace.SetBelong(null);
				}
				return r_GetKeywordCount_Injected_Ref_LocalKeywordSpace;
			}
		}

		/// <summary>
		/// Void GetKeyword_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef, System.String, UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected static RMethod r_GetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword;
		public static RMethod RGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword
		{
			get
			{
				if(r_GetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword == null)
				{
					r_GetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeywordSpace), "GetKeyword_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType(), typeof(System.String), typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_GetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword.SetBelong(null);
				}
				return r_GetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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
			@_unity_self = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (UnityEngine.Rendering.LocalKeyword[])___result;
        }


        public static System.String[] GetKeywordNames_Injected(ref UnityEngine.Rendering.LocalKeywordSpace  @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetKeywordNames_Injected_Ref_LocalKeywordSpace.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (System.String[])___result;
        }


        public static System.UInt32 GetKeywordCount_Injected(ref UnityEngine.Rendering.LocalKeywordSpace  @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetKeywordCount_Injected_Ref_LocalKeywordSpace.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (System.UInt32)___result;
        }


        public static void GetKeyword_Injected(ref UnityEngine.Rendering.LocalKeywordSpace  @_unity_self, System.String  @name, out UnityEngine.Rendering.LocalKeyword  @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @name, @ret};
            var ___result = RGetKeyword_Injected_Ref_LocalKeywordSpace_String_Out_LocalKeyword.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];
			@ret = (UnityEngine.Rendering.LocalKeyword)___parameters[2];

            
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
