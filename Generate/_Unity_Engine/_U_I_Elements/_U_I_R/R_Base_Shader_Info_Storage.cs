
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.BaseShaderInfoStorage
	/// </summary>
    public partial class RBaseShaderInfoStorage : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BaseShaderInfoStorage");
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


		/// <summary>
		/// System.Int32 s_TextureCounter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fs_TextureCounter;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFs_TextureCounter
		{
			get
			{
				if(r_Fs_TextureCounter == null)
				{
					r_Fs_TextureCounter = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BaseShaderInfoStorage"), "s_TextureCounter");
				}
				return r_Fs_TextureCounter;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerCopyTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerCopyTexture;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerCopyTexture
		{
			get
			{
				if(r_Fs_MarkerCopyTexture == null)
				{
					r_Fs_MarkerCopyTexture = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BaseShaderInfoStorage"), "s_MarkerCopyTexture");
				}
				return r_Fs_MarkerCopyTexture;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerGetTextureData
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerGetTextureData;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerGetTextureData
		{
			get
			{
				if(r_Fs_MarkerGetTextureData == null)
				{
					r_Fs_MarkerGetTextureData = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BaseShaderInfoStorage"), "s_MarkerGetTextureData");
				}
				return r_Fs_MarkerGetTextureData;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerUpdateTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerUpdateTexture;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerUpdateTexture
		{
			get
			{
				if(r_Fs_MarkerUpdateTexture == null)
				{
					r_Fs_MarkerUpdateTexture = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BaseShaderInfoStorage"), "s_MarkerUpdateTexture");
				}
				return r_Fs_MarkerUpdateTexture;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__disposed__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__disposed__1__k__BackingField
		{
			get
			{
				if(r_F__0__disposed__1__k__BackingField == null)
				{
					r_F__0__disposed__1__k__BackingField = new(this, "<disposed>k__BackingField");
				}
				return r_F__0__disposed__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D texture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Ptexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPtexture
		{
			get
			{
				if(r_Ptexture == null)
				{
					r_Ptexture = new(this, "texture", -1);
				}
				return r_Ptexture;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdisposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdisposed
		{
			get
			{
				if(r_Pdisposed == null)
				{
					r_Pdisposed = new(this, "disposed", -1);
				}
				return r_Pdisposed;
			}
		}

		/// <summary>
		/// Boolean AllocateRect(Int32, Int32, UnityEngine.RectInt ByRef)
		/// </summary>
		protected RMethod r_MAllocateRect_Int32_Int32_Out_RectInt;
		public virtual RMethod RMAllocateRect_Int32_Int32_Out_RectInt
		{
			get
			{
				if(r_MAllocateRect_Int32_Int32_Out_RectInt == null)
				{
					r_MAllocateRect_Int32_Int32_Out_RectInt = new(this, "AllocateRect", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RectInt).MakeByRefType());
				}
				return r_MAllocateRect_Int32_Int32_Out_RectInt;
			}
		}

		/// <summary>
		/// Void SetTexel(Int32, Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetTexel_Int32_Int32_Color;
		public virtual RMethod RMSetTexel_Int32_Int32_Color
		{
			get
			{
				if(r_MSetTexel_Int32_Int32_Color == null)
				{
					r_MSetTexel_Int32_Int32_Color = new(this, "SetTexel", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color));
				}
				return r_MSetTexel_Int32_Int32_Color;
			}
		}

		/// <summary>
		/// Void UpdateTexture()
		/// </summary>
		protected RMethod r_MUpdateTexture;
		public virtual RMethod RMUpdateTexture
		{
			get
			{
				if(r_MUpdateTexture == null)
				{
					r_MUpdateTexture = new(this, "UpdateTexture", 0);
				}
				return r_MUpdateTexture;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
				}
				return r_MDispose_Boolean;
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


        public virtual System.Boolean AllocateRect(System.Int32 @width, System.Int32 @height, out UnityEngine.RectInt @uvs)
        {
			@uvs = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @uvs};
            var ___result = RMAllocateRect_Int32_Int32_Out_RectInt.Invoke(___genericsType, ___parameters);
			@uvs = (UnityEngine.RectInt)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void SetTexel(System.Int32 @x, System.Int32 @y, UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @color};
            var ___result = RMSetTexel_Int32_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateTexture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
