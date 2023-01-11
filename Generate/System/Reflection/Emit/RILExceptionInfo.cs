using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.ILExceptionInfo
	/// </summary>
    public partial class RILExceptionInfo : RMember //
    {

		/// <summary>
		/// System.Reflection.Emit.ILExceptionBlock[] handlers
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RILExceptionBlock> r_handlers;
		public virtual RFieldArray<RSystem.RReflection.REmit.RILExceptionBlock> Rhandlers
		{
			get
			{
				if(r_handlers == null)
				{
					r_handlers = new(this, "handlers");
					r_handlers.SetBelong(this.instance);
				}
				return r_handlers;
			}
		}

		/// <summary>
		/// System.Int32 start
		/// </summary>
		protected RSystem.RInt32 r_start;
		public virtual RSystem.RInt32 Rstart
		{
			get
			{
				if(r_start == null)
				{
					r_start = new(this, "start");
					r_start.SetBelong(this.instance);
				}
				return r_start;
			}
		}

		/// <summary>
		/// System.Int32 len
		/// </summary>
		protected RSystem.RInt32 r_len;
		public virtual RSystem.RInt32 Rlen
		{
			get
			{
				if(r_len == null)
				{
					r_len = new(this, "len");
					r_len.SetBelong(this.instance);
				}
				return r_len;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.Label end
		/// </summary>
		protected RSystem.RReflection.REmit.RLabel r_end;
		public virtual RSystem.RReflection.REmit.RLabel Rend
		{
			get
			{
				if(r_end == null)
				{
					r_end = new(this, "end");
					r_end.SetBelong(this.instance);
				}
				return r_end;
			}
		}

		/// <summary>
		/// Int32 NumHandlers()
		/// </summary>
		protected RMethod r_NumHandlers;
		public virtual RMethod RNumHandlers
		{
			get
			{
				if(r_NumHandlers == null)
				{
					r_NumHandlers = new(this, "NumHandlers", 0);
					r_NumHandlers.SetBelong(this.instance);
				}
				return r_NumHandlers;
			}
		}

		/// <summary>
		/// Void AddCatch(System.Type, Int32)
		/// </summary>
		protected RMethod r_AddCatch_Type_Int32;
		public virtual RMethod RAddCatch_Type_Int32
		{
			get
			{
				if(r_AddCatch_Type_Int32 == null)
				{
					r_AddCatch_Type_Int32 = new(this, "AddCatch", 0, typeof(System.Type), typeof(System.Int32));
					r_AddCatch_Type_Int32.SetBelong(this.instance);
				}
				return r_AddCatch_Type_Int32;
			}
		}

		/// <summary>
		/// Void AddFinally(Int32)
		/// </summary>
		protected RMethod r_AddFinally_Int32;
		public virtual RMethod RAddFinally_Int32
		{
			get
			{
				if(r_AddFinally_Int32 == null)
				{
					r_AddFinally_Int32 = new(this, "AddFinally", 0, typeof(System.Int32));
					r_AddFinally_Int32.SetBelong(this.instance);
				}
				return r_AddFinally_Int32;
			}
		}

		/// <summary>
		/// Void AddFault(Int32)
		/// </summary>
		protected RMethod r_AddFault_Int32;
		public virtual RMethod RAddFault_Int32
		{
			get
			{
				if(r_AddFault_Int32 == null)
				{
					r_AddFault_Int32 = new(this, "AddFault", 0, typeof(System.Int32));
					r_AddFault_Int32.SetBelong(this.instance);
				}
				return r_AddFault_Int32;
			}
		}

		/// <summary>
		/// Void AddFilter(Int32)
		/// </summary>
		protected RMethod r_AddFilter_Int32;
		public virtual RMethod RAddFilter_Int32
		{
			get
			{
				if(r_AddFilter_Int32 == null)
				{
					r_AddFilter_Int32 = new(this, "AddFilter", 0, typeof(System.Int32));
					r_AddFilter_Int32.SetBelong(this.instance);
				}
				return r_AddFilter_Int32;
			}
		}

		/// <summary>
		/// Void End(Int32)
		/// </summary>
		protected RMethod r_End_Int32;
		public virtual RMethod REnd_Int32
		{
			get
			{
				if(r_End_Int32 == null)
				{
					r_End_Int32 = new(this, "End", 0, typeof(System.Int32));
					r_End_Int32.SetBelong(this.instance);
				}
				return r_End_Int32;
			}
		}

		/// <summary>
		/// Int32 LastClauseType()
		/// </summary>
		protected RMethod r_LastClauseType;
		public virtual RMethod RLastClauseType
		{
			get
			{
				if(r_LastClauseType == null)
				{
					r_LastClauseType = new(this, "LastClauseType", 0);
					r_LastClauseType.SetBelong(this.instance);
				}
				return r_LastClauseType;
			}
		}

		/// <summary>
		/// Void PatchFilterClause(Int32)
		/// </summary>
		protected RMethod r_PatchFilterClause_Int32;
		public virtual RMethod RPatchFilterClause_Int32
		{
			get
			{
				if(r_PatchFilterClause_Int32 == null)
				{
					r_PatchFilterClause_Int32 = new(this, "PatchFilterClause", 0, typeof(System.Int32));
					r_PatchFilterClause_Int32.SetBelong(this.instance);
				}
				return r_PatchFilterClause_Int32;
			}
		}

		/// <summary>
		/// Void Debug(Int32)
		/// </summary>
		protected RMethod r_Debug_Int32;
		public virtual RMethod RDebug_Int32
		{
			get
			{
				if(r_Debug_Int32 == null)
				{
					r_Debug_Int32 = new(this, "Debug", 0, typeof(System.Int32));
					r_Debug_Int32.SetBelong(this.instance);
				}
				return r_Debug_Int32;
			}
		}

		/// <summary>
		/// Void add_block(Int32)
		/// </summary>
		protected RMethod r_add_block_Int32;
		public virtual RMethod Radd_block_Int32
		{
			get
			{
				if(r_add_block_Int32 == null)
				{
					r_add_block_Int32 = new(this, "add_block", 0, typeof(System.Int32));
					r_add_block_Int32.SetBelong(this.instance);
				}
				return r_add_block_Int32;
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
            var ___result = RNumHandlers.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddCatch(System.Type @extype, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@extype, @offset};
            var ___result = RAddCatch_Type_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFinally(System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = RAddFinally_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFault(System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = RAddFault_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFilter(System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = RAddFilter_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void End(System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = REnd_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 LastClauseType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLastClauseType.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void PatchFilterClause(System.Int32 @start)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start};
            var ___result = RPatchFilterClause_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Debug(System.Int32 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@b};
            var ___result = RDebug_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void add_block(System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = Radd_block_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
