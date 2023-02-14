
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.Header
	/// </summary>
    public partial class RHeader : RMember //
    {

		/// <summary>
		/// System.String HeaderNamespace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FHeaderNamespace;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFHeaderNamespace
		{
			get
			{
				if(r_FHeaderNamespace == null)
				{
					r_FHeaderNamespace = new(this, "HeaderNamespace");
					r_FHeaderNamespace.SetBelong(this.instance);
				}
				return r_FHeaderNamespace;
			}
		}

		/// <summary>
		/// System.Boolean MustUnderstand
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FMustUnderstand;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFMustUnderstand
		{
			get
			{
				if(r_FMustUnderstand == null)
				{
					r_FMustUnderstand = new(this, "MustUnderstand");
					r_FMustUnderstand.SetBelong(this.instance);
				}
				return r_FMustUnderstand;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFName
		{
			get
			{
				if(r_FName == null)
				{
					r_FName = new(this, "Name");
					r_FName.SetBelong(this.instance);
				}
				return r_FName;
			}
		}

		/// <summary>
		/// System.Object Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_FValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFValue
		{
			get
			{
				if(r_FValue == null)
				{
					r_FValue = new(this, "Value");
					r_FValue.SetBelong(this.instance);
				}
				return r_FValue;
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


        public RHeader() : base("System.Runtime.Remoting.Messaging.Header")
        {
        }

        public RHeader(System.Object instance) : base("System.Runtime.Remoting.Messaging.Header")
		{
            SetInstance(instance);
		}

        public RHeader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHeader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
