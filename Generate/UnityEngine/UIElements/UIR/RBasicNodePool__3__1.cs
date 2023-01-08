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
		protected static RMethod r_Reset_BasicNode_d_T_p_;
		public static RMethod RReset_BasicNode_d_T_p_
		{
			get
			{
				if(r_Reset_BasicNode_d_T_p_ == null)
				{
					r_Reset_BasicNode_d_T_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BasicNodePool`1"), "Reset", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BasicNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Reset_BasicNode_d_T_p_.SetBelong(null);
				}
				return r_Reset_BasicNode_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BasicNode`1[T] Create()
		/// </summary>
		protected static RMethod r_Create;
		public static RMethod RCreate
		{
			get
			{
				if(r_Create == null)
				{
					r_Create = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BasicNodePool`1"), "Create", 0);
					r_Create.SetBelong(null);
				}
				return r_Create;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BasicNode`1[T] Get()
		/// </summary>
		protected RMethod r_Get;
		public virtual RMethod RGet
		{
			get
			{
				if(r_Get == null)
				{
					r_Get = new(this, "Get", 0);
					r_Get.SetBelong(this.instance);
				}
				return r_Get;
			}
		}

		/// <summary>
		/// Void Return(UnityEngine.UIElements.UIR.BasicNode`1[T])
		/// </summary>
		protected RMethod r_Return_BasicNode_d_T_p_;
		public virtual RMethod RReturn_BasicNode_d_T_p_
		{
			get
			{
				if(r_Return_BasicNode_d_T_p_ == null)
				{
					r_Return_BasicNode_d_T_p_ = new(this, "Return", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BasicNode`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_Return_BasicNode_d_T_p_.SetBelong(this.instance);
				}
				return r_Return_BasicNode_d_T_p_;
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

        public static void Reset(RUnityEngine.RUIElements.RUIR.RBasicNode<RType>  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value};
            var ___result = RReset_BasicNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
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


        public virtual void Return(RUnityEngine.RUIElements.RUIR.RBasicNode<RType>  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RReturn_BasicNode_d_T_p_.Invoke(___genericsType, ___parameters);

            
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
