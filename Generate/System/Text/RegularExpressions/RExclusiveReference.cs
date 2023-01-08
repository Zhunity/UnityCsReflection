using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.ExclusiveReference
	/// </summary>
    public partial class RExclusiveReference : RMember //
    {

		/// <summary>
		/// System.Text.RegularExpressions.RegexRunner _ref
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegexRunner r__ref;
		public virtual RSystem.RText.RRegularExpressions.RRegexRunner R_ref
		{
			get
			{
				if(r__ref == null)
				{
					r__ref = new(this, "_ref");
					r__ref.SetBelong(this.instance);
				}
				return r__ref;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexRunner _obj
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegexRunner r__obj;
		public virtual RSystem.RText.RRegularExpressions.RRegexRunner R_obj
		{
			get
			{
				if(r__obj == null)
				{
					r__obj = new(this, "_obj");
					r__obj.SetBelong(this.instance);
				}
				return r__obj;
			}
		}

		/// <summary>
		/// System.Int32 _locked
		/// </summary>
		protected RField r__locked;
		public virtual RField R_locked
		{
			get
			{
				if(r__locked == null)
				{
					r__locked = new(this, "_locked");
					r__locked.SetBelong(this.instance);
				}
				return r__locked;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexRunner Get()
		/// </summary>
		protected RMethod r_Get;
		public virtual RMethod RGet
		{
			get
			{
				if(r_Get == null)
				{
					r_Get = new(this, "Get", 0);
					r_Get.SetBelong(this.instance);
				}
				return r_Get;
			}
		}

		/// <summary>
		/// Void Release(System.Text.RegularExpressions.RegexRunner)
		/// </summary>
		protected RMethod r_Release_RegexRunner;
		public virtual RMethod RRelease_RegexRunner
		{
			get
			{
				if(r_Release_RegexRunner == null)
				{
					r_Release_RegexRunner = new(this, "Release", 0, typeof(System.Text.RegularExpressions.RegexRunner));
					r_Release_RegexRunner.SetBelong(this.instance);
				}
				return r_Release_RegexRunner;
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


        public RExclusiveReference() : base("System.Text.RegularExpressions.ExclusiveReference")
        {
        }

        public RExclusiveReference(System.Object instance) : base("System.Text.RegularExpressions.ExclusiveReference")
		{
            SetInstance(instance);
		}

        public RExclusiveReference(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RExclusiveReference(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Text.RegularExpressions.RegexRunner Get()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGet.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.RegexRunner)___result;
        }


        public virtual void Release(System.Text.RegularExpressions.RegexRunner @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RRelease_RegexRunner.Invoke(___genericsType, ___parameters);

            
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
