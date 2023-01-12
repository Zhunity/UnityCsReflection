using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.Capture
	/// </summary>
    public partial class RCapture : RMember //
    {

		/// <summary>
		/// System.Int32 <Index>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r_F__0__Index__1__k__BackingField;
		public virtual RSystem.RInt32 RF__0__Index__1__k__BackingField
		{
			get
			{
				if(r_F__0__Index__1__k__BackingField == null)
				{
					r_F__0__Index__1__k__BackingField = new(this, "<Index>k__BackingField");
					r_F__0__Index__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__Index__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <Length>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r_F__0__Length__1__k__BackingField;
		public virtual RSystem.RInt32 RF__0__Length__1__k__BackingField
		{
			get
			{
				if(r_F__0__Length__1__k__BackingField == null)
				{
					r_F__0__Length__1__k__BackingField = new(this, "<Length>k__BackingField");
					r_F__0__Length__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__Length__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <Text>k__BackingField
		/// </summary>
		protected RSystem.RString r_F__0__Text__1__k__BackingField;
		public virtual RSystem.RString RF__0__Text__1__k__BackingField
		{
			get
			{
				if(r_F__0__Text__1__k__BackingField == null)
				{
					r_F__0__Text__1__k__BackingField = new(this, "<Text>k__BackingField");
					r_F__0__Text__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__Text__1__k__BackingField;
			}
		}

		/// <summary>
		/// Int32 Index
		/// </summary>
		protected RSystem.RInt32 r_PIndex;
		public virtual RSystem.RInt32 RPIndex
		{
			get
			{
				if(r_PIndex == null)
				{
					r_PIndex = new(this, "Index", -1);
					r_PIndex.SetBelong(this.instance);
				}
				return r_PIndex;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RSystem.RInt32 r_PLength;
		public virtual RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
					r_PLength.SetBelong(this.instance);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// System.String Text
		/// </summary>
		protected RSystem.RString r_PText;
		public virtual RSystem.RString RPText
		{
			get
			{
				if(r_PText == null)
				{
					r_PText = new(this, "Text", -1);
					r_PText.SetBelong(this.instance);
				}
				return r_PText;
			}
		}

		/// <summary>
		/// System.String Value
		/// </summary>
		protected RSystem.RString r_PValue;
		public virtual RSystem.RString RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
					r_PValue.SetBelong(this.instance);
				}
				return r_PValue;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] GetLeftSubstring()
		/// </summary>
		protected RMethod r_MGetLeftSubstring;
		public virtual RMethod RMGetLeftSubstring
		{
			get
			{
				if(r_MGetLeftSubstring == null)
				{
					r_MGetLeftSubstring = new(this, "GetLeftSubstring", 0);
					r_MGetLeftSubstring.SetBelong(this.instance);
				}
				return r_MGetLeftSubstring;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] GetRightSubstring()
		/// </summary>
		protected RMethod r_MGetRightSubstring;
		public virtual RMethod RMGetRightSubstring
		{
			get
			{
				if(r_MGetRightSubstring == null)
				{
					r_MGetRightSubstring = new(this, "GetRightSubstring", 0);
					r_MGetRightSubstring.SetBelong(this.instance);
				}
				return r_MGetRightSubstring;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}


        public RCapture() : base("System.Text.RegularExpressions.Capture")
        {
        }

        public RCapture(System.Object instance) : base("System.Text.RegularExpressions.Capture")
		{
            SetInstance(instance);
		}

        public RCapture(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCapture(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual RSystem.RReadOnlySpan<RSystem.RChar> GetLeftSubstring()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLeftSubstring.Invoke(___genericsType, ___parameters);

            return new RSystem.RReadOnlySpan<RSystem.RChar>(___result);
        }


        public virtual RSystem.RReadOnlySpan<RSystem.RChar> GetRightSubstring()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRightSubstring.Invoke(___genericsType, ___parameters);

            return new RSystem.RReadOnlySpan<RSystem.RChar>(___result);
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


    }
}
