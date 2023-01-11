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
		protected RUnityEditor.RPropertyHandler r_m_Handler;
		public virtual RUnityEditor.RPropertyHandler Rm_Handler
		{
			get
			{
				if(r_m_Handler == null)
				{
					r_m_Handler = new(this, "m_Handler");
					r_m_Handler.SetBelong(this.instance);
				}
				return r_m_Handler;
			}
		}

		/// <summary>
		/// System.Int32 m_NestingLevel
		/// </summary>
		protected RSystem.RInt32 r_m_NestingLevel;
		public virtual RSystem.RInt32 Rm_NestingLevel
		{
			get
			{
				if(r_m_NestingLevel == null)
				{
					r_m_NestingLevel = new(this, "m_NestingLevel");
					r_m_NestingLevel.SetBelong(this.instance);
				}
				return r_m_NestingLevel;
			}
		}

		/// <summary>
		/// System.Int32 m_OldNestingLevel
		/// </summary>
		protected RSystem.RInt32 r_m_OldNestingLevel;
		public virtual RSystem.RInt32 Rm_OldNestingLevel
		{
			get
			{
				if(r_m_OldNestingLevel == null)
				{
					r_m_OldNestingLevel = new(this, "m_OldNestingLevel");
					r_m_OldNestingLevel.SetBelong(this.instance);
				}
				return r_m_OldNestingLevel;
			}
		}

		/// <summary>
		/// NestingContext Get(UnityEditor.PropertyHandler, Int32)
		/// </summary>
		protected static RMethod r_Get_PropertyHandler_Int32;
		public static RMethod RGet_PropertyHandler_Int32
		{
			get
			{
				if(r_Get_PropertyHandler_Int32 == null)
				{
					r_Get_PropertyHandler_Int32 = new( ReflectionUtils.GetType("UnityEditor.PropertyHandler+NestingContext"), "Get", 0,  ReflectionUtils.GetType("UnityEditor.PropertyHandler"), typeof(System.Int32));
					r_Get_PropertyHandler_Int32.SetBelong(null);
				}
				return r_Get_PropertyHandler_Int32;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void Open()
		/// </summary>
		protected RMethod r_Open;
		public virtual RMethod ROpen
		{
			get
			{
				if(r_Open == null)
				{
					r_Open = new(this, "Open", 0);
					r_Open.SetBelong(this.instance);
				}
				return r_Open;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_Close;
		public virtual RMethod RClose
		{
			get
			{
				if(r_Close == null)
				{
					r_Close = new(this, "Close", 0);
					r_Close.SetBelong(this.instance);
				}
				return r_Close;
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
            var ___result = RGet_PropertyHandler_Int32.Invoke(___genericsType, ___parameters);

            return new RUnityEditor.RPropertyHandler.RNestingContext(___result);
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Open()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROpen.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
}