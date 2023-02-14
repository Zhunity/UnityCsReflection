
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.RenderTargetIdentifier
	/// </summary>
    public partial class RRenderTargetIdentifier : RMember //
    {

		/// <summary>
		/// System.Int32 AllDepthSlices
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FAllDepthSlices;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFAllDepthSlices
		{
			get
			{
				if(r_FAllDepthSlices == null)
				{
					r_FAllDepthSlices = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "AllDepthSlices");
					r_FAllDepthSlices.SetBelong(null);
				}
				return r_FAllDepthSlices;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType m_Type
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_Fm_Type;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFm_Type
		{
			get
			{
				if(r_Fm_Type == null)
				{
					r_Fm_Type = new(this, "m_Type");
					r_Fm_Type.SetBelong(this.instance);
				}
				return r_Fm_Type;
			}
		}

		/// <summary>
		/// System.Int32 m_NameID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_NameID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_NameID
		{
			get
			{
				if(r_Fm_NameID == null)
				{
					r_Fm_NameID = new(this, "m_NameID");
					r_Fm_NameID.SetBelong(this.instance);
				}
				return r_Fm_NameID;
			}
		}

		/// <summary>
		/// System.Int32 m_InstanceID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_InstanceID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_InstanceID
		{
			get
			{
				if(r_Fm_InstanceID == null)
				{
					r_Fm_InstanceID = new(this, "m_InstanceID");
					r_Fm_InstanceID.SetBelong(this.instance);
				}
				return r_Fm_InstanceID;
			}
		}

		/// <summary>
		/// System.IntPtr m_BufferPointer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_BufferPointer;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_BufferPointer
		{
			get
			{
				if(r_Fm_BufferPointer == null)
				{
					r_Fm_BufferPointer = new(this, "m_BufferPointer");
					r_Fm_BufferPointer.SetBelong(this.instance);
				}
				return r_Fm_BufferPointer;
			}
		}

		/// <summary>
		/// System.Int32 m_MipLevel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MipLevel;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MipLevel
		{
			get
			{
				if(r_Fm_MipLevel == null)
				{
					r_Fm_MipLevel = new(this, "m_MipLevel");
					r_Fm_MipLevel.SetBelong(this.instance);
				}
				return r_Fm_MipLevel;
			}
		}

		/// <summary>
		/// UnityEngine.CubemapFace m_CubeFace
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace r_Fm_CubeFace;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace RFm_CubeFace
		{
			get
			{
				if(r_Fm_CubeFace == null)
				{
					r_Fm_CubeFace = new(this, "m_CubeFace");
					r_Fm_CubeFace.SetBelong(this.instance);
				}
				return r_Fm_CubeFace;
			}
		}

		/// <summary>
		/// System.Int32 m_DepthSlice
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_DepthSlice;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_DepthSlice
		{
			get
			{
				if(r_Fm_DepthSlice == null)
				{
					r_Fm_DepthSlice = new(this, "m_DepthSlice");
					r_Fm_DepthSlice.SetBelong(this.instance);
				}
				return r_Fm_DepthSlice;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.BuiltinRenderTextureType)
		/// </summary>
		protected static RMethod r_Mop_Implicit_BuiltinRenderTextureType;
		public static RMethod RMop_Implicit_BuiltinRenderTextureType
		{
			get
			{
				if(r_Mop_Implicit_BuiltinRenderTextureType == null)
				{
					r_Mop_Implicit_BuiltinRenderTextureType = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Implicit", 0, typeof(UnityEngine.Rendering.BuiltinRenderTextureType));
					r_Mop_Implicit_BuiltinRenderTextureType.SetBelong(null);
				}
				return r_Mop_Implicit_BuiltinRenderTextureType;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(System.String)
		/// </summary>
		protected static RMethod r_Mop_Implicit_String;
		public static RMethod RMop_Implicit_String
		{
			get
			{
				if(r_Mop_Implicit_String == null)
				{
					r_Mop_Implicit_String = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Implicit", 0, typeof(System.String));
					r_Mop_Implicit_String.SetBelong(null);
				}
				return r_Mop_Implicit_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(Int32)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Int32;
		public static RMethod RMop_Implicit_Int32
		{
			get
			{
				if(r_Mop_Implicit_Int32 == null)
				{
					r_Mop_Implicit_Int32 = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Implicit", 0, typeof(System.Int32));
					r_Mop_Implicit_Int32.SetBelong(null);
				}
				return r_Mop_Implicit_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Texture;
		public static RMethod RMop_Implicit_Texture
		{
			get
			{
				if(r_Mop_Implicit_Texture == null)
				{
					r_Mop_Implicit_Texture = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Implicit", 0, typeof(UnityEngine.Texture));
					r_Mop_Implicit_Texture.SetBelong(null);
				}
				return r_Mop_Implicit_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.RenderBuffer)
		/// </summary>
		protected static RMethod r_Mop_Implicit_RenderBuffer;
		public static RMethod RMop_Implicit_RenderBuffer
		{
			get
			{
				if(r_Mop_Implicit_RenderBuffer == null)
				{
					r_Mop_Implicit_RenderBuffer = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Implicit", 0, typeof(UnityEngine.RenderBuffer));
					r_Mop_Implicit_RenderBuffer.SetBelong(null);
				}
				return r_Mop_Implicit_RenderBuffer;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected RMethod r_MEquals_RenderTargetIdentifier;
		public virtual RMethod RMEquals_RenderTargetIdentifier
		{
			get
			{
				if(r_MEquals_RenderTargetIdentifier == null)
				{
					r_MEquals_RenderTargetIdentifier = new(this, "Equals", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_MEquals_RenderTargetIdentifier.SetBelong(this.instance);
				}
				return r_MEquals_RenderTargetIdentifier;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected static RMethod r_Mop_Equality_RenderTargetIdentifier_RenderTargetIdentifier;
		public static RMethod RMop_Equality_RenderTargetIdentifier_RenderTargetIdentifier
		{
			get
			{
				if(r_Mop_Equality_RenderTargetIdentifier_RenderTargetIdentifier == null)
				{
					r_Mop_Equality_RenderTargetIdentifier_RenderTargetIdentifier = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Equality", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_Mop_Equality_RenderTargetIdentifier_RenderTargetIdentifier.SetBelong(null);
				}
				return r_Mop_Equality_RenderTargetIdentifier_RenderTargetIdentifier;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier)
		/// </summary>
		protected static RMethod r_Mop_Inequality_RenderTargetIdentifier_RenderTargetIdentifier;
		public static RMethod RMop_Inequality_RenderTargetIdentifier_RenderTargetIdentifier
		{
			get
			{
				if(r_Mop_Inequality_RenderTargetIdentifier_RenderTargetIdentifier == null)
				{
					r_Mop_Inequality_RenderTargetIdentifier_RenderTargetIdentifier = new(typeof(UnityEngine.Rendering.RenderTargetIdentifier), "op_Inequality", 0, typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier));
					r_Mop_Inequality_RenderTargetIdentifier_RenderTargetIdentifier.SetBelong(null);
				}
				return r_Mop_Inequality_RenderTargetIdentifier_RenderTargetIdentifier;
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}


        public RRenderTargetIdentifier() : base("UnityEngine.Rendering.RenderTargetIdentifier")
        {
        }

        public RRenderTargetIdentifier(System.Object instance) : base("UnityEngine.Rendering.RenderTargetIdentifier")
		{
            SetInstance(instance);
		}

        public RRenderTargetIdentifier(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderTargetIdentifier(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.BuiltinRenderTextureType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMop_Implicit_BuiltinRenderTextureType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderTargetIdentifier)___result;
        }


        public static UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMop_Implicit_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderTargetIdentifier)___result;
        }


        public static UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(System.Int32 @nameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID};
            var ___result = RMop_Implicit_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderTargetIdentifier)___result;
        }


        public static UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Texture @tex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tex};
            var ___result = RMop_Implicit_Texture.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderTargetIdentifier)___result;
        }


        public static UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.RenderBuffer @buf)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buf};
            var ___result = RMop_Implicit_RenderBuffer.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderTargetIdentifier)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.RenderTargetIdentifier @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rhs};
            var ___result = RMEquals_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.RenderTargetIdentifier @lhs, UnityEngine.Rendering.RenderTargetIdentifier @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_RenderTargetIdentifier_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.RenderTargetIdentifier @lhs, UnityEngine.Rendering.RenderTargetIdentifier @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_RenderTargetIdentifier_RenderTargetIdentifier.Invoke(___genericsType, ___parameters);

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
