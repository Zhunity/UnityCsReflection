
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.Rendering.ShaderTagId
	/// </summary>
    public partial class RShaderTagId : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.ShaderTagId);
            }
        }

        public RShaderTagId() : base("UnityEngine.Rendering.ShaderTagId")
        {
        }

        public RShaderTagId(System.Object instance) : base("UnityEngine.Rendering.ShaderTagId")
		{
            SetInstance(instance);
		}

        public RShaderTagId(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RShaderTagId(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.Rendering.ShaderTagId none
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RShaderTagId r_Fnone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RShaderTagId RFnone
		{
			get
			{
				if(r_Fnone == null)
				{
					r_Fnone = new(Type, "none");
				}
				return r_Fnone;
			}
		}

		/// <summary>
		/// System.Int32 m_Id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Id;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Id
		{
			get
			{
				if(r_Fm_Id == null)
				{
					r_Fm_Id = new(this, "m_Id");
				}
				return r_Fm_Id;
			}
		}

		/// <summary>
		/// Int32 id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pid;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
				}
				return r_Pid;
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
		/// Boolean Equals(UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected RMethod r_MEquals_ShaderTagId;
		public virtual RMethod RMEquals_ShaderTagId
		{
			get
			{
				if(r_MEquals_ShaderTagId == null)
				{
					r_MEquals_ShaderTagId = new(this, "Equals", 0, typeof(UnityEngine.Rendering.ShaderTagId));
				}
				return r_MEquals_ShaderTagId;
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
		/// Boolean op_Equality(UnityEngine.Rendering.ShaderTagId, UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected static RMethod r_Mop_Equality_ShaderTagId_ShaderTagId;
		public static RMethod RMop_Equality_ShaderTagId_ShaderTagId
		{
			get
			{
				if(r_Mop_Equality_ShaderTagId_ShaderTagId == null)
				{
					r_Mop_Equality_ShaderTagId_ShaderTagId = new(Type, "op_Equality", 0, typeof(UnityEngine.Rendering.ShaderTagId), typeof(UnityEngine.Rendering.ShaderTagId));
				}
				return r_Mop_Equality_ShaderTagId_ShaderTagId;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.ShaderTagId, UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected static RMethod r_Mop_Inequality_ShaderTagId_ShaderTagId;
		public static RMethod RMop_Inequality_ShaderTagId_ShaderTagId
		{
			get
			{
				if(r_Mop_Inequality_ShaderTagId_ShaderTagId == null)
				{
					r_Mop_Inequality_ShaderTagId_ShaderTagId = new(Type, "op_Inequality", 0, typeof(UnityEngine.Rendering.ShaderTagId), typeof(UnityEngine.Rendering.ShaderTagId));
				}
				return r_Mop_Inequality_ShaderTagId_ShaderTagId;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderTagId op_Explicit(System.String)
		/// </summary>
		protected static RMethod r_Mop_Explicit_String;
		public static RMethod RMop_Explicit_String
		{
			get
			{
				if(r_Mop_Explicit_String == null)
				{
					r_Mop_Explicit_String = new(Type, "op_Explicit", 0, typeof(System.String));
				}
				return r_Mop_Explicit_String;
			}
		}

		/// <summary>
		/// System.String op_Explicit(UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected static RMethod r_Mop_Explicit_ShaderTagId;
		public static RMethod RMop_Explicit_ShaderTagId
		{
			get
			{
				if(r_Mop_Explicit_ShaderTagId == null)
				{
					r_Mop_Explicit_ShaderTagId = new(Type, "op_Explicit", 0, typeof(UnityEngine.Rendering.ShaderTagId));
				}
				return r_Mop_Explicit_ShaderTagId;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.ShaderTagId @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_ShaderTagId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.ShaderTagId @tag1, UnityEngine.Rendering.ShaderTagId @tag2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag1, @tag2};
            var ___result = RMop_Equality_ShaderTagId_ShaderTagId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.ShaderTagId @tag1, UnityEngine.Rendering.ShaderTagId @tag2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag1, @tag2};
            var ___result = RMop_Inequality_ShaderTagId_ShaderTagId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static UnityEngine.Rendering.ShaderTagId op_Explicit(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMop_Explicit_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.ShaderTagId>(___result);
        }


        public static System.String op_Explicit(UnityEngine.Rendering.ShaderTagId @tagId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tagId};
            var ___result = RMop_Explicit_ShaderTagId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
