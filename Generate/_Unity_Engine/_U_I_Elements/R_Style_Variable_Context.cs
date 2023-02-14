
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleVariableContext
	/// </summary>
    public partial class RStyleVariableContext : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext none
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableContext r_Fnone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableContext RFnone
		{
			get
			{
				if(r_Fnone == null)
				{
					r_Fnone = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleVariableContext"), "none");
					r_Fnone.SetBelong(null);
				}
				return r_Fnone;
			}
		}

		/// <summary>
		/// System.Int32 m_VariableHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_VariableHash;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_VariableHash
		{
			get
			{
				if(r_Fm_VariableHash == null)
				{
					r_Fm_VariableHash = new(this, "m_VariableHash");
					r_Fm_VariableHash.SetBelong(this.instance);
				}
				return r_Fm_VariableHash;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleVariable] m_Variables
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariable> r_Fm_Variables;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariable> RFm_Variables
		{
			get
			{
				if(r_Fm_Variables == null)
				{
					r_Fm_Variables = new(this, "m_Variables");
					r_Fm_Variables.SetBelong(this.instance);
				}
				return r_Fm_Variables;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_SortedHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fm_SortedHash;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RInt32> RFm_SortedHash
		{
			get
			{
				if(r_Fm_SortedHash == null)
				{
					r_Fm_SortedHash = new(this, "m_SortedHash");
					r_Fm_SortedHash.SetBelong(this.instance);
				}
				return r_Fm_SortedHash;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleVariable] variables
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariable> r_Pvariables;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariable> RPvariables
		{
			get
			{
				if(r_Pvariables == null)
				{
					r_Pvariables = new(this, "variables", -1);
					r_Pvariables.SetBelong(this.instance);
				}
				return r_Pvariables;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.StyleVariable)
		/// </summary>
		protected RMethod r_MAdd_StyleVariable;
		public virtual RMethod RMAdd_StyleVariable
		{
			get
			{
				if(r_MAdd_StyleVariable == null)
				{
					r_MAdd_StyleVariable = new(this, "Add", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleVariable"));
					r_MAdd_StyleVariable.SetBelong(this.instance);
				}
				return r_MAdd_StyleVariable;
			}
		}

		/// <summary>
		/// Void AddInitialRange(UnityEngine.UIElements.StyleVariableContext)
		/// </summary>
		protected RMethod r_MAddInitialRange_StyleVariableContext;
		public virtual RMethod RMAddInitialRange_StyleVariableContext
		{
			get
			{
				if(r_MAddInitialRange_StyleVariableContext == null)
				{
					r_MAddInitialRange_StyleVariableContext = new(this, "AddInitialRange", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleVariableContext"));
					r_MAddInitialRange_StyleVariableContext.SetBelong(this.instance);
				}
				return r_MAddInitialRange_StyleVariableContext;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
					r_MClear.SetBelong(this.instance);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// Boolean TryFindVariable(System.String, UnityEngine.UIElements.StyleVariable ByRef)
		/// </summary>
		protected RMethod r_MTryFindVariable_String_Out_StyleVariable;
		public virtual RMethod RMTryFindVariable_String_Out_StyleVariable
		{
			get
			{
				if(r_MTryFindVariable_String_Out_StyleVariable == null)
				{
					r_MTryFindVariable_String_Out_StyleVariable = new(this, "TryFindVariable", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleVariable").MakeByRefType());
					r_MTryFindVariable_String_Out_StyleVariable.SetBelong(this.instance);
				}
				return r_MTryFindVariable_String_Out_StyleVariable;
			}
		}

		/// <summary>
		/// Int32 GetVariableHash()
		/// </summary>
		protected RMethod r_MGetVariableHash;
		public virtual RMethod RMGetVariableHash
		{
			get
			{
				if(r_MGetVariableHash == null)
				{
					r_MGetVariableHash = new(this, "GetVariableHash", 0);
					r_MGetVariableHash.SetBelong(this.instance);
				}
				return r_MGetVariableHash;
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

        public virtual void Add(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariable @sv)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sv.Value};
            var ___result = RMAdd_StyleVariable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInitialRange(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableContext @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMAddInitialRange_StyleVariableContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryFindVariable(System.String @name, out Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariable @v)
        {
			@v = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @v.Value};
            var ___result = RMTryFindVariable_String_Out_StyleVariable.Invoke(___genericsType, ___parameters);
			@v = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariable(___parameters[1]);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetVariableHash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetVariableHash.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
