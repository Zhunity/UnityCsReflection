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
		protected RSystem.RInt32 r_PCount;
		public virtual RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
					r_PCount.SetBelong(this.instance);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Void Reset(UnityEngine.UIElements.UIR.BasicNode`1[T])
		/// </summary>
		protected static RMethod r_MReset_BasicNode_d_T_p_;
		public static RMethod RMReset_BasicNode_d_T_p_
		{
			get
			{
				if(r_MReset_BasicNode_d_T_p_ == null)
				{
					r_MReset_BasicNode_d_T_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BasicNodePool`1"), "Reset", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BasicNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MReset_BasicNode_d_T_p_.SetBelong(null);
				}
				return r_MReset_BasicNode_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BasicNode`1[T] Create()
		/// </summary>
		protected static RMethod r_MCreate;
		public static RMethod RMCreate
		{
			get
			{
				if(r_MCreate == null)
				{
					r_MCreate = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BasicNodePool`1"), "Create", 0);
					r_MCreate.SetBelong(null);
				}
				return r_MCreate;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
					r_MClear.SetBelong(this.instance);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BasicNode`1[T] Get()
		/// </summary>
		protected RMethod r_MGet;
		public virtual RMethod RMGet
		{
			get
			{
				if(r_MGet == null)
				{
					r_MGet = new(this, "Get", 0);
					r_MGet.SetBelong(this.instance);
				}
				return r_MGet;
			}
		}

		/// <summary>
		/// Void Return(UnityEngine.UIElements.UIR.BasicNode`1[T])
		/// </summary>
		protected RMethod r_MReturn_BasicNode_d_T_p_;
		public virtual RMethod RMReturn_BasicNode_d_T_p_
		{
			get
			{
				if(r_MReturn_BasicNode_d_T_p_ == null)
				{
					r_MReturn_BasicNode_d_T_p_ = new(this, "Return", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BasicNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MReturn_BasicNode_d_T_p_.SetBelong(this.instance);
				}
				return r_MReturn_BasicNode_d_T_p_;
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

        public static void Reset(RUnityEngine.RUIElements.RUIR.RBasicNode<RType> @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value};
            var ___result = RMReset_BasicNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static RUnityEngine.RUIElements.RUIR.RBasicNode<RType> Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreate.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RBasicNode<RType>(___result);
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RUIR.RBasicNode<RType> Get()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGet.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RBasicNode<RType>(___result);
        }


        public virtual void Return(RUnityEngine.RUIElements.RUIR.RBasicNode<RType> @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RMReturn_BasicNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
