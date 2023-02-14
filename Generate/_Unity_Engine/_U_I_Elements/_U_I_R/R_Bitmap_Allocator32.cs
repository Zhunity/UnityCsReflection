
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.BitmapAllocator32
	/// </summary>
    public partial class RBitmapAllocator32 : RMember //
    {

		/// <summary>
		/// System.Int32 kPageWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FkPageWidth;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFkPageWidth
		{
			get
			{
				if(r_FkPageWidth == null)
				{
					r_FkPageWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BitmapAllocator32"), "kPageWidth");
					r_FkPageWidth.SetBelong(null);
				}
				return r_FkPageWidth;
			}
		}

		/// <summary>
		/// System.Int32 m_PageHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_PageHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_PageHeight
		{
			get
			{
				if(r_Fm_PageHeight == null)
				{
					r_Fm_PageHeight = new(this, "m_PageHeight");
					r_Fm_PageHeight.SetBelong(this.instance);
				}
				return r_Fm_PageHeight;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.BitmapAllocator32+Page] m_Pages
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32.RPage> r_Fm_Pages;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32.RPage> RFm_Pages
		{
			get
			{
				if(r_Fm_Pages == null)
				{
					r_Fm_Pages = new(this, "m_Pages");
					r_Fm_Pages.SetBelong(this.instance);
				}
				return r_Fm_Pages;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] m_AllocMap
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RUInt32> r_Fm_AllocMap;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RUInt32> RFm_AllocMap
		{
			get
			{
				if(r_Fm_AllocMap == null)
				{
					r_Fm_AllocMap = new(this, "m_AllocMap");
					r_Fm_AllocMap.SetBelong(this.instance);
				}
				return r_Fm_AllocMap;
			}
		}

		/// <summary>
		/// System.Int32 m_EntryWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_EntryWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_EntryWidth
		{
			get
			{
				if(r_Fm_EntryWidth == null)
				{
					r_Fm_EntryWidth = new(this, "m_EntryWidth");
					r_Fm_EntryWidth.SetBelong(this.instance);
				}
				return r_Fm_EntryWidth;
			}
		}

		/// <summary>
		/// System.Int32 m_EntryHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_EntryHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_EntryHeight
		{
			get
			{
				if(r_Fm_EntryHeight == null)
				{
					r_Fm_EntryHeight = new(this, "m_EntryHeight");
					r_Fm_EntryHeight.SetBelong(this.instance);
				}
				return r_Fm_EntryHeight;
			}
		}

		/// <summary>
		/// Int32 entryWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PentryWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPentryWidth
		{
			get
			{
				if(r_PentryWidth == null)
				{
					r_PentryWidth = new(this, "entryWidth", -1);
					r_PentryWidth.SetBelong(this.instance);
				}
				return r_PentryWidth;
			}
		}

		/// <summary>
		/// Int32 entryHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PentryHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPentryHeight
		{
			get
			{
				if(r_PentryHeight == null)
				{
					r_PentryHeight = new(this, "entryHeight", -1);
					r_PentryHeight.SetBelong(this.instance);
				}
				return r_PentryHeight;
			}
		}

		/// <summary>
		/// Void Construct(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MConstruct_Int32_Int32_Int32;
		public virtual RMethod RMConstruct_Int32_Int32_Int32
		{
			get
			{
				if(r_MConstruct_Int32_Int32_Int32 == null)
				{
					r_MConstruct_Int32_Int32_Int32 = new(this, "Construct", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MConstruct_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MConstruct_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ForceFirstAlloc(UInt16, UInt16)
		/// </summary>
		protected RMethod r_MForceFirstAlloc_UInt16_UInt16;
		public virtual RMethod RMForceFirstAlloc_UInt16_UInt16
		{
			get
			{
				if(r_MForceFirstAlloc_UInt16_UInt16 == null)
				{
					r_MForceFirstAlloc_UInt16_UInt16 = new(this, "ForceFirstAlloc", 0, typeof(System.UInt16), typeof(System.UInt16));
					r_MForceFirstAlloc_UInt16_UInt16.SetBelong(this.instance);
				}
				return r_MForceFirstAlloc_UInt16_UInt16;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc Allocate(UnityEngine.UIElements.UIR.BaseShaderInfoStorage)
		/// </summary>
		protected RMethod r_MAllocate_BaseShaderInfoStorage;
		public virtual RMethod RMAllocate_BaseShaderInfoStorage
		{
			get
			{
				if(r_MAllocate_BaseShaderInfoStorage == null)
				{
					r_MAllocate_BaseShaderInfoStorage = new(this, "Allocate", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BaseShaderInfoStorage"));
					r_MAllocate_BaseShaderInfoStorage.SetBelong(this.instance);
				}
				return r_MAllocate_BaseShaderInfoStorage;
			}
		}

		/// <summary>
		/// Void Free(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_MFree_BMPAlloc;
		public virtual RMethod RMFree_BMPAlloc
		{
			get
			{
				if(r_MFree_BMPAlloc == null)
				{
					r_MFree_BMPAlloc = new(this, "Free", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MFree_BMPAlloc.SetBelong(this.instance);
				}
				return r_MFree_BMPAlloc;
			}
		}

		/// <summary>
		/// Void GetAllocPageAtlasLocation(Int32, UInt16 ByRef, UInt16 ByRef)
		/// </summary>
		protected RMethod r_MGetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16;
		public virtual RMethod RMGetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16
		{
			get
			{
				if(r_MGetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16 == null)
				{
					r_MGetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16 = new(this, "GetAllocPageAtlasLocation", 0, typeof(System.Int32), typeof(System.UInt16).MakeByRefType(), typeof(System.UInt16).MakeByRefType());
					r_MGetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16.SetBelong(this.instance);
				}
				return r_MGetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16;
			}
		}

		/// <summary>
		/// Byte CountTrailingZeroes(UInt32)
		/// </summary>
		protected static RMethod r_MCountTrailingZeroes_UInt32;
		public static RMethod RMCountTrailingZeroes_UInt32
		{
			get
			{
				if(r_MCountTrailingZeroes_UInt32 == null)
				{
					r_MCountTrailingZeroes_UInt32 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BitmapAllocator32"), "CountTrailingZeroes", 0, typeof(System.UInt32));
					r_MCountTrailingZeroes_UInt32.SetBelong(null);
				}
				return r_MCountTrailingZeroes_UInt32;
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


        public RBitmapAllocator32() : base("UnityEngine.UIElements.UIR.BitmapAllocator32")
        {
        }

        public RBitmapAllocator32(System.Object instance) : base("UnityEngine.UIElements.UIR.BitmapAllocator32")
		{
            SetInstance(instance);
		}

        public RBitmapAllocator32(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBitmapAllocator32(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Construct(System.Int32 @pageHeight, System.Int32 @entryWidth, System.Int32 @entryHeight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pageHeight, @entryWidth, @entryHeight};
            var ___result = RMConstruct_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ForceFirstAlloc(System.UInt16 @firstPageX, System.UInt16 @firstPageY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@firstPageX, @firstPageY};
            var ___result = RMForceFirstAlloc_UInt16_UInt16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc Allocate(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBaseShaderInfoStorage @storage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@storage.Value};
            var ___result = RMAllocate_BaseShaderInfoStorage.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc(___result);
        }


        public virtual void Free(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMFree_BMPAlloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetAllocPageAtlasLocation(System.Int32 @page, out System.UInt16 @x, out System.UInt16 @y)
        {
			@x = default;
			@y = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@page, @x, @y};
            var ___result = RMGetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16.Invoke(___genericsType, ___parameters);
			@x = (System.UInt16)___parameters[1];
			@y = (System.UInt16)___parameters[2];

            
        }


        public static System.Byte CountTrailingZeroes(System.UInt32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RMCountTrailingZeroes_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
