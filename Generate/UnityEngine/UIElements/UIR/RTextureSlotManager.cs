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
					r_k_SlotCount = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.TextureSlotManager"), "k_SlotCount");
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
					r_k_SlotSize = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.TextureSlotManager"), "k_SlotSize");
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
					r_slotIds = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.TextureSlotManager"), "slotIds");
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
					r_textureTableId = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.TextureSlotManager"), "textureTableId");
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
		protected RField r___0__FreeSlots__1__k__BackingField;
		public virtual RField R__0__FreeSlots__1__k__BackingField
		{
			get
			{
				if(r___0__FreeSlots__1__k__BackingField == null)
				{
					r___0__FreeSlots__1__k__BackingField = new(this, "<FreeSlots>k__BackingField");
					r___0__FreeSlots__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__FreeSlots__1__k__BackingField;
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
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
			}
		}

		/// <summary>
		/// Void StartNewBatch()
		/// </summary>
		protected RMethod r_StartNewBatch;
		public virtual RMethod RStartNewBatch
		{
			get
			{
				if(r_StartNewBatch == null)
				{
					r_StartNewBatch = new(this, "StartNewBatch", 0);
					r_StartNewBatch.SetBelong(this.instance);
				}
				return r_StartNewBatch;
			}
		}

		/// <summary>
		/// Int32 IndexOf(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_IndexOf_TextureId;
		public virtual RMethod RIndexOf_TextureId
		{
			get
			{
				if(r_IndexOf_TextureId == null)
				{
					r_IndexOf_TextureId = new(this, "IndexOf", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_IndexOf_TextureId.SetBelong(this.instance);
				}
				return r_IndexOf_TextureId;
			}
		}

		/// <summary>
		/// Void MarkUsed(Int32)
		/// </summary>
		protected RMethod r_MarkUsed_Int32;
		public virtual RMethod RMarkUsed_Int32
		{
			get
			{
				if(r_MarkUsed_Int32 == null)
				{
					r_MarkUsed_Int32 = new(this, "MarkUsed", 0, typeof(System.Int32));
					r_MarkUsed_Int32.SetBelong(this.instance);
				}
				return r_MarkUsed_Int32;
			}
		}

		/// <summary>
		/// Int32 FindOldestSlot()
		/// </summary>
		protected RMethod r_FindOldestSlot;
		public virtual RMethod RFindOldestSlot
		{
			get
			{
				if(r_FindOldestSlot == null)
				{
					r_FindOldestSlot = new(this, "FindOldestSlot", 0);
					r_FindOldestSlot.SetBelong(this.instance);
				}
				return r_FindOldestSlot;
			}
		}

		/// <summary>
		/// Void Bind(UnityEngine.UIElements.TextureId, Single, Int32, UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_Bind_TextureId_Single_Int32_MaterialPropertyBlock;
		public virtual RMethod RBind_TextureId_Single_Int32_MaterialPropertyBlock
		{
			get
			{
				if(r_Bind_TextureId_Single_Int32_MaterialPropertyBlock == null)
				{
					r_Bind_TextureId_Single_Int32_MaterialPropertyBlock = new(this, "Bind", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Single), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock));
					r_Bind_TextureId_Single_Int32_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_Bind_TextureId_Single_Int32_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void SetGpuData(Int32, UnityEngine.UIElements.TextureId, Int32, Int32, Single)
		/// </summary>
		protected RMethod r_SetGpuData_Int32_TextureId_Int32_Int32_Single;
		public virtual RMethod RSetGpuData_Int32_TextureId_Int32_Int32_Single
		{
			get
			{
				if(r_SetGpuData_Int32_TextureId_Int32_Int32_Single == null)
				{
					r_SetGpuData_Int32_TextureId_Int32_Int32_Single = new(this, "SetGpuData", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Int32), typeof(System.Int32), typeof(System.Single));
					r_SetGpuData_Int32_TextureId_Int32_Int32_Single.SetBelong(this.instance);
				}
				return r_SetGpuData_Int32_TextureId_Int32_Int32_Single;
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


        public virtual System.Int32 IndexOf(RUnityEngine.RUIElements.RTextureId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RIndexOf_TextureId.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void MarkUsed(System.Int32 @slotIndex)
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


        public virtual void Bind(RUnityEngine.RUIElements.RTextureId @id, System.Single @sdfScale, System.Int32 @slot, UnityEngine.MaterialPropertyBlock @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @sdfScale, @slot, @mat};
            var ___result = RBind_TextureId_Single_Int32_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGpuData(System.Int32 @slotIndex, RUnityEngine.RUIElements.RTextureId @id, System.Int32 @textureWidth, System.Int32 @textureHeight, System.Single @sdfScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slotIndex, @id.Value, @textureWidth, @textureHeight, @sdfScale};
            var ___result = RSetGpuData_Int32_TextureId_Int32_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
