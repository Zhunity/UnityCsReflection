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
		protected RMethod r_GetToken_String;
		public virtual RMethod RGetToken_String
		{
			get
			{
				if(r_GetToken_String == null)
				{
					r_GetToken_String = new(this, "GetToken", 0, typeof(System.String));
					r_GetToken_String.SetBelong(this.instance);
				}
				return r_GetToken_String;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MemberInfo, Boolean)
		/// </summary>
		protected RMethod r_GetToken_MemberInfo_Boolean;
		public virtual RMethod RGetToken_MemberInfo_Boolean
		{
			get
			{
				if(r_GetToken_MemberInfo_Boolean == null)
				{
					r_GetToken_MemberInfo_Boolean = new(this, "GetToken", 0, typeof(System.Reflection.MemberInfo), typeof(System.Boolean));
					r_GetToken_MemberInfo_Boolean.SetBelong(this.instance);
				}
				return r_GetToken_MemberInfo_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MethodBase, System.Type[])
		/// </summary>
		protected RMethod r_GetToken_MethodBase_TypeArray;
		public virtual RMethod RGetToken_MethodBase_TypeArray
		{
			get
			{
				if(r_GetToken_MethodBase_TypeArray == null)
				{
					r_GetToken_MethodBase_TypeArray = new(this, "GetToken", 0, typeof(System.Reflection.MethodBase), typeof(System.Type).MakeArrayType());
					r_GetToken_MethodBase_TypeArray.SetBelong(this.instance);
				}
				return r_GetToken_MethodBase_TypeArray;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.Emit.SignatureHelper)
		/// </summary>
		protected RMethod r_GetToken_SignatureHelper;
		public virtual RMethod RGetToken_SignatureHelper
		{
			get
			{
				if(r_GetToken_SignatureHelper == null)
				{
					r_GetToken_SignatureHelper = new(this, "GetToken", 0, typeof(System.Reflection.Emit.SignatureHelper));
					r_GetToken_SignatureHelper.SetBelong(this.instance);
				}
				return r_GetToken_SignatureHelper;
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

        public virtual System.Int32 GetToken(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RGetToken_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MemberInfo @member, System.Boolean @create_open_instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@member, @create_open_instance};
            var ___result = RGetToken_MemberInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MethodBase @method, System.Type[] @opt_param_types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @opt_param_types};
            var ___result = RGetToken_MethodBase_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.Emit.SignatureHelper @helper)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@helper};
            var ___result = RGetToken_SignatureHelper.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
