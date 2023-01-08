using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleDataRef`1
	/// </summary>
    public partial class RStyleDataRef<T> : RMember // where T : struct, System.IEquatable<T>
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1+RefCounted[T] m_Ref
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleDataRef<RField>.RRefCounted r_m_Ref;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RField>.RRefCounted Rm_Ref
		{
			get
			{
				if(r_m_Ref == null)
				{
					r_m_Ref = new(this, "m_Ref");
					r_m_Ref.SetBelong(this.instance);
				}
				return r_m_Ref;
			}
		}

		/// <summary>
		/// Int32 refCount
		/// </summary>
		protected RProperty r_refCount;
		public virtual RProperty RrefCount
		{
			get
			{
				if(r_refCount == null)
				{
					r_refCount = new(this, "refCount", -1);
					r_refCount.SetBelong(this.instance);
				}
				return r_refCount;
			}
		}

		/// <summary>
		/// UInt32 id
		/// </summary>
		protected RProperty r_id;
		public virtual RProperty Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id", -1);
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[T] Acquire()
		/// </summary>
		protected RMethod r_Acquire;
		public virtual RMethod RAcquire
		{
			get
			{
				if(r_Acquire == null)
				{
					r_Acquire = new(this, "Acquire", 0);
					r_Acquire.SetBelong(this.instance);
				}
				return r_Acquire;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_Release;
		public virtual RMethod RRelease
		{
			get
			{
				if(r_Release == null)
				{
					r_Release = new(this, "Release", 0);
					r_Release.SetBelong(this.instance);
				}
				return r_Release;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.UIElements.StyleDataRef`1[T])
		/// </summary>
		protected RMethod r_CopyFrom_StyleDataRef_d_T_p_;
		public virtual RMethod RCopyFrom_StyleDataRef_d_T_p_
		{
			get
			{
				if(r_CopyFrom_StyleDataRef_d_T_p_ == null)
				{
					r_CopyFrom_StyleDataRef_d_T_p_ = new(this, "CopyFrom", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"));
					r_CopyFrom_StyleDataRef_d_T_p_.SetBelong(this.instance);
				}
				return r_CopyFrom_StyleDataRef_d_T_p_;
			}
		}

		/// <summary>
		/// T& Read()
		/// </summary>
		protected RMethod r_Read;
		public virtual RMethod RRead
		{
			get
			{
				if(r_Read == null)
				{
					r_Read = new(this, "Read", 0);
					r_Read.SetBelong(this.instance);
				}
				return r_Read;
			}
		}

		/// <summary>
		/// T& Write()
		/// </summary>
		protected RMethod r_Write;
		public virtual RMethod RWrite
		{
			get
			{
				if(r_Write == null)
				{
					r_Write = new(this, "Write", 0);
					r_Write.SetBelong(this.instance);
				}
				return r_Write;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[T] Create()
		/// </summary>
		protected static RMethod r_Create;
		public static RMethod RCreate
		{
			get
			{
				if(r_Create == null)
				{
					r_Create = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"), "Create", 0);
					r_Create.SetBelong(null);
				}
				return r_Create;
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
		/// Boolean op_Equality(UnityEngine.UIElements.StyleDataRef`1[T], UnityEngine.UIElements.StyleDataRef`1[T])
		/// </summary>
		protected static RMethod r_op_Equality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_;
		public static RMethod Rop_Equality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_
		{
			get
			{
				if(r_op_Equality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_ == null)
				{
					r_op_Equality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_ = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"));
					r_op_Equality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_.SetBelong(null);
				}
				return r_op_Equality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleDataRef`1[T], UnityEngine.UIElements.StyleDataRef`1[T])
		/// </summary>
		protected static RMethod r_op_Inequality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_;
		public static RMethod Rop_Inequality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_
		{
			get
			{
				if(r_op_Inequality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_ == null)
				{
					r_op_Inequality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_ = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"));
					r_op_Inequality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_.SetBelong(null);
				}
				return r_op_Inequality_StyleDataRef_d_T_p__StyleDataRef_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleDataRef`1[T])
		/// </summary>
		protected RMethod r_Equals_StyleDataRef_d_T_p_;
		public virtual RMethod REquals_StyleDataRef_d_T_p_
		{
			get
			{
				if(r_Equals_StyleDataRef_d_T_p_ == null)
				{
					r_Equals_StyleDataRef_d_T_p_ = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"));
					r_Equals_StyleDataRef_d_T_p_.SetBelong(this.instance);
				}
				return r_Equals_StyleDataRef_d_T_p_;
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
		/// Boolean ReferenceEquals(UnityEngine.UIElements.StyleDataRef`1[T])
		/// </summary>
		protected RMethod r_ReferenceEquals_StyleDataRef_d_T_p_;
		public virtual RMethod RReferenceEquals_StyleDataRef_d_T_p_
		{
			get
			{
				if(r_ReferenceEquals_StyleDataRef_d_T_p_ == null)
				{
					r_ReferenceEquals_StyleDataRef_d_T_p_ = new(this, "ReferenceEquals", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1"));
					r_ReferenceEquals_StyleDataRef_d_T_p_.SetBelong(this.instance);
				}
				return r_ReferenceEquals_StyleDataRef_d_T_p_;
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

        public virtual System.Object Acquire()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAcquire.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRelease.Invoke(___genericsType, ___parameters);

            
        }



        public virtual T Read()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRead.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T Write()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWrite.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static System.Object Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreate.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }





        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
