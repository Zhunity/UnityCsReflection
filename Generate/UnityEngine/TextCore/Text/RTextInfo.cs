using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextInfo
	/// </summary>
    public partial class RTextInfo : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector2 s_InfinityVectorPositive
		/// </summary>
		protected static RUnityEngine.RVector2 r_s_InfinityVectorPositive;
		public static RUnityEngine.RVector2 Rs_InfinityVectorPositive
		{
			get
			{
				if(r_s_InfinityVectorPositive == null)
				{
					r_s_InfinityVectorPositive = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"), "s_InfinityVectorPositive");
					r_s_InfinityVectorPositive.SetBelong(null);
				}
				return r_s_InfinityVectorPositive;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 s_InfinityVectorNegative
		/// </summary>
		protected static RUnityEngine.RVector2 r_s_InfinityVectorNegative;
		public static RUnityEngine.RVector2 Rs_InfinityVectorNegative
		{
			get
			{
				if(r_s_InfinityVectorNegative == null)
				{
					r_s_InfinityVectorNegative = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"), "s_InfinityVectorNegative");
					r_s_InfinityVectorNegative.SetBelong(null);
				}
				return r_s_InfinityVectorNegative;
			}
		}

		/// <summary>
		/// System.Int32 characterCount
		/// </summary>
		protected RField r_characterCount;
		public virtual RField RcharacterCount
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
		/// System.Int32 spriteCount
		/// </summary>
		protected RField r_spriteCount;
		public virtual RField RspriteCount
		{
			get
			{
				if(r_spriteCount == null)
				{
					r_spriteCount = new(this, "spriteCount");
					r_spriteCount.SetBelong(this.instance);
				}
				return r_spriteCount;
			}
		}

		/// <summary>
		/// System.Int32 spaceCount
		/// </summary>
		protected RField r_spaceCount;
		public virtual RField RspaceCount
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
		/// System.Int32 wordCount
		/// </summary>
		protected RField r_wordCount;
		public virtual RField RwordCount
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
		/// System.Int32 linkCount
		/// </summary>
		protected RField r_linkCount;
		public virtual RField RlinkCount
		{
			get
			{
				if(r_linkCount == null)
				{
					r_linkCount = new(this, "linkCount");
					r_linkCount.SetBelong(this.instance);
				}
				return r_linkCount;
			}
		}

		/// <summary>
		/// System.Int32 lineCount
		/// </summary>
		protected RField r_lineCount;
		public virtual RField RlineCount
		{
			get
			{
				if(r_lineCount == null)
				{
					r_lineCount = new(this, "lineCount");
					r_lineCount.SetBelong(this.instance);
				}
				return r_lineCount;
			}
		}

		/// <summary>
		/// System.Int32 pageCount
		/// </summary>
		protected RField r_pageCount;
		public virtual RField RpageCount
		{
			get
			{
				if(r_pageCount == null)
				{
					r_pageCount = new(this, "pageCount");
					r_pageCount.SetBelong(this.instance);
				}
				return r_pageCount;
			}
		}

		/// <summary>
		/// System.Int32 materialCount
		/// </summary>
		protected RField r_materialCount;
		public virtual RField RmaterialCount
		{
			get
			{
				if(r_materialCount == null)
				{
					r_materialCount = new(this, "materialCount");
					r_materialCount.SetBelong(this.instance);
				}
				return r_materialCount;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextElementInfo[] textElementInfo
		/// </summary>
		protected RFieldArray<RUnityEngine.RTextCore.RText.RTextElementInfo> r_textElementInfo;
		public virtual RFieldArray<RUnityEngine.RTextCore.RText.RTextElementInfo> RtextElementInfo
		{
			get
			{
				if(r_textElementInfo == null)
				{
					r_textElementInfo = new(this, "textElementInfo");
					r_textElementInfo.SetBelong(this.instance);
				}
				return r_textElementInfo;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.WordInfo[] wordInfo
		/// </summary>
		protected RFieldArray<RUnityEngine.RTextCore.RText.RWordInfo> r_wordInfo;
		public virtual RFieldArray<RUnityEngine.RTextCore.RText.RWordInfo> RwordInfo
		{
			get
			{
				if(r_wordInfo == null)
				{
					r_wordInfo = new(this, "wordInfo");
					r_wordInfo.SetBelong(this.instance);
				}
				return r_wordInfo;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.LinkInfo[] linkInfo
		/// </summary>
		protected RFieldArray<RUnityEngine.RTextCore.RText.RLinkInfo> r_linkInfo;
		public virtual RFieldArray<RUnityEngine.RTextCore.RText.RLinkInfo> RlinkInfo
		{
			get
			{
				if(r_linkInfo == null)
				{
					r_linkInfo = new(this, "linkInfo");
					r_linkInfo.SetBelong(this.instance);
				}
				return r_linkInfo;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.LineInfo[] lineInfo
		/// </summary>
		protected RFieldArray<RUnityEngine.RTextCore.RText.RLineInfo> r_lineInfo;
		public virtual RFieldArray<RUnityEngine.RTextCore.RText.RLineInfo> RlineInfo
		{
			get
			{
				if(r_lineInfo == null)
				{
					r_lineInfo = new(this, "lineInfo");
					r_lineInfo.SetBelong(this.instance);
				}
				return r_lineInfo;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.PageInfo[] pageInfo
		/// </summary>
		protected RFieldArray<RUnityEngine.RTextCore.RText.RPageInfo> r_pageInfo;
		public virtual RFieldArray<RUnityEngine.RTextCore.RText.RPageInfo> RpageInfo
		{
			get
			{
				if(r_pageInfo == null)
				{
					r_pageInfo = new(this, "pageInfo");
					r_pageInfo.SetBelong(this.instance);
				}
				return r_pageInfo;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.MeshInfo[] meshInfo
		/// </summary>
		protected RFieldArray<RUnityEngine.RTextCore.RText.RMeshInfo> r_meshInfo;
		public virtual RFieldArray<RUnityEngine.RTextCore.RText.RMeshInfo> RmeshInfo
		{
			get
			{
				if(r_meshInfo == null)
				{
					r_meshInfo = new(this, "meshInfo");
					r_meshInfo.SetBelong(this.instance);
				}
				return r_meshInfo;
			}
		}

		/// <summary>
		/// System.Boolean isDirty
		/// </summary>
		protected RField r_isDirty;
		public virtual RField RisDirty
		{
			get
			{
				if(r_isDirty == null)
				{
					r_isDirty = new(this, "isDirty");
					r_isDirty.SetBelong(this.instance);
				}
				return r_isDirty;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// Void ClearMeshInfo(Boolean)
		/// </summary>
		protected RMethod r_RClearMeshInfo_Boolean;
		public virtual RMethod RClearMeshInfo_Boolean
		{
			get
			{
				if(r_RClearMeshInfo_Boolean == null)
				{
					r_RClearMeshInfo_Boolean = new(this, "ClearMeshInfo", 0, typeof(System.Boolean));
					r_RClearMeshInfo_Boolean.SetBelong(this.instance);
				}
				return r_RClearMeshInfo_Boolean;
			}
		}

		/// <summary>
		/// Void ClearLineInfo()
		/// </summary>
		protected RMethod r_RClearLineInfo;
		public virtual RMethod RClearLineInfo
		{
			get
			{
				if(r_RClearLineInfo == null)
				{
					r_RClearLineInfo = new(this, "ClearLineInfo", 0);
					r_RClearLineInfo.SetBelong(this.instance);
				}
				return r_RClearLineInfo;
			}
		}

		/// <summary>
		/// Void ClearPageInfo()
		/// </summary>
		protected RMethod r_RClearPageInfo;
		public virtual RMethod RClearPageInfo
		{
			get
			{
				if(r_RClearPageInfo == null)
				{
					r_RClearPageInfo = new(this, "ClearPageInfo", 0);
					r_RClearPageInfo.SetBelong(this.instance);
				}
				return r_RClearPageInfo;
			}
		}

		/// <summary>
		/// Void Resize[T](T[] ByRef, Int32)
		/// </summary>
		protected static RMethod r_RResize_GT_Ref_TArray_Int32;
		public static RMethod RResize_GT_Ref_TArray_Int32
		{
			get
			{
				if(r_RResize_GT_Ref_TArray_Int32 == null)
				{
					r_RResize_GT_Ref_TArray_Int32 = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"), "Resize", 1, Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType(), typeof(System.Int32));
					r_RResize_GT_Ref_TArray_Int32.SetBelong(null);
				}
				return r_RResize_GT_Ref_TArray_Int32;
			}
		}

		/// <summary>
		/// Void Resize[T](T[] ByRef, Int32, Boolean)
		/// </summary>
		protected static RMethod r_RResize_GT_Ref_TArray_Int32_Boolean;
		public static RMethod RResize_GT_Ref_TArray_Int32_Boolean
		{
			get
			{
				if(r_RResize_GT_Ref_TArray_Int32_Boolean == null)
				{
					r_RResize_GT_Ref_TArray_Int32_Boolean = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"), "Resize", 1, Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType(), typeof(System.Int32), typeof(System.Boolean));
					r_RResize_GT_Ref_TArray_Int32_Boolean.SetBelong(null);
				}
				return r_RResize_GT_Ref_TArray_Int32_Boolean;
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


        public RTextInfo() : base("UnityEngine.TextCore.Text.TextInfo")
        {
        }

        public RTextInfo(System.Object instance) : base("UnityEngine.TextCore.Text.TextInfo")
		{
            SetInstance(instance);
		}

        public RTextInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearMeshInfo(System.Boolean  @updateMesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateMesh};
            var ___result = RClearMeshInfo_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearLineInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearLineInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPageInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearPageInfo.Invoke(___genericsType, ___parameters);

            
        }


        public static void Resize<T>(ref T[]  @array, System.Int32  @size)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @size};
            var ___result = RResize_GT_Ref_TArray_Int32.Invoke(___genericsType, ___parameters);
			array = (T[])___parameters[0];

            
        }


        public static void Resize<T>(ref T[]  @array, System.Int32  @size, System.Boolean  @isBlockAllocated)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @size, @isBlockAllocated};
            var ___result = RResize_GT_Ref_TArray_Int32_Boolean.Invoke(___genericsType, ___parameters);
			array = (T[])___parameters[0];

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
