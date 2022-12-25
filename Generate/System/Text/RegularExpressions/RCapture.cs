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
		protected RField r___1__Index__2__k__BackingField;
		public virtual RField R__1__Index__2__k__BackingField
		{
			get
			{
				if(r___1__Index__2__k__BackingField == null)
				{
					r___1__Index__2__k__BackingField = new(this, "<Index>k__BackingField");
					r___1__Index__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__Index__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <Length>k__BackingField
		/// </summary>
		protected RField r___1__Length__2__k__BackingField;
		public virtual RField R__1__Length__2__k__BackingField
		{
			get
			{
				if(r___1__Length__2__k__BackingField == null)
				{
					r___1__Length__2__k__BackingField = new(this, "<Length>k__BackingField");
					r___1__Length__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__Length__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <Text>k__BackingField
		/// </summary>
		protected RField r___1__Text__2__k__BackingField;
		public virtual RField R__1__Text__2__k__BackingField
		{
			get
			{
				if(r___1__Text__2__k__BackingField == null)
				{
					r___1__Text__2__k__BackingField = new(this, "<Text>k__BackingField");
					r___1__Text__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__Text__2__k__BackingField;
			}
		}

		/// <summary>
		/// Int32 Index
		/// </summary>
		protected RProperty r_Index;
		public virtual RProperty RIndex
		{
			get
			{
				if(r_Index == null)
				{
					r_Index = new(this, "Index", -1);
					r_Index.SetBelong(this.instance);
				}
				return r_Index;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RProperty r_Length;
		public virtual RProperty RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length", -1);
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// System.String Text
		/// </summary>
		protected RProperty r_Text;
		public virtual RProperty RText
		{
			get
			{
				if(r_Text == null)
				{
					r_Text = new(this, "Text", -1);
					r_Text.SetBelong(this.instance);
				}
				return r_Text;
			}
		}

		/// <summary>
		/// System.String Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
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
		/// System.ReadOnlySpan`1[System.Char] GetLeftSubstring()
		/// </summary>
		protected RMethod r_RGetLeftSubstring;
		public virtual RMethod RGetLeftSubstring
		{
			get
			{
				if(r_RGetLeftSubstring == null)
				{
					r_RGetLeftSubstring = new(this, "GetLeftSubstring", 0);
					r_RGetLeftSubstring.SetBelong(this.instance);
				}
				return r_RGetLeftSubstring;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] GetRightSubstring()
		/// </summary>
		protected RMethod r_RGetRightSubstring;
		public virtual RMethod RGetRightSubstring
		{
			get
			{
				if(r_RGetRightSubstring == null)
				{
					r_RGetRightSubstring = new(this, "GetRightSubstring", 0);
					r_RGetRightSubstring.SetBelong(this.instance);
				}
				return r_RGetRightSubstring;
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
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object GetLeftSubstring()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLeftSubstring.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetRightSubstring()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRightSubstring.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


    }
}
