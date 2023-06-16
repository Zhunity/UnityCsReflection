
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Threading.Tasks.StackGuard
	/// </summary>
    public partial class RStackGuard : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Threading.Tasks.StackGuard");
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


		/// <summary>
		/// System.Int32 m_inliningDepth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_inliningDepth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_inliningDepth
		{
			get
			{
				if(r_Fm_inliningDepth == null)
				{
					r_Fm_inliningDepth = new(this, "m_inliningDepth");
				}
				return r_Fm_inliningDepth;
			}
		}

		/// <summary>
		/// System.Int32 MAX_UNCHECKED_INLINING_DEPTH
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMAX_UNCHECKED_INLINING_DEPTH;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMAX_UNCHECKED_INLINING_DEPTH
		{
			get
			{
				if(r_FMAX_UNCHECKED_INLINING_DEPTH == null)
				{
					r_FMAX_UNCHECKED_INLINING_DEPTH = new(Type, "MAX_UNCHECKED_INLINING_DEPTH");
				}
				return r_FMAX_UNCHECKED_INLINING_DEPTH;
			}
		}

		/// <summary>
		/// Boolean TryBeginInliningScope()
		/// </summary>
		protected RMethod r_MTryBeginInliningScope;
		public virtual RMethod RMTryBeginInliningScope
		{
			get
			{
				if(r_MTryBeginInliningScope == null)
				{
					r_MTryBeginInliningScope = new(this, "TryBeginInliningScope", 0);
				}
				return r_MTryBeginInliningScope;
			}
		}

		/// <summary>
		/// Void EndInliningScope()
		/// </summary>
		protected RMethod r_MEndInliningScope;
		public virtual RMethod RMEndInliningScope
		{
			get
			{
				if(r_MEndInliningScope == null)
				{
					r_MEndInliningScope = new(this, "EndInliningScope", 0);
				}
				return r_MEndInliningScope;
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


        public virtual System.Boolean TryBeginInliningScope()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTryBeginInliningScope.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void EndInliningScope()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEndInliningScope.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
