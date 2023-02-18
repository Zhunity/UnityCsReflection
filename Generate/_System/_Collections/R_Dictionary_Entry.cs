
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.DictionaryEntry
	/// </summary>
    public partial class RDictionaryEntry : RMember //
    {

		/// <summary>
		/// System.Object _key
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F_key;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF_key
		{
			get
			{
				if(r_F_key == null)
				{
					r_F_key = new(this, "_key");
					r_F_key.SetBelong(this.GetValue());
				}
				return r_F_key;
			}
		}

		/// <summary>
		/// System.Object _value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F_value;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF_value
		{
			get
			{
				if(r_F_value == null)
				{
					r_F_value = new(this, "_value");
					r_F_value.SetBelong(this.GetValue());
				}
				return r_F_value;
			}
		}

		/// <summary>
		/// System.Object Key
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPKey
		{
			get
			{
				if(r_PKey == null)
				{
					r_PKey = new(this, "Key", -1);
					r_PKey.SetBelong(this.GetValue());
				}
				return r_PKey;
			}
		}

		/// <summary>
		/// System.Object Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
					r_PValue.SetBelong(this.GetValue());
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// Void Deconstruct(System.Object ByRef, System.Object ByRef)
		/// </summary>
		protected RMethod r_MDeconstruct_Out_Object_Out_Object;
		public virtual RMethod RMDeconstruct_Out_Object_Out_Object
		{
			get
			{
				if(r_MDeconstruct_Out_Object_Out_Object == null)
				{
					r_MDeconstruct_Out_Object_Out_Object = new(this, "Deconstruct", 0, typeof(System.Object).MakeByRefType(), typeof(System.Object).MakeByRefType());
					r_MDeconstruct_Out_Object_Out_Object.SetBelong(this.GetValue());
				}
				return r_MDeconstruct_Out_Object_Out_Object;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RDictionaryEntry() : base("System.Collections.DictionaryEntry")
        {
        }

        public RDictionaryEntry(System.Object instance) : base("System.Collections.DictionaryEntry")
		{
            SetInstance(instance);
		}

        public RDictionaryEntry(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDictionaryEntry(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Deconstruct(out System.Object @key, out System.Object @value)
        {
			@key = default;
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMDeconstruct_Out_Object_Out_Object.Invoke(___genericsType, ___parameters);
			@key = (System.Object)___parameters[0];
			@value = (System.Object)___parameters[1];

            
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
