using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.StackGuard
	/// </summary>
    public partial class RStackGuard : RMember //
    {

		/// <summary>
		/// System.Int32 m_inliningDepth
		/// </summary>
		protected RSystem.RInt32 r_m_inliningDepth;
		public virtual RSystem.RInt32 Rm_inliningDepth
		{
			get
			{
				if(r_m_inliningDepth == null)
				{
					r_m_inliningDepth = new(this, "m_inliningDepth");
					r_m_inliningDepth.SetBelong(this.instance);
				}
				return r_m_inliningDepth;
			}
		}

		/// <summary>
		/// System.Int32 MAX_UNCHECKED_INLINING_DEPTH
		/// </summary>
		protected static RSystem.RInt32 r_MAX_UNCHECKED_INLINING_DEPTH;
		public static RSystem.RInt32 RMAX_UNCHECKED_INLINING_DEPTH
		{
			get
			{
				if(r_MAX_UNCHECKED_INLINING_DEPTH == null)
				{
					r_MAX_UNCHECKED_INLINING_DEPTH = new( ReflectionUtils.GetType("System.Threading.Tasks.StackGuard"), "MAX_UNCHECKED_INLINING_DEPTH");
					r_MAX_UNCHECKED_INLINING_DEPTH.SetBelong(null);
				}
				return r_MAX_UNCHECKED_INLINING_DEPTH;
			}
		}

		/// <summary>
		/// Boolean TryBeginInliningScope()
		/// </summary>
		protected RMethod r_TryBeginInliningScope;
		public virtual RMethod RTryBeginInliningScope
		{
			get
			{
				if(r_TryBeginInliningScope == null)
				{
					r_TryBeginInliningScope = new(this, "TryBeginInliningScope", 0);
					r_TryBeginInliningScope.SetBelong(this.instance);
				}
				return r_TryBeginInliningScope;
			}
		}

		/// <summary>
		/// Void EndInliningScope()
		/// </summary>
		protected RMethod r_EndInliningScope;
		public virtual RMethod REndInliningScope
		{
			get
			{
				if(r_EndInliningScope == null)
				{
					r_EndInliningScope = new(this, "EndInliningScope", 0);
					r_EndInliningScope.SetBelong(this.instance);
				}
				return r_EndInliningScope;
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


        public RStackGuard() : base("System.Threading.Tasks.StackGuard")
        {
        }

        public RStackGuard(System.Object instance) : base("System.Threading.Tasks.StackGuard")
		{
            SetInstance(instance);
		}

        public RStackGuard(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStackGuard(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean TryBeginInliningScope()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTryBeginInliningScope.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void EndInliningScope()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndInliningScope.Invoke(___genericsType, ___parameters);

            
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
