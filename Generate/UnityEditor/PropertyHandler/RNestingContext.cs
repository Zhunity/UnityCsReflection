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
		protected RField r_m_NestingLevel;
		public virtual RField Rm_NestingLevel
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
		protected RField r_m_OldNestingLevel;
		public virtual RField Rm_OldNestingLevel
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
		protected static RMethod r_RGet_PropertyHandler_Int32;
		public static RMethod RGet_PropertyHandler_Int32
		{
			get
			{
				if(r_RGet_PropertyHandler_Int32 == null)
				{
					r_RGet_PropertyHandler_Int32 = new( ReleactionUtils.GetType("UnityEditor.PropertyHandler+NestingContext"), "Get", 0,  ReleactionUtils.GetType("UnityEditor.PropertyHandler"), typeof(System.Int32));
					r_RGet_PropertyHandler_Int32.SetBelong(null);
				}
				return r_RGet_PropertyHandler_Int32;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Open()
		/// </summary>
		protected RMethod r_ROpen;
		public virtual RMethod ROpen
		{
			get
			{
				if(r_ROpen == null)
				{
					r_ROpen = new(this, "Open", 0);
					r_ROpen.SetBelong(this.instance);
				}
				return r_ROpen;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_RClose;
		public virtual RMethod RClose
		{
			get
			{
				if(r_RClose == null)
				{
					r_RClose = new(this, "Close", 0);
					r_RClose.SetBelong(this.instance);
				}
				return r_RClose;
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


        public virtual System.Boolean Equals(System.Object  @obj)
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