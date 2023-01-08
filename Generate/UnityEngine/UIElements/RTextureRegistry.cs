using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TextureRegistry
	/// </summary>
    public partial class RTextureRegistry : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TextureRegistry+TextureInfo] m_Textures
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTextureRegistry.RTextureInfo> r_m_Textures;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTextureRegistry.RTextureInfo> Rm_Textures
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
		/// System.Collections.Generic.Dictionary`2[UnityEngine.Texture,UnityEngine.UIElements.TextureId] m_TextureToId
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RTexture, RUnityEngine.RUIElements.RTextureId> r_m_TextureToId;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RTexture, RUnityEngine.RUIElements.RTextureId> Rm_TextureToId
		{
			get
			{
				if(r_m_TextureToId == null)
				{
					r_m_TextureToId = new(this, "m_TextureToId");
					r_m_TextureToId.SetBelong(this.instance);
				}
				return r_m_TextureToId;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.UIElements.TextureId] m_FreeIds
		/// </summary>
		protected RSystem.RCollections.RGeneric.RStack<RUnityEngine.RUIElements.RTextureId> r_m_FreeIds;
		public virtual RSystem.RCollections.RGeneric.RStack<RUnityEngine.RUIElements.RTextureId> Rm_FreeIds
		{
			get
			{
				if(r_m_FreeIds == null)
				{
					r_m_FreeIds = new(this, "m_FreeIds");
					r_m_FreeIds.SetBelong(this.instance);
				}
				return r_m_FreeIds;
			}
		}

		/// <summary>
		/// System.Int32 maxTextures
		/// </summary>
		protected static RField r_maxTextures;
		public static RField RmaxTextures
		{
			get
			{
				if(r_maxTextures == null)
				{
					r_maxTextures = new( ReflectionUtils.GetType("UnityEngine.UIElements.TextureRegistry"), "maxTextures");
					r_maxTextures.SetBelong(null);
				}
				return r_maxTextures;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureRegistry <instance>k__BackingField
		/// </summary>
		protected static RUnityEngine.RUIElements.RTextureRegistry r___0__instance__1__k__BackingField;
		public static RUnityEngine.RUIElements.RTextureRegistry R__0__instance__1__k__BackingField
		{
			get
			{
				if(r___0__instance__1__k__BackingField == null)
				{
					r___0__instance__1__k__BackingField = new( ReflectionUtils.GetType("UnityEngine.UIElements.TextureRegistry"), "<instance>k__BackingField");
					r___0__instance__1__k__BackingField.SetBelong(null);
				}
				return r___0__instance__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureRegistry instance
		/// </summary>
		protected static RUnityEngine.RUIElements.RTextureRegistry r_instance;
		public static RUnityEngine.RUIElements.RTextureRegistry Rinstance
		{
			get
			{
				if(r_instance == null)
				{
					r_instance = new( ReflectionUtils.GetType("UnityEngine.UIElements.TextureRegistry"), "instance", -1);
					r_instance.SetBelong(null);
				}
				return r_instance;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetTexture(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_GetTexture_TextureId;
		public virtual RMethod RGetTexture_TextureId
		{
			get
			{
				if(r_GetTexture_TextureId == null)
				{
					r_GetTexture_TextureId = new(this, "GetTexture", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_GetTexture_TextureId.SetBelong(this.instance);
				}
				return r_GetTexture_TextureId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId AllocAndAcquireDynamic()
		/// </summary>
		protected RMethod r_AllocAndAcquireDynamic;
		public virtual RMethod RAllocAndAcquireDynamic
		{
			get
			{
				if(r_AllocAndAcquireDynamic == null)
				{
					r_AllocAndAcquireDynamic = new(this, "AllocAndAcquireDynamic", 0);
					r_AllocAndAcquireDynamic.SetBelong(this.instance);
				}
				return r_AllocAndAcquireDynamic;
			}
		}

		/// <summary>
		/// Void UpdateDynamic(UnityEngine.UIElements.TextureId, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_UpdateDynamic_TextureId_Texture;
		public virtual RMethod RUpdateDynamic_TextureId_Texture
		{
			get
			{
				if(r_UpdateDynamic_TextureId_Texture == null)
				{
					r_UpdateDynamic_TextureId_Texture = new(this, "UpdateDynamic", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(UnityEngine.Texture));
					r_UpdateDynamic_TextureId_Texture.SetBelong(this.instance);
				}
				return r_UpdateDynamic_TextureId_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId AllocAndAcquire(UnityEngine.Texture, Boolean)
		/// </summary>
		protected RMethod r_AllocAndAcquire_Texture_Boolean;
		public virtual RMethod RAllocAndAcquire_Texture_Boolean
		{
			get
			{
				if(r_AllocAndAcquire_Texture_Boolean == null)
				{
					r_AllocAndAcquire_Texture_Boolean = new(this, "AllocAndAcquire", 0, typeof(UnityEngine.Texture), typeof(System.Boolean));
					r_AllocAndAcquire_Texture_Boolean.SetBelong(this.instance);
				}
				return r_AllocAndAcquire_Texture_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId Acquire(UnityEngine.Texture)
		/// </summary>
		protected RMethod r_Acquire_Texture;
		public virtual RMethod RAcquire_Texture
		{
			get
			{
				if(r_Acquire_Texture == null)
				{
					r_Acquire_Texture = new(this, "Acquire", 0, typeof(UnityEngine.Texture));
					r_Acquire_Texture.SetBelong(this.instance);
				}
				return r_Acquire_Texture;
			}
		}

		/// <summary>
		/// Void Acquire(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_Acquire_TextureId;
		public virtual RMethod RAcquire_TextureId
		{
			get
			{
				if(r_Acquire_TextureId == null)
				{
					r_Acquire_TextureId = new(this, "Acquire", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_Acquire_TextureId.SetBelong(this.instance);
				}
				return r_Acquire_TextureId;
			}
		}

		/// <summary>
		/// Void Release(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_Release_TextureId;
		public virtual RMethod RRelease_TextureId
		{
			get
			{
				if(r_Release_TextureId == null)
				{
					r_Release_TextureId = new(this, "Release", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_Release_TextureId.SetBelong(this.instance);
				}
				return r_Release_TextureId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId TextureToId(UnityEngine.Texture)
		/// </summary>
		protected RMethod r_TextureToId_Texture;
		public virtual RMethod RTextureToId_Texture
		{
			get
			{
				if(r_TextureToId_Texture == null)
				{
					r_TextureToId_Texture = new(this, "TextureToId", 0, typeof(UnityEngine.Texture));
					r_TextureToId_Texture.SetBelong(this.instance);
				}
				return r_TextureToId_Texture;
			}
		}

		/// <summary>
		/// Statistics GatherStatistics()
		/// </summary>
		protected RMethod r_GatherStatistics;
		public virtual RMethod RGatherStatistics
		{
			get
			{
				if(r_GatherStatistics == null)
				{
					r_GatherStatistics = new(this, "GatherStatistics", 0);
					r_GatherStatistics.SetBelong(this.instance);
				}
				return r_GatherStatistics;
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

        public virtual UnityEngine.Texture GetTexture(RUnityEngine.RUIElements.RTextureId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RGetTexture_TextureId.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture)___result;
        }


        public virtual RUnityEngine.RUIElements.RTextureId AllocAndAcquireDynamic()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocAndAcquireDynamic.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RTextureId(___result);
        }


        public virtual void UpdateDynamic(RUnityEngine.RUIElements.RTextureId @id, UnityEngine.Texture @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @texture};
            var ___result = RUpdateDynamic_TextureId_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RTextureId AllocAndAcquire(UnityEngine.Texture @texture, System.Boolean @dynamic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @dynamic};
            var ___result = RAllocAndAcquire_Texture_Boolean.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RTextureId(___result);
        }


        public virtual RUnityEngine.RUIElements.RTextureId Acquire(UnityEngine.Texture @tex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tex};
            var ___result = RAcquire_Texture.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RTextureId(___result);
        }


        public virtual void Acquire(RUnityEngine.RUIElements.RTextureId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RAcquire_TextureId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Release(RUnityEngine.RUIElements.RTextureId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RRelease_TextureId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RTextureId TextureToId(UnityEngine.Texture @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture};
            var ___result = RTextureToId_Texture.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RTextureId(___result);
        }


        public virtual RUnityEngine.RUIElements.RTextureRegistry.RStatistics GatherStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGatherStatistics.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RTextureRegistry.RStatistics(___result);
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
