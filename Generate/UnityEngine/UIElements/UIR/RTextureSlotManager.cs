using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.TextureSlotManager
	/// </summary>
    public partial class RTextureSlotManager : RMember //
    {

		/// <summary>
		/// System.Int32 k_SlotCount
		/// </summary>
		protected static RField r_k_SlotCount;
		public static RField Rk_SlotCount
		{
			get
			{
				if(r_k_SlotCount == null)
				{
					r_k_SlotCount = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.TextureSlotManager"), "k_SlotCount");
					r_k_SlotCount.SetBelong(null);
				}
				return r_k_SlotCount;
			}
		}

		/// <summary>
		/// System.Int32 k_SlotSize
		/// </summary>
		protected static RField r_k_SlotSize;
		public static RField Rk_SlotSize
		{
			get
			{
				if(r_k_SlotSize == null)
				{
					r_k_SlotSize = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.TextureSlotManager"), "k_SlotSize");
					r_k_SlotSize.SetBelong(null);
				}
				return r_k_SlotSize;
			}
		}

		/// <summary>
		/// System.Int32[] slotIds
		/// </summary>
		protected static RFieldArray<RField> r_slotIds;
		public static RFieldArray<RField> RslotIds
		{
			get
			{
				if(r_slotIds == null)
				{
					r_slotIds = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.TextureSlotManager"), "slotIds");
					r_slotIds.SetBelong(null);
				}
				return r_slotIds;
			}
		}

		/// <summary>
		/// System.Int32 textureTableId
		/// </summary>
		protected static RField r_textureTableId;
		public static RField RtextureTableId
		{
			get
			{
				if(r_textureTableId == null)
				{
					r_textureTableId = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.TextureSlotManager"), "textureTableId");
					r_textureTableId.SetBelong(null);
				}
				return r_textureTableId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId[] m_Textures
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RTextureId> r_m_Textures;
		public virtual RFieldArray<RUnityEngine.RUIElements.RTextureId> Rm_Textures
		{
			get
			{
				if(r_m_Textures == null)
				{
					r_m_Textures = new(this, "m_Textures");
					r_m_Textures.SetBelong(this.instance);
				}
				return r_m_Textures;
			}
		}

		/// <summary>
		/// System.Int32[] m_Tickets
		/// </summary>
		protected RFieldArray<RField> r_m_Tickets;
		public virtual RFieldArray<RField> Rm_Tickets
		{
			get
			{
				if(r_m_Tickets == null)
				{
					r_m_Tickets = new(this, "m_Tickets");
					r_m_Tickets.SetBelong(this.instance);
				}
				return r_m_Tickets;
			}
		}

		/// <summary>
		/// System.Int32 m_CurrentTicket
		/// </summary>
		protected RField r_m_CurrentTicket;
		public virtual RField Rm_CurrentTicket
		{
			get
			{
				if(r_m_CurrentTicket == null)
				{
					r_m_CurrentTicket = new(this, "m_CurrentTicket");
					r_m_CurrentTicket.SetBelong(this.instance);
				}
				return r_m_CurrentTicket;
			}
		}

		/// <summary>
		/// System.Int32 m_FirstUsedTicket
		/// </summary>
		protected RField r_m_FirstUsedTicket;
		public virtual RField Rm_FirstUsedTicket
		{
			get
			{
				if(r_m_FirstUsedTicket == null)
				{
					r_m_FirstUsedTicket = new(this, "m_FirstUsedTicket");
					r_m_FirstUsedTicket.SetBelong(this.instance);
				}
				return r_m_FirstUsedTicket;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] m_GpuTextures
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector4> r_m_GpuTextures;
		public virtual RFieldArray<RUnityEngine.RVector4> Rm_GpuTextures
		{
			get
			{
				if(r_m_GpuTextures == null)
				{
					r_m_GpuTextures = new(this, "m_GpuTextures");
					r_m_GpuTextures.SetBelong(this.instance);
				}
				return r_m_GpuTextures;
			}
		}

		/// <summary>
		/// System.Int32 <FreeSlots>k__BackingField
		/// </summary>
		protected RField r___1__FreeSlots__2__k__BackingField;
		public virtual RField R__1__FreeSlots__2__k__BackingField
		{
			get
			{
				if(r___1__FreeSlots__2__k__BackingField == null)
				{
					r___1__FreeSlots__2__k__BackingField = new(this, "<FreeSlots>k__BackingField");
					r___1__FreeSlots__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__FreeSlots__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureRegistry textureRegistry
		/// </summary>
		protected RUnityEngine.RUIElements.RTextureRegistry r_textureRegistry;
		public virtual RUnityEngine.RUIElements.RTextureRegistry RtextureRegistry
		{
			get
			{
				if(r_textureRegistry == null)
				{
					r_textureRegistry = new(this, "textureRegistry");
					r_textureRegistry.SetBelong(this.instance);
				}
				return r_textureRegistry;
			}
		}

		/// <summary>
		/// Int32 FreeSlots
		/// </summary>
		protected RProperty r_FreeSlots;
		public virtual RProperty RFreeSlots
		{
			get
			{
				if(r_FreeSlots == null)
				{
					r_FreeSlots = new(this, "FreeSlots", -1);
					r_FreeSlots.SetBelong(this.instance);
				}
				return r_FreeSlots;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Void StartNewBatch()
		/// </summary>
		protected RMethod r_RStartNewBatch;
		public virtual RMethod RStartNewBatch
		{
			get
			{
				if(r_RStartNewBatch == null)
				{
					r_RStartNewBatch = new(this, "StartNewBatch", 0);
					r_RStartNewBatch.SetBelong(this.instance);
				}
				return r_RStartNewBatch;
			}
		}

		/// <summary>
		/// Int32 IndexOf(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_RIndexOf_TextureId;
		public virtual RMethod RIndexOf_TextureId
		{
			get
			{
				if(r_RIndexOf_TextureId == null)
				{
					r_RIndexOf_TextureId = new(this, "IndexOf", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_RIndexOf_TextureId.SetBelong(this.instance);
				}
				return r_RIndexOf_TextureId;
			}
		}

		/// <summary>
		/// Void MarkUsed(Int32)
		/// </summary>
		protected RMethod r_RMarkUsed_Int32;
		public virtual RMethod RMarkUsed_Int32
		{
			get
			{
				if(r_RMarkUsed_Int32 == null)
				{
					r_RMarkUsed_Int32 = new(this, "MarkUsed", 0, typeof(System.Int32));
					r_RMarkUsed_Int32.SetBelong(this.instance);
				}
				return r_RMarkUsed_Int32;
			}
		}

		/// <summary>
		/// Int32 FindOldestSlot()
		/// </summary>
		protected RMethod r_RFindOldestSlot;
		public virtual RMethod RFindOldestSlot
		{
			get
			{
				if(r_RFindOldestSlot == null)
				{
					r_RFindOldestSlot = new(this, "FindOldestSlot", 0);
					r_RFindOldestSlot.SetBelong(this.instance);
				}
				return r_RFindOldestSlot;
			}
		}

		/// <summary>
		/// Void Bind(UnityEngine.UIElements.TextureId, Single, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RBind_TextureId_Single_Int32_MaterialPropertyBlock;
		public virtual RMethod RBind_TextureId_Single_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_RBind_TextureId_Single_Int32_MaterialPropertyBlock == null)
				{
					r_RBind_TextureId_Single_Int32_MaterialPropertyBlock = new(this, "Bind", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Single), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_RBind_TextureId_Single_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RBind_TextureId_Single_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void SetGpuData(Int32, UnityEngine.UIElements.TextureId, Int32, Int32, Single)
		/// </summary>
		protected RMethod r_RSetGpuData_Int32_TextureId_Int32_Int32_Single;
		public virtual RMethod RSetGpuData_Int32_TextureId_Int32_Int32_Single
		{
			get
			{
				if(r_RSetGpuData_Int32_TextureId_Int32_Int32_Single == null)
				{
					r_RSetGpuData_Int32_TextureId_Int32_Int32_Single = new(this, "SetGpuData", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Int32), typeof(System.Int32), typeof(System.Single));
					r_RSetGpuData_Int32_TextureId_Int32_Int32_Single.SetBelong(this.instance);
				}
				return r_RSetGpuData_Int32_TextureId_Int32_Int32_Single;
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

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartNewBatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStartNewBatch.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void MarkUsed(System.Int32  @slotIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slotIndex};
            var ___result = RMarkUsed_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 FindOldestSlot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFindOldestSlot.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
