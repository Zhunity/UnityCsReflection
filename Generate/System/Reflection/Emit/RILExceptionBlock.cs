using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.ILExceptionBlock
	/// </summary>
    public partial class RILExceptionBlock : RMember //
    {

		/// <summary>
		/// System.Int32 CATCH
		/// </summary>
		protected static RSystem.RInt32 r_FCATCH;
		public static RSystem.RInt32 RFCATCH
		{
			get
			{
				if(r_FCATCH == null)
				{
					r_FCATCH = new( ReflectionUtils.GetType("System.Reflection.Emit.ILExceptionBlock"), "CATCH");
					r_FCATCH.SetBelong(null);
				}
				return r_FCATCH;
			}
		}

		/// <summary>
		/// System.Int32 FILTER
		/// </summary>
		protected static RSystem.RInt32 r_FFILTER;
		public static RSystem.RInt32 RFFILTER
		{
			get
			{
				if(r_FFILTER == null)
				{
					r_FFILTER = new( ReflectionUtils.GetType("System.Reflection.Emit.ILExceptionBlock"), "FILTER");
					r_FFILTER.SetBelong(null);
				}
				return r_FFILTER;
			}
		}

		/// <summary>
		/// System.Int32 FINALLY
		/// </summary>
		protected static RSystem.RInt32 r_FFINALLY;
		public static RSystem.RInt32 RFFINALLY
		{
			get
			{
				if(r_FFINALLY == null)
				{
					r_FFINALLY = new( ReflectionUtils.GetType("System.Reflection.Emit.ILExceptionBlock"), "FINALLY");
					r_FFINALLY.SetBelong(null);
				}
				return r_FFINALLY;
			}
		}

		/// <summary>
		/// System.Int32 FAULT
		/// </summary>
		protected static RSystem.RInt32 r_FFAULT;
		public static RSystem.RInt32 RFFAULT
		{
			get
			{
				if(r_FFAULT == null)
				{
					r_FFAULT = new( ReflectionUtils.GetType("System.Reflection.Emit.ILExceptionBlock"), "FAULT");
					r_FFAULT.SetBelong(null);
				}
				return r_FFAULT;
			}
		}

		/// <summary>
		/// System.Int32 FILTER_START
		/// </summary>
		protected static RSystem.RInt32 r_FFILTER_START;
		public static RSystem.RInt32 RFFILTER_START
		{
			get
			{
				if(r_FFILTER_START == null)
				{
					r_FFILTER_START = new( ReflectionUtils.GetType("System.Reflection.Emit.ILExceptionBlock"), "FILTER_START");
					r_FFILTER_START.SetBelong(null);
				}
				return r_FFILTER_START;
			}
		}

		/// <summary>
		/// System.Type extype
		/// </summary>
		protected RSystem.RType r_Fextype;
		public virtual RSystem.RType RFextype
		{
			get
			{
				if(r_Fextype == null)
				{
					r_Fextype = new(this, "extype");
					r_Fextype.SetBelong(this.instance);
				}
				return r_Fextype;
			}
		}

		/// <summary>
		/// System.Int32 type
		/// </summary>
		protected RSystem.RInt32 r_Ftype;
		public virtual RSystem.RInt32 RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
					r_Ftype.SetBelong(this.instance);
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// System.Int32 start
		/// </summary>
		protected RSystem.RInt32 r_Fstart;
		public virtual RSystem.RInt32 RFstart
		{
			get
			{
				if(r_Fstart == null)
				{
					r_Fstart = new(this, "start");
					r_Fstart.SetBelong(this.instance);
				}
				return r_Fstart;
			}
		}

		/// <summary>
		/// System.Int32 len
		/// </summary>
		protected RSystem.RInt32 r_Flen;
		public virtual RSystem.RInt32 RFlen
		{
			get
			{
				if(r_Flen == null)
				{
					r_Flen = new(this, "len");
					r_Flen.SetBelong(this.instance);
				}
				return r_Flen;
			}
		}

		/// <summary>
		/// System.Int32 filter_offset
		/// </summary>
		protected RSystem.RInt32 r_Ffilter_offset;
		public virtual RSystem.RInt32 RFfilter_offset
		{
			get
			{
				if(r_Ffilter_offset == null)
				{
					r_Ffilter_offset = new(this, "filter_offset");
					r_Ffilter_offset.SetBelong(this.instance);
				}
				return r_Ffilter_offset;
			}
		}

		/// <summary>
		/// Void Debug()
		/// </summary>
		protected RMethod r_MDebug;
		public virtual RMethod RMDebug
		{
			get
			{
				if(r_MDebug == null)
				{
					r_MDebug = new(this, "Debug", 0);
					r_MDebug.SetBelong(this.instance);
				}
				return r_MDebug;
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


        public RILExceptionBlock() : base("System.Reflection.Emit.ILExceptionBlock")
        {
        }

        public RILExceptionBlock(System.Object instance) : base("System.Reflection.Emit.ILExceptionBlock")
		{
            SetInstance(instance);
		}

        public RILExceptionBlock(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RILExceptionBlock(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Debug()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDebug.Invoke(___genericsType, ___parameters);

            
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
