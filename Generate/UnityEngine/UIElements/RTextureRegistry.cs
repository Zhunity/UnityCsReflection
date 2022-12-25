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
					r_maxTextures = new( ReleactionUtils.GetType("UnityEngine.UIElements.TextureRegistry"), "maxTextures");
					r_maxTextures.SetBelong(null);
				}
				return r_maxTextures;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureRegistry <instance>k__BackingField
		/// </summary>
		protected static RUnityEngine.RUIElements.RTextureRegistry r___1__instance__2__k__BackingField;
		public static RUnityEngine.RUIElements.RTextureRegistry R__1__instance__2__k__BackingField
		{
			get
			{
				if(r___1__instance__2__k__BackingField == null)
				{
					r___1__instance__2__k__BackingField = new( ReleactionUtils.GetType("UnityEngine.UIElements.TextureRegistry"), "<instance>k__BackingField");
					r___1__instance__2__k__BackingField.SetBelong(null);
				}
				return r___1__instance__2__k__BackingField;
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
					r_instance = new( ReleactionUtils.GetType("UnityEngine.UIElements.TextureRegistry"), "instance", -1);
					r_instance.SetBelong(null);
				}
				return r_instance;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GetTexture(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_RGetTexture_TextureId;
		public virtual RMethod RGetTexture_TextureId
		{
			get
			{
				if(r_RGetTexture_TextureId == null)
				{
					r_RGetTexture_TextureId = new(this, "GetTexture", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_RGetTexture_TextureId.SetBelong(this.instance);
				}
				return r_RGetTexture_TextureId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId AllocAndAcquireDynamic()
		/// </summary>
		protected RMethod r_RAllocAndAcquireDynamic;
		public virtual RMethod RAllocAndAcquireDynamic
		{
			get
			{
				if(r_RAllocAndAcquireDynamic == null)
				{
					r_RAllocAndAcquireDynamic = new(this, "AllocAndAcquireDynamic", 0);
					r_RAllocAndAcquireDynamic.SetBelong(this.instance);
				}
				return r_RAllocAndAcquireDynamic;
			}
		}

		/// <summary>
		/// Void UpdateDynamic(UnityEngine.UIElements.TextureId, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RUpdateDynamic_TextureId_Texture;
		public virtual RMethod RUpdateDynamic_TextureId_Texture
		{
			get
			{
				if(r_RUpdateDynamic_TextureId_Texture == null)
				{
					r_RUpdateDynamic_TextureId_Texture = new(this, "UpdateDynamic", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(UnityEngine.Texture));
					r_RUpdateDynamic_TextureId_Texture.SetBelong(this.instance);
				}
				return r_RUpdateDynamic_TextureId_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId AllocAndAcquire(UnityEngine.Texture, Boolean)
		/// </summary>
		protected RMethod r_RAllocAndAcquire_Texture_Boolean;
		public virtual RMethod RAllocAndAcquire_Texture_Boolean
		{
			get
			{
				if(r_RAllocAndAcquire_Texture_Boolean == null)
				{
					r_RAllocAndAcquire_Texture_Boolean = new(this, "AllocAndAcquire", 0, typeof(UnityEngine.Texture), typeof(System.Boolean));
					r_RAllocAndAcquire_Texture_Boolean.SetBelong(this.instance);
				}
				return r_RAllocAndAcquire_Texture_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId Acquire(UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RAcquire_Texture;
		public virtual RMethod RAcquire_Texture
		{
			get
			{
				if(r_RAcquire_Texture == null)
				{
					r_RAcquire_Texture = new(this, "Acquire", 0, typeof(UnityEngine.Texture));
					r_RAcquire_Texture.SetBelong(this.instance);
				}
				return r_RAcquire_Texture;
			}
		}

		/// <summary>
		/// Void Acquire(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_RAcquire_TextureId;
		public virtual RMethod RAcquire_TextureId
		{
			get
			{
				if(r_RAcquire_TextureId == null)
				{
					r_RAcquire_TextureId = new(this, "Acquire", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_RAcquire_TextureId.SetBelong(this.instance);
				}
				return r_RAcquire_TextureId;
			}
		}

		/// <summary>
		/// Void Release(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_RRelease_TextureId;
		public virtual RMethod RRelease_TextureId
		{
			get
			{
				if(r_RRelease_TextureId == null)
				{
					r_RRelease_TextureId = new(this, "Release", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_RRelease_TextureId.SetBelong(this.instance);
				}
				return r_RRelease_TextureId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId TextureToId(UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RTextureToId_Texture;
		public virtual RMethod RTextureToId_Texture
		{
			get
			{
				if(r_RTextureToId_Texture == null)
				{
					r_RTextureToId_Texture = new(this, "TextureToId", 0, typeof(UnityEngine.Texture));
					r_RTextureToId_Texture.SetBelong(this.instance);
				}
				return r_RTextureToId_Texture;
			}
		}

		/// <summary>
		/// Statistics GatherStatistics()
		/// </summary>
		protected RMethod r_RGatherStatistics;
		public virtual RMethod RGatherStatistics
		{
			get
			{
				if(r_RGatherStatistics == null)
				{
					r_RGatherStatistics = new(this, "GatherStatistics", 0);
					r_RGatherStatistics.SetBelong(this.instance);
				}
				return r_RGatherStatistics;
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


        public virtual System.Object AllocAndAcquireDynamic()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocAndAcquireDynamic.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Object AllocAndAcquire(UnityEngine.Texture  @texture, System.Boolean  @dynamic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @dynamic};
            var ___result = RAllocAndAcquire_Texture_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Acquire(UnityEngine.Texture  @tex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tex};
            var ___result = RAcquire_Texture.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }




        public virtual System.Object TextureToId(UnityEngine.Texture  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture};
            var ___result = RTextureToId_Texture.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GatherStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGatherStatistics.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
