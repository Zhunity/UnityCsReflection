
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RUnsafe
{
	/// <summary>
	/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription
	/// </summary>
    public partial class RProfilerRecorderDescription : RMember //
    {

		/// <summary>
		/// Unity.Profiling.ProfilerCategory category
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_Fcategory;
		public virtual SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RFcategory
		{
			get
			{
				if(r_Fcategory == null)
				{
					r_Fcategory = new(this, "category");
					r_Fcategory.SetBelong(this.instance);
				}
				return r_Fcategory;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.MarkerFlags flags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RMarkerFlags r_Fflags;
		public virtual SMFrame.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RMarkerFlags RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
					r_Fflags.SetBelong(this.instance);
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType dataType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_FdataType;
		public virtual SMFrame.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RFdataType
		{
			get
			{
				if(r_FdataType == null)
				{
					r_FdataType = new(this, "dataType");
					r_FdataType.SetBelong(this.instance);
				}
				return r_FdataType;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarkerDataUnit unitType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerMarkerDataUnit r_FunitType;
		public virtual SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerMarkerDataUnit RFunitType
		{
			get
			{
				if(r_FunitType == null)
				{
					r_FunitType = new(this, "unitType");
					r_FunitType.SetBelong(this.instance);
				}
				return r_FunitType;
			}
		}

		/// <summary>
		/// System.Int32 reserved0
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Freserved0;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFreserved0
		{
			get
			{
				if(r_Freserved0 == null)
				{
					r_Freserved0 = new(this, "reserved0");
					r_Freserved0.SetBelong(this.instance);
				}
				return r_Freserved0;
			}
		}

		/// <summary>
		/// System.Int32 nameUtf8Len
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FnameUtf8Len;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFnameUtf8Len
		{
			get
			{
				if(r_FnameUtf8Len == null)
				{
					r_FnameUtf8Len = new(this, "nameUtf8Len");
					r_FnameUtf8Len.SetBelong(this.instance);
				}
				return r_FnameUtf8Len;
			}
		}

		/// <summary>
		/// System.Byte* nameUtf8
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldPointer<SMFrame.Editor.Refleaction.RSystem.RByte> r_FnameUtf8;
		public virtual SMFrame.Editor.Refleaction.RFieldPointer<SMFrame.Editor.Refleaction.RSystem.RByte> RFnameUtf8
		{
			get
			{
				if(r_FnameUtf8 == null)
				{
					r_FnameUtf8 = new(this, "nameUtf8");
					r_FnameUtf8.SetBelong(this.instance);
				}
				return r_FnameUtf8;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Category
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PCategory;
		public virtual SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPCategory
		{
			get
			{
				if(r_PCategory == null)
				{
					r_PCategory = new(this, "Category", -1);
					r_PCategory.SetBelong(this.instance);
				}
				return r_PCategory;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.MarkerFlags Flags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RMarkerFlags r_PFlags;
		public virtual SMFrame.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RMarkerFlags RPFlags
		{
			get
			{
				if(r_PFlags == null)
				{
					r_PFlags = new(this, "Flags", -1);
					r_PFlags.SetBelong(this.instance);
				}
				return r_PFlags;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType DataType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_PDataType;
		public virtual SMFrame.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RPDataType
		{
			get
			{
				if(r_PDataType == null)
				{
					r_PDataType = new(this, "DataType", -1);
					r_PDataType.SetBelong(this.instance);
				}
				return r_PDataType;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarkerDataUnit UnitType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerMarkerDataUnit r_PUnitType;
		public virtual SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerMarkerDataUnit RPUnitType
		{
			get
			{
				if(r_PUnitType == null)
				{
					r_PUnitType = new(this, "UnitType", -1);
					r_PUnitType.SetBelong(this.instance);
				}
				return r_PUnitType;
			}
		}

		/// <summary>
		/// Int32 NameUtf8Len
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PNameUtf8Len;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPNameUtf8Len
		{
			get
			{
				if(r_PNameUtf8Len == null)
				{
					r_PNameUtf8Len = new(this, "NameUtf8Len", -1);
					r_PNameUtf8Len.SetBelong(this.instance);
				}
				return r_PNameUtf8Len;
			}
		}

		/// <summary>
		/// Byte* NameUtf8
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyPointer<SMFrame.Editor.Refleaction.RSystem.RByte> r_PNameUtf8;
		public virtual SMFrame.Editor.Refleaction.RPropertyPointer<SMFrame.Editor.Refleaction.RSystem.RByte> RPNameUtf8
		{
			get
			{
				if(r_PNameUtf8 == null)
				{
					r_PNameUtf8 = new(this, "NameUtf8", -1);
					r_PNameUtf8.SetBelong(this.instance);
				}
				return r_PNameUtf8;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
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


        public RProfilerRecorderDescription() : base("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription")
        {
        }

        public RProfilerRecorderDescription(System.Object instance) : base("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription")
		{
            SetInstance(instance);
		}

        public RProfilerRecorderDescription(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RProfilerRecorderDescription(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
