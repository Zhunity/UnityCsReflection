using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
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
		protected RSystem.RCollections.RGeneric.RLinkedList<RField> r__list;
		public virtual RSystem.RCollections.RGeneric.RLinkedList<RField> R_list
		{
			get
			{
				if(r__list == null)
				{
					r__list = new(this, "_list");
					r__list.SetBelong(this.instance);
				}
				return r__list;
			}
		}

		/// <summary>
		/// System.Collections.Generic.LinkedListNode`1[T] _node
		/// </summary>
		protected RSystem.RCollections.RGeneric.RLinkedListNode<RField> r__node;
		public virtual RSystem.RCollections.RGeneric.RLinkedListNode<RField> R_node
		{
			get
			{
				if(r__node == null)
				{
					r__node = new(this, "_node");
					r__node.SetBelong(this.instance);
				}
				return r__node;
			}
		}

		/// <summary>
		/// System.Int32 _version
		/// </summary>
		protected RField r__version;
		public virtual RField R_version
		{
			get
			{
				if(r__version == null)
				{
					r__version = new(this, "_version");
					r__version.SetBelong(this.instance);
				}
				return r__version;
			}
		}

		/// <summary>
		/// T _current
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
		/// System.Int32 _index
		/// </summary>
		protected RField r__index;
		public virtual RField R_index
		{
			get
			{
				if(r__index == null)
				{
					r__index = new(this, "_index");
					r__index.SetBelong(this.instance);
				}
				return r__index;
			}
		}

		/// <summary>
		/// System.String LinkedListName
		/// </summary>
		protected static RField r_LinkedListName;
		public static RField RLinkedListName
		{
			get
			{
				if(r_LinkedListName == null)
				{
					r_LinkedListName = new( ReleactionUtils.GetType("System.Collections.Generic.LinkedList`1+Enumerator"), "LinkedListName");
					r_LinkedListName.SetBelong(null);
				}
				return r_LinkedListName;
			}
		}

		/// <summary>
		/// System.String CurrentValueName
		/// </summary>
		protected static RField r_CurrentValueName;
		public static RField RCurrentValueName
		{
			get
			{
				if(r_CurrentValueName == null)
				{
					r_CurrentValueName = new( ReleactionUtils.GetType("System.Collections.Generic.LinkedList`1+Enumerator"), "CurrentValueName");
					r_CurrentValueName.SetBelong(null);
				}
				return r_CurrentValueName;
			}
		}

		/// <summary>
		/// System.String VersionName
		/// </summary>
		protected static RField r_VersionName;
		public static RField RVersionName
		{
			get
			{
				if(r_VersionName == null)
				{
					r_VersionName = new( ReleactionUtils.GetType("System.Collections.Generic.LinkedList`1+Enumerator"), "VersionName");
					r_VersionName.SetBelong(null);
				}
				return r_VersionName;
			}
		}

		/// <summary>
		/// System.String IndexName
		/// </summary>
		protected static RField r_IndexName;
		public static RField RIndexName
		{
			get
			{
				if(r_IndexName == null)
				{
					r_IndexName = new( ReleactionUtils.GetType("System.Collections.Generic.LinkedList`1+Enumerator"), "IndexName");
					r_IndexName.SetBelong(null);
				}
				return r_IndexName;
			}
		}

		/// <summary>
		/// T Current
		/// </summary>
		protected RProperty r_Current;
		public virtual RProperty RCurrent
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
		/// System.Object System.Collections.IEnumerator.Current
		/// </summary>
		protected RSystem.RObject r_RSystem__0__Collections__0__IEnumerator__0__get_Current;
		public virtual RSystem.RObject RSystem__0__Collections__0__IEnumerator__0__get_Current
		{
			get
			{
				if(r_RSystem__0__Collections__0__IEnumerator__0__get_Current == null)
				{
					r_RSystem__0__Collections__0__IEnumerator__0__get_Current = new(this, "System.Collections.IEnumerator.Current", -1);
					r_RSystem__0__Collections__0__IEnumerator__0__get_Current.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IEnumerator__0__get_Current;
			}
		}

		/// <summary>
		/// Boolean MoveNext()
		/// </summary>
		protected RMethod r_RMoveNext;
		public virtual RMethod RMoveNext
		{
			get
			{
				if(r_RMoveNext == null)
				{
					r_RMoveNext = new(this, "MoveNext", 0);
					r_RMoveNext.SetBelong(this.instance);
				}
				return r_RMoveNext;
			}
		}

		/// <summary>
		/// Void System.Collections.IEnumerator.Reset()
		/// </summary>
		protected RMethod r_RSystem__0__Collections__0__IEnumerator__0__Reset;
		public virtual RMethod RSystem__0__Collections__0__IEnumerator__0__Reset
		{
			get
			{
				if(r_RSystem__0__Collections__0__IEnumerator__0__Reset == null)
				{
					r_RSystem__0__Collections__0__IEnumerator__0__Reset = new(this, "System.Collections.IEnumerator.Reset", 0);
					r_RSystem__0__Collections__0__IEnumerator__0__Reset.SetBelong(this.instance);
				}
				return r_RSystem__0__Collections__0__IEnumerator__0__Reset;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object;
		public virtual RMethod RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object
		{
			get
			{
				if(r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object == null)
				{
					r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object;
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
            var ___result = RMoveNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__0__Collections__0__IEnumerator__0__Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__IEnumerator__0__Reset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization(System.Object  @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
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
}