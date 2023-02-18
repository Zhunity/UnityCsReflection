
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation
{
	/// <summary>
	/// UnityEditor.Scripting.ScriptCompilation.IVersionTypeTraits
	/// </summary>
    public partial class RIVersionTypeTraits : RMember //
    {

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
					r_MIsAllowedFirstCharacter_Char_Boolean.SetBelong(this.GetValue());
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
					r_MIsAllowedLastCharacter_Char_Boolean.SetBelong(this.GetValue());
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
					r_MIsAllowedCharacter_Char.SetBelong(this.GetValue());
				}
				return r_MIsAllowedCharacter_Char;
			}
		}


        public RIVersionTypeTraits() : base("UnityEditor.Scripting.ScriptCompilation.IVersionTypeTraits")
        {
        }

        public RIVersionTypeTraits(System.Object instance) : base("UnityEditor.Scripting.ScriptCompilation.IVersionTypeTraits")
		{
            SetInstance(instance);
		}

        public RIVersionTypeTraits(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIVersionTypeTraits(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


    }
}
