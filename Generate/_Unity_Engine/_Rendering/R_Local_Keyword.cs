
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.LocalKeyword
	/// </summary>
    public partial class RLocalKeyword : RMember //
    {

		/// <summary>
		/// UnityEngine.Rendering.LocalKeywordSpace m_SpaceInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RLocalKeywordSpace r_Fm_SpaceInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RLocalKeywordSpace RFm_SpaceInfo
		{
			get
			{
				if(r_Fm_SpaceInfo == null)
				{
					r_Fm_SpaceInfo = new(this, "m_SpaceInfo");
				}
				return r_Fm_SpaceInfo;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.UInt32 m_Index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_Index;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_Index
		{
			get
			{
				if(r_Fm_Index == null)
				{
					r_Fm_Index = new(this, "m_Index");
				}
				return r_Fm_Index;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// Boolean isDynamic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDynamic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDynamic
		{
			get
			{
				if(r_PisDynamic == null)
				{
					r_PisDynamic = new(this, "isDynamic", -1);
				}
				return r_PisDynamic;
			}
		}

		/// <summary>
		/// Boolean isOverridable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisOverridable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisOverridable
		{
			get
			{
				if(r_PisOverridable == null)
				{
					r_PisOverridable = new(this, "isOverridable", -1);
				}
				return r_PisOverridable;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisValid
		{
			get
			{
				if(r_PisValid == null)
				{
					r_PisValid = new(this, "isValid", -1);
				}
				return r_PisValid;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderKeywordType type
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RShaderKeywordType r_Ptype;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RShaderKeywordType RPtype
		{
			get
			{
				if(r_Ptype == null)
				{
					r_Ptype = new(this, "type", -1);
				}
				return r_Ptype;
			}
		}

		/// <summary>
		/// Boolean IsDynamic(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected static RMethod r_MIsDynamic_LocalKeyword;
		public static RMethod RMIsDynamic_LocalKeyword
		{
			get
			{
				if(r_MIsDynamic_LocalKeyword == null)
				{
					r_MIsDynamic_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeyword), "IsDynamic", 0, typeof(UnityEngine.Rendering.LocalKeyword));
				}
				return r_MIsDynamic_LocalKeyword;
			}
		}

		/// <summary>
		/// Boolean IsOverridable(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected static RMethod r_MIsOverridable_LocalKeyword;
		public static RMethod RMIsOverridable_LocalKeyword
		{
			get
			{
				if(r_MIsOverridable_LocalKeyword == null)
				{
					r_MIsOverridable_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeyword), "IsOverridable", 0, typeof(UnityEngine.Rendering.LocalKeyword));
				}
				return r_MIsOverridable_LocalKeyword;
			}
		}

		/// <summary>
		/// UInt32 GetShaderKeywordCount(UnityEngine.Shader)
		/// </summary>
		protected static RMethod r_MGetShaderKeywordCount_Shader;
		public static RMethod RMGetShaderKeywordCount_Shader
		{
			get
			{
				if(r_MGetShaderKeywordCount_Shader == null)
				{
					r_MGetShaderKeywordCount_Shader = new(typeof(UnityEngine.Rendering.LocalKeyword), "GetShaderKeywordCount", 0, typeof(UnityEngine.Shader));
				}
				return r_MGetShaderKeywordCount_Shader;
			}
		}

		/// <summary>
		/// UInt32 GetShaderKeywordIndex(UnityEngine.Shader, System.String)
		/// </summary>
		protected static RMethod r_MGetShaderKeywordIndex_Shader_String;
		public static RMethod RMGetShaderKeywordIndex_Shader_String
		{
			get
			{
				if(r_MGetShaderKeywordIndex_Shader_String == null)
				{
					r_MGetShaderKeywordIndex_Shader_String = new(typeof(UnityEngine.Rendering.LocalKeyword), "GetShaderKeywordIndex", 0, typeof(UnityEngine.Shader), typeof(System.String));
				}
				return r_MGetShaderKeywordIndex_Shader_String;
			}
		}

		/// <summary>
		/// UInt32 GetComputeShaderKeywordCount(UnityEngine.ComputeShader)
		/// </summary>
		protected static RMethod r_MGetComputeShaderKeywordCount_ComputeShader;
		public static RMethod RMGetComputeShaderKeywordCount_ComputeShader
		{
			get
			{
				if(r_MGetComputeShaderKeywordCount_ComputeShader == null)
				{
					r_MGetComputeShaderKeywordCount_ComputeShader = new(typeof(UnityEngine.Rendering.LocalKeyword), "GetComputeShaderKeywordCount", 0, typeof(UnityEngine.ComputeShader));
				}
				return r_MGetComputeShaderKeywordCount_ComputeShader;
			}
		}

		/// <summary>
		/// UInt32 GetComputeShaderKeywordIndex(UnityEngine.ComputeShader, System.String)
		/// </summary>
		protected static RMethod r_MGetComputeShaderKeywordIndex_ComputeShader_String;
		public static RMethod RMGetComputeShaderKeywordIndex_ComputeShader_String
		{
			get
			{
				if(r_MGetComputeShaderKeywordIndex_ComputeShader_String == null)
				{
					r_MGetComputeShaderKeywordIndex_ComputeShader_String = new(typeof(UnityEngine.Rendering.LocalKeyword), "GetComputeShaderKeywordIndex", 0, typeof(UnityEngine.ComputeShader), typeof(System.String));
				}
				return r_MGetComputeShaderKeywordIndex_ComputeShader_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderKeywordType GetKeywordType(UnityEngine.Rendering.LocalKeywordSpace, UInt32)
		/// </summary>
		protected static RMethod r_MGetKeywordType_LocalKeywordSpace_UInt32;
		public static RMethod RMGetKeywordType_LocalKeywordSpace_UInt32
		{
			get
			{
				if(r_MGetKeywordType_LocalKeywordSpace_UInt32 == null)
				{
					r_MGetKeywordType_LocalKeywordSpace_UInt32 = new(typeof(UnityEngine.Rendering.LocalKeyword), "GetKeywordType", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace), typeof(System.UInt32));
				}
				return r_MGetKeywordType_LocalKeywordSpace_UInt32;
			}
		}

		/// <summary>
		/// Boolean IsValid(UnityEngine.Rendering.LocalKeywordSpace, UInt32)
		/// </summary>
		protected static RMethod r_MIsValid_LocalKeywordSpace_UInt32;
		public static RMethod RMIsValid_LocalKeywordSpace_UInt32
		{
			get
			{
				if(r_MIsValid_LocalKeywordSpace_UInt32 == null)
				{
					r_MIsValid_LocalKeywordSpace_UInt32 = new(typeof(UnityEngine.Rendering.LocalKeyword), "IsValid", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace), typeof(System.UInt32));
				}
				return r_MIsValid_LocalKeywordSpace_UInt32;
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
		/// Boolean Equals(UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected RMethod r_MEquals_LocalKeyword;
		public virtual RMethod RMEquals_LocalKeyword
		{
			get
			{
				if(r_MEquals_LocalKeyword == null)
				{
					r_MEquals_LocalKeyword = new(this, "Equals", 0, typeof(UnityEngine.Rendering.LocalKeyword));
				}
				return r_MEquals_LocalKeyword;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rendering.LocalKeyword, UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected static RMethod r_Mop_Equality_LocalKeyword_LocalKeyword;
		public static RMethod RMop_Equality_LocalKeyword_LocalKeyword
		{
			get
			{
				if(r_Mop_Equality_LocalKeyword_LocalKeyword == null)
				{
					r_Mop_Equality_LocalKeyword_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeyword), "op_Equality", 0, typeof(UnityEngine.Rendering.LocalKeyword), typeof(UnityEngine.Rendering.LocalKeyword));
				}
				return r_Mop_Equality_LocalKeyword_LocalKeyword;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.LocalKeyword, UnityEngine.Rendering.LocalKeyword)
		/// </summary>
		protected static RMethod r_Mop_Inequality_LocalKeyword_LocalKeyword;
		public static RMethod RMop_Inequality_LocalKeyword_LocalKeyword
		{
			get
			{
				if(r_Mop_Inequality_LocalKeyword_LocalKeyword == null)
				{
					r_Mop_Inequality_LocalKeyword_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeyword), "op_Inequality", 0, typeof(UnityEngine.Rendering.LocalKeyword), typeof(UnityEngine.Rendering.LocalKeyword));
				}
				return r_Mop_Inequality_LocalKeyword_LocalKeyword;
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
		/// Boolean IsDynamic_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected static RMethod r_MIsDynamic_Injected_Ref_LocalKeyword;
		public static RMethod RMIsDynamic_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_MIsDynamic_Injected_Ref_LocalKeyword == null)
				{
					r_MIsDynamic_Injected_Ref_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeyword), "IsDynamic_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
				}
				return r_MIsDynamic_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// Boolean IsOverridable_Injected(UnityEngine.Rendering.LocalKeyword ByRef)
		/// </summary>
		protected static RMethod r_MIsOverridable_Injected_Ref_LocalKeyword;
		public static RMethod RMIsOverridable_Injected_Ref_LocalKeyword
		{
			get
			{
				if(r_MIsOverridable_Injected_Ref_LocalKeyword == null)
				{
					r_MIsOverridable_Injected_Ref_LocalKeyword = new(typeof(UnityEngine.Rendering.LocalKeyword), "IsOverridable_Injected", 0, typeof(UnityEngine.Rendering.LocalKeyword).MakeByRefType());
				}
				return r_MIsOverridable_Injected_Ref_LocalKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderKeywordType GetKeywordType_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef, UInt32)
		/// </summary>
		protected static RMethod r_MGetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32;
		public static RMethod RMGetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32
		{
			get
			{
				if(r_MGetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32 == null)
				{
					r_MGetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32 = new(typeof(UnityEngine.Rendering.LocalKeyword), "GetKeywordType_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType(), typeof(System.UInt32));
				}
				return r_MGetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32;
			}
		}

		/// <summary>
		/// Boolean IsValid_Injected(UnityEngine.Rendering.LocalKeywordSpace ByRef, UInt32)
		/// </summary>
		protected static RMethod r_MIsValid_Injected_Ref_LocalKeywordSpace_UInt32;
		public static RMethod RMIsValid_Injected_Ref_LocalKeywordSpace_UInt32
		{
			get
			{
				if(r_MIsValid_Injected_Ref_LocalKeywordSpace_UInt32 == null)
				{
					r_MIsValid_Injected_Ref_LocalKeywordSpace_UInt32 = new(typeof(UnityEngine.Rendering.LocalKeyword), "IsValid_Injected", 0, typeof(UnityEngine.Rendering.LocalKeywordSpace).MakeByRefType(), typeof(System.UInt32));
				}
				return r_MIsValid_Injected_Ref_LocalKeywordSpace_UInt32;
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
            var ___result = RMIsDynamic_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsOverridable(UnityEngine.Rendering.LocalKeyword @kw)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kw};
            var ___result = RMIsOverridable_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.UInt32 GetShaderKeywordCount(UnityEngine.Shader @shader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader};
            var ___result = RMGetShaderKeywordCount_Shader.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt32 GetShaderKeywordIndex(UnityEngine.Shader @shader, System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @keyword};
            var ___result = RMGetShaderKeywordIndex_Shader_String.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt32 GetComputeShaderKeywordCount(UnityEngine.ComputeShader @shader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader};
            var ___result = RMGetComputeShaderKeywordCount_ComputeShader.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt32 GetComputeShaderKeywordIndex(UnityEngine.ComputeShader @shader, System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shader, @keyword};
            var ___result = RMGetComputeShaderKeywordIndex_ComputeShader_String.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static UnityEngine.Rendering.ShaderKeywordType GetKeywordType(UnityEngine.Rendering.LocalKeywordSpace @spaceInfo, System.UInt32 @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spaceInfo, @keyword};
            var ___result = RMGetKeywordType_LocalKeywordSpace_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderKeywordType)___result;
        }


        public static System.Boolean IsValid(UnityEngine.Rendering.LocalKeywordSpace @spaceInfo, System.UInt32 @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spaceInfo, @keyword};
            var ___result = RMIsValid_LocalKeywordSpace_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.LocalKeyword @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rhs};
            var ___result = RMEquals_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.LocalKeyword @lhs, UnityEngine.Rendering.LocalKeyword @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_LocalKeyword_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.LocalKeyword @lhs, UnityEngine.Rendering.LocalKeyword @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_LocalKeyword_LocalKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean IsDynamic_Injected(ref UnityEngine.Rendering.LocalKeyword @kw)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kw};
            var ___result = RMIsDynamic_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@kw = (UnityEngine.Rendering.LocalKeyword)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Boolean IsOverridable_Injected(ref UnityEngine.Rendering.LocalKeyword @kw)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kw};
            var ___result = RMIsOverridable_Injected_Ref_LocalKeyword.Invoke(___genericsType, ___parameters);
			@kw = (UnityEngine.Rendering.LocalKeyword)___parameters[0];

            return (System.Boolean)___result;
        }


        public static UnityEngine.Rendering.ShaderKeywordType GetKeywordType_Injected(ref UnityEngine.Rendering.LocalKeywordSpace @spaceInfo, System.UInt32 @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spaceInfo, @keyword};
            var ___result = RMGetKeywordType_Injected_Ref_LocalKeywordSpace_UInt32.Invoke(___genericsType, ___parameters);
			@spaceInfo = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (UnityEngine.Rendering.ShaderKeywordType)___result;
        }


        public static System.Boolean IsValid_Injected(ref UnityEngine.Rendering.LocalKeywordSpace @spaceInfo, System.UInt32 @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spaceInfo, @keyword};
            var ___result = RMIsValid_Injected_Ref_LocalKeywordSpace_UInt32.Invoke(___genericsType, ___parameters);
			@spaceInfo = (UnityEngine.Rendering.LocalKeywordSpace)___parameters[0];

            return (System.Boolean)___result;
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
