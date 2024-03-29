
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Threading.CancellationTokenRegistration
	/// </summary>
    public partial class RCancellationTokenRegistration : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Threading.CancellationTokenRegistration);
            }
        }

        public RCancellationTokenRegistration() : base("System.Threading.CancellationTokenRegistration")
        {
        }

        public RCancellationTokenRegistration(System.Object instance) : base("System.Threading.CancellationTokenRegistration")
		{
            SetInstance(instance);
		}

        public RCancellationTokenRegistration(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCancellationTokenRegistration(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Threading.CancellationCallbackInfo m_callbackInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationCallbackInfo r_Fm_callbackInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationCallbackInfo RFm_callbackInfo
		{
			get
			{
				if(r_Fm_callbackInfo == null)
				{
					r_Fm_callbackInfo = new(this, "m_callbackInfo");
				}
				return r_Fm_callbackInfo;
			}
		}

		/// <summary>
		/// System.Threading.SparselyPopulatedArrayAddInfo`1[System.Threading.CancellationCallbackInfo] m_registrationInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayAddInfo<Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationCallbackInfo> r_Fm_registrationInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSparselyPopulatedArrayAddInfo<Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationCallbackInfo> RFm_registrationInfo
		{
			get
			{
				if(r_Fm_registrationInfo == null)
				{
					r_Fm_registrationInfo = new(this, "m_registrationInfo");
				}
				return r_Fm_registrationInfo;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken Token
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationToken r_PToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RCancellationToken RPToken
		{
			get
			{
				if(r_PToken == null)
				{
					r_PToken = new(this, "Token", -1);
				}
				return r_PToken;
			}
		}

		/// <summary>
		/// Boolean Unregister()
		/// </summary>
		protected RMethod r_MUnregister;
		public virtual RMethod RMUnregister
		{
			get
			{
				if(r_MUnregister == null)
				{
					r_MUnregister = new(this, "Unregister", 0);
				}
				return r_MUnregister;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Threading.CancellationTokenRegistration, System.Threading.CancellationTokenRegistration)
		/// </summary>
		protected static RMethod r_Mop_Equality_CancellationTokenRegistration_CancellationTokenRegistration;
		public static RMethod RMop_Equality_CancellationTokenRegistration_CancellationTokenRegistration
		{
			get
			{
				if(r_Mop_Equality_CancellationTokenRegistration_CancellationTokenRegistration == null)
				{
					r_Mop_Equality_CancellationTokenRegistration_CancellationTokenRegistration = new(Type, "op_Equality", 0, typeof(System.Threading.CancellationTokenRegistration), typeof(System.Threading.CancellationTokenRegistration));
				}
				return r_Mop_Equality_CancellationTokenRegistration_CancellationTokenRegistration;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Threading.CancellationTokenRegistration, System.Threading.CancellationTokenRegistration)
		/// </summary>
		protected static RMethod r_Mop_Inequality_CancellationTokenRegistration_CancellationTokenRegistration;
		public static RMethod RMop_Inequality_CancellationTokenRegistration_CancellationTokenRegistration
		{
			get
			{
				if(r_Mop_Inequality_CancellationTokenRegistration_CancellationTokenRegistration == null)
				{
					r_Mop_Inequality_CancellationTokenRegistration_CancellationTokenRegistration = new(Type, "op_Inequality", 0, typeof(System.Threading.CancellationTokenRegistration), typeof(System.Threading.CancellationTokenRegistration));
				}
				return r_Mop_Inequality_CancellationTokenRegistration_CancellationTokenRegistration;
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
		/// Boolean Equals(System.Threading.CancellationTokenRegistration)
		/// </summary>
		protected RMethod r_MEquals_CancellationTokenRegistration;
		public virtual RMethod RMEquals_CancellationTokenRegistration
		{
			get
			{
				if(r_MEquals_CancellationTokenRegistration == null)
				{
					r_MEquals_CancellationTokenRegistration = new(this, "Equals", 0, typeof(System.Threading.CancellationTokenRegistration));
				}
				return r_MEquals_CancellationTokenRegistration;
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
		/// System.Threading.Tasks.ValueTask DisposeAsync()
		/// </summary>
		protected RMethod r_MDisposeAsync;
		public virtual RMethod RMDisposeAsync
		{
			get
			{
				if(r_MDisposeAsync == null)
				{
					r_MDisposeAsync = new(this, "DisposeAsync", 0);
				}
				return r_MDisposeAsync;
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


        public virtual System.Boolean Unregister()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnregister.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean op_Equality(System.Threading.CancellationTokenRegistration @left, System.Threading.CancellationTokenRegistration @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_CancellationTokenRegistration_CancellationTokenRegistration.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.Threading.CancellationTokenRegistration @left, System.Threading.CancellationTokenRegistration @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_CancellationTokenRegistration_CancellationTokenRegistration.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Threading.CancellationTokenRegistration @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_CancellationTokenRegistration.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Threading.Tasks.ValueTask DisposeAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisposeAsync.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Threading.Tasks.ValueTask>(___result);
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
