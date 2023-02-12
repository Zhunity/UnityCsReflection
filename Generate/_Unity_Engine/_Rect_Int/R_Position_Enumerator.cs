
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{public partial class RRectInt
{
	
	/// <summary>
	/// UnityEngine.RectInt+PositionEnumerator
	/// </summary>
    public partial class RPositionEnumerator : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector2Int _min
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_F_min;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RF_min
		{
			get
			{
				if(r_F_min == null)
				{
					r_F_min = new(this, "_min");
					r_F_min.SetBelong(this.instance);
				}
				return r_F_min;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int _max
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_F_max;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RF_max
		{
			get
			{
				if(r_F_max == null)
				{
					r_F_max = new(this, "_max");
					r_F_max.SetBelong(this.instance);
				}
				return r_F_max;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int _current
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_F_current;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RF_current
		{
			get
			{
				if(r_F_current == null)
				{
					r_F_current = new(this, "_current");
					r_F_current.SetBelong(this.instance);
				}
				return r_F_current;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int Current
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_PCurrent;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RPCurrent
		{
			get
			{
				if(r_PCurrent == null)
				{
					r_PCurrent = new(this, "Current", -1);
					r_PCurrent.SetBelong(this.instance);
				}
				return r_PCurrent;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IEnumerator.Current
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PSystem__2__Collections__2__IEnumerator__2__Current;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPSystem__2__Collections__2__IEnumerator__2__Current
		{
			get
			{
				if(r_PSystem__2__Collections__2__IEnumerator__2__Current == null)
				{
					r_PSystem__2__Collections__2__IEnumerator__2__Current = new(this, "System.Collections.IEnumerator.Current", -1);
					r_PSystem__2__Collections__2__IEnumerator__2__Current.SetBelong(this.instance);
				}
				return r_PSystem__2__Collections__2__IEnumerator__2__Current;
			}
		}

		/// <summary>
		/// PositionEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
					r_MGetEnumerator.SetBelong(this.instance);
				}
				return r_MGetEnumerator;
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
					r_MMoveNext.SetBelong(this.instance);
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
					r_MReset.SetBelong(this.instance);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// Void System.IDisposable.Dispose()
		/// </summary>
		protected RMethod r_MSystem__2__IDisposable__2__Dispose;
		public virtual RMethod RMSystem__2__IDisposable__2__Dispose
		{
			get
			{
				if(r_MSystem__2__IDisposable__2__Dispose == null)
				{
					r_MSystem__2__IDisposable__2__Dispose = new(this, "System.IDisposable.Dispose", 0);
					r_MSystem__2__IDisposable__2__Dispose.SetBelong(this.instance);
				}
				return r_MSystem__2__IDisposable__2__Dispose;
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


        public RPositionEnumerator() : base("UnityEngine.RectInt+PositionEnumerator")
        {
        }

        public RPositionEnumerator(System.Object instance) : base("UnityEngine.RectInt+PositionEnumerator")
		{
            SetInstance(instance);
		}

        public RPositionEnumerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPositionEnumerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRectInt.RPositionEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEngine.RRectInt.RPositionEnumerator(___result);
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


        public virtual void System__2__IDisposable__2__Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__IDisposable__2__Dispose.Invoke(___genericsType, ___parameters);

            
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