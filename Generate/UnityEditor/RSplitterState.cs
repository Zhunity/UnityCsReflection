using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.SplitterState
	/// </summary>
    public partial class RSplitterState : RMember //
    {

		/// <summary>
		/// System.Int32 defaultSplitSize
		/// </summary>
		protected static RField r_defaultSplitSize;
		public static RField RdefaultSplitSize
		{
			get
			{
				if(r_defaultSplitSize == null)
				{
					r_defaultSplitSize = new( ReleactionUtils.GetType("UnityEditor.SplitterState"), "defaultSplitSize");
					r_defaultSplitSize.SetBelong(null);
				}
				return r_defaultSplitSize;
			}
		}

		/// <summary>
		/// System.Int32 ID
		/// </summary>
		protected RField r_ID;
		public virtual RField RID
		{
			get
			{
				if(r_ID == null)
				{
					r_ID = new(this, "ID");
					r_ID.SetBelong(this.instance);
				}
				return r_ID;
			}
		}

		/// <summary>
		/// System.Single splitterInitialOffset
		/// </summary>
		protected RField r_splitterInitialOffset;
		public virtual RField RsplitterInitialOffset
		{
			get
			{
				if(r_splitterInitialOffset == null)
				{
					r_splitterInitialOffset = new(this, "splitterInitialOffset");
					r_splitterInitialOffset.SetBelong(this.instance);
				}
				return r_splitterInitialOffset;
			}
		}

		/// <summary>
		/// System.Int32 currentActiveSplitter
		/// </summary>
		protected RField r_currentActiveSplitter;
		public virtual RField RcurrentActiveSplitter
		{
			get
			{
				if(r_currentActiveSplitter == null)
				{
					r_currentActiveSplitter = new(this, "currentActiveSplitter");
					r_currentActiveSplitter.SetBelong(this.instance);
				}
				return r_currentActiveSplitter;
			}
		}

		/// <summary>
		/// System.Single[] realSizes
		/// </summary>
		protected RFieldArray<RField> r_realSizes;
		public virtual RFieldArray<RField> RrealSizes
		{
			get
			{
				if(r_realSizes == null)
				{
					r_realSizes = new(this, "realSizes");
					r_realSizes.SetBelong(this.instance);
				}
				return r_realSizes;
			}
		}

		/// <summary>
		/// System.Single[] relativeSizes
		/// </summary>
		protected RFieldArray<RField> r_relativeSizes;
		public virtual RFieldArray<RField> RrelativeSizes
		{
			get
			{
				if(r_relativeSizes == null)
				{
					r_relativeSizes = new(this, "relativeSizes");
					r_relativeSizes.SetBelong(this.instance);
				}
				return r_relativeSizes;
			}
		}

		/// <summary>
		/// System.Single[] minSizes
		/// </summary>
		protected RFieldArray<RField> r_minSizes;
		public virtual RFieldArray<RField> RminSizes
		{
			get
			{
				if(r_minSizes == null)
				{
					r_minSizes = new(this, "minSizes");
					r_minSizes.SetBelong(this.instance);
				}
				return r_minSizes;
			}
		}

		/// <summary>
		/// System.Single[] maxSizes
		/// </summary>
		protected RFieldArray<RField> r_maxSizes;
		public virtual RFieldArray<RField> RmaxSizes
		{
			get
			{
				if(r_maxSizes == null)
				{
					r_maxSizes = new(this, "maxSizes");
					r_maxSizes.SetBelong(this.instance);
				}
				return r_maxSizes;
			}
		}

		/// <summary>
		/// System.Single lastTotalSize
		/// </summary>
		protected RField r_lastTotalSize;
		public virtual RField RlastTotalSize
		{
			get
			{
				if(r_lastTotalSize == null)
				{
					r_lastTotalSize = new(this, "lastTotalSize");
					r_lastTotalSize.SetBelong(this.instance);
				}
				return r_lastTotalSize;
			}
		}

		/// <summary>
		/// System.Single splitSize
		/// </summary>
		protected RField r_splitSize;
		public virtual RField RsplitSize
		{
			get
			{
				if(r_splitSize == null)
				{
					r_splitSize = new(this, "splitSize");
					r_splitSize.SetBelong(this.instance);
				}
				return r_splitSize;
			}
		}

		/// <summary>
		/// System.Single xOffset
		/// </summary>
		protected RField r_xOffset;
		public virtual RField RxOffset
		{
			get
			{
				if(r_xOffset == null)
				{
					r_xOffset = new(this, "xOffset");
					r_xOffset.SetBelong(this.instance);
				}
				return r_xOffset;
			}
		}

		/// <summary>
		/// System.Int32 m_Version
		/// </summary>
		protected RField r_m_Version;
		public virtual RField Rm_Version
		{
			get
			{
				if(r_m_Version == null)
				{
					r_m_Version = new(this, "m_Version");
					r_m_Version.SetBelong(this.instance);
				}
				return r_m_Version;
			}
		}

		/// <summary>
		/// System.Int32[] oldRealSizes
		/// </summary>
		protected RFieldArray<RField> r_oldRealSizes;
		public virtual RFieldArray<RField> RoldRealSizes
		{
			get
			{
				if(r_oldRealSizes == null)
				{
					r_oldRealSizes = new(this, "oldRealSizes");
					r_oldRealSizes.SetBelong(this.instance);
				}
				return r_oldRealSizes;
			}
		}

		/// <summary>
		/// System.Int32[] oldMinSizes
		/// </summary>
		protected RFieldArray<RField> r_oldMinSizes;
		public virtual RFieldArray<RField> RoldMinSizes
		{
			get
			{
				if(r_oldMinSizes == null)
				{
					r_oldMinSizes = new(this, "oldMinSizes");
					r_oldMinSizes.SetBelong(this.instance);
				}
				return r_oldMinSizes;
			}
		}

		/// <summary>
		/// System.Int32[] oldMaxSizes
		/// </summary>
		protected RFieldArray<RField> r_oldMaxSizes;
		public virtual RFieldArray<RField> RoldMaxSizes
		{
			get
			{
				if(r_oldMaxSizes == null)
				{
					r_oldMaxSizes = new(this, "oldMaxSizes");
					r_oldMaxSizes.SetBelong(this.instance);
				}
				return r_oldMaxSizes;
			}
		}

		/// <summary>
		/// System.Int32 oldSplitSize
		/// </summary>
		protected RField r_oldSplitSize;
		public virtual RField RoldSplitSize
		{
			get
			{
				if(r_oldSplitSize == null)
				{
					r_oldSplitSize = new(this, "oldSplitSize");
					r_oldSplitSize.SetBelong(this.instance);
				}
				return r_oldSplitSize;
			}
		}

		/// <summary>
		/// System.Converter`2[System.Int32,System.Single] s_ConverterDelegate
		/// </summary>
		protected static RSystem.RConverter<RField, RField> r_s_ConverterDelegate;
		public static RSystem.RConverter<RField, RField> Rs_ConverterDelegate
		{
			get
			{
				if(r_s_ConverterDelegate == null)
				{
					r_s_ConverterDelegate = new( ReleactionUtils.GetType("UnityEditor.SplitterState"), "s_ConverterDelegate");
					r_s_ConverterDelegate.SetBelong(null);
				}
				return r_s_ConverterDelegate;
			}
		}

		/// <summary>
		/// Single CastIntToFloat(Int32)
		/// </summary>
		protected static RMethod r_RCastIntToFloat_Int32;
		public static RMethod RCastIntToFloat_Int32
		{
			get
			{
				if(r_RCastIntToFloat_Int32 == null)
				{
					r_RCastIntToFloat_Int32 = new( ReleactionUtils.GetType("UnityEditor.SplitterState"), "CastIntToFloat", 0, typeof(System.Int32));
					r_RCastIntToFloat_Int32.SetBelong(null);
				}
				return r_RCastIntToFloat_Int32;
			}
		}

		/// <summary>
		/// UnityEditor.SplitterState FromAbsolute(Single[], Single[], Single[])
		/// </summary>
		protected static RMethod r_RFromAbsolute_SingleArray_SingleArray_SingleArray;
		public static RMethod RFromAbsolute_SingleArray_SingleArray_SingleArray
		{
			get
			{
				if(r_RFromAbsolute_SingleArray_SingleArray_SingleArray == null)
				{
					r_RFromAbsolute_SingleArray_SingleArray_SingleArray = new( ReleactionUtils.GetType("UnityEditor.SplitterState"), "FromAbsolute", 0, typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType());
					r_RFromAbsolute_SingleArray_SingleArray_SingleArray.SetBelong(null);
				}
				return r_RFromAbsolute_SingleArray_SingleArray_SingleArray;
			}
		}

		/// <summary>
		/// UnityEditor.SplitterState FromRelative(Single[])
		/// </summary>
		protected static RMethod r_RFromRelative_SingleArray;
		public static RMethod RFromRelative_SingleArray
		{
			get
			{
				if(r_RFromRelative_SingleArray == null)
				{
					r_RFromRelative_SingleArray = new( ReleactionUtils.GetType("UnityEditor.SplitterState"), "FromRelative", 0, typeof(System.Single).MakeArrayType());
					r_RFromRelative_SingleArray.SetBelong(null);
				}
				return r_RFromRelative_SingleArray;
			}
		}

		/// <summary>
		/// UnityEditor.SplitterState FromRelative(Single[], Single[], Single[])
		/// </summary>
		protected static RMethod r_RFromRelative_SingleArray_SingleArray_SingleArray;
		public static RMethod RFromRelative_SingleArray_SingleArray_SingleArray
		{
			get
			{
				if(r_RFromRelative_SingleArray_SingleArray_SingleArray == null)
				{
					r_RFromRelative_SingleArray_SingleArray_SingleArray = new( ReleactionUtils.GetType("UnityEditor.SplitterState"), "FromRelative", 0, typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType());
					r_RFromRelative_SingleArray_SingleArray_SingleArray.SetBelong(null);
				}
				return r_RFromRelative_SingleArray_SingleArray_SingleArray;
			}
		}

		/// <summary>
		/// UnityEditor.SplitterState FromRelative(Single[], Single[], Single[], Int32)
		/// </summary>
		protected static RMethod r_RFromRelative_SingleArray_SingleArray_SingleArray_Int32;
		public static RMethod RFromRelative_SingleArray_SingleArray_SingleArray_Int32
		{
			get
			{
				if(r_RFromRelative_SingleArray_SingleArray_SingleArray_Int32 == null)
				{
					r_RFromRelative_SingleArray_SingleArray_SingleArray_Int32 = new( ReleactionUtils.GetType("UnityEditor.SplitterState"), "FromRelative", 0, typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_RFromRelative_SingleArray_SingleArray_SingleArray_Int32.SetBelong(null);
				}
				return r_RFromRelative_SingleArray_SingleArray_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Boolean IsValid()
		/// </summary>
		protected RMethod r_RIsValid;
		public virtual RMethod RIsValid
		{
			get
			{
				if(r_RIsValid == null)
				{
					r_RIsValid = new(this, "IsValid", 0);
					r_RIsValid.SetBelong(this.instance);
				}
				return r_RIsValid;
			}
		}

		/// <summary>
		/// Void InitFromAbsolute(Single[], Single[], Single[])
		/// </summary>
		protected RMethod r_RInitFromAbsolute_SingleArray_SingleArray_SingleArray;
		public virtual RMethod RInitFromAbsolute_SingleArray_SingleArray_SingleArray
		{
			get
			{
				if(r_RInitFromAbsolute_SingleArray_SingleArray_SingleArray == null)
				{
					r_RInitFromAbsolute_SingleArray_SingleArray_SingleArray = new(this, "InitFromAbsolute", 0, typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType());
					r_RInitFromAbsolute_SingleArray_SingleArray_SingleArray.SetBelong(this.instance);
				}
				return r_RInitFromAbsolute_SingleArray_SingleArray_SingleArray;
			}
		}

		/// <summary>
		/// Void InitFromRelative(Single[], Single[], Single[], Int32)
		/// </summary>
		protected RMethod r_RInitFromRelative_SingleArray_SingleArray_SingleArray_Int32;
		public virtual RMethod RInitFromRelative_SingleArray_SingleArray_SingleArray_Int32
		{
			get
			{
				if(r_RInitFromRelative_SingleArray_SingleArray_SingleArray_Int32 == null)
				{
					r_RInitFromRelative_SingleArray_SingleArray_SingleArray_Int32 = new(this, "InitFromRelative", 0, typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_RInitFromRelative_SingleArray_SingleArray_SingleArray_Int32.SetBelong(this.instance);
				}
				return r_RInitFromRelative_SingleArray_SingleArray_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void NormalizeRelativeSizes()
		/// </summary>
		protected RMethod r_RNormalizeRelativeSizes;
		public virtual RMethod RNormalizeRelativeSizes
		{
			get
			{
				if(r_RNormalizeRelativeSizes == null)
				{
					r_RNormalizeRelativeSizes = new(this, "NormalizeRelativeSizes", 0);
					r_RNormalizeRelativeSizes.SetBelong(this.instance);
				}
				return r_RNormalizeRelativeSizes;
			}
		}

		/// <summary>
		/// Void RealToRelativeSizes()
		/// </summary>
		protected RMethod r_RRealToRelativeSizes;
		public virtual RMethod RRealToRelativeSizes
		{
			get
			{
				if(r_RRealToRelativeSizes == null)
				{
					r_RRealToRelativeSizes = new(this, "RealToRelativeSizes", 0);
					r_RRealToRelativeSizes.SetBelong(this.instance);
				}
				return r_RRealToRelativeSizes;
			}
		}

		/// <summary>
		/// Void RelativeToRealSizes(Single)
		/// </summary>
		protected RMethod r_RRelativeToRealSizes_Single;
		public virtual RMethod RRelativeToRealSizes_Single
		{
			get
			{
				if(r_RRelativeToRealSizes_Single == null)
				{
					r_RRelativeToRealSizes_Single = new(this, "RelativeToRealSizes", 0, typeof(System.Single));
					r_RRelativeToRealSizes_Single.SetBelong(this.instance);
				}
				return r_RRelativeToRealSizes_Single;
			}
		}

		/// <summary>
		/// Void DoSplitter(Int32, Int32, Single)
		/// </summary>
		protected RMethod r_RDoSplitter_Int32_Int32_Single;
		public virtual RMethod RDoSplitter_Int32_Int32_Single
		{
			get
			{
				if(r_RDoSplitter_Int32_Int32_Single == null)
				{
					r_RDoSplitter_Int32_Int32_Single = new(this, "DoSplitter", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Single));
					r_RDoSplitter_Int32_Int32_Single.SetBelong(this.instance);
				}
				return r_RDoSplitter_Int32_Int32_Single;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_ROnBeforeSerialize;
		public virtual RMethod ROnBeforeSerialize
		{
			get
			{
				if(r_ROnBeforeSerialize == null)
				{
					r_ROnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_ROnBeforeSerialize.SetBelong(this.instance);
				}
				return r_ROnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void ConvertOldArray(Int32[], Single[] ByRef)
		/// </summary>
		protected static RMethod r_RConvertOldArray_Int32Array_Ref_SingleArray;
		public static RMethod RConvertOldArray_Int32Array_Ref_SingleArray
		{
			get
			{
				if(r_RConvertOldArray_Int32Array_Ref_SingleArray == null)
				{
					r_RConvertOldArray_Int32Array_Ref_SingleArray = new( ReleactionUtils.GetType("UnityEditor.SplitterState"), "ConvertOldArray", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Single).MakeArrayType().MakeByRefType());
					r_RConvertOldArray_Int32Array_Ref_SingleArray.SetBelong(null);
				}
				return r_RConvertOldArray_Int32Array_Ref_SingleArray;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_ROnAfterDeserialize;
		public virtual RMethod ROnAfterDeserialize
		{
			get
			{
				if(r_ROnAfterDeserialize == null)
				{
					r_ROnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_ROnAfterDeserialize.SetBelong(this.instance);
				}
				return r_ROnAfterDeserialize;
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

        public static System.Single CastIntToFloat(System.Int32  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RCastIntToFloat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Object FromAbsolute(System.Single[]  @realSizes, System.Single[]  @minSizes, System.Single[]  @maxSizes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@realSizes, @minSizes, @maxSizes};
            var ___result = RFromAbsolute_SingleArray_SingleArray_SingleArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object FromRelative(System.Single[]  @relativeSizes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeSizes};
            var ___result = RFromRelative_SingleArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object FromRelative(System.Single[]  @relativeSizes, System.Single[]  @minSizes, System.Single[]  @maxSizes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeSizes, @minSizes, @maxSizes};
            var ___result = RFromRelative_SingleArray_SingleArray_SingleArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object FromRelative(System.Single[]  @relativeSizes, System.Single[]  @minSizes, System.Single[]  @maxSizes, System.Int32  @splitSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeSizes, @minSizes, @maxSizes, @splitSize};
            var ___result = RFromRelative_SingleArray_SingleArray_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsValid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InitFromAbsolute(System.Single[]  @realSizes, System.Single[]  @minSizes, System.Single[]  @maxSizes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@realSizes, @minSizes, @maxSizes};
            var ___result = RInitFromAbsolute_SingleArray_SingleArray_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitFromRelative(System.Single[]  @relativeSizes, System.Single[]  @minSizes, System.Single[]  @maxSizes, System.Int32  @splitSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativeSizes, @minSizes, @maxSizes, @splitSize};
            var ___result = RInitFromRelative_SingleArray_SingleArray_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NormalizeRelativeSizes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNormalizeRelativeSizes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RealToRelativeSizes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRealToRelativeSizes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RelativeToRealSizes(System.Single  @totalSpace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@totalSpace};
            var ___result = RRelativeToRealSizes_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoSplitter(System.Int32  @i1, System.Int32  @i2, System.Single  @diff)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i1, @i2, @diff};
            var ___result = RDoSplitter_Int32_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public static void ConvertOldArray(System.Int32[]  @oldArray, ref System.Single[]  @newArray)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldArray, @newArray};
            var ___result = RConvertOldArray_Int32Array_Ref_SingleArray.Invoke(___genericsType, ___parameters);
			newArray = (System.Single[])___parameters[1];

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
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
