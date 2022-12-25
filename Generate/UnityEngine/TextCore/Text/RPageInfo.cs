using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.PageInfo
	/// </summary>
    public partial class RPageInfo : RMember //
    {

		/// <summary>
		/// System.Int32 firstCharacterIndex
		/// </summary>
		protected RField r_firstCharacterIndex;
		public virtual RField RfirstCharacterIndex
		{
			get
			{
				if(r_firstCharacterIndex == null)
				{
					r_firstCharacterIndex = new(this, "firstCharacterIndex");
					r_firstCharacterIndex.SetBelong(this.instance);
				}
				return r_firstCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 lastCharacterIndex
		/// </summary>
		protected RField r_lastCharacterIndex;
		public virtual RField RlastCharacterIndex
		{
			get
			{
				if(r_lastCharacterIndex == null)
				{
					r_lastCharacterIndex = new(this, "lastCharacterIndex");
					r_lastCharacterIndex.SetBelong(this.instance);
				}
				return r_lastCharacterIndex;
			}
		}

		/// <summary>
		/// System.Single ascender
		/// </summary>
		protected RField r_ascender;
		public virtual RField Rascender
		{
			get
			{
				if(r_ascender == null)
				{
					r_ascender = new(this, "ascender");
					r_ascender.SetBelong(this.instance);
				}
				return r_ascender;
			}
		}

		/// <summary>
		/// System.Single baseLine
		/// </summary>
		protected RField r_baseLine;
		public virtual RField RbaseLine
		{
			get
			{
				if(r_baseLine == null)
				{
					r_baseLine = new(this, "baseLine");
					r_baseLine.SetBelong(this.instance);
				}
				return r_baseLine;
			}
		}

		/// <summary>
		/// System.Single descender
		/// </summary>
		protected RField r_descender;
		public virtual RField Rdescender
		{
			get
			{
				if(r_descender == null)
				{
					r_descender = new(this, "descender");
					r_descender.SetBelong(this.instance);
				}
				return r_descender;
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


        public RPageInfo() : base("UnityEngine.TextCore.Text.PageInfo")
        {
        }

        public RPageInfo(System.Object instance) : base("UnityEngine.TextCore.Text.PageInfo")
		{
            SetInstance(instance);
		}

        public RPageInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPageInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
