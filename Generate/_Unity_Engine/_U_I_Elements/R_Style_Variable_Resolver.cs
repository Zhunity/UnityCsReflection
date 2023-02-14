
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleVariableResolver
	/// </summary>
    public partial class RStyleVariableResolver : RMember //
    {

		/// <summary>
		/// System.Int32 kMaxResolves
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FkMaxResolves;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFkMaxResolves
		{
			get
			{
				if(r_FkMaxResolves == null)
				{
					r_FkMaxResolves = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleVariableResolver"), "kMaxResolves");
					r_FkMaxResolves.SetBelong(null);
				}
				return r_FkMaxResolves;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser s_SyntaxParser
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxParser r_Fs_SyntaxParser;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxParser RFs_SyntaxParser
		{
			get
			{
				if(r_Fs_SyntaxParser == null)
				{
					r_Fs_SyntaxParser = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleVariableResolver"), "s_SyntaxParser");
					r_Fs_SyntaxParser.SetBelong(null);
				}
				return r_Fs_SyntaxParser;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher m_Matcher
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValueMatcher r_Fm_Matcher;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValueMatcher RFm_Matcher
		{
			get
			{
				if(r_Fm_Matcher == null)
				{
					r_Fm_Matcher = new(this, "m_Matcher");
					r_Fm_Matcher.SetBelong(this.instance);
				}
				return r_Fm_Matcher;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyValue] m_ResolvedValues
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> r_Fm_ResolvedValues;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> RFm_ResolvedValues
		{
			get
			{
				if(r_Fm_ResolvedValues == null)
				{
					r_Fm_ResolvedValues = new(this, "m_ResolvedValues");
					r_Fm_ResolvedValues.SetBelong(this.instance);
				}
				return r_Fm_ResolvedValues;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[System.String] m_ResolvedVarStack
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_ResolvedVarStack;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RSystem.RString> RFm_ResolvedVarStack
		{
			get
			{
				if(r_Fm_ResolvedVarStack == null)
				{
					r_Fm_ResolvedVarStack = new(this, "m_ResolvedVarStack");
					r_Fm_ResolvedVarStack.SetBelong(this.instance);
				}
				return r_Fm_ResolvedVarStack;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleProperty m_Property
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleProperty r_Fm_Property;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleProperty RFm_Property
		{
			get
			{
				if(r_Fm_Property == null)
				{
					r_Fm_Property = new(this, "m_Property");
					r_Fm_Property.SetBelong(this.instance);
				}
				return r_Fm_Property;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.UIElements.StyleVariableResolver+ResolveContext] m_ContextStack
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableResolver.RResolveContext> r_Fm_ContextStack;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableResolver.RResolveContext> RFm_ContextStack
		{
			get
			{
				if(r_Fm_ContextStack == null)
				{
					r_Fm_ContextStack = new(this, "m_ContextStack");
					r_Fm_ContextStack.SetBelong(this.instance);
				}
				return r_Fm_ContextStack;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableResolver+ResolveContext m_CurrentContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableResolver.RResolveContext r_Fm_CurrentContext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableResolver.RResolveContext RFm_CurrentContext
		{
			get
			{
				if(r_Fm_CurrentContext == null)
				{
					r_Fm_CurrentContext = new(this, "m_CurrentContext");
					r_Fm_CurrentContext.SetBelong(this.instance);
				}
				return r_Fm_CurrentContext;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext <variableContext>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableContext r_F__0__variableContext__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableContext RF__0__variableContext__1__k__BackingField
		{
			get
			{
				if(r_F__0__variableContext__1__k__BackingField == null)
				{
					r_F__0__variableContext__1__k__BackingField = new(this, "<variableContext>k__BackingField");
					r_F__0__variableContext__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__variableContext__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet currentSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet r_PcurrentSheet;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet RPcurrentSheet
		{
			get
			{
				if(r_PcurrentSheet == null)
				{
					r_PcurrentSheet = new(this, "currentSheet", -1);
					r_PcurrentSheet.SetBelong(this.instance);
				}
				return r_PcurrentSheet;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueHandle[] currentHandles
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle> r_PcurrentHandles;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle> RPcurrentHandles
		{
			get
			{
				if(r_PcurrentHandles == null)
				{
					r_PcurrentHandles = new(this, "currentHandles", -1);
					r_PcurrentHandles.SetBelong(this.instance);
				}
				return r_PcurrentHandles;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyValue] resolvedValues
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> r_PresolvedValues;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> RPresolvedValues
		{
			get
			{
				if(r_PresolvedValues == null)
				{
					r_PresolvedValues = new(this, "resolvedValues", -1);
					r_PresolvedValues.SetBelong(this.instance);
				}
				return r_PresolvedValues;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext variableContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableContext r_PvariableContext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableContext RPvariableContext
		{
			get
			{
				if(r_PvariableContext == null)
				{
					r_PvariableContext = new(this, "variableContext", -1);
					r_PvariableContext.SetBelong(this.instance);
				}
				return r_PvariableContext;
			}
		}

		/// <summary>
		/// Void Init(UnityEngine.UIElements.StyleProperty, UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleValueHandle[])
		/// </summary>
		protected RMethod r_MInit_StyleProperty_StyleSheet_StyleValueHandleArray;
		public virtual RMethod RMInit_StyleProperty_StyleSheet_StyleValueHandleArray
		{
			get
			{
				if(r_MInit_StyleProperty_StyleSheet_StyleValueHandleArray == null)
				{
					r_MInit_StyleProperty_StyleSheet_StyleValueHandleArray = new(this, "Init", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleProperty"), typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle").MakeArrayType());
					r_MInit_StyleProperty_StyleSheet_StyleValueHandleArray.SetBelong(this.instance);
				}
				return r_MInit_StyleProperty_StyleSheet_StyleValueHandleArray;
			}
		}

		/// <summary>
		/// Void PushContext(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleValueHandle[])
		/// </summary>
		protected RMethod r_MPushContext_StyleSheet_StyleValueHandleArray;
		public virtual RMethod RMPushContext_StyleSheet_StyleValueHandleArray
		{
			get
			{
				if(r_MPushContext_StyleSheet_StyleValueHandleArray == null)
				{
					r_MPushContext_StyleSheet_StyleValueHandleArray = new(this, "PushContext", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle").MakeArrayType());
					r_MPushContext_StyleSheet_StyleValueHandleArray.SetBelong(this.instance);
				}
				return r_MPushContext_StyleSheet_StyleValueHandleArray;
			}
		}

		/// <summary>
		/// Void PopContext()
		/// </summary>
		protected RMethod r_MPopContext;
		public virtual RMethod RMPopContext
		{
			get
			{
				if(r_MPopContext == null)
				{
					r_MPopContext = new(this, "PopContext", 0);
					r_MPopContext.SetBelong(this.instance);
				}
				return r_MPopContext;
			}
		}

		/// <summary>
		/// Void AddValue(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MAddValue_StyleValueHandle;
		public virtual RMethod RMAddValue_StyleValueHandle
		{
			get
			{
				if(r_MAddValue_StyleValueHandle == null)
				{
					r_MAddValue_StyleValueHandle = new(this, "AddValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MAddValue_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MAddValue_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean ResolveVarFunction(Int32 ByRef)
		/// </summary>
		protected RMethod r_MResolveVarFunction_Ref_Int32;
		public virtual RMethod RMResolveVarFunction_Ref_Int32
		{
			get
			{
				if(r_MResolveVarFunction_Ref_Int32 == null)
				{
					r_MResolveVarFunction_Ref_Int32 = new(this, "ResolveVarFunction", 0, typeof(System.Int32).MakeByRefType());
					r_MResolveVarFunction_Ref_Int32.SetBelong(this.instance);
				}
				return r_MResolveVarFunction_Ref_Int32;
			}
		}

		/// <summary>
		/// Result ResolveVarFunction(Int32 ByRef, Int32, System.String)
		/// </summary>
		protected RMethod r_MResolveVarFunction_Ref_Int32_Int32_String;
		public virtual RMethod RMResolveVarFunction_Ref_Int32_Int32_String
		{
			get
			{
				if(r_MResolveVarFunction_Ref_Int32_Int32_String == null)
				{
					r_MResolveVarFunction_Ref_Int32_Int32_String = new(this, "ResolveVarFunction", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32), typeof(System.String));
					r_MResolveVarFunction_Ref_Int32_Int32_String.SetBelong(this.instance);
				}
				return r_MResolveVarFunction_Ref_Int32_Int32_String;
			}
		}

		/// <summary>
		/// Boolean ValidateResolvedValues()
		/// </summary>
		protected RMethod r_MValidateResolvedValues;
		public virtual RMethod RMValidateResolvedValues
		{
			get
			{
				if(r_MValidateResolvedValues == null)
				{
					r_MValidateResolvedValues = new(this, "ValidateResolvedValues", 0);
					r_MValidateResolvedValues.SetBelong(this.instance);
				}
				return r_MValidateResolvedValues;
			}
		}

		/// <summary>
		/// Result ResolveVariable(System.String)
		/// </summary>
		protected RMethod r_MResolveVariable_String;
		public virtual RMethod RMResolveVariable_String
		{
			get
			{
				if(r_MResolveVariable_String == null)
				{
					r_MResolveVariable_String = new(this, "ResolveVariable", 0, typeof(System.String));
					r_MResolveVariable_String.SetBelong(this.instance);
				}
				return r_MResolveVariable_String;
			}
		}

		/// <summary>
		/// Result ResolveFallback(Int32 ByRef)
		/// </summary>
		protected RMethod r_MResolveFallback_Ref_Int32;
		public virtual RMethod RMResolveFallback_Ref_Int32
		{
			get
			{
				if(r_MResolveFallback_Ref_Int32 == null)
				{
					r_MResolveFallback_Ref_Int32 = new(this, "ResolveFallback", 0, typeof(System.Int32).MakeByRefType());
					r_MResolveFallback_Ref_Int32.SetBelong(this.instance);
				}
				return r_MResolveFallback_Ref_Int32;
			}
		}

		/// <summary>
		/// Void ParseVarFunction(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleValueHandle[], Int32 ByRef, Int32 ByRef, System.String ByRef)
		/// </summary>
		protected static RMethod r_MParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String;
		public static RMethod RMParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String
		{
			get
			{
				if(r_MParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String == null)
				{
					r_MParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleVariableResolver"), "ParseVarFunction", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle").MakeArrayType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.String).MakeByRefType());
					r_MParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String.SetBelong(null);
				}
				return r_MParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String;
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

        public virtual void Init(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleProperty @property, UnityEngine.UIElements.StyleSheet @sheet, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle> @handles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property.Value, @sheet, @handles.Value};
            var ___result = RMInit_StyleProperty_StyleSheet_StyleValueHandleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PushContext(UnityEngine.UIElements.StyleSheet @sheet, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle> @handles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @handles.Value};
            var ___result = RMPushContext_StyleSheet_StyleValueHandleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PopContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPopContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMAddValue_StyleValueHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ResolveVarFunction(ref System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMResolveVarFunction_Ref_Int32.Invoke(___genericsType, ___parameters);
			@index = (System.Int32)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableResolver.RResult ResolveVarFunction(ref System.Int32 @index, System.Int32 @argc, System.String @varName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @argc, @varName};
            var ___result = RMResolveVarFunction_Ref_Int32_Int32_String.Invoke(___genericsType, ___parameters);
			@index = (System.Int32)___parameters[0];

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableResolver.RResult(___result);
        }


        public virtual System.Boolean ValidateResolvedValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValidateResolvedValues.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableResolver.RResult ResolveVariable(System.String @variableName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@variableName};
            var ___result = RMResolveVariable_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableResolver.RResult(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableResolver.RResult ResolveFallback(ref System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMResolveFallback_Ref_Int32.Invoke(___genericsType, ___parameters);
			@index = (System.Int32)___parameters[0];

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableResolver.RResult(___result);
        }


        public static void ParseVarFunction(UnityEngine.UIElements.StyleSheet @sheet, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle> @handles, ref System.Int32 @index, out System.Int32 @argCount, out System.String @variableName)
        {
			@argCount = default;
			@variableName = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @handles.Value, @index, @argCount, @variableName};
            var ___result = RMParseVarFunction_StyleSheet_StyleValueHandleArray_Ref_Int32_Out_Int32_Out_String.Invoke(___genericsType, ___parameters);
			@index = (System.Int32)___parameters[2];
			@argCount = (System.Int32)___parameters[3];
			@variableName = (System.String)___parameters[4];

            
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
