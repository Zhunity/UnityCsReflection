
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.ActivationContext
	/// </summary>
    public partial class RActivationContext : RMember //
    {

		/// <summary>
		/// System.ApplicationIdentity _appid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RApplicationIdentity r_F_appid;
		public virtual Hvak.Editor.Refleaction.RSystem.RApplicationIdentity RF_appid
		{
			get
			{
				if(r_F_appid == null)
				{
					r_F_appid = new(this, "_appid");
				}
				return r_F_appid;
			}
		}

		/// <summary>
		/// System.ActivationContext+ContextForm _form
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RActivationContext.RContextForm r_F_form;
		public virtual Hvak.Editor.Refleaction.RSystem.RActivationContext.RContextForm RF_form
		{
			get
			{
				if(r_F_form == null)
				{
					r_F_form = new(this, "_form");
				}
				return r_F_form;
			}
		}

		/// <summary>
		/// System.Boolean _disposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_disposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_disposed
		{
			get
			{
				if(r_F_disposed == null)
				{
					r_F_disposed = new(this, "_disposed");
				}
				return r_F_disposed;
			}
		}

		/// <summary>
		/// ContextForm Form
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RActivationContext.RContextForm r_PForm;
		public virtual Hvak.Editor.Refleaction.RSystem.RActivationContext.RContextForm RPForm
		{
			get
			{
				if(r_PForm == null)
				{
					r_PForm = new(this, "Form", -1);
				}
				return r_PForm;
			}
		}

		/// <summary>
		/// System.ApplicationIdentity Identity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RApplicationIdentity r_PIdentity;
		public virtual Hvak.Editor.Refleaction.RSystem.RApplicationIdentity RPIdentity
		{
			get
			{
				if(r_PIdentity == null)
				{
					r_PIdentity = new(this, "Identity", -1);
				}
				return r_PIdentity;
			}
		}

		/// <summary>
		/// Byte[] ApplicationManifestBytes
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PApplicationManifestBytes;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPApplicationManifestBytes
		{
			get
			{
				if(r_PApplicationManifestBytes == null)
				{
					r_PApplicationManifestBytes = new(this, "ApplicationManifestBytes", -1);
				}
				return r_PApplicationManifestBytes;
			}
		}

		/// <summary>
		/// Byte[] DeploymentManifestBytes
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PDeploymentManifestBytes;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPDeploymentManifestBytes
		{
			get
			{
				if(r_PDeploymentManifestBytes == null)
				{
					r_PDeploymentManifestBytes = new(this, "DeploymentManifestBytes", -1);
				}
				return r_PDeploymentManifestBytes;
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
		/// System.ActivationContext CreatePartialActivationContext(System.ApplicationIdentity)
		/// </summary>
		protected static RMethod r_MCreatePartialActivationContext_ApplicationIdentity;
		public static RMethod RMCreatePartialActivationContext_ApplicationIdentity
		{
			get
			{
				if(r_MCreatePartialActivationContext_ApplicationIdentity == null)
				{
					r_MCreatePartialActivationContext_ApplicationIdentity = new(typeof(System.ActivationContext), "CreatePartialActivationContext", 0, typeof(System.ApplicationIdentity));
				}
				return r_MCreatePartialActivationContext_ApplicationIdentity;
			}
		}

		/// <summary>
		/// System.ActivationContext CreatePartialActivationContext(System.ApplicationIdentity, System.String[])
		/// </summary>
		protected static RMethod r_MCreatePartialActivationContext_ApplicationIdentity_StringArray;
		public static RMethod RMCreatePartialActivationContext_ApplicationIdentity_StringArray
		{
			get
			{
				if(r_MCreatePartialActivationContext_ApplicationIdentity_StringArray == null)
				{
					r_MCreatePartialActivationContext_ApplicationIdentity_StringArray = new(typeof(System.ActivationContext), "CreatePartialActivationContext", 0, typeof(System.ApplicationIdentity), typeof(System.String).MakeArrayType());
				}
				return r_MCreatePartialActivationContext_ApplicationIdentity_StringArray;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
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
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.ActivationContext CreatePartialActivationContext(System.ApplicationIdentity @identity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identity};
            var ___result = RMCreatePartialActivationContext_ApplicationIdentity.Invoke(___genericsType, ___parameters);

            return (System.ActivationContext)___result;
        }


        public static System.ActivationContext CreatePartialActivationContext(System.ApplicationIdentity @identity, System.String[] @manifestPaths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identity, @manifestPaths};
            var ___result = RMCreatePartialActivationContext_ApplicationIdentity_StringArray.Invoke(___genericsType, ___parameters);

            return (System.ActivationContext)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
