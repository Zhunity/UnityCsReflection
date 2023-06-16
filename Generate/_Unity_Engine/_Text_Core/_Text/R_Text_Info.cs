
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.TextCore.Text.TextInfo
	/// </summary>
    public partial class RTextInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextInfo");
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


		/// <summary>
		/// UnityEngine.Vector2 s_InfinityVectorPositive
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fs_InfinityVectorPositive;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFs_InfinityVectorPositive
		{
			get
			{
				if(r_Fs_InfinityVectorPositive == null)
				{
					r_Fs_InfinityVectorPositive = new(Type, "s_InfinityVectorPositive");
				}
				return r_Fs_InfinityVectorPositive;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 s_InfinityVectorNegative
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fs_InfinityVectorNegative;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFs_InfinityVectorNegative
		{
			get
			{
				if(r_Fs_InfinityVectorNegative == null)
				{
					r_Fs_InfinityVectorNegative = new(Type, "s_InfinityVectorNegative");
				}
				return r_Fs_InfinityVectorNegative;
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
		/// System.Int32 spriteCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FspriteCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFspriteCount
		{
			get
			{
				if(r_FspriteCount == null)
				{
					r_FspriteCount = new(this, "spriteCount");
				}
				return r_FspriteCount;
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
		/// System.Int32 linkCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FlinkCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlinkCount
		{
			get
			{
				if(r_FlinkCount == null)
				{
					r_FlinkCount = new(this, "linkCount");
				}
				return r_FlinkCount;
			}
		}

		/// <summary>
		/// System.Int32 lineCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FlineCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlineCount
		{
			get
			{
				if(r_FlineCount == null)
				{
					r_FlineCount = new(this, "lineCount");
				}
				return r_FlineCount;
			}
		}

		/// <summary>
		/// System.Int32 pageCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FpageCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpageCount
		{
			get
			{
				if(r_FpageCount == null)
				{
					r_FpageCount = new(this, "pageCount");
				}
				return r_FpageCount;
			}
		}

		/// <summary>
		/// System.Int32 materialCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FmaterialCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmaterialCount
		{
			get
			{
				if(r_FmaterialCount == null)
				{
					r_FmaterialCount = new(this, "materialCount");
				}
				return r_FmaterialCount;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextElementInfo[] textElementInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextElementInfo> r_FtextElementInfo;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextElementInfo> RFtextElementInfo
		{
			get
			{
				if(r_FtextElementInfo == null)
				{
					r_FtextElementInfo = new(this, "textElementInfo");
				}
				return r_FtextElementInfo;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.WordInfo[] wordInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RWordInfo> r_FwordInfo;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RWordInfo> RFwordInfo
		{
			get
			{
				if(r_FwordInfo == null)
				{
					r_FwordInfo = new(this, "wordInfo");
				}
				return r_FwordInfo;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.LinkInfo[] linkInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RLinkInfo> r_FlinkInfo;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RLinkInfo> RFlinkInfo
		{
			get
			{
				if(r_FlinkInfo == null)
				{
					r_FlinkInfo = new(this, "linkInfo");
				}
				return r_FlinkInfo;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.LineInfo[] lineInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RLineInfo> r_FlineInfo;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RLineInfo> RFlineInfo
		{
			get
			{
				if(r_FlineInfo == null)
				{
					r_FlineInfo = new(this, "lineInfo");
				}
				return r_FlineInfo;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.PageInfo[] pageInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RPageInfo> r_FpageInfo;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RPageInfo> RFpageInfo
		{
			get
			{
				if(r_FpageInfo == null)
				{
					r_FpageInfo = new(this, "pageInfo");
				}
				return r_FpageInfo;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.MeshInfo[] meshInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RMeshInfo> r_FmeshInfo;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RMeshInfo> RFmeshInfo
		{
			get
			{
				if(r_FmeshInfo == null)
				{
					r_FmeshInfo = new(this, "meshInfo");
				}
				return r_FmeshInfo;
			}
		}

		/// <summary>
		/// System.Boolean isDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisDirty
		{
			get
			{
				if(r_FisDirty == null)
				{
					r_FisDirty = new(this, "isDirty");
				}
				return r_FisDirty;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// Void ClearMeshInfo(Boolean)
		/// </summary>
		protected RMethod r_MClearMeshInfo_Boolean;
		public virtual RMethod RMClearMeshInfo_Boolean
		{
			get
			{
				if(r_MClearMeshInfo_Boolean == null)
				{
					r_MClearMeshInfo_Boolean = new(this, "ClearMeshInfo", 0, typeof(System.Boolean));
				}
				return r_MClearMeshInfo_Boolean;
			}
		}

		/// <summary>
		/// Void ClearLineInfo()
		/// </summary>
		protected RMethod r_MClearLineInfo;
		public virtual RMethod RMClearLineInfo
		{
			get
			{
				if(r_MClearLineInfo == null)
				{
					r_MClearLineInfo = new(this, "ClearLineInfo", 0);
				}
				return r_MClearLineInfo;
			}
		}

		/// <summary>
		/// Void ClearPageInfo()
		/// </summary>
		protected RMethod r_MClearPageInfo;
		public virtual RMethod RMClearPageInfo
		{
			get
			{
				if(r_MClearPageInfo == null)
				{
					r_MClearPageInfo = new(this, "ClearPageInfo", 0);
				}
				return r_MClearPageInfo;
			}
		}

		/// <summary>
		/// Void Resize[T](T[] ByRef, Int32)
		/// </summary>
		protected static RMethod r_MResize_GT_Ref_TArray_Int32;
		public static RMethod RMResize_GT_Ref_TArray_Int32
		{
			get
			{
				if(r_MResize_GT_Ref_TArray_Int32 == null)
				{
					r_MResize_GT_Ref_TArray_Int32 = new(Type, "Resize", 1, Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType(), typeof(System.Int32));
				}
				return r_MResize_GT_Ref_TArray_Int32;
			}
		}

		/// <summary>
		/// Void Resize[T](T[] ByRef, Int32, Boolean)
		/// </summary>
		protected static RMethod r_MResize_GT_Ref_TArray_Int32_Boolean;
		public static RMethod RMResize_GT_Ref_TArray_Int32_Boolean
		{
			get
			{
				if(r_MResize_GT_Ref_TArray_Int32_Boolean == null)
				{
					r_MResize_GT_Ref_TArray_Int32_Boolean = new(Type, "Resize", 1, Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType(), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MResize_GT_Ref_TArray_Int32_Boolean;
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


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearMeshInfo(System.Boolean @updateMesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateMesh};
            var ___result = RMClearMeshInfo_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearLineInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearLineInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPageInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearPageInfo.Invoke(___genericsType, ___parameters);

            
        }


        public static void Resize<T>(ref T[] @array, System.Int32 @size)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @size};
            var ___result = RMResize_GT_Ref_TArray_Int32.Invoke(___genericsType, ___parameters);
			@array = ReflectionUtils.Convert<T[]>(___parameters[0]);

            
        }


        public static void Resize<T>(ref T[] @array, System.Int32 @size, System.Boolean @isBlockAllocated)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @size, @isBlockAllocated};
            var ___result = RMResize_GT_Ref_TArray_Int32_Boolean.Invoke(___genericsType, ___parameters);
			@array = ReflectionUtils.Convert<T[]>(___parameters[0]);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
