using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleVariableResolver
	/// </summary>
    public partial class RStyleVariableResolver : RMember //
    {

		/// <summary>
		/// System.Int32 kMaxResolves
		/// </summary>
		protected static RField r_kMaxResolves;
		public static RField RkMaxResolves
		{
			get
			{
				if(r_kMaxResolves == null)
				{
					r_kMaxResolves = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleVariableResolver"), "kMaxResolves");
					r_kMaxResolves.SetBelong(null);
				}
				return r_kMaxResolves;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser s_SyntaxParser
		/// </summary>
		protected static RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxParser r_s_SyntaxParser;
		public static RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxParser Rs_SyntaxParser
		{
			get
			{
				if(r_s_SyntaxParser == null)
				{
					r_s_SyntaxParser = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleVariableResolver"), "s_SyntaxParser");
					r_s_SyntaxParser.SetBelong(null);
				}
				return r_s_SyntaxParser;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher m_Matcher
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValueMatcher r_m_Matcher;
		public virtual RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValueMatcher Rm_Matcher
		{
			get
			{
				if(r_m_Matcher == null)
				{
					r_m_Matcher = new(this, "m_Matcher");
					r_m_Matcher.SetBelong(this.instance);
				}
				return r_m_Matcher;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyValue] m_ResolvedValues
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> r_m_ResolvedValues;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> Rm_ResolvedValues
		{
			get
			{
				if(r_m_ResolvedValues == null)
				{
					r_m_ResolvedValues = new(this, "m_ResolvedValues");
					r_m_ResolvedValues.SetBelong(this.instance);
				}
				return r_m_ResolvedValues;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[System.String] m_ResolvedVarStack
		/// </summary>
		protected RSystem.RCollections.RGeneric.RStack<RField> r_m_ResolvedVarStack;
		public virtual RSystem.RCollections.RGeneric.RStack<RField> Rm_ResolvedVarStack
		{
			get
			{
				if(r_m_ResolvedVarStack == null)
				{
					r_m_ResolvedVarStack = new(this, "m_ResolvedVarStack");
					r_m_ResolvedVarStack.SetBelong(this.instance);
				}
				return r_m_ResolvedVarStack;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleProperty m_Property
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleProperty r_m_Property;
		public virtual RUnityEngine.RUIElements.RStyleProperty Rm_Property
		{
			get
			{
				if(r_m_Property == null)
				{
					r_m_Property = new(this, "m_Property");
					r_m_Property.SetBelong(this.instance);
				}
				return r_m_Property;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.UIElements.StyleVariableResolver+ResolveContext] m_ContextStack
		/// </summary>
		protected RSystem.RCollections.RGeneric.RStack<RUnityEngine.RUIElements.RStyleVariableResolver.RResolveContext> r_m_ContextStack;
		public virtual RSystem.RCollections.RGeneric.RStack<RUnityEngine.RUIElements.RStyleVariableResolver.RResolveContext> Rm_ContextStack
		{
			get
			{
				if(r_m_ContextStack == null)
				{
					r_m_ContextStack = new(this, "m_ContextStack");
					r_m_ContextStack.SetBelong(this.instance);
				}
				return r_m_ContextStack;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableResolver+ResolveContext m_CurrentContext
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleVariableResolver.RResolveContext r_m_CurrentContext;
		public virtual RUnityEngine.RUIElements.RStyleVariableResolver.RResolveContext Rm_CurrentContext
		{
			get
			{
				if(r_m_CurrentContext == null)
				{
					r_m_CurrentContext = new(this, "m_CurrentContext");
					r_m_CurrentContext.SetBelong(this.instance);
				}
				return r_m_CurrentContext;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext <variableContext>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleVariableContext r___1__variableContext__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RStyleVariableContext R__1__variableContext__2__k__BackingField
		{
			get
			{
				if(r___1__variableContext__2__k__BackingField == null)
				{
					r___1__variableContext__2__k__BackingField = new(this, "<variableContext>k__BackingField");
					r___1__variableContext__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__variableContext__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet currentSheet
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheet r_currentSheet;
		public virtual RUnityEngine.RUIElements.RStyleSheet RcurrentSheet
		{
			get
			{
				if(r_currentSheet == null)
				{
					r_currentSheet = new(this, "currentSheet", -1);
					r_currentSheet.SetBelong(this.instance);
				}
				return r_currentSheet;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueHandle[] currentHandles
		/// </summary>
		protected RPropertyArray<RUnityEngine.RUIElements.RStyleValueHandle> r_currentHandles;
		public virtual RPropertyArray<RUnityEngine.RUIElements.RStyleValueHandle> RcurrentHandles
		{
			get
			{
				if(r_currentHandles == null)
				{
					r_currentHandles = new(this, "currentHandles", -1);
					r_currentHandles.SetBelong(this.instance);
				}
				return r_currentHandles;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyValue] resolvedValues
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> r_resolvedValues;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> RresolvedValues
		{
			get
			{
				if(r_resolvedValues == null)
				{
					r_resolvedValues = new(this, "resolvedValues", -1);
					r_resolvedValues.SetBelong(this.instance);
				}
				return r_resolvedValues;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext variableContext
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleVariableContext r_variableContext;
		public virtual RUnityEngine.RUIElements.RStyleVariableContext RvariableContext
		{
			get
			{
				if(r_variableContext == null)
				{
					r_variableContext = new(this, "variableContext", -1);
					r_variableContext.SetBelong(this.instance);
				}
				return r_variableContext;
			}
		}

		/// <summary>
		/// Void Init(UnityEngine.UIElements.StyleProperty, UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleValueHandle[])
		/// </summary>
		protected RMethod r_RInit_StyleProperty_StyleSheet_StyleValueHandleArray;
		public virtual RMethod RInit_StyleProperty_StyleSheet_StyleValueHandleArray
		{
			get
			{
				if(r_RInit_StyleProperty_StyleSheet_StyleValueHandleArray == null)
				{
					r_RInit_StyleProperty_StyleSheet_StyleValueHandleArray = new(this, "Init", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleProperty"), typeof(UnityEngine.UIElements.StyleSheet),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle").MakeArrayType());
					r_RInit_StyleProperty_StyleSheet_StyleValueHandleArray.SetBelong(this.instance);
				}
				return r_RInit_StyleProperty_StyleSheet_StyleValueHandleArray;
			}
		}

		/// <summary>
		/// Void PushContext(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleValueHandle[])
		/// </summary>
		protected RMethod r_RPushContext_StyleSheet_StyleValueHandleArray;
		public virtual RMethod RPushContext_StyleSheet_StyleValueHandleArray
		{
			get
			{
				if(r_RPushContext_StyleSheet_StyleValueHandleArray == null)
				{
					r_RPushContext_StyleSheet_StyleValueHandleArray = new(this, "PushContext", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle").MakeArrayType());
					r_RPushContext_StyleSheet_StyleValueHandleArray.SetBelong(this.instance);
				}
				return r_RPushContext_StyleSheet_StyleValueHandleArray;
			}
		}

		/// <summary>
		/// Void PopContext()
		/// </summary>
		protected RMethod r_RPopContext;
		public virtual RMethod RPopContext
		{
			get
			{
				if(r_RPopContext == null)
				{
					r_RPopContext = new(this, "PopContext", 0);
					r_RPopContext.SetBelong(this.instance);
				}
				return r_RPopContext;
			}
		}

		/// <summary>
		/// Void AddValue(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RAddValue_StyleValueHandle;
		public virtual RMethod RAddValue_StyleValueHandle
		{
			get
			{
				if(r_RAddValue_StyleValueHandle == null)
				{
					r_RAddValue_StyleValueHandle = new(this, "AddValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RAddValue_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RAddValue_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean ResolveVarFunction(Int32 ByRef)
		/// </summary>
		protected RMethod r_RResolveVarFunction_Ref_Int32;
		public virtual RMethod RResolveVarFunction_Ref_Int32
		{
			get
			{
				if(r_RResolveVarFunction_Ref_Int32 == null)
				{
					r_RResolveVarFunction_Ref_Int32 = new(this, "ResolveVarFunction", 0, typeof(System.Int32).MakeByRefType());
					r_RResolveVarFunction_Ref_Int32.SetBelong(this.instance);
				}
				return r_RResolveVarFunction_Ref_Int32;
			}
		}

		/// <summary>
		/// Result ResolveVarFunction(Int32 ByRef, Int32, System.String)
		/// </summary>
		protected RMethod r_RResolveVarFunction_Ref_Int32_Int32_String;
		public virtual RMethod RResolveVarFunction_Ref_Int32_Int32_String
		{
			get
			{
				if(r_RResolveVarFunction_Ref_Int32_Int32_String == null)
				{
					r_RResolveVarFunction_Ref_Int32_Int32_String = new(this, "ResolveVarFunction", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32), typeof(System.String));
					r_RResolveVarFunction_Ref_Int32_Int32_String.SetBelong(this.instance);
				}
				return r_RResolveVarFunction_Ref_Int32_Int32_String;
			}
		}

		/// <summary>
		/// Boolean ValidateResolvedValues()
		/// </summary>
		protected RMethod r_RValidateResolvedValues;
		public virtual RMethod RValidateResolvedValues
		{
			get
			{
				if(r_RValidateResolvedValues == null)
				{
					r_RValidateResolvedValues = new(this, "ValidateResolvedValues", 0);
					r_RValidateResolvedValues.SetBelong(this.instance);
				}
				return r_RValidateResolvedValues;
			}
		}

		/// <summary>
		/// Result ResolveVariable(System.String)
		/// </summary>
		protected RMethod r_RResolveVariable_String;
		public virtual RMethod RResolveVariable_String
		{
			get
			{
				if(r_RResolveVariable_String == null)
				{
					r_RResolveVariable_String = new(this, "ResolveVariable", 0, typeof(System.String));
					r_RResolveVariable_String.SetBelong(this.instance);
				}
				return r_RResolveVariable_String;
			}
		}

		/// <summary>
		/// Result ResolveFallback(Int32 ByRef)
		/// </summary>
		protected RMethod r_RResolveFallback_Ref_Int32;
		public virtual RMethod RResolveFallback_Ref_Int32
		{
			get
			{
				if(r_RResolveFallback_Ref_Int32 == null)
				{
					r_RResolveFallback_Ref_Int32 = new(this, "ResolveFallback", 0, typeof(System.Int32).MakeByRefType());
					r_RResolveFallback_Ref_Int32.SetBelong(this.instance);
				}
				return r_RResolveFallback_Ref_Int32;
			}
		}

		/// <summary>
		/// Void ParseVarFunction(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleValueHandle[], Int32 ByRef, Int32 ByRef, System.String ByRef)
		/// </summary>
		protected static RMethod r_RParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String;
		public static RMethod RParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String
		{
			get
			{
				if(r_RParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String == null)
				{
					r_RParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleVariableResolver"), "ParseVarFunction", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle").MakeArrayType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.String).MakeByRefType());
					r_RParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String.SetBelong(null);
				}
				return r_RParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String;
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


        public RStyleVariableResolver() : base("UnityEngine.UIElements.StyleVariableResolver")
        {
        }

        public RStyleVariableResolver(System.Object instance) : base("UnityEngine.UIElements.StyleVariableResolver")
		{
            SetInstance(instance);
		}

        public RStyleVariableResolver(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleVariableResolver(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }



        public virtual void PopContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPopContext.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean ResolveVarFunction(ref System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RResolveVarFunction_Ref_Int32.Invoke(___genericsType, ___parameters);
			index = (System.Int32)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Object ResolveVarFunction(ref System.Int32  @index, System.Int32  @argc, System.String  @varName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @argc, @varName};
            var ___result = RResolveVarFunction_Ref_Int32_Int32_String.Invoke(___genericsType, ___parameters);
			index = (System.Int32)___parameters[0];

            return (System.Object)___result;
        }


        public virtual System.Boolean ValidateResolvedValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidateResolvedValues.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object ResolveVariable(System.String  @variableName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@variableName};
            var ___result = RResolveVariable_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ResolveFallback(ref System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RResolveFallback_Ref_Int32.Invoke(___genericsType, ___parameters);
			index = (System.Int32)___parameters[0];

            return (System.Object)___result;
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