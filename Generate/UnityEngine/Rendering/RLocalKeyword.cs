using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.LocalKeyword
	/// </summary>
    public partial class RLocalKeyword : RMember //
    {

		/// <summary>
		/// UnityEngine.Rendering.LocalKeywordSpace m_SpaceInfo
		/// </summary>
		protected RUnityEngine.RRendering.RLocalKeywordSpace r_m_SpaceInfo;
		public virtual RUnityEngine.RRendering.RLocalKeywordSpace Rm_SpaceInfo
		{
			get
			{
				if(r_m_SpaceInfo == null)
				{
					r_m_SpaceInfo = new(this, "m_SpaceInfo");
					r_m_SpaceInfo.SetBelong(this.instance);
				}
				return r_m_SpaceInfo;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected RSystem.RString r_m_Name;
		public virtual RSystem.RString Rm_Name
		{
			get
			{
				if(r_m_Name == null)
				{
					r_m_Name = new(this, "m_Name");
					r_m_Name.SetBelong(this.instance);
				}
				return r_m_Name;
			}
		}

		/// <summary>
		/// System.UInt32 m_Index
		/// </summary>
		protected RSystem.RUInt32 r_m_Index;
		public virtual RSystem.RUInt32 Rm_Index
		{
			get
			{
				if(r_m_Index == null)
				{
					r_m_Index = new(this, "m_Index");
					r_m_Index.SetBelong(this.instance);
				}
				return r_m_Index;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_name;
		public virtual RSystem.RString Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// Boolean isDynamic
		/// </summary>
		protected RSystem.RBoolean r_isDynamic;
		public virtual RSystem.RBoolean RisDynamic
		{
			get
			{
				if(r_isDynamic == null)
				{
					r_isDynamic = new(this, "isDynamic", -1);
					r_isDynamic.SetBelong(this.instance);
				}
				return r_isDynamic;
			}
		}

		/// <summary>
		/// Boolean isOverridable
		/// </summary>
		protected RSystem.RBoolean r_isOverridable;
		public virtual RSystem.RBoolean RisOverridable
		{
			get
			{
				if(r_isOverridable == null)
				{
					r_isOverridable = new(this, "isOverridable", -1);
					r_isOverridable.SetBelong(this.instance);
				}
				return r_isOverridable;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected RSystem.RBoolean r_isValid;
		public virtual RSystem.RBoolean RisValid
		{
			get
			{
				if(r_isValid == null)
				{
					r_isValid = new(this, "isValid", -1);
					r_isValid.SetBelong(this.instance);
				}
				return r_isValid;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderKeywordType type
		/// </summary>
		protected RProperty r_type;
		public virtual RProperty Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type", -1);
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// Boolean IsDynamic(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected static RMethod r_IsDynamic_LocalKeyword;
		public static RMethod RIsDynamic_LocalKeyword
		{
			get
			{
				if(r_IsDynamic_LocalKeyword == null)
				{
					r_IsDynamic_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeyword), "IsDynamic", 0, typeof(UnityEngine.Rendering.LocalKeyword));
					r_IsDynamic_LocalKeyword.SetBelong(null);
				}
				return r_IsDynamic_LocalKeyword;
			}
		}

		/// <summary>
		/// Boolean IsOverridable(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected static RMethod r_IsOverridable_LocalKeyword;
		public static RMethod RIsOverridable_LocalKeyword
		{
			get
			{
				if(r_IsOverridable_LocalKeyword == null)
				{
					r_IsOverridable_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeyword), "IsOverridable", 0, typeof(UnityEngine.Rendering.LocalKeyword));
					r_IsOverridable_LocalKeyword.SetBelong(null);
				}
				return r_IsOverridable_LocalKeyword;
			}
		}

		/// <summary>
		/// UInt32 GetShaderKeywordCount(UnityEngine.Shader)
		/// </summary>
		protected static RMethod r_GetShaderKeywordCount_Shader;
		public static RMethod RGetShaderKeywordCount_Shader
		{
			get
			{
				if(r_GetShaderKeywordCount_Shader == null)
				{
					r_GetShaderKeywordCount_Shader = new(typeof(UnityEngine.Rendering.LocalKeyword), "GetShaderKeywordCount", 0, typeof(UnityEngine.Shader));
					r_GetShaderKeywordCount_Shader.SetBelong(null);
				}
				return r_GetShaderKeywordCount_Shader;
			}
		}

		/// <summary>
		/// UInt32 GetShaderKeywordIndex(UnityEngine.Shader, System.String)
		/// </summary>
		protected static RMethod r_GetShaderKeywordIndex_Shader_String;
		public static RMethod RGetShaderKeywordIndex_Shader_String
		{
			get
			{
				if(r_GetShaderKeywordIndex_Shader_String == null)
				{
					r_GetShaderKeywordIndex_Shader_String = new(typeof(UnityEngine.Rendering.LocalKeyword), "GetShaderKeywordIndex", 0, typeof(UnityEngine.Shader), typeof(System.String));
					r_GetShaderKeywordIndex_Shader_String.SetBelong(null);
				}
				return r_GetShaderKeywordIndex_Shader_String;
			}
		}

		/// <summary>
		/// UInt32 GetComputeShaderKeywordCount(UnityEngine.ComputeShader)
		/// </summary>
		protected static RMethod r_GetComputeShaderKeywordCount_ComputeShader;
		public static RMethod RGetComputeShaderKeywordCount_ComputeShader
		{
			get
			{
				if(r_GetComputeShaderKeywordCount_ComputeShader == null)
				{
					r_GetComputeShaderKeywordCount_ComputeShader = new(typeof(UnityEngine.Rendering.LocalKeyword), "GetComputeShaderKeywordCount", 0, typeof(UnityEngine.ComputeShader));
					r_GetComputeShaderKeywordCount_ComputeShader.SetBelong(null);
				}
				return r_GetComputeShaderKeywordCount_ComputeShader;
			}
		}

		/// <summary>
		/// UInt32 GetComputeShaderKeywordIndex(UnityEngine.ComputeShader, System.String)
		/// </summary>
		protected static RMethod r_GetComputeShaderKeywordIndex_ComputeShader_String;
		public static RMethod RGetComputeShaderKeywordIndex_ComputeShader_String
		{
			get
			{
				if(r_GetComputeShaderKeywordIndex_ComputeShader_String == null)
				{
					r_GetComputeShaderKeywordIndex_ComputeShader_String = new(typeof(UnityEngine.Rendering.LocalKeyword), "GetComputeShaderKeywordIndex", 0, typeof(UnityEngine.ComputeShader), typeof(System.String));
					r_GetComputeShaderKeywordIndex_ComputeShader_String.SetBelong(null);
				}
				return r_GetComputeShaderKeywordIndex_ComputeShader_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderKeywordType GetKeywordType(UnityEngine.Rendering.LocalKeywordSpace, UInt32)
		/// </summary>
		protected static RMethod r_GetKeywordType_LocalKeywordSpace_UInt32;
		public static RMethod RGetKeywordType_LocalKeywordSpace_UInt32
		{
			get
			{
				if(r_GetKeywordType_LocalKeywordSpace_UInt32 == null)
				{
					r_GetKeywordType_LocalKeywordSpace_UInt32 = new(typeof(UnityEngine.Rendering.LocalKeyword), "GetKeywordType", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace), typeof(System.UInt32));
					r_GetKeywordType_LocalKeywordSpace_UInt32.SetBelong(null);
				}
				return r_GetKeywordType_LocalKeywordSpace_UInt32;
			}
		}

		/// <summary>
		/// Boolean IsValid(UnityEngine.Rendering.LocalKeywordSpace, UInt32)
		/// </summary>
		protected static RMethod r_IsValid_LocalKeywordSpace_UInt32;
		public static RMethod RIsValid_LocalKeywordSpace_UInt32
		{
			get
			{
				if(r_IsValid_LocalKeywordSpace_UInt32 == null)
				{
					r_IsValid_LocalKeywordSpace_UInt32 = new(typeof(UnityEngine.Rendering.LocalKeyword), "IsValid", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace), typeof(System.UInt32));
					r_IsValid_LocalKeywordSpace_UInt32.SetBelong(null);
				}
				return r_IsValid_LocalKeywordSpace_UInt32;
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
		/// Boolean Equals(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_Equals_LocalKeyword;
		public virtual RMethod REquals_LocalKeyword
		{
			get
			{
				if(r_Equals_LocalKeyword == null)
				{
					r_Equals_LocalKeyword = new(this, "Equals", 0, typeof(UnityEngine.Rendering.LocalKeyword));
					r_Equals_LocalKeyword.SetBelong(this.instance);
				}
				return r_Equals_LocalKeyword;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rendering.LocalKeyword, UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected static RMethod r_op_Equality_LocalKeyword_LocalKeyword;
		public static RMethod Rop_Equality_LocalKeyword_LocalKeyword
		{
			get
			{
				if(r_op_Equality_LocalKeyword_LocalKeyword == null)
				{
					r_op_Equality_LocalKeyword_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeyword), "op_Equality", 0, typeof(UnityEngine.Rendering.LocalKeyword), typeof(UnityEngine.Rendering.LocalKeyword));
					r_op_Equality_LocalKeyword_LocalKeyword.SetBelong(null);
				}
				return r_op_Equality_LocalKeyword_LocalKeyword;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.LocalKeyword, UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected static RMethod r_op_Inequality_LocalKeyword_LocalKeyword;
		public static RMethod Rop_Inequality_LocalKeyword_LocalKeyword
		{
			get
			{
				if(r_op_Inequality_LocalKeyword_LocalKeyword == null)
				{
					r_op_Inequality_LocalKeyword_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeyword), "op_Inequality", 0, typeof(UnityEngine.Rendering.LocalKeyword), typeof(UnityEngine.Rendering.LocalKeyword));
					r_op_Inequality_LocalKeyword_LocalKeyword.SetBelong(null);
				}
				return r_op_Inequality_LocalKeyword_LocalKeyword;
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
		/// Boolean IsDynamic_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected static RMethod r_IsDynamic_Injected_Ref_LocalKeyword;
		public static RMethod RIsDynamic_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_IsDynamic_Injected_Ref_LocalKeyword == null)
				{
					r_IsDynamic_Injected_Ref_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeyword), "IsDynamic_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_IsDynamic_Injected_Ref_LocalKeyword.SetBelong(null);
				}
				return r_IsDynamic_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Boolean IsOverridable_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected static RMethod r_IsOverridable_Injected_Ref_LocalKeyword;
		public static RMethod RIsOverridable_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_IsOverridable_Injected_Ref_LocalKeyword == null)
				{
					r_IsOverridable_Injected_Ref_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeyword), "IsOverridable_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
					r_IsOverridable_Injected_Ref_LocalKeyword.SetBelong(null);
				}
				return r_IsOverridable_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderKeywordType GetKeywordType_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef, UInt32)
		/// </summary>
		protected static RMethod r_GetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32;
		public static RMethod RGetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32
		{
			get
			{
				if(r_GetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32 == null)
				{
					r_GetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32 = new(typeof(UnityEngine.Rendering.LocalKeyword), "GetKeywordType_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType(), typeof(System.UInt32));
					r_GetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32.SetBelong(null);
				}
				return r_GetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32;
			}
		}

		/// <summary>
		/// Boolean IsValid_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef, UInt32)
		/// </summary>
		protected static RMethod r_IsValid_Injected_Ref_LocalKeywordSpace_UInt32;
		public static RMethod RIsValid_Injected_Ref_LocalKeywordSpace_UInt32
		{
			get
			{
				if(r_IsValid_Injected_Ref_LocalKeywordSpace_UInt32 == null)
				{
					r_IsValid_Injected_Ref_LocalKeywordSpace_UInt32 = new(typeof(UnityEngine.Rendering.LocalKeyword), "IsValid_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType(), typeof(System.UInt32));
					r_IsValid_Injected_Ref_LocalKeywordSpace_UInt32.SetBelong(null);
				}
				return r_IsValid_Injected_Ref_LocalKeywordSpace_UInt32;
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


        public RLocalKeyword() : base("UnityEngine.Rendering.LocalKeyword")
        {
        }

        public RLocalKeyword(System.Object instance) : base("UnityEngine.Rendering.LocalKeyword")
		{
            SetInstance(instance);
		}

        public RLocalKeyword(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLocalKeyword(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean IsDynamic(UnityEngine.Rendering.LocalKeyword @kw)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kw};
            var ___result = RIsDynamic_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsOverridable(UnityEngine.Rendering.LocalKeyword @kw)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kw};
            var ___result = RIsOverridable_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.UInt32 GetShaderKeywordCount(UnityEngine.Shader @shader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader};
            var ___result = RGetShaderKeywordCount_Shader.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt32 GetShaderKeywordIndex(UnityEngine.Shader @shader, System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @keyword};
            var ___result = RGetShaderKeywordIndex_Shader_String.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt32 GetComputeShaderKeywordCount(UnityEngine.ComputeShader @shader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader};
            var ___result = RGetComputeShaderKeywordCount_ComputeShader.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt32 GetComputeShaderKeywordIndex(UnityEngine.ComputeShader @shader, System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @keyword};
            var ___result = RGetComputeShaderKeywordIndex_ComputeShader_String.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static UnityEngine.Rendering.ShaderKeywordType GetKeywordType(UnityEngine.Rendering.LocalKeywordSpace @spaceInfo, System.UInt32 @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spaceInfo, @keyword};
            var ___result = RGetKeywordType_LocalKeywordSpace_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderKeywordType)___result;
        }


        public static System.Boolean IsValid(UnityEngine.Rendering.LocalKeywordSpace @spaceInfo, System.UInt32 @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spaceInfo, @keyword};
            var ___result = RIsValid_LocalKeywordSpace_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.LocalKeyword @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rhs};
            var ___result = REquals_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.LocalKeyword @lhs, UnityEngine.Rendering.LocalKeyword @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_LocalKeyword_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.LocalKeyword @lhs, UnityEngine.Rendering.LocalKeyword @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_LocalKeyword_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean IsDynamic_Injected(ref UnityEngine.Rendering.LocalKeyword @kw)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kw};
            var ___result = RIsDynamic_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@kw = (UnityEngine.Rendering.LocalKeyword)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Boolean IsOverridable_Injected(ref UnityEngine.Rendering.LocalKeyword @kw)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kw};
            var ___result = RIsOverridable_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@kw = (UnityEngine.Rendering.LocalKeyword)___parameters[0];

            return (System.Boolean)___result;
        }


        public static UnityEngine.Rendering.ShaderKeywordType GetKeywordType_Injected(ref UnityEngine.Rendering.LocalKeywordSpace @spaceInfo, System.UInt32 @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spaceInfo, @keyword};
            var ___result = RGetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32.Invoke(___genericsType, ___parameters);
			@spaceInfo = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (UnityEngine.Rendering.ShaderKeywordType)___result;
        }


        public static System.Boolean IsValid_Injected(ref UnityEngine.Rendering.LocalKeywordSpace @spaceInfo, System.UInt32 @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spaceInfo, @keyword};
            var ___result = RIsValid_Injected_Ref_LocalKeywordSpace_UInt32.Invoke(___genericsType, ___parameters);
			@spaceInfo = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (System.Boolean)___result;
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
