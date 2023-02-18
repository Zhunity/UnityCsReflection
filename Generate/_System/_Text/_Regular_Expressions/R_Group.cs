
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.Group
	/// </summary>
    public partial class RGroup : RMember //
    {

		/// <summary>
		/// System.Text.RegularExpressions.Group s_emptyGroup
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RGroup r_Fs_emptyGroup;
		public static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RGroup RFs_emptyGroup
		{
			get
			{
				if(r_Fs_emptyGroup == null)
				{
					r_Fs_emptyGroup = new(typeof(System.Text.RegularExpressions.Group), "s_emptyGroup");
				}
				return r_Fs_emptyGroup;
			}
		}

		/// <summary>
		/// System.Int32[] _caps
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_F_caps;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RF_caps
		{
			get
			{
				if(r_F_caps == null)
				{
					r_F_caps = new(this, "_caps");
				}
				return r_F_caps;
			}
		}

		/// <summary>
		/// System.Int32 _capcount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_capcount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_capcount
		{
			get
			{
				if(r_F_capcount == null)
				{
					r_F_capcount = new(this, "_capcount");
				}
				return r_F_capcount;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.CaptureCollection _capcoll
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCaptureCollection r_F_capcoll;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCaptureCollection RF_capcoll
		{
			get
			{
				if(r_F_capcoll == null)
				{
					r_F_capcoll = new(this, "_capcoll");
				}
				return r_F_capcoll;
			}
		}

		/// <summary>
		/// System.String <Name>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__Name__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__Name__1__k__BackingField
		{
			get
			{
				if(r_F__0__Name__1__k__BackingField == null)
				{
					r_F__0__Name__1__k__BackingField = new(this, "<Name>k__BackingField");
				}
				return r_F__0__Name__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean Success
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSuccess;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSuccess
		{
			get
			{
				if(r_PSuccess == null)
				{
					r_PSuccess = new(this, "Success", -1);
				}
				return r_PSuccess;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.CaptureCollection Captures
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCaptureCollection r_PCaptures;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCaptureCollection RPCaptures
		{
			get
			{
				if(r_PCaptures == null)
				{
					r_PCaptures = new(this, "Captures", -1);
				}
				return r_PCaptures;
			}
		}

		/// <summary>
		/// Int32 Index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPIndex
		{
			get
			{
				if(r_PIndex == null)
				{
					r_PIndex = new(this, "Index", -1);
				}
				return r_PIndex;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// System.String Text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PText;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPText
		{
			get
			{
				if(r_PText == null)
				{
					r_PText = new(this, "Text", -1);
				}
				return r_PText;
			}
		}

		/// <summary>
		/// System.String Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Group Synchronized(System.Text.RegularExpressions.Group)
		/// </summary>
		protected static RMethod r_MSynchronized_Group;
		public static RMethod RMSynchronized_Group
		{
			get
			{
				if(r_MSynchronized_Group == null)
				{
					r_MSynchronized_Group = new(typeof(System.Text.RegularExpressions.Group), "Synchronized", 0, typeof(System.Text.RegularExpressions.Group));
				}
				return r_MSynchronized_Group;
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

        public static System.Text.RegularExpressions.Group Synchronized(System.Text.RegularExpressions.Group @inner)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inner};
            var ___result = RMSynchronized_Group.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Group)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> GetLeftSubstring()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLeftSubstring.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> GetRightSubstring()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRightSubstring.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar>(___result);
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
