using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.BaseShaderInfoStorage
	/// </summary>
    public partial class RBaseShaderInfoStorage : RMember //
    {

		/// <summary>
		/// System.Int32 s_TextureCounter
		/// </summary>
		protected static RField r_s_TextureCounter;
		public static RField Rs_TextureCounter
		{
			get
			{
				if(r_s_TextureCounter == null)
				{
					r_s_TextureCounter = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BaseShaderInfoStorage"), "s_TextureCounter");
					r_s_TextureCounter.SetBelong(null);
				}
				return r_s_TextureCounter;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerCopyTexture
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerCopyTexture;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerCopyTexture
		{
			get
			{
				if(r_s_MarkerCopyTexture == null)
				{
					r_s_MarkerCopyTexture = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BaseShaderInfoStorage"), "s_MarkerCopyTexture");
					r_s_MarkerCopyTexture.SetBelong(null);
				}
				return r_s_MarkerCopyTexture;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerGetTextureData
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerGetTextureData;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerGetTextureData
		{
			get
			{
				if(r_s_MarkerGetTextureData == null)
				{
					r_s_MarkerGetTextureData = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BaseShaderInfoStorage"), "s_MarkerGetTextureData");
					r_s_MarkerGetTextureData.SetBelong(null);
				}
				return r_s_MarkerGetTextureData;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerUpdateTexture
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerUpdateTexture;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerUpdateTexture
		{
			get
			{
				if(r_s_MarkerUpdateTexture == null)
				{
					r_s_MarkerUpdateTexture = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BaseShaderInfoStorage"), "s_MarkerUpdateTexture");
					r_s_MarkerUpdateTexture.SetBelong(null);
				}
				return r_s_MarkerUpdateTexture;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected RField r___1__disposed__2__k__BackingField;
		public virtual RField R__1__disposed__2__k__BackingField
		{
			get
			{
				if(r___1__disposed__2__k__BackingField == null)
				{
					r___1__disposed__2__k__BackingField = new(this, "<disposed>k__BackingField");
					r___1__disposed__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__disposed__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D texture
		/// </summary>
		protected RUnityEngine.RTexture2D r_texture;
		public virtual RUnityEngine.RTexture2D Rtexture
		{
			get
			{
				if(r_texture == null)
				{
					r_texture = new(this, "texture", -1);
					r_texture.SetBelong(this.instance);
				}
				return r_texture;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected RProperty r_disposed;
		public virtual RProperty Rdisposed
		{
			get
			{
				if(r_disposed == null)
				{
					r_disposed = new(this, "disposed", -1);
					r_disposed.SetBelong(this.instance);
				}
				return r_disposed;
			}
		}

		/// <summary>
		/// Boolean AllocateRect(Int32, Int32, UnityEngine.RectInt ByRef)
		/// </summary>
		protected RMethod r_RAllocateRect_Int32_Int32_Out_RectInt;
		public virtual RMethod RAllocateRect_Int32_Int32_Out_RectInt
		{
			get
			{
				if(r_RAllocateRect_Int32_Int32_Out_RectInt == null)
				{
					r_RAllocateRect_Int32_Int32_Out_RectInt = new(this, "AllocateRect", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RectInt).MakeByRefType());
					r_RAllocateRect_Int32_Int32_Out_RectInt.SetBelong(this.instance);
				}
				return r_RAllocateRect_Int32_Int32_Out_RectInt;
			}
		}

		/// <summary>
		/// Void SetTexel(Int32, Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetTexel_Int32_Int32_Color;
		public virtual RMethod RSetTexel_Int32_Int32_Color
		{
			get
			{
				if(r_RSetTexel_Int32_Int32_Color == null)
				{
					r_RSetTexel_Int32_Int32_Color = new(this, "SetTexel", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color));
					r_RSetTexel_Int32_Int32_Color.SetBelong(this.instance);
				}
				return r_RSetTexel_Int32_Int32_Color;
			}
		}

		/// <summary>
		/// Void UpdateTexture()
		/// </summary>
		protected RMethod r_RUpdateTexture;
		public virtual RMethod RUpdateTexture
		{
			get
			{
				if(r_RUpdateTexture == null)
				{
					r_RUpdateTexture = new(this, "UpdateTexture", 0);
					r_RUpdateTexture.SetBelong(this.instance);
				}
				return r_RUpdateTexture;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
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


        public RBaseShaderInfoStorage() : base("UnityEngine.UIElements.UIR.BaseShaderInfoStorage")
        {
        }

        public RBaseShaderInfoStorage(System.Object instance) : base("UnityEngine.UIElements.UIR.BaseShaderInfoStorage")
		{
            SetInstance(instance);
		}

        public RBaseShaderInfoStorage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBaseShaderInfoStorage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean AllocateRect(System.Int32  @width, System.Int32  @height, out UnityEngine.RectInt  @uvs)
        {
			uvs = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @uvs};
            var ___result = RAllocateRect_Int32_Int32_Out_RectInt.Invoke(___genericsType, ___parameters);
			uvs = (UnityEngine.RectInt)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void SetTexel(System.Int32  @x, System.Int32  @y, UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @color};
            var ___result = RSetTexel_Int32_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateTexture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}