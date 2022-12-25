using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.BasicNodePool`1
	/// </summary>
    public partial class RBasicNodePool<T> : RMember //
    {

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// Void Reset(UnityEngine.UIElements.UIR.BasicNode`1[T])
		/// </summary>
		protected static RMethod r_RReset_BasicNode_d_T_p_;
		public static RMethod RReset_BasicNode_d_T_p_
		{
			get
			{
				if(r_RReset_BasicNode_d_T_p_ == null)
				{
					r_RReset_BasicNode_d_T_p_ = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BasicNodePool`1"), "Reset", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BasicNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RReset_BasicNode_d_T_p_.SetBelong(null);
				}
				return r_RReset_BasicNode_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BasicNode`1[T] Create()
		/// </summary>
		protected static RMethod r_RCreate;
		public static RMethod RCreate
		{
			get
			{
				if(r_RCreate == null)
				{
					r_RCreate = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BasicNodePool`1"), "Create", 0);
					r_RCreate.SetBelong(null);
				}
				return r_RCreate;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BasicNode`1[T] Get()
		/// </summary>
		protected RMethod r_RGet;
		public virtual RMethod RGet
		{
			get
			{
				if(r_RGet == null)
				{
					r_RGet = new(this, "Get", 0);
					r_RGet.SetBelong(this.instance);
				}
				return r_RGet;
			}
		}

		/// <summary>
		/// Void Return(UnityEngine.UIElements.UIR.BasicNode`1[T])
		/// </summary>
		protected RMethod r_RReturn_BasicNode_d_T_p_;
		public virtual RMethod RReturn_BasicNode_d_T_p_
		{
			get
			{
				if(r_RReturn_BasicNode_d_T_p_ == null)
				{
					r_RReturn_BasicNode_d_T_p_ = new(this, "Return", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BasicNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RReturn_BasicNode_d_T_p_.SetBelong(this.instance);
				}
				return r_RReturn_BasicNode_d_T_p_;
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


        public RBasicNodePool() : base("UnityEngine.UIElements.UIR.BasicNodePool`1")
        {
        }

        public RBasicNodePool(System.Object instance) : base("UnityEngine.UIElements.UIR.BasicNodePool`1")
		{
            SetInstance(instance);
		}

        public RBasicNodePool(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBasicNodePool(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public static System.Object Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreate.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Get()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGet.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
