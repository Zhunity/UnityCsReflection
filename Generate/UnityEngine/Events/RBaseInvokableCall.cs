using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.REvents
{
	/// <summary>
	/// UnityEngine.Events.BaseInvokableCall
	/// </summary>
    public partial class RBaseInvokableCall : RMember //
    {

		/// <summary>
		/// Void Invoke(System.Object[])
		/// </summary>
		protected RMethod r_RInvoke_ObjectArray;
		public virtual RMethod RInvoke_ObjectArray
		{
			get
			{
				if(r_RInvoke_ObjectArray == null)
				{
					r_RInvoke_ObjectArray = new(this, "Invoke", 0, typeof(System.Object).MakeArrayType());
					r_RInvoke_ObjectArray.SetBelong(this.instance);
				}
				return r_RInvoke_ObjectArray;
			}
		}

		/// <summary>
		/// Void ThrowOnInvalidArg[T](System.Object)
		/// </summary>
		protected static RMethod r_RThrowOnInvalidArg_GT_Object;
		public static RMethod RThrowOnInvalidArg_GT_Object
		{
			get
			{
				if(r_RThrowOnInvalidArg_GT_Object == null)
				{
					r_RThrowOnInvalidArg_GT_Object = new( ReleactionUtils.GetType("UnityEngine.Events.BaseInvokableCall"), "ThrowOnInvalidArg", 1, typeof(System.Object));
					r_RThrowOnInvalidArg_GT_Object.SetBelong(null);
				}
				return r_RThrowOnInvalidArg_GT_Object;
			}
		}

		/// <summary>
		/// Boolean AllowInvoke(System.Delegate)
		/// </summary>
		protected static RMethod r_RAllowInvoke_Delegate;
		public static RMethod RAllowInvoke_Delegate
		{
			get
			{
				if(r_RAllowInvoke_Delegate == null)
				{
					r_RAllowInvoke_Delegate = new( ReleactionUtils.GetType("UnityEngine.Events.BaseInvokableCall"), "AllowInvoke", 0, typeof(System.Delegate));
					r_RAllowInvoke_Delegate.SetBelong(null);
				}
				return r_RAllowInvoke_Delegate;
			}
		}

		/// <summary>
		/// Boolean Find(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RFind_Object_MethodInfo;
		public virtual RMethod RFind_Object_MethodInfo
		{
			get
			{
				if(r_RFind_Object_MethodInfo == null)
				{
					r_RFind_Object_MethodInfo = new(this, "Find", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_RFind_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_RFind_Object_MethodInfo;
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


        public RBaseInvokableCall() : base("UnityEngine.Events.BaseInvokableCall")
        {
        }

        public RBaseInvokableCall(System.Object instance) : base("UnityEngine.Events.BaseInvokableCall")
		{
            SetInstance(instance);
		}

        public RBaseInvokableCall(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBaseInvokableCall(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Invoke(System.Object[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RInvoke_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void ThrowOnInvalidArg<T>(System.Object  @arg)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@arg};
            var ___result = RThrowOnInvalidArg_GT_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean AllowInvoke(System.Delegate  @delegate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delegate};
            var ___result = RAllowInvoke_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Find(System.Object  @targetObj, System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObj, @method};
            var ___result = RFind_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
