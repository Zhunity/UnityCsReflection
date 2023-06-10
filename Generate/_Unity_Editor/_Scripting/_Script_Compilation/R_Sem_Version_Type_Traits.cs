
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation
{
	/// <summary>
	/// UnityEditor.Scripting.ScriptCompilation.SemVersionTypeTraits
	/// </summary>
    public partial class RSemVersionTypeTraits : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersionTypeTraits");
            }
        }

        public RSemVersionTypeTraits() : base("UnityEditor.Scripting.ScriptCompilation.SemVersionTypeTraits")
        {
        }

        public RSemVersionTypeTraits(System.Object instance) : base("UnityEditor.Scripting.ScriptCompilation.SemVersionTypeTraits")
		{
            SetInstance(instance);
		}

        public RSemVersionTypeTraits(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSemVersionTypeTraits(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Boolean IsAllowedFirstCharacter(Char, Boolean)
		/// </summary>
		protected RMethod r_MIsAllowedFirstCharacter_Char_Boolean;
		public virtual RMethod RMIsAllowedFirstCharacter_Char_Boolean
		{
			get
			{
				if(r_MIsAllowedFirstCharacter_Char_Boolean == null)
				{
					r_MIsAllowedFirstCharacter_Char_Boolean = new(this, "IsAllowedFirstCharacter", 0, typeof(System.Char), typeof(System.Boolean));
				}
				return r_MIsAllowedFirstCharacter_Char_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsAllowedLastCharacter(Char, Boolean)
		/// </summary>
		protected RMethod r_MIsAllowedLastCharacter_Char_Boolean;
		public virtual RMethod RMIsAllowedLastCharacter_Char_Boolean
		{
			get
			{
				if(r_MIsAllowedLastCharacter_Char_Boolean == null)
				{
					r_MIsAllowedLastCharacter_Char_Boolean = new(this, "IsAllowedLastCharacter", 0, typeof(System.Char), typeof(System.Boolean));
				}
				return r_MIsAllowedLastCharacter_Char_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsAllowedCharacter(Char)
		/// </summary>
		protected RMethod r_MIsAllowedCharacter_Char;
		public virtual RMethod RMIsAllowedCharacter_Char
		{
			get
			{
				if(r_MIsAllowedCharacter_Char == null)
				{
					r_MIsAllowedCharacter_Char = new(this, "IsAllowedCharacter", 0, typeof(System.Char));
				}
				return r_MIsAllowedCharacter_Char;
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


        public virtual System.Boolean IsAllowedFirstCharacter(System.Char @c, System.Boolean @strict)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c, @strict};
            var ___result = RMIsAllowedFirstCharacter_Char_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAllowedLastCharacter(System.Char @c, System.Boolean @strict)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c, @strict};
            var ___result = RMIsAllowedLastCharacter_Char_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAllowedCharacter(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsAllowedCharacter_Char.Invoke(___genericsType, ___parameters);

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
