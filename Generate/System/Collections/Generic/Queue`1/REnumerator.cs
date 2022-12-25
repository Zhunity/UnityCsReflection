using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{public partial class RQueue<T>
{
	
	/// <summary>
	/// System.Collections.Generic.Queue`1+Enumerator
	/// </summary>
    public partial class REnumerator : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Queue`1[T] _q
		/// </summary>
		protected RSystem.RCollections.RGeneric.RQueue<RField> r__q;
		public virtual RSystem.RCollections.RGeneric.RQueue<RField> R_q
		{
			get
			{
				if(r__q == null)
				{
					r__q = new(this, "_q");
					r__q.SetBelong(this.instance);
				}
				return r__q;
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
		/// T _currentElement
		/// </summary>
		protected RField r__currentElement;
		public virtual RField R_currentElement
		{
			get
			{
				if(r__currentElement == null)
				{
					r__currentElement = new(this, "_currentElement");
					r__currentElement.SetBelong(this.instance);
				}
				return r__currentElement;
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
		/// Void ThrowEnumerationNotStartedOrEnded()
		/// </summary>
		protected RMethod r_RThrowEnumerationNotStartedOrEnded;
		public virtual RMethod RThrowEnumerationNotStartedOrEnded
		{
			get
			{
				if(r_RThrowEnumerationNotStartedOrEnded == null)
				{
					r_RThrowEnumerationNotStartedOrEnded = new(this, "ThrowEnumerationNotStartedOrEnded", 0);
					r_RThrowEnumerationNotStartedOrEnded.SetBelong(this.instance);
				}
				return r_RThrowEnumerationNotStartedOrEnded;
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


        public REnumerator() : base("System.Collections.Generic.Queue`1+Enumerator")
        {
        }

        public REnumerator(System.Object instance) : base("System.Collections.Generic.Queue`1+Enumerator")
		{
            SetInstance(instance);
		}

        public REnumerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REnumerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ThrowEnumerationNotStartedOrEnded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowEnumerationNotStartedOrEnded.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Collections__0__IEnumerator__0__Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__Collections__0__IEnumerator__0__Reset.Invoke(___genericsType, ___parameters);

            
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