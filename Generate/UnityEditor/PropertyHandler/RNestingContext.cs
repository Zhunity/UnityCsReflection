using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{public partial class RPropertyHandler
{
	
	/// <summary>
	/// UnityEditor.PropertyHandler+NestingContext
	/// </summary>
    public partial class RNestingContext : RMember //
    {

		/// <summary>
		/// UnityEditor.PropertyHandler m_Handler
		/// </summary>
		protected RUnityEditor.RPropertyHandler r_Fm_Handler;
		public virtual RUnityEditor.RPropertyHandler RFm_Handler
		{
			get
			{
				if(r_Fm_Handler == null)
				{
					r_Fm_Handler = new(this, "m_Handler");
					r_Fm_Handler.SetBelong(this.instance);
				}
				return r_Fm_Handler;
			}
		}

		/// <summary>
		/// System.Int32 m_NestingLevel
		/// </summary>
		protected RSystem.RInt32 r_Fm_NestingLevel;
		public virtual RSystem.RInt32 RFm_NestingLevel
		{
			get
			{
				if(r_Fm_NestingLevel == null)
				{
					r_Fm_NestingLevel = new(this, "m_NestingLevel");
					r_Fm_NestingLevel.SetBelong(this.instance);
				}
				return r_Fm_NestingLevel;
			}
		}

		/// <summary>
		/// System.Int32 m_OldNestingLevel
		/// </summary>
		protected RSystem.RInt32 r_Fm_OldNestingLevel;
		public virtual RSystem.RInt32 RFm_OldNestingLevel
		{
			get
			{
				if(r_Fm_OldNestingLevel == null)
				{
					r_Fm_OldNestingLevel = new(this, "m_OldNestingLevel");
					r_Fm_OldNestingLevel.SetBelong(this.instance);
				}
				return r_Fm_OldNestingLevel;
			}
		}

		/// <summary>
		/// NestingContext Get(UnityEditor.PropertyHandler, Int32)
		/// </summary>
		protected static RMethod r_MGet_PropertyHandler_Int32;
		public static RMethod RMGet_PropertyHandler_Int32
		{
			get
			{
				if(r_MGet_PropertyHandler_Int32 == null)
				{
					r_MGet_PropertyHandler_Int32 = new( ReflectionUtils.GetType("UnityEditor.PropertyHandler+NestingContext"), "Get", 0,  ReflectionUtils.GetType("UnityEditor.PropertyHandler"), typeof(System.Int32));
					r_MGet_PropertyHandler_Int32.SetBelong(null);
				}
				return r_MGet_PropertyHandler_Int32;
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
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Open()
		/// </summary>
		protected RMethod r_MOpen;
		public virtual RMethod RMOpen
		{
			get
			{
				if(r_MOpen == null)
				{
					r_MOpen = new(this, "Open", 0);
					r_MOpen.SetBelong(this.instance);
				}
				return r_MOpen;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_MClose;
		public virtual RMethod RMClose
		{
			get
			{
				if(r_MClose == null)
				{
					r_MClose = new(this, "Close", 0);
					r_MClose.SetBelong(this.instance);
				}
				return r_MClose;
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


        public RNestingContext() : base("UnityEditor.PropertyHandler+NestingContext")
        {
        }

        public RNestingContext(System.Object instance) : base("UnityEditor.PropertyHandler+NestingContext")
		{
            SetInstance(instance);
		}

        public RNestingContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNestingContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static RUnityEditor.RPropertyHandler.RNestingContext Get(RUnityEditor.RPropertyHandler @handler, System.Int32 @nestingLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handler.Value, @nestingLevel};
            var ___result = RMGet_PropertyHandler_Int32.Invoke(___genericsType, ___parameters);

            return new RUnityEditor.RPropertyHandler.RNestingContext(___result);
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Open()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOpen.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
}