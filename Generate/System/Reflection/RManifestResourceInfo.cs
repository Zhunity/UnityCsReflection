using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.ManifestResourceInfo
	/// </summary>
    public partial class RManifestResourceInfo : RMember //
    {

		/// <summary>
		/// System.Reflection.Assembly <ReferencedAssembly>k__BackingField
		/// </summary>
		protected RSystem.RReflection.RAssembly r___1__ReferencedAssembly__2__k__BackingField;
		public virtual RSystem.RReflection.RAssembly R__1__ReferencedAssembly__2__k__BackingField
		{
			get
			{
				if(r___1__ReferencedAssembly__2__k__BackingField == null)
				{
					r___1__ReferencedAssembly__2__k__BackingField = new(this, "<ReferencedAssembly>k__BackingField");
					r___1__ReferencedAssembly__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__ReferencedAssembly__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <FileName>k__BackingField
		/// </summary>
		protected RField r___1__FileName__2__k__BackingField;
		public virtual RField R__1__FileName__2__k__BackingField
		{
			get
			{
				if(r___1__FileName__2__k__BackingField == null)
				{
					r___1__FileName__2__k__BackingField = new(this, "<FileName>k__BackingField");
					r___1__FileName__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__FileName__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Reflection.ResourceLocation <ResourceLocation>k__BackingField
		/// </summary>
		protected RField r___1__ResourceLocation__2__k__BackingField;
		public virtual RField R__1__ResourceLocation__2__k__BackingField
		{
			get
			{
				if(r___1__ResourceLocation__2__k__BackingField == null)
				{
					r___1__ResourceLocation__2__k__BackingField = new(this, "<ResourceLocation>k__BackingField");
					r___1__ResourceLocation__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__ResourceLocation__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly ReferencedAssembly
		/// </summary>
		protected RSystem.RReflection.RAssembly r_ReferencedAssembly;
		public virtual RSystem.RReflection.RAssembly ReferencedAssembly
		{
			get
			{
				if(r_ReferencedAssembly == null)
				{
					r_ReferencedAssembly = new(this, "ReferencedAssembly", -1);
					r_ReferencedAssembly.SetBelong(this.instance);
				}
				return r_ReferencedAssembly;
			}
		}

		/// <summary>
		/// System.String FileName
		/// </summary>
		protected RProperty r_FileName;
		public virtual RProperty RFileName
		{
			get
			{
				if(r_FileName == null)
				{
					r_FileName = new(this, "FileName", -1);
					r_FileName.SetBelong(this.instance);
				}
				return r_FileName;
			}
		}

		/// <summary>
		/// System.Reflection.ResourceLocation ResourceLocation
		/// </summary>
		protected RProperty r_ResourceLocation;
		public virtual RProperty ResourceLocation
		{
			get
			{
				if(r_ResourceLocation == null)
				{
					r_ResourceLocation = new(this, "ResourceLocation", -1);
					r_ResourceLocation.SetBelong(this.instance);
				}
				return r_ResourceLocation;
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


        public RManifestResourceInfo() : base("System.Reflection.ManifestResourceInfo")
        {
        }

        public RManifestResourceInfo(System.Object instance) : base("System.Reflection.ManifestResourceInfo")
		{
            SetInstance(instance);
		}

        public RManifestResourceInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RManifestResourceInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
