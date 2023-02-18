
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric
{public partial class RLinkedList<T>
{
	
	/// <summary>
	/// System.Collections.Generic.LinkedList`1+Enumerator
	/// </summary>
    public partial class REnumerator : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.LinkedList`1[T] _list
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedList<Hvak.Editor.Refleaction.RField> r_F_list;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedList<Hvak.Editor.Refleaction.RField> RF_list
		{
			get
			{
				if(r_F_list == null)
				{
					r_F_list = new(this, "_list");
				}
				return r_F_list;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] _node
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RField> r_F_node;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RLinkedListNode<Hvak.Editor.Refleaction.RField> RF_node
		{
			get
			{
				if(r_F_node == null)
				{
					r_F_node = new(this, "_node");
				}
				return r_F_node;
			}
		}

		/// <summary>
		/// System.Int32 _version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_version;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_version
		{
			get
			{
				if(r_F_version == null)
				{
					r_F_version = new(this, "_version");
				}
				return r_F_version;
			}
		}

		/// <summary>
		/// T _current
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_F_current;
		public virtual Hvak.Editor.Refleaction.RField RF_current
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
		/// System.Int32 _index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_index;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_index
		{
			get
			{
				if(r_F_index == null)
				{
					r_F_index = new(this, "_index");
				}
				return r_F_index;
			}
		}

		/// <summary>
		/// System.String LinkedListName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FLinkedListName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFLinkedListName
		{
			get
			{
				if(r_FLinkedListName == null)
				{
					r_FLinkedListName = new( ReflectionUtils.GetType("System.Collections.Generic.LinkedList`1+Enumerator"), "LinkedListName");
				}
				return r_FLinkedListName;
			}
		}

		/// <summary>
		/// System.String CurrentValueName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FCurrentValueName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFCurrentValueName
		{
			get
			{
				if(r_FCurrentValueName == null)
				{
					r_FCurrentValueName = new( ReflectionUtils.GetType("System.Collections.Generic.LinkedList`1+Enumerator"), "CurrentValueName");
				}
				return r_FCurrentValueName;
			}
		}

		/// <summary>
		/// System.String VersionName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FVersionName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFVersionName
		{
			get
			{
				if(r_FVersionName == null)
				{
					r_FVersionName = new( ReflectionUtils.GetType("System.Collections.Generic.LinkedList`1+Enumerator"), "VersionName");
				}
				return r_FVersionName;
			}
		}

		/// <summary>
		/// System.String IndexName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FIndexName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFIndexName
		{
			get
			{
				if(r_FIndexName == null)
				{
					r_FIndexName = new( ReflectionUtils.GetType("System.Collections.Generic.LinkedList`1+Enumerator"), "IndexName");
				}
				return r_FIndexName;
			}
		}

		/// <summary>
		/// T Current
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PCurrent;
		public virtual Hvak.Editor.Refleaction.RProperty RPCurrent
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
		/// Void System.Collections.IEnumerator.Reset()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IEnumerator__2__Reset;
		public virtual RMethod RMSystem__2__Collections__2__IEnumerator__2__Reset
		{
			get
			{
				if(r_MSystem__2__Collections__2__IEnumerator__2__Reset == null)
				{
					r_MSystem__2__Collections__2__IEnumerator__2__Reset = new(this, "System.Collections.IEnumerator.Reset", 0);
				}
				return r_MSystem__2__Collections__2__IEnumerator__2__Reset;
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
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
				}
				return r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
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


        public REnumerator() : base("System.Collections.Generic.LinkedList`1+Enumerator")
        {
        }

        public REnumerator(System.Object instance) : base("System.Collections.Generic.LinkedList`1+Enumerator")
		{
            SetInstance(instance);
		}

        public REnumerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REnumerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Collections__2__IEnumerator__2__Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerator__2__Reset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
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
}