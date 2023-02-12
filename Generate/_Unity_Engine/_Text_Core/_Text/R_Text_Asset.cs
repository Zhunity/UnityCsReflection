
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextAsset
	/// </summary>
    public partial class RTextAsset : RMember //
    {

		/// <summary>
		/// System.String m_Version
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_Version;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_Version
		{
			get
			{
				if(r_Fm_Version == null)
				{
					r_Fm_Version = new(this, "m_Version");
					r_Fm_Version.SetBelong(this.instance);
				}
				return r_Fm_Version;
			}
		}

		/// <summary>
		/// System.Int32 m_InstanceID
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_InstanceID;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_InstanceID
		{
			get
			{
				if(r_Fm_InstanceID == null)
				{
					r_Fm_InstanceID = new(this, "m_InstanceID");
					r_Fm_InstanceID.SetBelong(this.instance);
				}
				return r_Fm_InstanceID;
			}
		}

		/// <summary>
		/// System.Int32 m_HashCode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_HashCode;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_HashCode
		{
			get
			{
				if(r_Fm_HashCode == null)
				{
					r_Fm_HashCode = new(this, "m_HashCode");
					r_Fm_HashCode.SetBelong(this.instance);
				}
				return r_Fm_HashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_Material
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMaterial r_Fm_Material;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMaterial RFm_Material
		{
			get
			{
				if(r_Fm_Material == null)
				{
					r_Fm_Material = new(this, "m_Material");
					r_Fm_Material.SetBelong(this.instance);
				}
				return r_Fm_Material;
			}
		}

		/// <summary>
		/// System.Int32 m_MaterialHashCode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_MaterialHashCode;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_MaterialHashCode
		{
			get
			{
				if(r_Fm_MaterialHashCode == null)
				{
					r_Fm_MaterialHashCode = new(this, "m_MaterialHashCode");
					r_Fm_MaterialHashCode.SetBelong(this.instance);
				}
				return r_Fm_MaterialHashCode;
			}
		}

		/// <summary>
		/// System.String version
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Pversion;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPversion
		{
			get
			{
				if(r_Pversion == null)
				{
					r_Pversion = new(this, "version", -1);
					r_Pversion.SetBelong(this.instance);
				}
				return r_Pversion;
			}
		}

		/// <summary>
		/// Int32 instanceID
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PinstanceID;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPinstanceID
		{
			get
			{
				if(r_PinstanceID == null)
				{
					r_PinstanceID = new(this, "instanceID", -1);
					r_PinstanceID.SetBelong(this.instance);
				}
				return r_PinstanceID;
			}
		}

		/// <summary>
		/// Int32 hashCode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PhashCode;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPhashCode
		{
			get
			{
				if(r_PhashCode == null)
				{
					r_PhashCode = new(this, "hashCode", -1);
					r_PhashCode.SetBelong(this.instance);
				}
				return r_PhashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMaterial r_Pmaterial;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMaterial RPmaterial
		{
			get
			{
				if(r_Pmaterial == null)
				{
					r_Pmaterial = new(this, "material", -1);
					r_Pmaterial.SetBelong(this.instance);
				}
				return r_Pmaterial;
			}
		}

		/// <summary>
		/// Int32 materialHashCode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PmaterialHashCode;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPmaterialHashCode
		{
			get
			{
				if(r_PmaterialHashCode == null)
				{
					r_PmaterialHashCode = new(this, "materialHashCode", -1);
					r_PmaterialHashCode.SetBelong(this.instance);
				}
				return r_PmaterialHashCode;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
					r_PhideFlags.SetBelong(this.instance);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
					r_MSetDirty.SetBelong(this.instance);
				}
				return r_MSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
					r_MGetInstanceID.SetBelong(this.instance);
				}
				return r_MGetInstanceID;
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


        public RTextAsset() : base("UnityEngine.TextCore.Text.TextAsset")
        {
        }

        public RTextAsset(System.Object instance) : base("UnityEngine.TextCore.Text.TextAsset")
		{
            SetInstance(instance);
		}

        public RTextAsset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextAsset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
