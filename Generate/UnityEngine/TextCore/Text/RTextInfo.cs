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
					r_s_InfinityVectorPositive = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"), "s_InfinityVectorPositive");
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
					r_s_InfinityVectorNegative = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"), "s_InfinityVectorNegative");
					r_s_InfinityVectorNegative.SetBelong(null);
				}
				return r_s_InfinityVectorNegative;
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
		/// System.Int32 spriteCount
		/// </summary>
		protected RSystem.RInt32 r_spriteCount;
		public virtual RSystem.RInt32 RspriteCount
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
		/// System.Int32 linkCount
		/// </summary>
		protected RSystem.RInt32 r_linkCount;
		public virtual RSystem.RInt32 RlinkCount
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
		protected RSystem.RInt32 r_lineCount;
		public virtual RSystem.RInt32 RlineCount
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
		protected RSystem.RInt32 r_pageCount;
		public virtual RSystem.RInt32 RpageCount
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
		protected RSystem.RInt32 r_materialCount;
		public virtual RSystem.RInt32 RmaterialCount
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
		protected RSystem.RBoolean r_isDirty;
		public virtual RSystem.RBoolean RisDirty
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
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// Void ClearMeshInfo(Boolean)
		/// </summary>
		protected RMethod r_ClearMeshInfo_Boolean;
		public virtual RMethod RClearMeshInfo_Boolean
		{
			get
			{
				if(r_ClearMeshInfo_Boolean == null)
				{
					r_ClearMeshInfo_Boolean = new(this, "ClearMeshInfo", 0, typeof(System.Boolean));
					r_ClearMeshInfo_Boolean.SetBelong(this.instance);
				}
				return r_ClearMeshInfo_Boolean;
			}
		}

		/// <summary>
		/// Void ClearLineInfo()
		/// </summary>
		protected RMethod r_ClearLineInfo;
		public virtual RMethod RClearLineInfo
		{
			get
			{
				if(r_ClearLineInfo == null)
				{
					r_ClearLineInfo = new(this, "ClearLineInfo", 0);
					r_ClearLineInfo.SetBelong(this.instance);
				}
				return r_ClearLineInfo;
			}
		}

		/// <summary>
		/// Void ClearPageInfo()
		/// </summary>
		protected RMethod r_ClearPageInfo;
		public virtual RMethod RClearPageInfo
		{
			get
			{
				if(r_ClearPageInfo == null)
				{
					r_ClearPageInfo = new(this, "ClearPageInfo", 0);
					r_ClearPageInfo.SetBelong(this.instance);
				}
				return r_ClearPageInfo;
			}
		}

		/// <summary>
		/// Void Resize[T](T[] ByRef, Int32)
		/// </summary>
		protected static RMethod r_Resize_GT_Ref_TArray_Int32;
		public static RMethod RResize_GT_Ref_TArray_Int32
		{
			get
			{
				if(r_Resize_GT_Ref_TArray_Int32 == null)
				{
					r_Resize_GT_Ref_TArray_Int32 = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"), "Resize", 1, Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType(), typeof(System.Int32));
					r_Resize_GT_Ref_TArray_Int32.SetBelong(null);
				}
				return r_Resize_GT_Ref_TArray_Int32;
			}
		}

		/// <summary>
		/// Void Resize[T](T[] ByRef, Int32, Boolean)
		/// </summary>
		protected static RMethod r_Resize_GT_Ref_TArray_Int32_Boolean;
		public static RMethod RResize_GT_Ref_TArray_Int32_Boolean
		{
			get
			{
				if(r_Resize_GT_Ref_TArray_Int32_Boolean == null)
				{
					r_Resize_GT_Ref_TArray_Int32_Boolean = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"), "Resize", 1, Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType(), typeof(System.Int32), typeof(System.Boolean));
					r_Resize_GT_Ref_TArray_Int32_Boolean.SetBelong(null);
				}
				return r_Resize_GT_Ref_TArray_Int32_Boolean;
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


        public virtual void ClearMeshInfo(System.Boolean @updateMesh)
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


        public static void Resize<T>(ref T[] @array, System.Int32 @size)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @size};
            var ___result = RResize_GT_Ref_TArray_Int32.Invoke(___genericsType, ___parameters);
			@array = (T[])___parameters[0];

            
        }


        public static void Resize<T>(ref T[] @array, System.Int32 @size, System.Boolean @isBlockAllocated)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @size, @isBlockAllocated};
            var ___result = RResize_GT_Ref_TArray_Int32_Boolean.Invoke(___genericsType, ___parameters);
			@array = (T[])___parameters[0];

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
