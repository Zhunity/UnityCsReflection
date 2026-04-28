
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.TextHandle
	/// </summary>
    public partial class RTextHandle : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.TextHandle");
            }
        }

        public RTextHandle() : base("UnityEngine.UIElements.TextHandle")
        {
        }

        public RTextHandle(System.Object instance) : base("UnityEngine.UIElements.TextHandle")
		{
            SetInstance(instance);
		}

        public RTextHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.ITextHandle textHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RITextHandle r_FtextHandle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RITextHandle RFtextHandle
		{
			get
			{
				if(r_FtextHandle == null)
				{
					r_FtextHandle = new(this, "textHandle");
				}
				return r_FtextHandle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 MeasuredSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PMeasuredSizes;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPMeasuredSizes
		{
			get
			{
				if(r_PMeasuredSizes == null)
				{
					r_PMeasuredSizes = new(this, "MeasuredSizes", -1);
				}
				return r_PMeasuredSizes;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 RoundedSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PRoundedSizes;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPRoundedSizes
		{
			get
			{
				if(r_PRoundedSizes == null)
				{
					r_PRoundedSizes = new(this, "RoundedSizes", -1);
				}
				return r_PRoundedSizes;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters, Single)
		/// </summary>
		protected RMethod r_MGetCursorPosition_CursorPositionStylePainterParameters_Single;
		public virtual RMethod RMGetCursorPosition_CursorPositionStylePainterParameters_Single
		{
			get
			{
				if(r_MGetCursorPosition_CursorPositionStylePainterParameters_Single == null)
				{
					r_MGetCursorPosition_CursorPositionStylePainterParameters_Single = new(this, "GetCursorPosition", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CursorPositionStylePainterParameters"), typeof(System.Single));
				}
				return r_MGetCursorPosition_CursorPositionStylePainterParameters_Single;
			}
		}

		/// <summary>
		/// Single GetLineHeight(Int32, TextParams, Single, Single)
		/// </summary>
		protected RMethod r_MGetLineHeight_Int32_TextParams_Single_Single;
		public virtual RMethod RMGetLineHeight_Int32_TextParams_Single_Single
		{
			get
			{
				if(r_MGetLineHeight_Int32_TextParams_Single_Single == null)
				{
					r_MGetLineHeight_Int32_TextParams_Single_Single = new(this, "GetLineHeight", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+TextParams"), typeof(System.Single), typeof(System.Single));
				}
				return r_MGetLineHeight_Int32_TextParams_Single_Single;
			}
		}

		/// <summary>
		/// Single ComputeTextWidth(TextParams, Single)
		/// </summary>
		protected RMethod r_MComputeTextWidth_TextParams_Single;
		public virtual RMethod RMComputeTextWidth_TextParams_Single
		{
			get
			{
				if(r_MComputeTextWidth_TextParams_Single == null)
				{
					r_MComputeTextWidth_TextParams_Single = new(this, "ComputeTextWidth", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+TextParams"), typeof(System.Single));
				}
				return r_MComputeTextWidth_TextParams_Single;
			}
		}

		/// <summary>
		/// Single ComputeTextHeight(TextParams, Single)
		/// </summary>
		protected RMethod r_MComputeTextHeight_TextParams_Single;
		public virtual RMethod RMComputeTextHeight_TextParams_Single
		{
			get
			{
				if(r_MComputeTextHeight_TextParams_Single == null)
				{
					r_MComputeTextHeight_TextParams_Single = new(this, "ComputeTextHeight", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+TextParams"), typeof(System.Single));
				}
				return r_MComputeTextHeight_TextParams_Single;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo Update(TextParams, Single)
		/// </summary>
		protected RMethod r_MUpdate_TextParams_Single;
		public virtual RMethod RMUpdate_TextParams_Single
		{
			get
			{
				if(r_MUpdate_TextParams_Single == null)
				{
					r_MUpdate_TextParams_Single = new(this, "Update", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+TextParams"), typeof(System.Single));
				}
				return r_MUpdate_TextParams_Single;
			}
		}

		/// <summary>
		/// Int32 VerticesCount(TextParams, Single)
		/// </summary>
		protected RMethod r_MVerticesCount_TextParams_Single;
		public virtual RMethod RMVerticesCount_TextParams_Single
		{
			get
			{
				if(r_MVerticesCount_TextParams_Single == null)
				{
					r_MVerticesCount_TextParams_Single = new(this, "VerticesCount", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+TextParams"), typeof(System.Single));
				}
				return r_MVerticesCount_TextParams_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ITextHandle New()
		/// </summary>
		protected RMethod r_MNew;
		public virtual RMethod RMNew
		{
			get
			{
				if(r_MNew == null)
				{
					r_MNew = new(this, "New", 0);
				}
				return r_MNew;
			}
		}

		/// <summary>
		/// Boolean IsLegacy()
		/// </summary>
		protected RMethod r_MIsLegacy;
		public virtual RMethod RMIsLegacy
		{
			get
			{
				if(r_MIsLegacy == null)
				{
					r_MIsLegacy = new(this, "IsLegacy", 0);
				}
				return r_MIsLegacy;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
				}
				return r_MSetDirty;
			}
		}

		/// <summary>
		/// Boolean IsElided()
		/// </summary>
		protected RMethod r_MIsElided;
		public virtual RMethod RMIsElided
		{
			get
			{
				if(r_MIsElided == null)
				{
					r_MIsElided = new(this, "IsElided", 0);
				}
				return r_MIsElided;
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


        public virtual UnityEngine.Vector2 GetCursorPosition(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCursorPositionStylePainterParameters @parms, System.Single @scaling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parms.Value, @scaling};
            var ___result = RMGetCursorPosition_CursorPositionStylePainterParameters_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual System.Single GetLineHeight(System.Int32 @characterIndex, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RTextParams @textParams, System.Single @textScaling, System.Single @pixelPerPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characterIndex, @textParams.Value, @textScaling, @pixelPerPoint};
            var ___result = RMGetLineHeight_Int32_TextParams_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Single ComputeTextWidth(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RTextParams @parms, System.Single @scaling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parms.Value, @scaling};
            var ___result = RMComputeTextWidth_TextParams_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Single ComputeTextHeight(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RTextParams @parms, System.Single @scaling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parms.Value, @scaling};
            var ___result = RMComputeTextHeight_TextParams_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo Update(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RTextParams @parms, System.Single @pixelsPerPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parms.Value, @pixelsPerPoint};
            var ___result = RMUpdate_TextParams_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo>(___result);
        }


        public virtual System.Int32 VerticesCount(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RTextParams @parms, System.Single @pixelPerPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parms.Value, @pixelPerPoint};
            var ___result = RMVerticesCount_TextParams_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RITextHandle New()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNew.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RITextHandle>(___result);
        }


        public virtual System.Boolean IsLegacy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsLegacy.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsElided()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsElided.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
