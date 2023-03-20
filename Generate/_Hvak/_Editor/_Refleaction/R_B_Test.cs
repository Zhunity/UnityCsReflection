
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RHvak.REditor.RRefleaction
{
	/// <summary>
	/// Hvak.Editor.Refleaction.BTest
	/// </summary>
    public partial class RBTest : RMember //
    {

		/// <summary>
		/// System.String str
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fstr;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFstr
		{
			get
			{
				if(r_Fstr == null)
				{
					r_Fstr = new(this, "str");
				}
				return r_Fstr;
			}
		}

		/// <summary>
		/// Hvak.Editor.Refleaction.ATest <aTest>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RHvak.REditor.RRefleaction.RATest r_F__0__aTest__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RHvak.REditor.RRefleaction.RATest RF__0__aTest__1__k__BackingField
		{
			get
			{
				if(r_F__0__aTest__1__k__BackingField == null)
				{
					r_F__0__aTest__1__k__BackingField = new(this, "<aTest>k__BackingField");
				}
				return r_F__0__aTest__1__k__BackingField;
			}
		}

		/// <summary>
		/// Hvak.Editor.Refleaction.ATest aTest
		/// </summary>
		protected Hvak.Editor.Refleaction.RHvak.REditor.RRefleaction.RATest r_PaTest;
		public virtual Hvak.Editor.Refleaction.RHvak.REditor.RRefleaction.RATest RPaTest
		{
			get
			{
				if(r_PaTest == null)
				{
					r_PaTest = new(this, "aTest", -1);
				}
				return r_PaTest;
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


        public RBTest() : base("Hvak.Editor.Refleaction.BTest")
        {
        }

        public RBTest(System.Object instance) : base("Hvak.Editor.Refleaction.BTest")
		{
            SetInstance(instance);
		}

        public RBTest(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBTest(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
