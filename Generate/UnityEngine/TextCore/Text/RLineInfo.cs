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
		protected RSystem.RInt32 r_controlCharacterCount;
		public virtual RSystem.RInt32 RcontrolCharacterCount
		{
			get
			{
				if(r_controlCharacterCount == null)
				{
					r_controlCharacterCount = new(this, "controlCharacterCount");
					r_controlCharacterCount.SetBelong(this.instance);
				}
				return r_controlCharacterCount;
			}
		}

		/// <summary>
		/// System.Int32 characterCount
		/// </summary>
		protected RSystem.RInt32 r_characterCount;
		public virtual RSystem.RInt32 RcharacterCount
		{
			get
			{
				if(r_characterCount == null)
				{
					r_characterCount = new(this, "characterCount");
					r_characterCount.SetBelong(this.instance);
				}
				return r_characterCount;
			}
		}

		/// <summary>
		/// System.Int32 visibleCharacterCount
		/// </summary>
		protected RSystem.RInt32 r_visibleCharacterCount;
		public virtual RSystem.RInt32 RvisibleCharacterCount
		{
			get
			{
				if(r_visibleCharacterCount == null)
				{
					r_visibleCharacterCount = new(this, "visibleCharacterCount");
					r_visibleCharacterCount.SetBelong(this.instance);
				}
				return r_visibleCharacterCount;
			}
		}

		/// <summary>
		/// System.Int32 spaceCount
		/// </summary>
		protected RSystem.RInt32 r_spaceCount;
		public virtual RSystem.RInt32 RspaceCount
		{
			get
			{
				if(r_spaceCount == null)
				{
					r_spaceCount = new(this, "spaceCount");
					r_spaceCount.SetBelong(this.instance);
				}
				return r_spaceCount;
			}
		}

		/// <summary>
		/// System.Int32 visibleSpaceCount
		/// </summary>
		protected RSystem.RInt32 r_visibleSpaceCount;
		public virtual RSystem.RInt32 RvisibleSpaceCount
		{
			get
			{
				if(r_visibleSpaceCount == null)
				{
					r_visibleSpaceCount = new(this, "visibleSpaceCount");
					r_visibleSpaceCount.SetBelong(this.instance);
				}
				return r_visibleSpaceCount;
			}
		}

		/// <summary>
		/// System.Int32 wordCount
		/// </summary>
		protected RSystem.RInt32 r_wordCount;
		public virtual RSystem.RInt32 RwordCount
		{
			get
			{
				if(r_wordCount == null)
				{
					r_wordCount = new(this, "wordCount");
					r_wordCount.SetBelong(this.instance);
				}
				return r_wordCount;
			}
		}

		/// <summary>
		/// System.Int32 firstCharacterIndex
		/// </summary>
		protected RSystem.RInt32 r_firstCharacterIndex;
		public virtual RSystem.RInt32 RfirstCharacterIndex
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
		/// System.Int32 firstVisibleCharacterIndex
		/// </summary>
		protected RSystem.RInt32 r_firstVisibleCharacterIndex;
		public virtual RSystem.RInt32 RfirstVisibleCharacterIndex
		{
			get
			{
				if(r_firstVisibleCharacterIndex == null)
				{
					r_firstVisibleCharacterIndex = new(this, "firstVisibleCharacterIndex");
					r_firstVisibleCharacterIndex.SetBelong(this.instance);
				}
				return r_firstVisibleCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 lastCharacterIndex
		/// </summary>
		protected RSystem.RInt32 r_lastCharacterIndex;
		public virtual RSystem.RInt32 RlastCharacterIndex
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
		/// System.Int32 lastVisibleCharacterIndex
		/// </summary>
		protected RSystem.RInt32 r_lastVisibleCharacterIndex;
		public virtual RSystem.RInt32 RlastVisibleCharacterIndex
		{
			get
			{
				if(r_lastVisibleCharacterIndex == null)
				{
					r_lastVisibleCharacterIndex = new(this, "lastVisibleCharacterIndex");
					r_lastVisibleCharacterIndex.SetBelong(this.instance);
				}
				return r_lastVisibleCharacterIndex;
			}
		}

		/// <summary>
		/// System.Single length
		/// </summary>
		protected RSystem.RSingle r_length;
		public virtual RSystem.RSingle Rlength
		{
			get
			{
				if(r_length == null)
				{
					r_length = new(this, "length");
					r_length.SetBelong(this.instance);
				}
				return r_length;
			}
		}

		/// <summary>
		/// System.Single lineHeight
		/// </summary>
		protected RSystem.RSingle r_lineHeight;
		public virtual RSystem.RSingle RlineHeight
		{
			get
			{
				if(r_lineHeight == null)
				{
					r_lineHeight = new(this, "lineHeight");
					r_lineHeight.SetBelong(this.instance);
				}
				return r_lineHeight;
			}
		}

		/// <summary>
		/// System.Single ascender
		/// </summary>
		protected RSystem.RSingle r_ascender;
		public virtual RSystem.RSingle Rascender
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
		/// System.Single baseline
		/// </summary>
		protected RSystem.RSingle r_baseline;
		public virtual RSystem.RSingle Rbaseline
		{
			get
			{
				if(r_baseline == null)
				{
					r_baseline = new(this, "baseline");
					r_baseline.SetBelong(this.instance);
				}
				return r_baseline;
			}
		}

		/// <summary>
		/// System.Single descender
		/// </summary>
		protected RSystem.RSingle r_descender;
		public virtual RSystem.RSingle Rdescender
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
		/// System.Single maxAdvance
		/// </summary>
		protected RSystem.RSingle r_maxAdvance;
		public virtual RSystem.RSingle RmaxAdvance
		{
			get
			{
				if(r_maxAdvance == null)
				{
					r_maxAdvance = new(this, "maxAdvance");
					r_maxAdvance.SetBelong(this.instance);
				}
				return r_maxAdvance;
			}
		}

		/// <summary>
		/// System.Single width
		/// </summary>
		protected RSystem.RSingle r_width;
		public virtual RSystem.RSingle Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width");
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// System.Single marginLeft
		/// </summary>
		protected RSystem.RSingle r_marginLeft;
		public virtual RSystem.RSingle RmarginLeft
		{
			get
			{
				if(r_marginLeft == null)
				{
					r_marginLeft = new(this, "marginLeft");
					r_marginLeft.SetBelong(this.instance);
				}
				return r_marginLeft;
			}
		}

		/// <summary>
		/// System.Single marginRight
		/// </summary>
		protected RSystem.RSingle r_marginRight;
		public virtual RSystem.RSingle RmarginRight
		{
			get
			{
				if(r_marginRight == null)
				{
					r_marginRight = new(this, "marginRight");
					r_marginRight.SetBelong(this.instance);
				}
				return r_marginRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment alignment
		/// </summary>
		protected RField r_alignment;
		public virtual RField Ralignment
		{
			get
			{
				if(r_alignment == null)
				{
					r_alignment = new(this, "alignment");
					r_alignment.SetBelong(this.instance);
				}
				return r_alignment;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.Extents lineExtents
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RExtents r_lineExtents;
		public virtual RUnityEngine.RTextCore.RText.RExtents RlineExtents
		{
			get
			{
				if(r_lineExtents == null)
				{
					r_lineExtents = new(this, "lineExtents");
					r_lineExtents.SetBelong(this.instance);
				}
				return r_lineExtents;
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
