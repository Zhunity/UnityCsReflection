
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TextureRegistry
	/// </summary>
    public partial class RTextureRegistry : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TextureRegistry+TextureInfo] m_Textures
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry.RTextureInfo> r_Fm_Textures;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry.RTextureInfo> RFm_Textures
		{
			get
			{
				if(r_Fm_Textures == null)
				{
					r_Fm_Textures = new(this, "m_Textures");
					r_Fm_Textures.SetBelong(this.instance);
				}
				return r_Fm_Textures;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.Texture,UnityEngine.UIElements.TextureId] m_TextureToId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RTexture, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId> r_Fm_TextureToId;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RTexture, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId> RFm_TextureToId
		{
			get
			{
				if(r_Fm_TextureToId == null)
				{
					r_Fm_TextureToId = new(this, "m_TextureToId");
					r_Fm_TextureToId.SetBelong(this.instance);
				}
				return r_Fm_TextureToId;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.UIElements.TextureId] m_FreeIds
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId> r_Fm_FreeIds;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId> RFm_FreeIds
		{
			get
			{
				if(r_Fm_FreeIds == null)
				{
					r_Fm_FreeIds = new(this, "m_FreeIds");
					r_Fm_FreeIds.SetBelong(this.instance);
				}
				return r_Fm_FreeIds;
			}
		}

		/// <summary>
		/// System.Int32 maxTextures
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FmaxTextures;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFmaxTextures
		{
			get
			{
				if(r_FmaxTextures == null)
				{
					r_FmaxTextures = new( ReflectionUtils.GetType("UnityEngine.UIElements.TextureRegistry"), "maxTextures");
					r_FmaxTextures.SetBelong(null);
				}
				return r_FmaxTextures;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureRegistry <instance>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry r_F__0__instance__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry RF__0__instance__1__k__BackingField
		{
			get
			{
				if(r_F__0__instance__1__k__BackingField == null)
				{
					r_F__0__instance__1__k__BackingField = new( ReflectionUtils.GetType("UnityEngine.UIElements.TextureRegistry"), "<instance>k__BackingField");
					r_F__0__instance__1__k__BackingField.SetBelong(null);
				}
				return r_F__0__instance__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureRegistry instance
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry r_Pinstance;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry RPinstance
		{
			get
			{
				if(r_Pinstance == null)
				{
					r_Pinstance = new( ReflectionUtils.GetType("UnityEngine.UIElements.TextureRegistry"), "instance", -1);
					r_Pinstance.SetBelong(null);
				}
				return r_Pinstance;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetTexture(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_MGetTexture_TextureId;
		public virtual RMethod RMGetTexture_TextureId
		{
			get
			{
				if(r_MGetTexture_TextureId == null)
				{
					r_MGetTexture_TextureId = new(this, "GetTexture", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_MGetTexture_TextureId.SetBelong(this.instance);
				}
				return r_MGetTexture_TextureId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId AllocAndAcquireDynamic()
		/// </summary>
		protected RMethod r_MAllocAndAcquireDynamic;
		public virtual RMethod RMAllocAndAcquireDynamic
		{
			get
			{
				if(r_MAllocAndAcquireDynamic == null)
				{
					r_MAllocAndAcquireDynamic = new(this, "AllocAndAcquireDynamic", 0);
					r_MAllocAndAcquireDynamic.SetBelong(this.instance);
				}
				return r_MAllocAndAcquireDynamic;
			}
		}

		/// <summary>
		/// Void UpdateDynamic(UnityEngine.UIElements.TextureId, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MUpdateDynamic_TextureId_Texture;
		public virtual RMethod RMUpdateDynamic_TextureId_Texture
		{
			get
			{
				if(r_MUpdateDynamic_TextureId_Texture == null)
				{
					r_MUpdateDynamic_TextureId_Texture = new(this, "UpdateDynamic", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(UnityEngine.Texture));
					r_MUpdateDynamic_TextureId_Texture.SetBelong(this.instance);
				}
				return r_MUpdateDynamic_TextureId_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId AllocAndAcquire(UnityEngine.Texture, Boolean)
		/// </summary>
		protected RMethod r_MAllocAndAcquire_Texture_Boolean;
		public virtual RMethod RMAllocAndAcquire_Texture_Boolean
		{
			get
			{
				if(r_MAllocAndAcquire_Texture_Boolean == null)
				{
					r_MAllocAndAcquire_Texture_Boolean = new(this, "AllocAndAcquire", 0, typeof(UnityEngine.Texture), typeof(System.Boolean));
					r_MAllocAndAcquire_Texture_Boolean.SetBelong(this.instance);
				}
				return r_MAllocAndAcquire_Texture_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId Acquire(UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MAcquire_Texture;
		public virtual RMethod RMAcquire_Texture
		{
			get
			{
				if(r_MAcquire_Texture == null)
				{
					r_MAcquire_Texture = new(this, "Acquire", 0, typeof(UnityEngine.Texture));
					r_MAcquire_Texture.SetBelong(this.instance);
				}
				return r_MAcquire_Texture;
			}
		}

		/// <summary>
		/// Void Acquire(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_MAcquire_TextureId;
		public virtual RMethod RMAcquire_TextureId
		{
			get
			{
				if(r_MAcquire_TextureId == null)
				{
					r_MAcquire_TextureId = new(this, "Acquire", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_MAcquire_TextureId.SetBelong(this.instance);
				}
				return r_MAcquire_TextureId;
			}
		}

		/// <summary>
		/// Void Release(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_MRelease_TextureId;
		public virtual RMethod RMRelease_TextureId
		{
			get
			{
				if(r_MRelease_TextureId == null)
				{
					r_MRelease_TextureId = new(this, "Release", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_MRelease_TextureId.SetBelong(this.instance);
				}
				return r_MRelease_TextureId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId TextureToId(UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MTextureToId_Texture;
		public virtual RMethod RMTextureToId_Texture
		{
			get
			{
				if(r_MTextureToId_Texture == null)
				{
					r_MTextureToId_Texture = new(this, "TextureToId", 0, typeof(UnityEngine.Texture));
					r_MTextureToId_Texture.SetBelong(this.instance);
				}
				return r_MTextureToId_Texture;
			}
		}

		/// <summary>
		/// Statistics GatherStatistics()
		/// </summary>
		protected RMethod r_MGatherStatistics;
		public virtual RMethod RMGatherStatistics
		{
			get
			{
				if(r_MGatherStatistics == null)
				{
					r_MGatherStatistics = new(this, "GatherStatistics", 0);
					r_MGatherStatistics.SetBelong(this.instance);
				}
				return r_MGatherStatistics;
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


        public RTextureRegistry() : base("UnityEngine.UIElements.TextureRegistry")
        {
        }

        public RTextureRegistry(System.Object instance) : base("UnityEngine.UIElements.TextureRegistry")
		{
            SetInstance(instance);
		}

        public RTextureRegistry(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextureRegistry(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.Texture GetTexture(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetTexture_TextureId.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId AllocAndAcquireDynamic()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAllocAndAcquireDynamic.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId(___result);
        }


        public virtual void UpdateDynamic(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @id, UnityEngine.Texture @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @texture};
            var ___result = RMUpdateDynamic_TextureId_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId AllocAndAcquire(UnityEngine.Texture @texture, System.Boolean @dynamic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @dynamic};
            var ___result = RMAllocAndAcquire_Texture_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId Acquire(UnityEngine.Texture @tex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tex};
            var ___result = RMAcquire_Texture.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId(___result);
        }


        public virtual void Acquire(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMAcquire_TextureId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Release(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMRelease_TextureId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId TextureToId(UnityEngine.Texture @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture};
            var ___result = RMTextureToId_Texture.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry.RStatistics GatherStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGatherStatistics.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry.RStatistics(___result);
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
