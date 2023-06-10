
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.BasicNode`1
	/// </summary>
    public partial class RBasicNode<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BasicNode`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public RBasicNode() : base("UnityEngine.UIElements.UIR.BasicNode`1")
        {
        }

        public RBasicNode(System.Object instance) : base("UnityEngine.UIElements.UIR.BasicNode`1")
		{
            SetInstance(instance);
		}

        public RBasicNode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBasicNode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.UIR.BasicNode`1[T] next
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBasicNode<Hvak.Editor.Refleaction.RField> r_Fnext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBasicNode<Hvak.Editor.Refleaction.RField> RFnext
		{
			get
			{
				if(r_Fnext == null)
				{
					r_Fnext = new(this, "next");
				}
				return r_Fnext;
			}
		}

		/// <summary>
		/// T data
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fdata;
		public virtual Hvak.Editor.Refleaction.RField RFdata
		{
			get
			{
				if(r_Fdata == null)
				{
					r_Fdata = new(this, "data");
				}
				return r_Fdata;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BasicNode`1[T] poolNext
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBasicNode<Hvak.Editor.Refleaction.RField> r_FpoolNext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBasicNode<Hvak.Editor.Refleaction.RField> RFpoolNext
		{
			get
			{
				if(r_FpoolNext == null)
				{
					r_FpoolNext = new(this, "poolNext");
				}
				return r_FpoolNext;
			}
		}

		/// <summary>
		/// Void AppendTo(UnityEngine.UIElements.UIR.BasicNode`1[T] ByRef)
		/// </summary>
		protected RMethod r_MAppendTo_Ref_BasicNode_d_T_p_;
		public virtual RMethod RMAppendTo_Ref_BasicNode_d_T_p_
		{
			get
			{
				if(r_MAppendTo_Ref_BasicNode_d_T_p_ == null)
				{
					r_MAppendTo_Ref_BasicNode_d_T_p_ = new(this, "AppendTo", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BasicNode`1").MakeByRefType());
				}
				return r_MAppendTo_Ref_BasicNode_d_T_p_;
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


        public virtual void AppendTo(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBasicNode<Hvak.Editor.Refleaction.RType> @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@first.Value};
            var ___result = RMAppendTo_Ref_BasicNode_d_T_p_.Invoke(___genericsType, ___parameters);
			@first = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBasicNode<Hvak.Editor.Refleaction.RType>(___parameters[0]);

            
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
