
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.ILExceptionInfo
	/// </summary>
    public partial class RILExceptionInfo : RMember //
    {

		/// <summary>
		/// System.Reflection.Emit.ILExceptionBlock[] handlers
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RILExceptionBlock> r_Fhandlers;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RILExceptionBlock> RFhandlers
		{
			get
			{
				if(r_Fhandlers == null)
				{
					r_Fhandlers = new(this, "handlers");
					r_Fhandlers.SetBelong(this.instance);
				}
				return r_Fhandlers;
			}
		}

		/// <summary>
		/// System.Int32 start
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fstart;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFstart
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
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Flen;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlen
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
		/// System.Reflection.Emit.Label end
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RLabel r_Fend;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RLabel RFend
		{
			get
			{
				if(r_Fend == null)
				{
					r_Fend = new(this, "end");
					r_Fend.SetBelong(this.instance);
				}
				return r_Fend;
			}
		}

		/// <summary>
		/// Int32 NumHandlers()
		/// </summary>
		protected RMethod r_MNumHandlers;
		public virtual RMethod RMNumHandlers
		{
			get
			{
				if(r_MNumHandlers == null)
				{
					r_MNumHandlers = new(this, "NumHandlers", 0);
					r_MNumHandlers.SetBelong(this.instance);
				}
				return r_MNumHandlers;
			}
		}

		/// <summary>
		/// Void AddCatch(System.Type, Int32)
		/// </summary>
		protected RMethod r_MAddCatch_Type_Int32;
		public virtual RMethod RMAddCatch_Type_Int32
		{
			get
			{
				if(r_MAddCatch_Type_Int32 == null)
				{
					r_MAddCatch_Type_Int32 = new(this, "AddCatch", 0, typeof(System.Type), typeof(System.Int32));
					r_MAddCatch_Type_Int32.SetBelong(this.instance);
				}
				return r_MAddCatch_Type_Int32;
			}
		}

		/// <summary>
		/// Void AddFinally(Int32)
		/// </summary>
		protected RMethod r_MAddFinally_Int32;
		public virtual RMethod RMAddFinally_Int32
		{
			get
			{
				if(r_MAddFinally_Int32 == null)
				{
					r_MAddFinally_Int32 = new(this, "AddFinally", 0, typeof(System.Int32));
					r_MAddFinally_Int32.SetBelong(this.instance);
				}
				return r_MAddFinally_Int32;
			}
		}

		/// <summary>
		/// Void AddFault(Int32)
		/// </summary>
		protected RMethod r_MAddFault_Int32;
		public virtual RMethod RMAddFault_Int32
		{
			get
			{
				if(r_MAddFault_Int32 == null)
				{
					r_MAddFault_Int32 = new(this, "AddFault", 0, typeof(System.Int32));
					r_MAddFault_Int32.SetBelong(this.instance);
				}
				return r_MAddFault_Int32;
			}
		}

		/// <summary>
		/// Void AddFilter(Int32)
		/// </summary>
		protected RMethod r_MAddFilter_Int32;
		public virtual RMethod RMAddFilter_Int32
		{
			get
			{
				if(r_MAddFilter_Int32 == null)
				{
					r_MAddFilter_Int32 = new(this, "AddFilter", 0, typeof(System.Int32));
					r_MAddFilter_Int32.SetBelong(this.instance);
				}
				return r_MAddFilter_Int32;
			}
		}

		/// <summary>
		/// Void End(Int32)
		/// </summary>
		protected RMethod r_MEnd_Int32;
		public virtual RMethod RMEnd_Int32
		{
			get
			{
				if(r_MEnd_Int32 == null)
				{
					r_MEnd_Int32 = new(this, "End", 0, typeof(System.Int32));
					r_MEnd_Int32.SetBelong(this.instance);
				}
				return r_MEnd_Int32;
			}
		}

		/// <summary>
		/// Int32 LastClauseType()
		/// </summary>
		protected RMethod r_MLastClauseType;
		public virtual RMethod RMLastClauseType
		{
			get
			{
				if(r_MLastClauseType == null)
				{
					r_MLastClauseType = new(this, "LastClauseType", 0);
					r_MLastClauseType.SetBelong(this.instance);
				}
				return r_MLastClauseType;
			}
		}

		/// <summary>
		/// Void PatchFilterClause(Int32)
		/// </summary>
		protected RMethod r_MPatchFilterClause_Int32;
		public virtual RMethod RMPatchFilterClause_Int32
		{
			get
			{
				if(r_MPatchFilterClause_Int32 == null)
				{
					r_MPatchFilterClause_Int32 = new(this, "PatchFilterClause", 0, typeof(System.Int32));
					r_MPatchFilterClause_Int32.SetBelong(this.instance);
				}
				return r_MPatchFilterClause_Int32;
			}
		}

		/// <summary>
		/// Void Debug(Int32)
		/// </summary>
		protected RMethod r_MDebug_Int32;
		public virtual RMethod RMDebug_Int32
		{
			get
			{
				if(r_MDebug_Int32 == null)
				{
					r_MDebug_Int32 = new(this, "Debug", 0, typeof(System.Int32));
					r_MDebug_Int32.SetBelong(this.instance);
				}
				return r_MDebug_Int32;
			}
		}

		/// <summary>
		/// Void add_block(Int32)
		/// </summary>
		protected RMethod r_Madd_block_Int32;
		public virtual RMethod RMadd_block_Int32
		{
			get
			{
				if(r_Madd_block_Int32 == null)
				{
					r_Madd_block_Int32 = new(this, "add_block", 0, typeof(System.Int32));
					r_Madd_block_Int32.SetBelong(this.instance);
				}
				return r_Madd_block_Int32;
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


        public RILExceptionInfo() : base("System.Reflection.Emit.ILExceptionInfo")
        {
        }

        public RILExceptionInfo(System.Object instance) : base("System.Reflection.Emit.ILExceptionInfo")
		{
            SetInstance(instance);
		}

        public RILExceptionInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RILExceptionInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 NumHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNumHandlers.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddCatch(System.Type @extype, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@extype, @offset};
            var ___result = RMAddCatch_Type_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFinally(System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = RMAddFinally_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFault(System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = RMAddFault_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFilter(System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = RMAddFilter_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void End(System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = RMEnd_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 LastClauseType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLastClauseType.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void PatchFilterClause(System.Int32 @start)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start};
            var ___result = RMPatchFilterClause_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Debug(System.Int32 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@b};
            var ___result = RMDebug_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void add_block(System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = RMadd_block_Int32.Invoke(___genericsType, ___parameters);

            
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
