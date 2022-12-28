using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.Group
	/// </summary>
    public partial class RGroup : RMember //
    {

		/// <summary>
		/// System.Text.RegularExpressions.Group s_emptyGroup
		/// </summary>
		protected static RSystem.RText.RRegularExpressions.RGroup r_s_emptyGroup;
		public static RSystem.RText.RRegularExpressions.RGroup Rs_emptyGroup
		{
			get
			{
				if(r_s_emptyGroup == null)
				{
					r_s_emptyGroup = new(typeof(System.Text.RegularExpressions.Group), "s_emptyGroup");
					r_s_emptyGroup.SetBelong(null);
				}
				return r_s_emptyGroup;
			}
		}

		/// <summary>
		/// System.Int32[] _caps
		/// </summary>
		protected RFieldArray<RField> r__caps;
		public virtual RFieldArray<RField> R_caps
		{
			get
			{
				if(r__caps == null)
				{
					r__caps = new(this, "_caps");
					r__caps.SetBelong(this.instance);
				}
				return r__caps;
			}
		}

		/// <summary>
		/// System.Int32 _capcount
		/// </summary>
		protected RField r__capcount;
		public virtual RField R_capcount
		{
			get
			{
				if(r__capcount == null)
				{
					r__capcount = new(this, "_capcount");
					r__capcount.SetBelong(this.instance);
				}
				return r__capcount;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.CaptureCollection _capcoll
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RCaptureCollection r__capcoll;
		public virtual RSystem.RText.RRegularExpressions.RCaptureCollection R_capcoll
		{
			get
			{
				if(r__capcoll == null)
				{
					r__capcoll = new(this, "_capcoll");
					r__capcoll.SetBelong(this.instance);
				}
				return r__capcoll;
			}
		}

		/// <summary>
		/// System.String <Name>k__BackingField
		/// </summary>
		protected RField r___1__Name__2__k__BackingField;
		public virtual RField R__1__Name__2__k__BackingField
		{
			get
			{
				if(r___1__Name__2__k__BackingField == null)
				{
					r___1__Name__2__k__BackingField = new(this, "<Name>k__BackingField");
					r___1__Name__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__Name__2__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean Success
		/// </summary>
		protected RProperty r_Success;
		public virtual RProperty RSuccess
		{
			get
			{
				if(r_Success == null)
				{
					r_Success = new(this, "Success", -1);
					r_Success.SetBelong(this.instance);
				}
				return r_Success;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.CaptureCollection Captures
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RCaptureCollection r_Captures;
		public virtual RSystem.RText.RRegularExpressions.RCaptureCollection RCaptures
		{
			get
			{
				if(r_Captures == null)
				{
					r_Captures = new(this, "Captures", -1);
					r_Captures.SetBelong(this.instance);
				}
				return r_Captures;
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
		/// System.Text.RegularExpressions.Group Synchronized(System.Text.RegularExpressions.Group)
		/// </summary>
		protected static RMethod r_RSynchronized_Group;
		public static RMethod RSynchronized_Group
		{
			get
			{
				if(r_RSynchronized_Group == null)
				{
					r_RSynchronized_Group = new(typeof(System.Text.RegularExpressions.Group), "Synchronized", 0, typeof(System.Text.RegularExpressions.Group));
					r_RSynchronized_Group.SetBelong(null);
				}
				return r_RSynchronized_Group;
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


        public RGroup() : base("System.Text.RegularExpressions.Group")
        {
        }

        public RGroup(System.Object instance) : base("System.Text.RegularExpressions.Group")
		{
            SetInstance(instance);
		}

        public RGroup(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGroup(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Text.RegularExpressions.Group Synchronized(System.Text.RegularExpressions.Group  @inner)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inner};
            var ___result = RSynchronized_Group.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Group)___result;
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