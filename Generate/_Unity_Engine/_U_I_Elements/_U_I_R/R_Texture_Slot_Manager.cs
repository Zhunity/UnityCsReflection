
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.TextureSlotManager
	/// </summary>
    public partial class RTextureSlotManager : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.TextureSlotManager");
            }
        }

        public RTextureSlotManager() : base("UnityEngine.UIElements.UIR.TextureSlotManager")
        {
        }

        public RTextureSlotManager(System.Object instance) : base("UnityEngine.UIElements.UIR.TextureSlotManager")
		{
            SetInstance(instance);
		}

        public RTextureSlotManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextureSlotManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 k_SlotCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_SlotCount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_SlotCount
		{
			get
			{
				if(r_Fk_SlotCount == null)
				{
					r_Fk_SlotCount = new(Type, "k_SlotCount");
				}
				return r_Fk_SlotCount;
			}
		}

		/// <summary>
		/// System.Int32 k_SlotSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_SlotSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_SlotSize
		{
			get
			{
				if(r_Fk_SlotSize == null)
				{
					r_Fk_SlotSize = new(Type, "k_SlotSize");
				}
				return r_Fk_SlotSize;
			}
		}

		/// <summary>
		/// System.Int32[] slotIds
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FslotIds;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFslotIds
		{
			get
			{
				if(r_FslotIds == null)
				{
					r_FslotIds = new(Type, "slotIds");
				}
				return r_FslotIds;
			}
		}

		/// <summary>
		/// System.Int32 textureTableId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FtextureTableId;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFtextureTableId
		{
			get
			{
				if(r_FtextureTableId == null)
				{
					r_FtextureTableId = new(Type, "textureTableId");
				}
				return r_FtextureTableId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId[] m_Textures
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId> r_Fm_Textures;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId> RFm_Textures
		{
			get
			{
				if(r_Fm_Textures == null)
				{
					r_Fm_Textures = new(this, "m_Textures");
				}
				return r_Fm_Textures;
			}
		}

		/// <summary>
		/// System.Int32[] m_Tickets
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fm_Tickets;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFm_Tickets
		{
			get
			{
				if(r_Fm_Tickets == null)
				{
					r_Fm_Tickets = new(this, "m_Tickets");
				}
				return r_Fm_Tickets;
			}
		}

		/// <summary>
		/// System.Int32 m_CurrentTicket
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_CurrentTicket;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_CurrentTicket
		{
			get
			{
				if(r_Fm_CurrentTicket == null)
				{
					r_Fm_CurrentTicket = new(this, "m_CurrentTicket");
				}
				return r_Fm_CurrentTicket;
			}
		}

		/// <summary>
		/// System.Int32 m_FirstUsedTicket
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_FirstUsedTicket;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_FirstUsedTicket
		{
			get
			{
				if(r_Fm_FirstUsedTicket == null)
				{
					r_Fm_FirstUsedTicket = new(this, "m_FirstUsedTicket");
				}
				return r_Fm_FirstUsedTicket;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] m_GpuTextures
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector4> r_Fm_GpuTextures;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector4> RFm_GpuTextures
		{
			get
			{
				if(r_Fm_GpuTextures == null)
				{
					r_Fm_GpuTextures = new(this, "m_GpuTextures");
				}
				return r_Fm_GpuTextures;
			}
		}

		/// <summary>
		/// System.Int32 <FreeSlots>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__FreeSlots__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__FreeSlots__1__k__BackingField
		{
			get
			{
				if(r_F__0__FreeSlots__1__k__BackingField == null)
				{
					r_F__0__FreeSlots__1__k__BackingField = new(this, "<FreeSlots>k__BackingField");
				}
				return r_F__0__FreeSlots__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureRegistry textureRegistry
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry r_FtextureRegistry;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry RFtextureRegistry
		{
			get
			{
				if(r_FtextureRegistry == null)
				{
					r_FtextureRegistry = new(this, "textureRegistry");
				}
				return r_FtextureRegistry;
			}
		}

		/// <summary>
		/// Int32 FreeSlots
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PFreeSlots;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPFreeSlots
		{
			get
			{
				if(r_PFreeSlots == null)
				{
					r_PFreeSlots = new(this, "FreeSlots", -1);
				}
				return r_PFreeSlots;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// Void StartNewBatch()
		/// </summary>
		protected RMethod r_MStartNewBatch;
		public virtual RMethod RMStartNewBatch
		{
			get
			{
				if(r_MStartNewBatch == null)
				{
					r_MStartNewBatch = new(this, "StartNewBatch", 0);
				}
				return r_MStartNewBatch;
			}
		}

		/// <summary>
		/// Int32 IndexOf(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_MIndexOf_TextureId;
		public virtual RMethod RMIndexOf_TextureId
		{
			get
			{
				if(r_MIndexOf_TextureId == null)
				{
					r_MIndexOf_TextureId = new(this, "IndexOf", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
				}
				return r_MIndexOf_TextureId;
			}
		}

		/// <summary>
		/// Void MarkUsed(Int32)
		/// </summary>
		protected RMethod r_MMarkUsed_Int32;
		public virtual RMethod RMMarkUsed_Int32
		{
			get
			{
				if(r_MMarkUsed_Int32 == null)
				{
					r_MMarkUsed_Int32 = new(this, "MarkUsed", 0, typeof(System.Int32));
				}
				return r_MMarkUsed_Int32;
			}
		}

		/// <summary>
		/// Int32 FindOldestSlot()
		/// </summary>
		protected RMethod r_MFindOldestSlot;
		public virtual RMethod RMFindOldestSlot
		{
			get
			{
				if(r_MFindOldestSlot == null)
				{
					r_MFindOldestSlot = new(this, "FindOldestSlot", 0);
				}
				return r_MFindOldestSlot;
			}
		}

		/// <summary>
		/// Void Bind(UnityEngine.UIElements.TextureId, Single, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_MBind_TextureId_Single_Int32_MaterialPropertyBlock;
		public virtual RMethod RMBind_TextureId_Single_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_MBind_TextureId_Single_Int32_MaterialPropertyBlock == null)
				{
					r_MBind_TextureId_Single_Int32_MaterialPropertyBlock = new(this, "Bind", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Single), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
				}
				return r_MBind_TextureId_Single_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void SetGpuData(Int32, UnityEngine.UIElements.TextureId, Int32, Int32, Single)
		/// </summary>
		protected RMethod r_MSetGpuData_Int32_TextureId_Int32_Int32_Single;
		public virtual RMethod RMSetGpuData_Int32_TextureId_Int32_Int32_Single
		{
			get
			{
				if(r_MSetGpuData_Int32_TextureId_Int32_Int32_Single == null)
				{
					r_MSetGpuData_Int32_TextureId_Int32_Int32_Single = new(this, "SetGpuData", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Int32), typeof(System.Int32), typeof(System.Single));
				}
				return r_MSetGpuData_Int32_TextureId_Int32_Int32_Single;
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


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartNewBatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStartNewBatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 IndexOf(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMIndexOf_TextureId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void MarkUsed(System.Int32 @slotIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slotIndex};
            var ___result = RMMarkUsed_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 FindOldestSlot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFindOldestSlot.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void Bind(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @id, System.Single @sdfScale, System.Int32 @slot, UnityEngine.MaterialPropertyBlock @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @sdfScale, @slot, @mat};
            var ___result = RMBind_TextureId_Single_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGpuData(System.Int32 @slotIndex, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @id, System.Int32 @textureWidth, System.Int32 @textureHeight, System.Single @sdfScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slotIndex, @id.Value, @textureWidth, @textureHeight, @sdfScale};
            var ___result = RMSetGpuData_Int32_TextureId_Int32_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
