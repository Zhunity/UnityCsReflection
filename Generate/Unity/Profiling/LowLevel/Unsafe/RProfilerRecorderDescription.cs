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
		protected RUnity.RProfiling.RProfilerCategory r_category;
		public virtual RUnity.RProfiling.RProfilerCategory Rcategory
		{
			get
			{
				if(r_category == null)
				{
					r_category = new(this, "category");
					r_category.SetBelong(this.instance);
				}
				return r_category;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.MarkerFlags flags
		/// </summary>
		protected RField r_flags;
		public virtual RField Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType dataType
		/// </summary>
		protected RField r_dataType;
		public virtual RField RdataType
		{
			get
			{
				if(r_dataType == null)
				{
					r_dataType = new(this, "dataType");
					r_dataType.SetBelong(this.instance);
				}
				return r_dataType;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarkerDataUnit unitType
		/// </summary>
		protected RField r_unitType;
		public virtual RField RunitType
		{
			get
			{
				if(r_unitType == null)
				{
					r_unitType = new(this, "unitType");
					r_unitType.SetBelong(this.instance);
				}
				return r_unitType;
			}
		}

		/// <summary>
		/// System.Int32 reserved0
		/// </summary>
		protected RField r_reserved0;
		public virtual RField Rreserved0
		{
			get
			{
				if(r_reserved0 == null)
				{
					r_reserved0 = new(this, "reserved0");
					r_reserved0.SetBelong(this.instance);
				}
				return r_reserved0;
			}
		}

		/// <summary>
		/// System.Int32 nameUtf8Len
		/// </summary>
		protected RField r_nameUtf8Len;
		public virtual RField RnameUtf8Len
		{
			get
			{
				if(r_nameUtf8Len == null)
				{
					r_nameUtf8Len = new(this, "nameUtf8Len");
					r_nameUtf8Len.SetBelong(this.instance);
				}
				return r_nameUtf8Len;
			}
		}

		/// <summary>
		/// System.Byte* nameUtf8
		/// </summary>
		protected RFieldPointer<RField> r_nameUtf8;
		public virtual RFieldPointer<RField> RnameUtf8
		{
			get
			{
				if(r_nameUtf8 == null)
				{
					r_nameUtf8 = new(this, "nameUtf8");
					r_nameUtf8.SetBelong(this.instance);
				}
				return r_nameUtf8;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Category
		/// </summary>
		protected RUnity.RProfiling.RProfilerCategory r_Category;
		public virtual RUnity.RProfiling.RProfilerCategory RCategory
		{
			get
			{
				if(r_Category == null)
				{
					r_Category = new(this, "Category", -1);
					r_Category.SetBelong(this.instance);
				}
				return r_Category;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.MarkerFlags Flags
		/// </summary>
		protected RProperty r_Flags;
		public virtual RProperty RFlags
		{
			get
			{
				if(r_Flags == null)
				{
					r_Flags = new(this, "Flags", -1);
					r_Flags.SetBelong(this.instance);
				}
				return r_Flags;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType DataType
		/// </summary>
		protected RProperty r_DataType;
		public virtual RProperty RDataType
		{
			get
			{
				if(r_DataType == null)
				{
					r_DataType = new(this, "DataType", -1);
					r_DataType.SetBelong(this.instance);
				}
				return r_DataType;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarkerDataUnit UnitType
		/// </summary>
		protected RProperty r_UnitType;
		public virtual RProperty RUnitType
		{
			get
			{
				if(r_UnitType == null)
				{
					r_UnitType = new(this, "UnitType", -1);
					r_UnitType.SetBelong(this.instance);
				}
				return r_UnitType;
			}
		}

		/// <summary>
		/// Int32 NameUtf8Len
		/// </summary>
		protected RProperty r_NameUtf8Len;
		public virtual RProperty RNameUtf8Len
		{
			get
			{
				if(r_NameUtf8Len == null)
				{
					r_NameUtf8Len = new(this, "NameUtf8Len", -1);
					r_NameUtf8Len.SetBelong(this.instance);
				}
				return r_NameUtf8Len;
			}
		}

		/// <summary>
		/// Byte* NameUtf8
		/// </summary>
		protected RPropertyPointer<RProperty> r_NameUtf8;
		public virtual RPropertyPointer<RProperty> RNameUtf8
		{
			get
			{
				if(r_NameUtf8 == null)
				{
					r_NameUtf8 = new(this, "NameUtf8", -1);
					r_NameUtf8.SetBelong(this.instance);
				}
				return r_NameUtf8;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
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

        public virtual System.Boolean Equals(System.Object  @obj)
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
