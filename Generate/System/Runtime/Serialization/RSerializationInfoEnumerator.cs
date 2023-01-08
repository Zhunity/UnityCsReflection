using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
	/// System.Runtime.Serialization.SerializationInfoEnumerator
	/// </summary>
    public partial class RSerializationInfoEnumerator : RMember //
    {

		/// <summary>
		/// System.String[] _members
		/// </summary>
		protected RFieldArray<RField> r__members;
		public virtual RFieldArray<RField> R_members
		{
			get
			{
				if(r__members == null)
				{
					r__members = new(this, "_members");
					r__members.SetBelong(this.instance);
				}
				return r__members;
			}
		}

		/// <summary>
		/// System.Object[] _data
		/// </summary>
		protected RFieldArray<RSystem.RObject> r__data;
		public virtual RFieldArray<RSystem.RObject> R_data
		{
			get
			{
				if(r__data == null)
				{
					r__data = new(this, "_data");
					r__data.SetBelong(this.instance);
				}
				return r__data;
			}
		}

		/// <summary>
		/// System.Type[] _types
		/// </summary>
		protected RFieldArray<RSystem.RType> r__types;
		public virtual RFieldArray<RSystem.RType> R_types
		{
			get
			{
				if(r__types == null)
				{
					r__types = new(this, "_types");
					r__types.SetBelong(this.instance);
				}
				return r__types;
			}
		}

		/// <summary>
		/// System.Int32 _numItems
		/// </summary>
		protected RField r__numItems;
		public virtual RField R_numItems
		{
			get
			{
				if(r__numItems == null)
				{
					r__numItems = new(this, "_numItems");
					r__numItems.SetBelong(this.instance);
				}
				return r__numItems;
			}
		}

		/// <summary>
		/// System.Int32 _currItem
		/// </summary>
		protected RField r__currItem;
		public virtual RField R_currItem
		{
			get
			{
				if(r__currItem == null)
				{
					r__currItem = new(this, "_currItem");
					r__currItem.SetBelong(this.instance);
				}
				return r__currItem;
			}
		}

		/// <summary>
		/// System.Boolean _current
		/// </summary>
		protected RField r__current;
		public virtual RField R_current
		{
			get
			{
				if(r__current == null)
				{
					r__current = new(this, "_current");
					r__current.SetBelong(this.instance);
				}
				return r__current;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IEnumerator.Current
		/// </summary>
		protected RSystem.RObject r_System__2__Collections__2__IEnumerator__2__Current;
		public virtual RSystem.RObject RSystem__2__Collections__2__IEnumerator__2__Current
		{
			get
			{
				if(r_System__2__Collections__2__IEnumerator__2__Current == null)
				{
					r_System__2__Collections__2__IEnumerator__2__Current = new(this, "System.Collections.IEnumerator.Current", -1);
					r_System__2__Collections__2__IEnumerator__2__Current.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IEnumerator__2__Current;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.SerializationEntry Current
		/// </summary>
		protected RSystem.RRuntime.RSerialization.RSerializationEntry r_Current;
		public virtual RSystem.RRuntime.RSerialization.RSerializationEntry RCurrent
		{
			get
			{
				if(r_Current == null)
				{
					r_Current = new(this, "Current", -1);
					r_Current.SetBelong(this.instance);
				}
				return r_Current;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
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
		/// System.Type ObjectType
		/// </summary>
		protected RSystem.RType r_ObjectType;
		public virtual RSystem.RType RObjectType
		{
			get
			{
				if(r_ObjectType == null)
				{
					r_ObjectType = new(this, "ObjectType", -1);
					r_ObjectType.SetBelong(this.instance);
				}
				return r_ObjectType;
			}
		}

		/// <summary>
		/// Boolean MoveNext()
		/// </summary>
		protected RMethod r_MoveNext;
		public virtual RMethod RMoveNext
		{
			get
			{
				if(r_MoveNext == null)
				{
					r_MoveNext = new(this, "MoveNext", 0);
					r_MoveNext.SetBelong(this.instance);
				}
				return r_MoveNext;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
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


        public RSerializationInfoEnumerator() : base("System.Runtime.Serialization.SerializationInfoEnumerator")
        {
        }

        public RSerializationInfoEnumerator(System.Object instance) : base("System.Runtime.Serialization.SerializationInfoEnumerator")
		{
            SetInstance(instance);
		}

        public RSerializationInfoEnumerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSerializationInfoEnumerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
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
