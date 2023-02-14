
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.TokenGenerator
	/// </summary>
    public partial class RTokenGenerator : RMember //
    {

		/// <summary>
		/// Int32 GetToken(System.String)
		/// </summary>
		protected RMethod r_MGetToken_String;
		public virtual RMethod RMGetToken_String
		{
			get
			{
				if(r_MGetToken_String == null)
				{
					r_MGetToken_String = new(this, "GetToken", 0, typeof(System.String));
					r_MGetToken_String.SetBelong(this.instance);
				}
				return r_MGetToken_String;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MemberInfo, Boolean)
		/// </summary>
		protected RMethod r_MGetToken_MemberInfo_Boolean;
		public virtual RMethod RMGetToken_MemberInfo_Boolean
		{
			get
			{
				if(r_MGetToken_MemberInfo_Boolean == null)
				{
					r_MGetToken_MemberInfo_Boolean = new(this, "GetToken", 0, typeof(System.Reflection.MemberInfo), typeof(System.Boolean));
					r_MGetToken_MemberInfo_Boolean.SetBelong(this.instance);
				}
				return r_MGetToken_MemberInfo_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MethodBase, System.Type[])
		/// </summary>
		protected RMethod r_MGetToken_MethodBase_TypeArray;
		public virtual RMethod RMGetToken_MethodBase_TypeArray
		{
			get
			{
				if(r_MGetToken_MethodBase_TypeArray == null)
				{
					r_MGetToken_MethodBase_TypeArray = new(this, "GetToken", 0, typeof(System.Reflection.MethodBase), typeof(System.Type).MakeArrayType());
					r_MGetToken_MethodBase_TypeArray.SetBelong(this.instance);
				}
				return r_MGetToken_MethodBase_TypeArray;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.Emit.SignatureHelper)
		/// </summary>
		protected RMethod r_MGetToken_SignatureHelper;
		public virtual RMethod RMGetToken_SignatureHelper
		{
			get
			{
				if(r_MGetToken_SignatureHelper == null)
				{
					r_MGetToken_SignatureHelper = new(this, "GetToken", 0, typeof(System.Reflection.Emit.SignatureHelper));
					r_MGetToken_SignatureHelper.SetBelong(this.instance);
				}
				return r_MGetToken_SignatureHelper;
			}
		}


        public RTokenGenerator() : base("System.Reflection.Emit.TokenGenerator")
        {
        }

        public RTokenGenerator(System.Object instance) : base("System.Reflection.Emit.TokenGenerator")
		{
            SetInstance(instance);
		}

        public RTokenGenerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTokenGenerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetToken(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMGetToken_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MemberInfo @member, System.Boolean @create_open_instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@member, @create_open_instance};
            var ___result = RMGetToken_MemberInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MethodBase @method, System.Type[] @opt_param_types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @opt_param_types};
            var ___result = RMGetToken_MethodBase_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.Emit.SignatureHelper @helper)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@helper};
            var ___result = RMGetToken_SignatureHelper.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


    }
}
