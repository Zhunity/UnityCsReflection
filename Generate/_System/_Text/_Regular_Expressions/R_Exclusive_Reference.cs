
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Text.RegularExpressions.ExclusiveReference
	/// </summary>
    public partial class RExclusiveReference : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Text.RegularExpressions.ExclusiveReference");
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


		/// <summary>
		/// System.Text.RegularExpressions.RegexRunner _ref
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexRunner r_F_ref;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexRunner RF_ref
		{
			get
			{
				if(r_F_ref == null)
				{
					r_F_ref = new(this, "_ref");
				}
				return r_F_ref;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexRunner _obj
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexRunner r_F_obj;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexRunner RF_obj
		{
			get
			{
				if(r_F_obj == null)
				{
					r_F_obj = new(this, "_obj");
				}
				return r_F_obj;
			}
		}

		/// <summary>
		/// System.Int32 _locked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_locked;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_locked
		{
			get
			{
				if(r_F_locked == null)
				{
					r_F_locked = new(this, "_locked");
				}
				return r_F_locked;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexRunner Get()
		/// </summary>
		protected RMethod r_MGet;
		public virtual RMethod RMGet
		{
			get
			{
				if(r_MGet == null)
				{
					r_MGet = new(this, "Get", 0);
				}
				return r_MGet;
			}
		}

		/// <summary>
		/// Void Release(System.Text.RegularExpressions.RegexRunner)
		/// </summary>
		protected RMethod r_MRelease_RegexRunner;
		public virtual RMethod RMRelease_RegexRunner
		{
			get
			{
				if(r_MRelease_RegexRunner == null)
				{
					r_MRelease_RegexRunner = new(this, "Release", 0, typeof(System.Text.RegularExpressions.RegexRunner));
				}
				return r_MRelease_RegexRunner;
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


        public virtual System.Text.RegularExpressions.RegexRunner Get()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGet.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Text.RegularExpressions.RegexRunner>(___result);
        }


        public virtual void Release(System.Text.RegularExpressions.RegexRunner @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMRelease_RegexRunner.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
