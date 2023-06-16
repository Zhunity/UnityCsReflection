
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.StyleDataRef`1
	/// </summary>
    public partial class RStyleDataRef<T> : RMember // where T : struct
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public RStyleDataRef() : base("UnityEngine.UIElements.StyleDataRef`1")
        {
        }

        public RStyleDataRef(System.Object instance) : base("UnityEngine.UIElements.StyleDataRef`1")
		{
            SetInstance(instance);
		}

        public RStyleDataRef(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleDataRef(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1+RefCounted[T] m_Ref
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RField>.RRefCounted r_Fm_Ref;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RField>.RRefCounted RFm_Ref
		{
			get
			{
				if(r_Fm_Ref == null)
				{
					r_Fm_Ref = new(this, "m_Ref");
				}
				return r_Fm_Ref;
			}
		}

		/// <summary>
		/// Int32 refCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PrefCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPrefCount
		{
			get
			{
				if(r_PrefCount == null)
				{
					r_PrefCount = new(this, "refCount", -1);
				}
				return r_PrefCount;
			}
		}

		/// <summary>
		/// UInt32 id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Pid;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[T] Acquire()
		/// </summary>
		protected RMethod r_MAcquire;
		public virtual RMethod RMAcquire
		{
			get
			{
				if(r_MAcquire == null)
				{
					r_MAcquire = new(this, "Acquire", 0);
				}
				return r_MAcquire;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_MRelease;
		public virtual RMethod RMRelease
		{
			get
			{
				if(r_MRelease == null)
				{
					r_MRelease = new(this, "Release", 0);
				}
				return r_MRelease;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.UIElements.StyleDataRef`1[T])
		/// </summary>
		protected RMethod r_MCopyFrom_StyleDataRef_d_T_p_;
		public virtual RMethod RMCopyFrom_StyleDataRef_d_T_p_
		{
			get
			{
				if(r_MCopyFrom_StyleDataRef_d_T_p_ == null)
				{
					r_MCopyFrom_StyleDataRef_d_T_p_ = new(this, "CopyFrom", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"));
				}
				return r_MCopyFrom_StyleDataRef_d_T_p_;
			}
		}

		/// <summary>
		/// T& Read()
		/// </summary>
		protected RMethod r_MRead;
		public virtual RMethod RMRead
		{
			get
			{
				if(r_MRead == null)
				{
					r_MRead = new(this, "Read", 0);
				}
				return r_MRead;
			}
		}

		/// <summary>
		/// T& Write()
		/// </summary>
		protected RMethod r_MWrite;
		public virtual RMethod RMWrite
		{
			get
			{
				if(r_MWrite == null)
				{
					r_MWrite = new(this, "Write", 0);
				}
				return r_MWrite;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[T] Create()
		/// </summary>
		protected static RMethod r_MCreate;
		public static RMethod RMCreate
		{
			get
			{
				if(r_MCreate == null)
				{
					r_MCreate = new(Type, "Create", 0);
				}
				return r_MCreate;
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
		/// Boolean op_Equality(UnityEngine.UIElements.StyleDataRef`1[T], UnityEngine.UIElements.StyleDataRef`1[T])
		/// </summary>
		protected static RMethod r_Mop_Equality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_;
		public static RMethod RMop_Equality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_
		{
			get
			{
				if(r_Mop_Equality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_ == null)
				{
					r_Mop_Equality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_ = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"));
				}
				return r_Mop_Equality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleDataRef`1[T], UnityEngine.UIElements.StyleDataRef`1[T])
		/// </summary>
		protected static RMethod r_Mop_Inequality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_;
		public static RMethod RMop_Inequality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_
		{
			get
			{
				if(r_Mop_Inequality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_ == null)
				{
					r_Mop_Inequality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_ = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"));
				}
				return r_Mop_Inequality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleDataRef`1[T])
		/// </summary>
		protected RMethod r_MEquals_StyleDataRef_d_T_p_;
		public virtual RMethod RMEquals_StyleDataRef_d_T_p_
		{
			get
			{
				if(r_MEquals_StyleDataRef_d_T_p_ == null)
				{
					r_MEquals_StyleDataRef_d_T_p_ = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"));
				}
				return r_MEquals_StyleDataRef_d_T_p_;
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
		/// Boolean ReferenceEquals(UnityEngine.UIElements.StyleDataRef`1[T])
		/// </summary>
		protected RMethod r_MReferenceEquals_StyleDataRef_d_T_p_;
		public virtual RMethod RMReferenceEquals_StyleDataRef_d_T_p_
		{
			get
			{
				if(r_MReferenceEquals_StyleDataRef_d_T_p_ == null)
				{
					r_MReferenceEquals_StyleDataRef_d_T_p_ = new(this, "ReferenceEquals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"));
				}
				return r_MReferenceEquals_StyleDataRef_d_T_p_;
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


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType> Acquire()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAcquire.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType>>(___result);
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCopyFrom_StyleDataRef_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RType Read()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRead.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RType Write()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWrite.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RType>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType> Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType>>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType> @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType> @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType> @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType> @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_StyleDataRef_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean ReferenceEquals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMReferenceEquals_StyleDataRef_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
