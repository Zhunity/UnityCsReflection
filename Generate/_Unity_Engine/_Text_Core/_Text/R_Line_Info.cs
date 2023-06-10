
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.LineInfo
	/// </summary>
    public partial class RLineInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.TextCore.Text.LineInfo");
            }
        }

        public RLineInfo() : base("UnityEngine.TextCore.Text.LineInfo")
        {
        }

        public RLineInfo(System.Object instance) : base("UnityEngine.TextCore.Text.LineInfo")
		{
            SetInstance(instance);
		}

        public RLineInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLineInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 controlCharacterCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcontrolCharacterCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcontrolCharacterCount
		{
			get
			{
				if(r_FcontrolCharacterCount == null)
				{
					r_FcontrolCharacterCount = new(this, "controlCharacterCount");
				}
				return r_FcontrolCharacterCount;
			}
		}

		/// <summary>
		/// System.Int32 characterCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcharacterCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcharacterCount
		{
			get
			{
				if(r_FcharacterCount == null)
				{
					r_FcharacterCount = new(this, "characterCount");
				}
				return r_FcharacterCount;
			}
		}

		/// <summary>
		/// System.Int32 visibleCharacterCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FvisibleCharacterCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvisibleCharacterCount
		{
			get
			{
				if(r_FvisibleCharacterCount == null)
				{
					r_FvisibleCharacterCount = new(this, "visibleCharacterCount");
				}
				return r_FvisibleCharacterCount;
			}
		}

		/// <summary>
		/// System.Int32 spaceCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FspaceCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFspaceCount
		{
			get
			{
				if(r_FspaceCount == null)
				{
					r_FspaceCount = new(this, "spaceCount");
				}
				return r_FspaceCount;
			}
		}

		/// <summary>
		/// System.Int32 visibleSpaceCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FvisibleSpaceCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvisibleSpaceCount
		{
			get
			{
				if(r_FvisibleSpaceCount == null)
				{
					r_FvisibleSpaceCount = new(this, "visibleSpaceCount");
				}
				return r_FvisibleSpaceCount;
			}
		}

		/// <summary>
		/// System.Int32 wordCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FwordCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFwordCount
		{
			get
			{
				if(r_FwordCount == null)
				{
					r_FwordCount = new(this, "wordCount");
				}
				return r_FwordCount;
			}
		}

		/// <summary>
		/// System.Int32 firstCharacterIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FfirstCharacterIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfirstCharacterIndex
		{
			get
			{
				if(r_FfirstCharacterIndex == null)
				{
					r_FfirstCharacterIndex = new(this, "firstCharacterIndex");
				}
				return r_FfirstCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 firstVisibleCharacterIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FfirstVisibleCharacterIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfirstVisibleCharacterIndex
		{
			get
			{
				if(r_FfirstVisibleCharacterIndex == null)
				{
					r_FfirstVisibleCharacterIndex = new(this, "firstVisibleCharacterIndex");
				}
				return r_FfirstVisibleCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 lastCharacterIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FlastCharacterIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlastCharacterIndex
		{
			get
			{
				if(r_FlastCharacterIndex == null)
				{
					r_FlastCharacterIndex = new(this, "lastCharacterIndex");
				}
				return r_FlastCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 lastVisibleCharacterIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FlastVisibleCharacterIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlastVisibleCharacterIndex
		{
			get
			{
				if(r_FlastVisibleCharacterIndex == null)
				{
					r_FlastVisibleCharacterIndex = new(this, "lastVisibleCharacterIndex");
				}
				return r_FlastVisibleCharacterIndex;
			}
		}

		/// <summary>
		/// System.Single length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Flength;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFlength
		{
			get
			{
				if(r_Flength == null)
				{
					r_Flength = new(this, "length");
				}
				return r_Flength;
			}
		}

		/// <summary>
		/// System.Single lineHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FlineHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFlineHeight
		{
			get
			{
				if(r_FlineHeight == null)
				{
					r_FlineHeight = new(this, "lineHeight");
				}
				return r_FlineHeight;
			}
		}

		/// <summary>
		/// System.Single ascender
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fascender;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFascender
		{
			get
			{
				if(r_Fascender == null)
				{
					r_Fascender = new(this, "ascender");
				}
				return r_Fascender;
			}
		}

		/// <summary>
		/// System.Single baseline
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fbaseline;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFbaseline
		{
			get
			{
				if(r_Fbaseline == null)
				{
					r_Fbaseline = new(this, "baseline");
				}
				return r_Fbaseline;
			}
		}

		/// <summary>
		/// System.Single descender
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fdescender;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFdescender
		{
			get
			{
				if(r_Fdescender == null)
				{
					r_Fdescender = new(this, "descender");
				}
				return r_Fdescender;
			}
		}

		/// <summary>
		/// System.Single maxAdvance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FmaxAdvance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFmaxAdvance
		{
			get
			{
				if(r_FmaxAdvance == null)
				{
					r_FmaxAdvance = new(this, "maxAdvance");
				}
				return r_FmaxAdvance;
			}
		}

		/// <summary>
		/// System.Single width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fwidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFwidth
		{
			get
			{
				if(r_Fwidth == null)
				{
					r_Fwidth = new(this, "width");
				}
				return r_Fwidth;
			}
		}

		/// <summary>
		/// System.Single marginLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FmarginLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFmarginLeft
		{
			get
			{
				if(r_FmarginLeft == null)
				{
					r_FmarginLeft = new(this, "marginLeft");
				}
				return r_FmarginLeft;
			}
		}

		/// <summary>
		/// System.Single marginRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FmarginRight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFmarginRight
		{
			get
			{
				if(r_FmarginRight == null)
				{
					r_FmarginRight = new(this, "marginRight");
				}
				return r_FmarginRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment alignment
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_Falignment;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFalignment
		{
			get
			{
				if(r_Falignment == null)
				{
					r_Falignment = new(this, "alignment");
				}
				return r_Falignment;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.Extents lineExtents
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RExtents r_FlineExtents;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RExtents RFlineExtents
		{
			get
			{
				if(r_FlineExtents == null)
				{
					r_FlineExtents = new(this, "lineExtents");
				}
				return r_FlineExtents;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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
