
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.REvents
{
	/// <summary>
	/// UnityEngine.Events.BaseInvokableCall
	/// </summary>
    public partial class RBaseInvokableCall : RMember //
    {

		/// <summary>
		/// Void Invoke(System.Object[])
		/// </summary>
		protected RMethod r_MInvoke_ObjectArray;
		public virtual RMethod RMInvoke_ObjectArray
		{
			get
			{
				if(r_MInvoke_ObjectArray == null)
				{
					r_MInvoke_ObjectArray = new(this, "Invoke", 0, typeof(System.Object).MakeArrayType());
				}
				return r_MInvoke_ObjectArray;
			}
		}

		/// <summary>
		/// Void ThrowOnInvalidArg[T](System.Object)
		/// </summary>
		protected static RMethod r_MThrowOnInvalidArg_GT_Object;
		public static RMethod RMThrowOnInvalidArg_GT_Object
		{
			get
			{
				if(r_MThrowOnInvalidArg_GT_Object == null)
				{
					r_MThrowOnInvalidArg_GT_Object = new( ReflectionUtils.GetType("UnityEngine.Events.BaseInvokableCall"), "ThrowOnInvalidArg", 1, typeof(System.Object));
				}
				return r_MThrowOnInvalidArg_GT_Object;
			}
		}

		/// <summary>
		/// Boolean AllowInvoke(System.Delegate)
		/// </summary>
		protected static RMethod r_MAllowInvoke_Delegate;
		public static RMethod RMAllowInvoke_Delegate
		{
			get
			{
				if(r_MAllowInvoke_Delegate == null)
				{
					r_MAllowInvoke_Delegate = new( ReflectionUtils.GetType("UnityEngine.Events.BaseInvokableCall"), "AllowInvoke", 0, typeof(System.Delegate));
				}
				return r_MAllowInvoke_Delegate;
			}
		}

		/// <summary>
		/// Boolean Find(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MFind_Object_MethodInfo;
		public virtual RMethod RMFind_Object_MethodInfo
		{
			get
			{
				if(r_MFind_Object_MethodInfo == null)
				{
					r_MFind_Object_MethodInfo = new(this, "Find", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
				}
				return r_MFind_Object_MethodInfo;
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

        public virtual void Invoke(System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMInvoke_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void ThrowOnInvalidArg<T>(System.Object @arg)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@arg};
            var ___result = RMThrowOnInvalidArg_GT_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean AllowInvoke(System.Delegate @delegate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delegate};
            var ___result = RMAllowInvoke_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Find(System.Object @targetObj, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObj, @method};
            var ___result = RMFind_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
