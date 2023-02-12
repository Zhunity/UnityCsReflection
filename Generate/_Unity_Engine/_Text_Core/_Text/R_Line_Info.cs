
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.LineInfo
	/// </summary>
    public partial class RLineInfo : RMember //
    {

		/// <summary>
		/// System.Int32 controlCharacterCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FcontrolCharacterCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFcontrolCharacterCount
		{
			get
			{
				if(r_FcontrolCharacterCount == null)
				{
					r_FcontrolCharacterCount = new(this, "controlCharacterCount");
					r_FcontrolCharacterCount.SetBelong(this.instance);
				}
				return r_FcontrolCharacterCount;
			}
		}

		/// <summary>
		/// System.Int32 characterCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FcharacterCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFcharacterCount
		{
			get
			{
				if(r_FcharacterCount == null)
				{
					r_FcharacterCount = new(this, "characterCount");
					r_FcharacterCount.SetBelong(this.instance);
				}
				return r_FcharacterCount;
			}
		}

		/// <summary>
		/// System.Int32 visibleCharacterCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FvisibleCharacterCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFvisibleCharacterCount
		{
			get
			{
				if(r_FvisibleCharacterCount == null)
				{
					r_FvisibleCharacterCount = new(this, "visibleCharacterCount");
					r_FvisibleCharacterCount.SetBelong(this.instance);
				}
				return r_FvisibleCharacterCount;
			}
		}

		/// <summary>
		/// System.Int32 spaceCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FspaceCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFspaceCount
		{
			get
			{
				if(r_FspaceCount == null)
				{
					r_FspaceCount = new(this, "spaceCount");
					r_FspaceCount.SetBelong(this.instance);
				}
				return r_FspaceCount;
			}
		}

		/// <summary>
		/// System.Int32 visibleSpaceCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FvisibleSpaceCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFvisibleSpaceCount
		{
			get
			{
				if(r_FvisibleSpaceCount == null)
				{
					r_FvisibleSpaceCount = new(this, "visibleSpaceCount");
					r_FvisibleSpaceCount.SetBelong(this.instance);
				}
				return r_FvisibleSpaceCount;
			}
		}

		/// <summary>
		/// System.Int32 wordCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FwordCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFwordCount
		{
			get
			{
				if(r_FwordCount == null)
				{
					r_FwordCount = new(this, "wordCount");
					r_FwordCount.SetBelong(this.instance);
				}
				return r_FwordCount;
			}
		}

		/// <summary>
		/// System.Int32 firstCharacterIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FfirstCharacterIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFfirstCharacterIndex
		{
			get
			{
				if(r_FfirstCharacterIndex == null)
				{
					r_FfirstCharacterIndex = new(this, "firstCharacterIndex");
					r_FfirstCharacterIndex.SetBelong(this.instance);
				}
				return r_FfirstCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 firstVisibleCharacterIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FfirstVisibleCharacterIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFfirstVisibleCharacterIndex
		{
			get
			{
				if(r_FfirstVisibleCharacterIndex == null)
				{
					r_FfirstVisibleCharacterIndex = new(this, "firstVisibleCharacterIndex");
					r_FfirstVisibleCharacterIndex.SetBelong(this.instance);
				}
				return r_FfirstVisibleCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 lastCharacterIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FlastCharacterIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFlastCharacterIndex
		{
			get
			{
				if(r_FlastCharacterIndex == null)
				{
					r_FlastCharacterIndex = new(this, "lastCharacterIndex");
					r_FlastCharacterIndex.SetBelong(this.instance);
				}
				return r_FlastCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 lastVisibleCharacterIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FlastVisibleCharacterIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFlastVisibleCharacterIndex
		{
			get
			{
				if(r_FlastVisibleCharacterIndex == null)
				{
					r_FlastVisibleCharacterIndex = new(this, "lastVisibleCharacterIndex");
					r_FlastVisibleCharacterIndex.SetBelong(this.instance);
				}
				return r_FlastVisibleCharacterIndex;
			}
		}

		/// <summary>
		/// System.Single length
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Flength;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFlength
		{
			get
			{
				if(r_Flength == null)
				{
					r_Flength = new(this, "length");
					r_Flength.SetBelong(this.instance);
				}
				return r_Flength;
			}
		}

		/// <summary>
		/// System.Single lineHeight
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FlineHeight;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFlineHeight
		{
			get
			{
				if(r_FlineHeight == null)
				{
					r_FlineHeight = new(this, "lineHeight");
					r_FlineHeight.SetBelong(this.instance);
				}
				return r_FlineHeight;
			}
		}

		/// <summary>
		/// System.Single ascender
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Fascender;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFascender
		{
			get
			{
				if(r_Fascender == null)
				{
					r_Fascender = new(this, "ascender");
					r_Fascender.SetBelong(this.instance);
				}
				return r_Fascender;
			}
		}

		/// <summary>
		/// System.Single baseline
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Fbaseline;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFbaseline
		{
			get
			{
				if(r_Fbaseline == null)
				{
					r_Fbaseline = new(this, "baseline");
					r_Fbaseline.SetBelong(this.instance);
				}
				return r_Fbaseline;
			}
		}

		/// <summary>
		/// System.Single descender
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Fdescender;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFdescender
		{
			get
			{
				if(r_Fdescender == null)
				{
					r_Fdescender = new(this, "descender");
					r_Fdescender.SetBelong(this.instance);
				}
				return r_Fdescender;
			}
		}

		/// <summary>
		/// System.Single maxAdvance
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FmaxAdvance;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFmaxAdvance
		{
			get
			{
				if(r_FmaxAdvance == null)
				{
					r_FmaxAdvance = new(this, "maxAdvance");
					r_FmaxAdvance.SetBelong(this.instance);
				}
				return r_FmaxAdvance;
			}
		}

		/// <summary>
		/// System.Single width
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Fwidth;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFwidth
		{
			get
			{
				if(r_Fwidth == null)
				{
					r_Fwidth = new(this, "width");
					r_Fwidth.SetBelong(this.instance);
				}
				return r_Fwidth;
			}
		}

		/// <summary>
		/// System.Single marginLeft
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FmarginLeft;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFmarginLeft
		{
			get
			{
				if(r_FmarginLeft == null)
				{
					r_FmarginLeft = new(this, "marginLeft");
					r_FmarginLeft.SetBelong(this.instance);
				}
				return r_FmarginLeft;
			}
		}

		/// <summary>
		/// System.Single marginRight
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FmarginRight;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFmarginRight
		{
			get
			{
				if(r_FmarginRight == null)
				{
					r_FmarginRight = new(this, "marginRight");
					r_FmarginRight.SetBelong(this.instance);
				}
				return r_FmarginRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment alignment
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_Falignment;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFalignment
		{
			get
			{
				if(r_Falignment == null)
				{
					r_Falignment = new(this, "alignment");
					r_Falignment.SetBelong(this.instance);
				}
				return r_Falignment;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.Extents lineExtents
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RExtents r_FlineExtents;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RExtents RFlineExtents
		{
			get
			{
				if(r_FlineExtents == null)
				{
					r_FlineExtents = new(this, "lineExtents");
					r_FlineExtents.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
