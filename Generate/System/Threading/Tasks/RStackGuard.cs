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
		protected RField r_m_inliningDepth;
		public virtual RField Rm_inliningDepth
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
		protected static RField r_MAX_UNCHECKED_INLINING_DEPTH;
		public static RField RMAX_UNCHECKED_INLINING_DEPTH
		{
			get
			{
				if(r_MAX_UNCHECKED_INLINING_DEPTH == null)
				{
					r_MAX_UNCHECKED_INLINING_DEPTH = new( ReleactionUtils.GetType("System.Threading.Tasks.StackGuard"), "MAX_UNCHECKED_INLINING_DEPTH");
					r_MAX_UNCHECKED_INLINING_DEPTH.SetBelong(null);
				}
				return r_MAX_UNCHECKED_INLINING_DEPTH;
			}
		}

		/// <summary>
		/// Boolean TryBeginInliningScope()
		/// </summary>
		protected RMethod r_RTryBeginInliningScope;
		public virtual RMethod RTryBeginInliningScope
		{
			get
			{
				if(r_RTryBeginInliningScope == null)
				{
					r_RTryBeginInliningScope = new(this, "TryBeginInliningScope", 0);
					r_RTryBeginInliningScope.SetBelong(this.instance);
				}
				return r_RTryBeginInliningScope;
			}
		}

		/// <summary>
		/// Void EndInliningScope()
		/// </summary>
		protected RMethod r_REndInliningScope;
		public virtual RMethod REndInliningScope
		{
			get
			{
				if(r_REndInliningScope == null)
				{
					r_REndInliningScope = new(this, "EndInliningScope", 0);
					r_REndInliningScope.SetBelong(this.instance);
				}
				return r_REndInliningScope;
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


        public virtual System.Boolean Equals(System.Object  @obj)
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
