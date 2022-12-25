using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleVariableContext
	/// </summary>
    public partial class RStyleVariableContext : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext none
		/// </summary>
		protected static RUnityEngine.RUIElements.RStyleVariableContext r_none;
		public static RUnityEngine.RUIElements.RStyleVariableContext Rnone
		{
			get
			{
				if(r_none == null)
				{
					r_none = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleVariableContext"), "none");
					r_none.SetBelong(null);
				}
				return r_none;
			}
		}

		/// <summary>
		/// System.Int32 m_VariableHash
		/// </summary>
		protected RField r_m_VariableHash;
		public virtual RField Rm_VariableHash
		{
			get
			{
				if(r_m_VariableHash == null)
				{
					r_m_VariableHash = new(this, "m_VariableHash");
					r_m_VariableHash.SetBelong(this.instance);
				}
				return r_m_VariableHash;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleVariable] m_Variables
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleVariable> r_m_Variables;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleVariable> Rm_Variables
		{
			get
			{
				if(r_m_Variables == null)
				{
					r_m_Variables = new(this, "m_Variables");
					r_m_Variables.SetBelong(this.instance);
				}
				return r_m_Variables;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_SortedHash
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_SortedHash;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_SortedHash
		{
			get
			{
				if(r_m_SortedHash == null)
				{
					r_m_SortedHash = new(this, "m_SortedHash");
					r_m_SortedHash.SetBelong(this.instance);
				}
				return r_m_SortedHash;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleVariable] variables
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleVariable> r_variables;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleVariable> Rvariables
		{
			get
			{
				if(r_variables == null)
				{
					r_variables = new(this, "variables", -1);
					r_variables.SetBelong(this.instance);
				}
				return r_variables;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.StyleVariable)
		/// </summary>
		protected RMethod r_RAdd_StyleVariable;
		public virtual RMethod RAdd_StyleVariable
		{
			get
			{
				if(r_RAdd_StyleVariable == null)
				{
					r_RAdd_StyleVariable = new(this, "Add", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleVariable"));
					r_RAdd_StyleVariable.SetBelong(this.instance);
				}
				return r_RAdd_StyleVariable;
			}
		}

		/// <summary>
		/// Void AddInitialRange(UnityEngine.UIElements.StyleVariableContext)
		/// </summary>
		protected RMethod r_RAddInitialRange_StyleVariableContext;
		public virtual RMethod RAddInitialRange_StyleVariableContext
		{
			get
			{
				if(r_RAddInitialRange_StyleVariableContext == null)
				{
					r_RAddInitialRange_StyleVariableContext = new(this, "AddInitialRange", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleVariableContext"));
					r_RAddInitialRange_StyleVariableContext.SetBelong(this.instance);
				}
				return r_RAddInitialRange_StyleVariableContext;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// Boolean TryFindVariable(System.String, UnityEngine.UIElements.StyleVariable ByRef)
		/// </summary>
		protected RMethod r_RTryFindVariable_String_Out_StyleVariable;
		public virtual RMethod RTryFindVariable_String_Out_StyleVariable
		{
			get
			{
				if(r_RTryFindVariable_String_Out_StyleVariable == null)
				{
					r_RTryFindVariable_String_Out_StyleVariable = new(this, "TryFindVariable", 0, typeof(System.String),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleVariable").MakeByRefType());
					r_RTryFindVariable_String_Out_StyleVariable.SetBelong(this.instance);
				}
				return r_RTryFindVariable_String_Out_StyleVariable;
			}
		}

		/// <summary>
		/// Int32 GetVariableHash()
		/// </summary>
		protected RMethod r_RGetVariableHash;
		public virtual RMethod RGetVariableHash
		{
			get
			{
				if(r_RGetVariableHash == null)
				{
					r_RGetVariableHash = new(this, "GetVariableHash", 0);
					r_RGetVariableHash.SetBelong(this.instance);
				}
				return r_RGetVariableHash;
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


        public RStyleVariableContext() : base("UnityEngine.UIElements.StyleVariableContext")
        {
        }

        public RStyleVariableContext(System.Object instance) : base("UnityEngine.UIElements.StyleVariableContext")
		{
            SetInstance(instance);
		}

        public RStyleVariableContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleVariableContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }



        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Int32 GetVariableHash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetVariableHash.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
