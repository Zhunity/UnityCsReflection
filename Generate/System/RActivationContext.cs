using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.ActivationContext
	/// </summary>
    public partial class RActivationContext : RMember //
    {

		/// <summary>
		/// System.ApplicationIdentity _appid
		/// </summary>
		protected RSystem.RApplicationIdentity r__appid;
		public virtual RSystem.RApplicationIdentity R_appid
		{
			get
			{
				if(r__appid == null)
				{
					r__appid = new(this, "_appid");
					r__appid.SetBelong(this.instance);
				}
				return r__appid;
			}
		}

		/// <summary>
		/// System.ActivationContext+ContextForm _form
		/// </summary>
		protected RField r__form;
		public virtual RField R_form
		{
			get
			{
				if(r__form == null)
				{
					r__form = new(this, "_form");
					r__form.SetBelong(this.instance);
				}
				return r__form;
			}
		}

		/// <summary>
		/// System.Boolean _disposed
		/// </summary>
		protected RField r__disposed;
		public virtual RField R_disposed
		{
			get
			{
				if(r__disposed == null)
				{
					r__disposed = new(this, "_disposed");
					r__disposed.SetBelong(this.instance);
				}
				return r__disposed;
			}
		}

		/// <summary>
		/// ContextForm Form
		/// </summary>
		protected RProperty r_Form;
		public virtual RProperty RForm
		{
			get
			{
				if(r_Form == null)
				{
					r_Form = new(this, "Form", -1);
					r_Form.SetBelong(this.instance);
				}
				return r_Form;
			}
		}

		/// <summary>
		/// System.ApplicationIdentity Identity
		/// </summary>
		protected RSystem.RApplicationIdentity r_Identity;
		public virtual RSystem.RApplicationIdentity RIdentity
		{
			get
			{
				if(r_Identity == null)
				{
					r_Identity = new(this, "Identity", -1);
					r_Identity.SetBelong(this.instance);
				}
				return r_Identity;
			}
		}

		/// <summary>
		/// Byte[] ApplicationManifestBytes
		/// </summary>
		protected RPropertyArray<RProperty> r_ApplicationManifestBytes;
		public virtual RPropertyArray<RProperty> RApplicationManifestBytes
		{
			get
			{
				if(r_ApplicationManifestBytes == null)
				{
					r_ApplicationManifestBytes = new(this, "ApplicationManifestBytes", -1);
					r_ApplicationManifestBytes.SetBelong(this.instance);
				}
				return r_ApplicationManifestBytes;
			}
		}

		/// <summary>
		/// Byte[] DeploymentManifestBytes
		/// </summary>
		protected RPropertyArray<RProperty> r_DeploymentManifestBytes;
		public virtual RPropertyArray<RProperty> RDeploymentManifestBytes
		{
			get
			{
				if(r_DeploymentManifestBytes == null)
				{
					r_DeploymentManifestBytes = new(this, "DeploymentManifestBytes", -1);
					r_DeploymentManifestBytes.SetBelong(this.instance);
				}
				return r_DeploymentManifestBytes;
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
		/// System.ActivationContext CreatePartialActivationContext(System.ApplicationIdentity)
		/// </summary>
		protected static RMethod r_CreatePartialActivationContext_ApplicationIdentity;
		public static RMethod RCreatePartialActivationContext_ApplicationIdentity
		{
			get
			{
				if(r_CreatePartialActivationContext_ApplicationIdentity == null)
				{
					r_CreatePartialActivationContext_ApplicationIdentity = new(typeof(System.ActivationContext), "CreatePartialActivationContext", 0, typeof(System.ApplicationIdentity));
					r_CreatePartialActivationContext_ApplicationIdentity.SetBelong(null);
				}
				return r_CreatePartialActivationContext_ApplicationIdentity;
			}
		}

		/// <summary>
		/// System.ActivationContext CreatePartialActivationContext(System.ApplicationIdentity, System.String[])
		/// </summary>
		protected static RMethod r_CreatePartialActivationContext_ApplicationIdentity_StringArray;
		public static RMethod RCreatePartialActivationContext_ApplicationIdentity_StringArray
		{
			get
			{
				if(r_CreatePartialActivationContext_ApplicationIdentity_StringArray == null)
				{
					r_CreatePartialActivationContext_ApplicationIdentity_StringArray = new(typeof(System.ActivationContext), "CreatePartialActivationContext", 0, typeof(System.ApplicationIdentity), typeof(System.String).MakeArrayType());
					r_CreatePartialActivationContext_ApplicationIdentity_StringArray.SetBelong(null);
				}
				return r_CreatePartialActivationContext_ApplicationIdentity_StringArray;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_Dispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_Dispose_Boolean == null)
				{
					r_Dispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_Dispose_Boolean.SetBelong(this.instance);
				}
				return r_Dispose_Boolean;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
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


        public RActivationContext() : base("System.ActivationContext")
        {
        }

        public RActivationContext(System.Object instance) : base("System.ActivationContext")
		{
            SetInstance(instance);
		}

        public RActivationContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RActivationContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.ActivationContext CreatePartialActivationContext(System.ApplicationIdentity @identity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identity};
            var ___result = RCreatePartialActivationContext_ApplicationIdentity.Invoke(___genericsType, ___parameters);

            return (System.ActivationContext)___result;
        }


        public static System.ActivationContext CreatePartialActivationContext(System.ApplicationIdentity @identity, System.String[] @manifestPaths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identity, @manifestPaths};
            var ___result = RCreatePartialActivationContext_ApplicationIdentity_StringArray.Invoke(___genericsType, ___parameters);

            return (System.ActivationContext)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
