using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.DictionaryEntry
	/// </summary>
    public partial class RDictionaryEntry : RMember //
    {

		/// <summary>
		/// System.Object _key
		/// </summary>
		protected RSystem.RObject r__key;
		public virtual RSystem.RObject R_key
		{
			get
			{
				if(r__key == null)
				{
					r__key = new(this, "_key");
					r__key.SetBelong(this.instance);
				}
				return r__key;
			}
		}

		/// <summary>
		/// System.Object _value
		/// </summary>
		protected RSystem.RObject r__value;
		public virtual RSystem.RObject R_value
		{
			get
			{
				if(r__value == null)
				{
					r__value = new(this, "_value");
					r__value.SetBelong(this.instance);
				}
				return r__value;
			}
		}

		/// <summary>
		/// System.Object Key
		/// </summary>
		protected RSystem.RObject r_Key;
		public virtual RSystem.RObject RKey
		{
			get
			{
				if(r_Key == null)
				{
					r_Key = new(this, "Key", -1);
					r_Key.SetBelong(this.instance);
				}
				return r_Key;
			}
		}

		/// <summary>
		/// System.Object Value
		/// </summary>
		protected RSystem.RObject r_Value;
		public virtual RSystem.RObject RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// Void Deconstruct(System.Object ByRef, System.Object ByRef)
		/// </summary>
		protected RMethod r_Deconstruct_Out_Object_Out_Object;
		public virtual RMethod RDeconstruct_Out_Object_Out_Object
		{
			get
			{
				if(r_Deconstruct_Out_Object_Out_Object == null)
				{
					r_Deconstruct_Out_Object_Out_Object = new(this, "Deconstruct", 0, typeof(System.Object).MakeByRefType(), typeof(System.Object).MakeByRefType());
					r_Deconstruct_Out_Object_Out_Object.SetBelong(this.instance);
				}
				return r_Deconstruct_Out_Object_Out_Object;
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

        public virtual void Deconstruct(out System.Object  @key, out System.Object  @value)
        {
			@key = default;
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RDeconstruct_Out_Object_Out_Object.Invoke(___genericsType, ___parameters);
			@key = (System.Object)___parameters[0];
			@value = (System.Object)___parameters[1];

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
