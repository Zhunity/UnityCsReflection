using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.BitmapAllocator32
	/// </summary>
    public partial class RBitmapAllocator32 : RMember //
    {

		/// <summary>
		/// System.Int32 kPageWidth
		/// </summary>
		protected static RField r_kPageWidth;
		public static RField RkPageWidth
		{
			get
			{
				if(r_kPageWidth == null)
				{
					r_kPageWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BitmapAllocator32"), "kPageWidth");
					r_kPageWidth.SetBelong(null);
				}
				return r_kPageWidth;
			}
		}

		/// <summary>
		/// System.Int32 m_PageHeight
		/// </summary>
		protected RField r_m_PageHeight;
		public virtual RField Rm_PageHeight
		{
			get
			{
				if(r_m_PageHeight == null)
				{
					r_m_PageHeight = new(this, "m_PageHeight");
					r_m_PageHeight.SetBelong(this.instance);
				}
				return r_m_PageHeight;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.BitmapAllocator32+Page] m_Pages
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RBitmapAllocator32.RPage> r_m_Pages;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RBitmapAllocator32.RPage> Rm_Pages
		{
			get
			{
				if(r_m_Pages == null)
				{
					r_m_Pages = new(this, "m_Pages");
					r_m_Pages.SetBelong(this.instance);
				}
				return r_m_Pages;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.UInt32] m_AllocMap
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_AllocMap;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_AllocMap
		{
			get
			{
				if(r_m_AllocMap == null)
				{
					r_m_AllocMap = new(this, "m_AllocMap");
					r_m_AllocMap.SetBelong(this.instance);
				}
				return r_m_AllocMap;
			}
		}

		/// <summary>
		/// System.Int32 m_EntryWidth
		/// </summary>
		protected RField r_m_EntryWidth;
		public virtual RField Rm_EntryWidth
		{
			get
			{
				if(r_m_EntryWidth == null)
				{
					r_m_EntryWidth = new(this, "m_EntryWidth");
					r_m_EntryWidth.SetBelong(this.instance);
				}
				return r_m_EntryWidth;
			}
		}

		/// <summary>
		/// System.Int32 m_EntryHeight
		/// </summary>
		protected RField r_m_EntryHeight;
		public virtual RField Rm_EntryHeight
		{
			get
			{
				if(r_m_EntryHeight == null)
				{
					r_m_EntryHeight = new(this, "m_EntryHeight");
					r_m_EntryHeight.SetBelong(this.instance);
				}
				return r_m_EntryHeight;
			}
		}

		/// <summary>
		/// Int32 entryWidth
		/// </summary>
		protected RProperty r_entryWidth;
		public virtual RProperty RentryWidth
		{
			get
			{
				if(r_entryWidth == null)
				{
					r_entryWidth = new(this, "entryWidth", -1);
					r_entryWidth.SetBelong(this.instance);
				}
				return r_entryWidth;
			}
		}

		/// <summary>
		/// Int32 entryHeight
		/// </summary>
		protected RProperty r_entryHeight;
		public virtual RProperty RentryHeight
		{
			get
			{
				if(r_entryHeight == null)
				{
					r_entryHeight = new(this, "entryHeight", -1);
					r_entryHeight.SetBelong(this.instance);
				}
				return r_entryHeight;
			}
		}

		/// <summary>
		/// Void Construct(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_Construct_Int32_Int32_Int32;
		public virtual RMethod RConstruct_Int32_Int32_Int32
		{
			get
			{
				if(r_Construct_Int32_Int32_Int32 == null)
				{
					r_Construct_Int32_Int32_Int32 = new(this, "Construct", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_Construct_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_Construct_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ForceFirstAlloc(UInt16, UInt16)
		/// </summary>
		protected RMethod r_ForceFirstAlloc_UInt16_UInt16;
		public virtual RMethod RForceFirstAlloc_UInt16_UInt16
		{
			get
			{
				if(r_ForceFirstAlloc_UInt16_UInt16 == null)
				{
					r_ForceFirstAlloc_UInt16_UInt16 = new(this, "ForceFirstAlloc", 0, typeof(System.UInt16), typeof(System.UInt16));
					r_ForceFirstAlloc_UInt16_UInt16.SetBelong(this.instance);
				}
				return r_ForceFirstAlloc_UInt16_UInt16;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc Allocate(UnityEngine.UIElements.UIR.BaseShaderInfoStorage)
		/// </summary>
		protected RMethod r_Allocate_BaseShaderInfoStorage;
		public virtual RMethod RAllocate_BaseShaderInfoStorage
		{
			get
			{
				if(r_Allocate_BaseShaderInfoStorage == null)
				{
					r_Allocate_BaseShaderInfoStorage = new(this, "Allocate", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BaseShaderInfoStorage"));
					r_Allocate_BaseShaderInfoStorage.SetBelong(this.instance);
				}
				return r_Allocate_BaseShaderInfoStorage;
			}
		}

		/// <summary>
		/// Void Free(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_Free_BMPAlloc;
		public virtual RMethod RFree_BMPAlloc
		{
			get
			{
				if(r_Free_BMPAlloc == null)
				{
					r_Free_BMPAlloc = new(this, "Free", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_Free_BMPAlloc.SetBelong(this.instance);
				}
				return r_Free_BMPAlloc;
			}
		}

		/// <summary>
		/// Void GetAllocPageAtlasLocation(Int32, UInt16 ByRef, UInt16 ByRef)
		/// </summary>
		protected RMethod r_GetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16;
		public virtual RMethod RGetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16
		{
			get
			{
				if(r_GetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16 == null)
				{
					r_GetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16 = new(this, "GetAllocPageAtlasLocation", 0, typeof(System.Int32), typeof(System.UInt16).MakeByRefType(), typeof(System.UInt16).MakeByRefType());
					r_GetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16.SetBelong(this.instance);
				}
				return r_GetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16;
			}
		}

		/// <summary>
		/// Byte CountTrailingZeroes(UInt32)
		/// </summary>
		protected static RMethod r_CountTrailingZeroes_UInt32;
		public static RMethod RCountTrailingZeroes_UInt32
		{
			get
			{
				if(r_CountTrailingZeroes_UInt32 == null)
				{
					r_CountTrailingZeroes_UInt32 = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BitmapAllocator32"), "CountTrailingZeroes", 0, typeof(System.UInt32));
					r_CountTrailingZeroes_UInt32.SetBelong(null);
				}
				return r_CountTrailingZeroes_UInt32;
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

        public virtual void Construct(System.Int32  @pageHeight, System.Int32  @entryWidth, System.Int32  @entryHeight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pageHeight, @entryWidth, @entryHeight};
            var ___result = RConstruct_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ForceFirstAlloc(System.UInt16  @firstPageX, System.UInt16  @firstPageY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@firstPageX, @firstPageY};
            var ___result = RForceFirstAlloc_UInt16_UInt16.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void GetAllocPageAtlasLocation(System.Int32  @page, out System.UInt16  @x, out System.UInt16  @y)
        {
			x = default;
			y = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@page, @x, @y};
            var ___result = RGetAllocPageAtlasLocation_Int32_Out_UInt16_Out_UInt16.Invoke(___genericsType, ___parameters);
			x = (System.UInt16)___parameters[1];
			y = (System.UInt16)___parameters[2];

            
        }


        public static System.Byte CountTrailingZeroes(System.UInt32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RCountTrailingZeroes_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
