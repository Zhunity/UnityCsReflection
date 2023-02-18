
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
	/// System.Runtime.Serialization.SerializationInfoEnumerator
	/// </summary>
    public partial class RSerializationInfoEnumerator : RMember //
    {

		/// <summary>
		/// System.String[] _members
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_F_members;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RF_members
		{
			get
			{
				if(r_F_members == null)
				{
					r_F_members = new(this, "_members");
				}
				return r_F_members;
			}
		}

		/// <summary>
		/// System.Object[] _data
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_F_data;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RF_data
		{
			get
			{
				if(r_F_data == null)
				{
					r_F_data = new(this, "_data");
				}
				return r_F_data;
			}
		}

		/// <summary>
		/// System.Type[] _types
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> r_F_types;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> RF_types
		{
			get
			{
				if(r_F_types == null)
				{
					r_F_types = new(this, "_types");
				}
				return r_F_types;
			}
		}

		/// <summary>
		/// System.Int32 _numItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_numItems;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_numItems
		{
			get
			{
				if(r_F_numItems == null)
				{
					r_F_numItems = new(this, "_numItems");
				}
				return r_F_numItems;
			}
		}

		/// <summary>
		/// System.Int32 _currItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_currItem;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_currItem
		{
			get
			{
				if(r_F_currItem == null)
				{
					r_F_currItem = new(this, "_currItem");
				}
				return r_F_currItem;
			}
		}

		/// <summary>
		/// System.Boolean _current
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_current;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_current
		{
			get
			{
				if(r_F_current == null)
				{
					r_F_current = new(this, "_current");
				}
				return r_F_current;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IEnumerator.Current
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSystem__2__Collections__2__IEnumerator__2__Current;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSystem__2__Collections__2__IEnumerator__2__Current
		{
			get
			{
				if(r_PSystem__2__Collections__2__IEnumerator__2__Current == null)
				{
					r_PSystem__2__Collections__2__IEnumerator__2__Current = new(this, "System.Collections.IEnumerator.Current", -1);
				}
				return r_PSystem__2__Collections__2__IEnumerator__2__Current;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.SerializationEntry Current
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RSerializationEntry r_PCurrent;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RSerializationEntry RPCurrent
		{
			get
			{
				if(r_PCurrent == null)
				{
					r_PCurrent = new(this, "Current", -1);
				}
				return r_PCurrent;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
				}
				return r_PName;
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
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// System.Type ObjectType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PObjectType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPObjectType
		{
			get
			{
				if(r_PObjectType == null)
				{
					r_PObjectType = new(this, "ObjectType", -1);
				}
				return r_PObjectType;
			}
		}

		/// <summary>
		/// Boolean MoveNext()
		/// </summary>
		protected RMethod r_MMoveNext;
		public virtual RMethod RMMoveNext
		{
			get
			{
				if(r_MMoveNext == null)
				{
					r_MMoveNext = new(this, "MoveNext", 0);
				}
				return r_MMoveNext;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
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
            var ___result = RMMoveNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
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
