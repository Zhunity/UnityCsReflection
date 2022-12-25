using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{public partial class RBoundsInt
{
	
	/// <summary>
	/// UnityEngine.BoundsInt+PositionEnumerator
	/// </summary>
    public partial class RPositionEnumerator : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3Int _min
		/// </summary>
		protected RUnityEngine.RVector3Int r__min;
		public virtual RUnityEngine.RVector3Int R_min
		{
			get
			{
				if(r__min == null)
				{
					r__min = new(this, "_min");
					r__min.SetBelong(this.instance);
				}
				return r__min;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int _max
		/// </summary>
		protected RUnityEngine.RVector3Int r__max;
		public virtual RUnityEngine.RVector3Int R_max
		{
			get
			{
				if(r__max == null)
				{
					r__max = new(this, "_max");
					r__max.SetBelong(this.instance);
				}
				return r__max;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int _current
		/// </summary>
		protected RUnityEngine.RVector3Int r__current;
		public virtual RUnityEngine.RVector3Int R_current
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
		/// UnityEngine.Vector3Int Current
		/// </summary>
		protected RUnityEngine.RVector3Int r_Current;
		public virtual RUnityEngine.RVector3Int RCurrent
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
		/// PositionEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
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
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Void System.IDisposable.Dispose()
		/// </summary>
		protected RMethod r_RSystem__0__IDisposable__0__Dispose;
		public virtual RMethod RSystem__0__IDisposable__0__Dispose
		{
			get
			{
				if(r_RSystem__0__IDisposable__0__Dispose == null)
				{
					r_RSystem__0__IDisposable__0__Dispose = new(this, "System.IDisposable.Dispose", 0);
					r_RSystem__0__IDisposable__0__Dispose.SetBelong(this.instance);
				}
				return r_RSystem__0__IDisposable__0__Dispose;
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


        public RPositionEnumerator() : base("UnityEngine.BoundsInt+PositionEnumerator")
        {
        }

        public RPositionEnumerator(System.Object instance) : base("UnityEngine.BoundsInt+PositionEnumerator")
		{
            SetInstance(instance);
		}

        public RPositionEnumerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPositionEnumerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual void System__0__IDisposable__0__Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__0__IDisposable__0__Dispose.Invoke(___genericsType, ___parameters);

            
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