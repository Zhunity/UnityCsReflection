using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.MethodBody
	/// </summary>
    public partial class RMethodBody : RMember //
    {

		/// <summary>
		/// System.Reflection.ExceptionHandlingClause[] clauses
		/// </summary>
		protected RFieldArray<RSystem.RReflection.RExceptionHandlingClause> r_clauses;
		public virtual RFieldArray<RSystem.RReflection.RExceptionHandlingClause> Rclauses
		{
			get
			{
				if(r_clauses == null)
				{
					r_clauses = new(this, "clauses");
					r_clauses.SetBelong(this.instance);
				}
				return r_clauses;
			}
		}

		/// <summary>
		/// System.Reflection.LocalVariableInfo[] locals
		/// </summary>
		protected RFieldArray<RSystem.RReflection.RLocalVariableInfo> r_locals;
		public virtual RFieldArray<RSystem.RReflection.RLocalVariableInfo> Rlocals
		{
			get
			{
				if(r_locals == null)
				{
					r_locals = new(this, "locals");
					r_locals.SetBelong(this.instance);
				}
				return r_locals;
			}
		}

		/// <summary>
		/// System.Byte[] il
		/// </summary>
		protected RFieldArray<RField> r_il;
		public virtual RFieldArray<RField> Ril
		{
			get
			{
				if(r_il == null)
				{
					r_il = new(this, "il");
					r_il.SetBelong(this.instance);
				}
				return r_il;
			}
		}

		/// <summary>
		/// System.Boolean init_locals
		/// </summary>
		protected RField r_init_locals;
		public virtual RField Rinit_locals
		{
			get
			{
				if(r_init_locals == null)
				{
					r_init_locals = new(this, "init_locals");
					r_init_locals.SetBelong(this.instance);
				}
				return r_init_locals;
			}
		}

		/// <summary>
		/// System.Int32 sig_token
		/// </summary>
		protected RField r_sig_token;
		public virtual RField Rsig_token
		{
			get
			{
				if(r_sig_token == null)
				{
					r_sig_token = new(this, "sig_token");
					r_sig_token.SetBelong(this.instance);
				}
				return r_sig_token;
			}
		}

		/// <summary>
		/// System.Int32 max_stack
		/// </summary>
		protected RField r_max_stack;
		public virtual RField Rmax_stack
		{
			get
			{
				if(r_max_stack == null)
				{
					r_max_stack = new(this, "max_stack");
					r_max_stack.SetBelong(this.instance);
				}
				return r_max_stack;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.ExceptionHandlingClause] ExceptionHandlingClauses
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RReflection.RExceptionHandlingClause> r_ExceptionHandlingClauses;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RReflection.RExceptionHandlingClause> RExceptionHandlingClauses
		{
			get
			{
				if(r_ExceptionHandlingClauses == null)
				{
					r_ExceptionHandlingClauses = new(this, "ExceptionHandlingClauses", -1);
					r_ExceptionHandlingClauses.SetBelong(this.instance);
				}
				return r_ExceptionHandlingClauses;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.LocalVariableInfo] LocalVariables
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RReflection.RLocalVariableInfo> r_LocalVariables;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RReflection.RLocalVariableInfo> RLocalVariables
		{
			get
			{
				if(r_LocalVariables == null)
				{
					r_LocalVariables = new(this, "LocalVariables", -1);
					r_LocalVariables.SetBelong(this.instance);
				}
				return r_LocalVariables;
			}
		}

		/// <summary>
		/// Boolean InitLocals
		/// </summary>
		protected RProperty r_InitLocals;
		public virtual RProperty RInitLocals
		{
			get
			{
				if(r_InitLocals == null)
				{
					r_InitLocals = new(this, "InitLocals", -1);
					r_InitLocals.SetBelong(this.instance);
				}
				return r_InitLocals;
			}
		}

		/// <summary>
		/// Int32 LocalSignatureMetadataToken
		/// </summary>
		protected RProperty r_LocalSignatureMetadataToken;
		public virtual RProperty RLocalSignatureMetadataToken
		{
			get
			{
				if(r_LocalSignatureMetadataToken == null)
				{
					r_LocalSignatureMetadataToken = new(this, "LocalSignatureMetadataToken", -1);
					r_LocalSignatureMetadataToken.SetBelong(this.instance);
				}
				return r_LocalSignatureMetadataToken;
			}
		}

		/// <summary>
		/// Int32 MaxStackSize
		/// </summary>
		protected RProperty r_MaxStackSize;
		public virtual RProperty RMaxStackSize
		{
			get
			{
				if(r_MaxStackSize == null)
				{
					r_MaxStackSize = new(this, "MaxStackSize", -1);
					r_MaxStackSize.SetBelong(this.instance);
				}
				return r_MaxStackSize;
			}
		}

		/// <summary>
		/// Byte[] GetILAsByteArray()
		/// </summary>
		protected RMethod r_RGetILAsByteArray;
		public virtual RMethod RGetILAsByteArray
		{
			get
			{
				if(r_RGetILAsByteArray == null)
				{
					r_RGetILAsByteArray = new(this, "GetILAsByteArray", 0);
					r_RGetILAsByteArray.SetBelong(this.instance);
				}
				return r_RGetILAsByteArray;
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


        public RMethodBody() : base("System.Reflection.MethodBody")
        {
        }

        public RMethodBody(System.Object instance) : base("System.Reflection.MethodBody")
		{
            SetInstance(instance);
		}

        public RMethodBody(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMethodBody(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Byte[] GetILAsByteArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetILAsByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
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
