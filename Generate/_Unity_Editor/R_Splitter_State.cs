
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.SplitterState
	/// </summary>
    public partial class RSplitterState : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.SplitterState");
            }
        }

        public RSplitterState() : base("UnityEditor.SplitterState")
        {
        }

        public RSplitterState(System.Object instance) : base("UnityEditor.SplitterState")
		{
            SetInstance(instance);
		}

        public RSplitterState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSplitterState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 defaultSplitSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FdefaultSplitSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFdefaultSplitSize
		{
			get
			{
				if(r_FdefaultSplitSize == null)
				{
					r_FdefaultSplitSize = new(Type, "defaultSplitSize");
				}
				return r_FdefaultSplitSize;
			}
		}

		/// <summary>
		/// System.Int32 ID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFID
		{
			get
			{
				if(r_FID == null)
				{
					r_FID = new(this, "ID");
				}
				return r_FID;
			}
		}

		/// <summary>
		/// System.Single splitterInitialOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FsplitterInitialOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFsplitterInitialOffset
		{
			get
			{
				if(r_FsplitterInitialOffset == null)
				{
					r_FsplitterInitialOffset = new(this, "splitterInitialOffset");
				}
				return r_FsplitterInitialOffset;
			}
		}

		/// <summary>
		/// System.Int32 currentActiveSplitter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcurrentActiveSplitter;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrentActiveSplitter
		{
			get
			{
				if(r_FcurrentActiveSplitter == null)
				{
					r_FcurrentActiveSplitter = new(this, "currentActiveSplitter");
				}
				return r_FcurrentActiveSplitter;
			}
		}

		/// <summary>
		/// System.Single[] realSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RSingle> r_FrealSizes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RSingle> RFrealSizes
		{
			get
			{
				if(r_FrealSizes == null)
				{
					r_FrealSizes = new(this, "realSizes");
				}
				return r_FrealSizes;
			}
		}

		/// <summary>
		/// System.Single[] relativeSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RSingle> r_FrelativeSizes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RSingle> RFrelativeSizes
		{
			get
			{
				if(r_FrelativeSizes == null)
				{
					r_FrelativeSizes = new(this, "relativeSizes");
				}
				return r_FrelativeSizes;
			}
		}

		/// <summary>
		/// System.Single[] minSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RSingle> r_FminSizes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RSingle> RFminSizes
		{
			get
			{
				if(r_FminSizes == null)
				{
					r_FminSizes = new(this, "minSizes");
				}
				return r_FminSizes;
			}
		}

		/// <summary>
		/// System.Single[] maxSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RSingle> r_FmaxSizes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RSingle> RFmaxSizes
		{
			get
			{
				if(r_FmaxSizes == null)
				{
					r_FmaxSizes = new(this, "maxSizes");
				}
				return r_FmaxSizes;
			}
		}

		/// <summary>
		/// System.Single lastTotalSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FlastTotalSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFlastTotalSize
		{
			get
			{
				if(r_FlastTotalSize == null)
				{
					r_FlastTotalSize = new(this, "lastTotalSize");
				}
				return r_FlastTotalSize;
			}
		}

		/// <summary>
		/// System.Single splitSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FsplitSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFsplitSize
		{
			get
			{
				if(r_FsplitSize == null)
				{
					r_FsplitSize = new(this, "splitSize");
				}
				return r_FsplitSize;
			}
		}

		/// <summary>
		/// System.Single xOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FxOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFxOffset
		{
			get
			{
				if(r_FxOffset == null)
				{
					r_FxOffset = new(this, "xOffset");
				}
				return r_FxOffset;
			}
		}

		/// <summary>
		/// System.Int32 m_Version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Version;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Version
		{
			get
			{
				if(r_Fm_Version == null)
				{
					r_Fm_Version = new(this, "m_Version");
				}
				return r_Fm_Version;
			}
		}

		/// <summary>
		/// System.Int32[] oldRealSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FoldRealSizes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFoldRealSizes
		{
			get
			{
				if(r_FoldRealSizes == null)
				{
					r_FoldRealSizes = new(this, "oldRealSizes");
				}
				return r_FoldRealSizes;
			}
		}

		/// <summary>
		/// System.Int32[] oldMinSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FoldMinSizes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFoldMinSizes
		{
			get
			{
				if(r_FoldMinSizes == null)
				{
					r_FoldMinSizes = new(this, "oldMinSizes");
				}
				return r_FoldMinSizes;
			}
		}

		/// <summary>
		/// System.Int32[] oldMaxSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FoldMaxSizes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFoldMaxSizes
		{
			get
			{
				if(r_FoldMaxSizes == null)
				{
					r_FoldMaxSizes = new(this, "oldMaxSizes");
				}
				return r_FoldMaxSizes;
			}
		}

		/// <summary>
		/// System.Int32 oldSplitSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FoldSplitSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFoldSplitSize
		{
			get
			{
				if(r_FoldSplitSize == null)
				{
					r_FoldSplitSize = new(this, "oldSplitSize");
				}
				return r_FoldSplitSize;
			}
		}

		/// <summary>
		/// System.Converter`2[System.Int32,System.Single] s_ConverterDelegate
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RConverter<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RSingle> r_Fs_ConverterDelegate;
		public static Hvak.Editor.Refleaction.RSystem.RConverter<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RSingle> RFs_ConverterDelegate
		{
			get
			{
				if(r_Fs_ConverterDelegate == null)
				{
					r_Fs_ConverterDelegate = new(Type, "s_ConverterDelegate");
				}
				return r_Fs_ConverterDelegate;
			}
		}

		/// <summary>
		/// Single CastIntToFloat(Int32)
		/// </summary>
		protected static RMethod r_MCastIntToFloat_Int32;
		public static RMethod RMCastIntToFloat_Int32
		{
			get
			{
				if(r_MCastIntToFloat_Int32 == null)
				{
					r_MCastIntToFloat_Int32 = new(Type, "CastIntToFloat", 0, typeof(System.Int32));
				}
				return r_MCastIntToFloat_Int32;
			}
		}

		/// <summary>
		/// UnityEditor.SplitterState FromAbsolute(Single[], Single[], Single[])
		/// </summary>
		protected static RMethod r_MFromAbsolute_SingleArray_SingleArray_SingleArray;
		public static RMethod RMFromAbsolute_SingleArray_SingleArray_SingleArray
		{
			get
			{
				if(r_MFromAbsolute_SingleArray_SingleArray_SingleArray == null)
				{
					r_MFromAbsolute_SingleArray_SingleArray_SingleArray = new(Type, "FromAbsolute", 0, typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType());
				}
				return r_MFromAbsolute_SingleArray_SingleArray_SingleArray;
			}
		}

		/// <summary>
		/// UnityEditor.SplitterState FromRelative(Single[])
		/// </summary>
		protected static RMethod r_MFromRelative_SingleArray;
		public static RMethod RMFromRelative_SingleArray
		{
			get
			{
				if(r_MFromRelative_SingleArray == null)
				{
					r_MFromRelative_SingleArray = new(Type, "FromRelative", 0, typeof(System.Single).MakeArrayType());
				}
				return r_MFromRelative_SingleArray;
			}
		}

		/// <summary>
		/// UnityEditor.SplitterState FromRelative(Single[], Single[], Single[])
		/// </summary>
		protected static RMethod r_MFromRelative_SingleArray_SingleArray_SingleArray;
		public static RMethod RMFromRelative_SingleArray_SingleArray_SingleArray
		{
			get
			{
				if(r_MFromRelative_SingleArray_SingleArray_SingleArray == null)
				{
					r_MFromRelative_SingleArray_SingleArray_SingleArray = new(Type, "FromRelative", 0, typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType());
				}
				return r_MFromRelative_SingleArray_SingleArray_SingleArray;
			}
		}

		/// <summary>
		/// UnityEditor.SplitterState FromRelative(Single[], Single[], Single[], Int32)
		/// </summary>
		protected static RMethod r_MFromRelative_SingleArray_SingleArray_SingleArray_Int32;
		public static RMethod RMFromRelative_SingleArray_SingleArray_SingleArray_Int32
		{
			get
			{
				if(r_MFromRelative_SingleArray_SingleArray_SingleArray_Int32 == null)
				{
					r_MFromRelative_SingleArray_SingleArray_SingleArray_Int32 = new(Type, "FromRelative", 0, typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
				}
				return r_MFromRelative_SingleArray_SingleArray_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Boolean IsValid()
		/// </summary>
		protected RMethod r_MIsValid;
		public virtual RMethod RMIsValid
		{
			get
			{
				if(r_MIsValid == null)
				{
					r_MIsValid = new(this, "IsValid", 0);
				}
				return r_MIsValid;
			}
		}

		/// <summary>
		/// Void InitFromAbsolute(Single[], Single[], Single[])
		/// </summary>
		protected RMethod r_MInitFromAbsolute_SingleArray_SingleArray_SingleArray;
		public virtual RMethod RMInitFromAbsolute_SingleArray_SingleArray_SingleArray
		{
			get
			{
				if(r_MInitFromAbsolute_SingleArray_SingleArray_SingleArray == null)
				{
					r_MInitFromAbsolute_SingleArray_SingleArray_SingleArray = new(this, "InitFromAbsolute", 0, typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType());
				}
				return r_MInitFromAbsolute_SingleArray_SingleArray_SingleArray;
			}
		}

		/// <summary>
		/// Void InitFromRelative(Single[], Single[], Single[], Int32)
		/// </summary>
		protected RMethod r_MInitFromRelative_SingleArray_SingleArray_SingleArray_Int32;
		public virtual RMethod RMInitFromRelative_SingleArray_SingleArray_SingleArray_Int32
		{
			get
			{
				if(r_MInitFromRelative_SingleArray_SingleArray_SingleArray_Int32 == null)
				{
					r_MInitFromRelative_SingleArray_SingleArray_SingleArray_Int32 = new(this, "InitFromRelative", 0, typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
				}
				return r_MInitFromRelative_SingleArray_SingleArray_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void NormalizeRelativeSizes()
		/// </summary>
		protected RMethod r_MNormalizeRelativeSizes;
		public virtual RMethod RMNormalizeRelativeSizes
		{
			get
			{
				if(r_MNormalizeRelativeSizes == null)
				{
					r_MNormalizeRelativeSizes = new(this, "NormalizeRelativeSizes", 0);
				}
				return r_MNormalizeRelativeSizes;
			}
		}

		/// <summary>
		/// Void RealToRelativeSizes()
		/// </summary>
		protected RMethod r_MRealToRelativeSizes;
		public virtual RMethod RMRealToRelativeSizes
		{
			get
			{
				if(r_MRealToRelativeSizes == null)
				{
					r_MRealToRelativeSizes = new(this, "RealToRelativeSizes", 0);
				}
				return r_MRealToRelativeSizes;
			}
		}

		/// <summary>
		/// Void RelativeToRealSizes(Single)
		/// </summary>
		protected RMethod r_MRelativeToRealSizes_Single;
		public virtual RMethod RMRelativeToRealSizes_Single
		{
			get
			{
				if(r_MRelativeToRealSizes_Single == null)
				{
					r_MRelativeToRealSizes_Single = new(this, "RelativeToRealSizes", 0, typeof(System.Single));
				}
				return r_MRelativeToRealSizes_Single;
			}
		}

		/// <summary>
		/// Void DoSplitter(Int32, Int32, Single)
		/// </summary>
		protected RMethod r_MDoSplitter_Int32_Int32_Single;
		public virtual RMethod RMDoSplitter_Int32_Int32_Single
		{
			get
			{
				if(r_MDoSplitter_Int32_Int32_Single == null)
				{
					r_MDoSplitter_Int32_Int32_Single = new(this, "DoSplitter", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Single));
				}
				return r_MDoSplitter_Int32_Int32_Single;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void ConvertOldArray(Int32[], Single[] ByRef)
		/// </summary>
		protected static RMethod r_MConvertOldArray_Int32Array_Ref_SingleArray;
		public static RMethod RMConvertOldArray_Int32Array_Ref_SingleArray
		{
			get
			{
				if(r_MConvertOldArray_Int32Array_Ref_SingleArray == null)
				{
					r_MConvertOldArray_Int32Array_Ref_SingleArray = new(Type, "ConvertOldArray", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Single).MakeArrayType().MakeByRefType());
				}
				return r_MConvertOldArray_Int32Array_Ref_SingleArray;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
				}
				return r_MOnAfterDeserialize;
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


        public static System.Single CastIntToFloat(System.Int32 @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RMCastIntToFloat_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEditor.RSplitterState FromAbsolute(System.Single[] @realSizes, System.Single[] @minSizes, System.Single[] @maxSizes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@realSizes, @minSizes, @maxSizes};
            var ___result = RMFromAbsolute_SingleArray_SingleArray_SingleArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RSplitterState>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEditor.RSplitterState FromRelative(System.Single[] @relativeSizes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeSizes};
            var ___result = RMFromRelative_SingleArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RSplitterState>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEditor.RSplitterState FromRelative(System.Single[] @relativeSizes, System.Single[] @minSizes, System.Single[] @maxSizes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeSizes, @minSizes, @maxSizes};
            var ___result = RMFromRelative_SingleArray_SingleArray_SingleArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RSplitterState>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEditor.RSplitterState FromRelative(System.Single[] @relativeSizes, System.Single[] @minSizes, System.Single[] @maxSizes, System.Int32 @splitSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeSizes, @minSizes, @maxSizes, @splitSize};
            var ___result = RMFromRelative_SingleArray_SingleArray_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RSplitterState>(___result);
        }


        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsValid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void InitFromAbsolute(System.Single[] @realSizes, System.Single[] @minSizes, System.Single[] @maxSizes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@realSizes, @minSizes, @maxSizes};
            var ___result = RMInitFromAbsolute_SingleArray_SingleArray_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitFromRelative(System.Single[] @relativeSizes, System.Single[] @minSizes, System.Single[] @maxSizes, System.Int32 @splitSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeSizes, @minSizes, @maxSizes, @splitSize};
            var ___result = RMInitFromRelative_SingleArray_SingleArray_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NormalizeRelativeSizes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNormalizeRelativeSizes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RealToRelativeSizes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRealToRelativeSizes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RelativeToRealSizes(System.Single @totalSpace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@totalSpace};
            var ___result = RMRelativeToRealSizes_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoSplitter(System.Int32 @i1, System.Int32 @i2, System.Single @diff)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i1, @i2, @diff};
            var ___result = RMDoSplitter_Int32_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public static void ConvertOldArray(System.Int32[] @oldArray, ref System.Single[] @newArray)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldArray, @newArray};
            var ___result = RMConvertOldArray_Int32Array_Ref_SingleArray.Invoke(___genericsType, ___parameters);
			@newArray = (System.Single[])___parameters[1];

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
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
