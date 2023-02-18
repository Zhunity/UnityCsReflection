
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.MethodBody
	/// </summary>
    public partial class RMethodBody : RMember //
    {

		/// <summary>
		/// System.Reflection.ExceptionHandlingClause[] clauses
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClause> r_Fclauses;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClause> RFclauses
		{
			get
			{
				if(r_Fclauses == null)
				{
					r_Fclauses = new(this, "clauses");
				}
				return r_Fclauses;
			}
		}

		/// <summary>
		/// System.Reflection.LocalVariableInfo[] locals
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RLocalVariableInfo> r_Flocals;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RLocalVariableInfo> RFlocals
		{
			get
			{
				if(r_Flocals == null)
				{
					r_Flocals = new(this, "locals");
				}
				return r_Flocals;
			}
		}

		/// <summary>
		/// System.Byte[] il
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fil;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFil
		{
			get
			{
				if(r_Fil == null)
				{
					r_Fil = new(this, "il");
				}
				return r_Fil;
			}
		}

		/// <summary>
		/// System.Boolean init_locals
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Finit_locals;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFinit_locals
		{
			get
			{
				if(r_Finit_locals == null)
				{
					r_Finit_locals = new(this, "init_locals");
				}
				return r_Finit_locals;
			}
		}

		/// <summary>
		/// System.Int32 sig_token
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fsig_token;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFsig_token
		{
			get
			{
				if(r_Fsig_token == null)
				{
					r_Fsig_token = new(this, "sig_token");
				}
				return r_Fsig_token;
			}
		}

		/// <summary>
		/// System.Int32 max_stack
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fmax_stack;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmax_stack
		{
			get
			{
				if(r_Fmax_stack == null)
				{
					r_Fmax_stack = new(this, "max_stack");
				}
				return r_Fmax_stack;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.ExceptionHandlingClause] ExceptionHandlingClauses
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClause> r_PExceptionHandlingClauses;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RReflection.RExceptionHandlingClause> RPExceptionHandlingClauses
		{
			get
			{
				if(r_PExceptionHandlingClauses == null)
				{
					r_PExceptionHandlingClauses = new(this, "ExceptionHandlingClauses", -1);
				}
				return r_PExceptionHandlingClauses;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.LocalVariableInfo] LocalVariables
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RReflection.RLocalVariableInfo> r_PLocalVariables;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RReflection.RLocalVariableInfo> RPLocalVariables
		{
			get
			{
				if(r_PLocalVariables == null)
				{
					r_PLocalVariables = new(this, "LocalVariables", -1);
				}
				return r_PLocalVariables;
			}
		}

		/// <summary>
		/// Boolean InitLocals
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PInitLocals;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPInitLocals
		{
			get
			{
				if(r_PInitLocals == null)
				{
					r_PInitLocals = new(this, "InitLocals", -1);
				}
				return r_PInitLocals;
			}
		}

		/// <summary>
		/// Int32 LocalSignatureMetadataToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLocalSignatureMetadataToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLocalSignatureMetadataToken
		{
			get
			{
				if(r_PLocalSignatureMetadataToken == null)
				{
					r_PLocalSignatureMetadataToken = new(this, "LocalSignatureMetadataToken", -1);
				}
				return r_PLocalSignatureMetadataToken;
			}
		}

		/// <summary>
		/// Int32 MaxStackSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMaxStackSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMaxStackSize
		{
			get
			{
				if(r_PMaxStackSize == null)
				{
					r_PMaxStackSize = new(this, "MaxStackSize", -1);
				}
				return r_PMaxStackSize;
			}
		}

		/// <summary>
		/// Byte[] GetILAsByteArray()
		/// </summary>
		protected RMethod r_MGetILAsByteArray;
		public virtual RMethod RMGetILAsByteArray
		{
			get
			{
				if(r_MGetILAsByteArray == null)
				{
					r_MGetILAsByteArray = new(this, "GetILAsByteArray", 0);
				}
				return r_MGetILAsByteArray;
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
            var ___result = RMGetILAsByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
