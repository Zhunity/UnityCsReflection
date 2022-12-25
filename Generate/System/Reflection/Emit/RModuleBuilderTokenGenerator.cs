using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.ModuleBuilderTokenGenerator
	/// </summary>
    public partial class RModuleBuilderTokenGenerator : RMember //
    {

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder mb
		/// </summary>
		protected RSystem.RReflection.REmit.RModuleBuilder r_mb;
		public virtual RSystem.RReflection.REmit.RModuleBuilder Rmb
		{
			get
			{
				if(r_mb == null)
				{
					r_mb = new(this, "mb");
					r_mb.SetBelong(this.instance);
				}
				return r_mb;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.String)
		/// </summary>
		protected RMethod r_RGetToken_String;
		public virtual RMethod RGetToken_String
		{
			get
			{
				if(r_RGetToken_String == null)
				{
					r_RGetToken_String = new(this, "GetToken", 0, typeof(System.String));
					r_RGetToken_String.SetBelong(this.instance);
				}
				return r_RGetToken_String;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MemberInfo, Boolean)
		/// </summary>
		protected RMethod r_RGetToken_MemberInfo_Boolean;
		public virtual RMethod RGetToken_MemberInfo_Boolean
		{
			get
			{
				if(r_RGetToken_MemberInfo_Boolean == null)
				{
					r_RGetToken_MemberInfo_Boolean = new(this, "GetToken", 0, typeof(System.Reflection.MemberInfo), typeof(System.Boolean));
					r_RGetToken_MemberInfo_Boolean.SetBelong(this.instance);
				}
				return r_RGetToken_MemberInfo_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MethodBase, System.Type[])
		/// </summary>
		protected RMethod r_RGetToken_MethodBase_TypeArray;
		public virtual RMethod RGetToken_MethodBase_TypeArray
		{
			get
			{
				if(r_RGetToken_MethodBase_TypeArray == null)
				{
					r_RGetToken_MethodBase_TypeArray = new(this, "GetToken", 0, typeof(System.Reflection.MethodBase), typeof(System.Type).MakeArrayType());
					r_RGetToken_MethodBase_TypeArray.SetBelong(this.instance);
				}
				return r_RGetToken_MethodBase_TypeArray;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.Emit.SignatureHelper)
		/// </summary>
		protected RMethod r_RGetToken_SignatureHelper;
		public virtual RMethod RGetToken_SignatureHelper
		{
			get
			{
				if(r_RGetToken_SignatureHelper == null)
				{
					r_RGetToken_SignatureHelper = new(this, "GetToken", 0, typeof(System.Reflection.Emit.SignatureHelper));
					r_RGetToken_SignatureHelper.SetBelong(this.instance);
				}
				return r_RGetToken_SignatureHelper;
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


        public RModuleBuilderTokenGenerator() : base("System.Reflection.Emit.ModuleBuilderTokenGenerator")
        {
        }

        public RModuleBuilderTokenGenerator(System.Object instance) : base("System.Reflection.Emit.ModuleBuilderTokenGenerator")
		{
            SetInstance(instance);
		}

        public RModuleBuilderTokenGenerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RModuleBuilderTokenGenerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetToken(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RGetToken_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MemberInfo  @member, System.Boolean  @create_open_instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@member, @create_open_instance};
            var ___result = RGetToken_MemberInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MethodBase  @method, System.Type[]  @opt_param_types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @opt_param_types};
            var ___result = RGetToken_MethodBase_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.Emit.SignatureHelper  @helper)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@helper};
            var ___result = RGetToken_SignatureHelper.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
