
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.ConstructorInfo
	/// </summary>
    public partial class RConstructorInfo : RMember //
    {

		/// <summary>
		/// System.String ConstructorName
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RString r_FConstructorName;
		public static SMFrame.Editor.Refleaction.RSystem.RString RFConstructorName
		{
			get
			{
				if(r_FConstructorName == null)
				{
					r_FConstructorName = new(typeof(System.Reflection.ConstructorInfo), "ConstructorName");
					r_FConstructorName.SetBelong(null);
				}
				return r_FConstructorName;
			}
		}

		/// <summary>
		/// System.String TypeConstructorName
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RString r_FTypeConstructorName;
		public static SMFrame.Editor.Refleaction.RSystem.RString RFTypeConstructorName
		{
			get
			{
				if(r_FTypeConstructorName == null)
				{
					r_FTypeConstructorName = new(typeof(System.Reflection.ConstructorInfo), "TypeConstructorName");
					r_FTypeConstructorName.SetBelong(null);
				}
				return r_FTypeConstructorName;
			}
		}

		/// <summary>
		/// System.Reflection.MemberTypes MemberType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMemberTypes r_PMemberType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMemberTypes RPMemberType
		{
			get
			{
				if(r_PMemberType == null)
				{
					r_PMemberType = new(this, "MemberType", -1);
					r_PMemberType.SetBelong(this.instance);
				}
				return r_PMemberType;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes Attributes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_PAttributes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
					r_PAttributes.SetBelong(this.instance);
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes MethodImplementationFlags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_PMethodImplementationFlags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RPMethodImplementationFlags
		{
			get
			{
				if(r_PMethodImplementationFlags == null)
				{
					r_PMethodImplementationFlags = new(this, "MethodImplementationFlags", -1);
					r_PMethodImplementationFlags.SetBelong(this.instance);
				}
				return r_PMethodImplementationFlags;
			}
		}

		/// <summary>
		/// System.Reflection.CallingConventions CallingConvention
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RCallingConventions r_PCallingConvention;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RCallingConventions RPCallingConvention
		{
			get
			{
				if(r_PCallingConvention == null)
				{
					r_PCallingConvention = new(this, "CallingConvention", -1);
					r_PCallingConvention.SetBelong(this.instance);
				}
				return r_PCallingConvention;
			}
		}

		/// <summary>
		/// Boolean IsAbstract
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsAbstract;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsAbstract
		{
			get
			{
				if(r_PIsAbstract == null)
				{
					r_PIsAbstract = new(this, "IsAbstract", -1);
					r_PIsAbstract.SetBelong(this.instance);
				}
				return r_PIsAbstract;
			}
		}

		/// <summary>
		/// Boolean IsConstructor
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsConstructor;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsConstructor
		{
			get
			{
				if(r_PIsConstructor == null)
				{
					r_PIsConstructor = new(this, "IsConstructor", -1);
					r_PIsConstructor.SetBelong(this.instance);
				}
				return r_PIsConstructor;
			}
		}

		/// <summary>
		/// Boolean IsFinal
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFinal;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFinal
		{
			get
			{
				if(r_PIsFinal == null)
				{
					r_PIsFinal = new(this, "IsFinal", -1);
					r_PIsFinal.SetBelong(this.instance);
				}
				return r_PIsFinal;
			}
		}

		/// <summary>
		/// Boolean IsHideBySig
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsHideBySig;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsHideBySig
		{
			get
			{
				if(r_PIsHideBySig == null)
				{
					r_PIsHideBySig = new(this, "IsHideBySig", -1);
					r_PIsHideBySig.SetBelong(this.instance);
				}
				return r_PIsHideBySig;
			}
		}

		/// <summary>
		/// Boolean IsSpecialName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSpecialName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSpecialName
		{
			get
			{
				if(r_PIsSpecialName == null)
				{
					r_PIsSpecialName = new(this, "IsSpecialName", -1);
					r_PIsSpecialName.SetBelong(this.instance);
				}
				return r_PIsSpecialName;
			}
		}

		/// <summary>
		/// Boolean IsStatic
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsStatic;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsStatic
		{
			get
			{
				if(r_PIsStatic == null)
				{
					r_PIsStatic = new(this, "IsStatic", -1);
					r_PIsStatic.SetBelong(this.instance);
				}
				return r_PIsStatic;
			}
		}

		/// <summary>
		/// Boolean IsVirtual
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsVirtual;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsVirtual
		{
			get
			{
				if(r_PIsVirtual == null)
				{
					r_PIsVirtual = new(this, "IsVirtual", -1);
					r_PIsVirtual.SetBelong(this.instance);
				}
				return r_PIsVirtual;
			}
		}

		/// <summary>
		/// Boolean IsAssembly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsAssembly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsAssembly
		{
			get
			{
				if(r_PIsAssembly == null)
				{
					r_PIsAssembly = new(this, "IsAssembly", -1);
					r_PIsAssembly.SetBelong(this.instance);
				}
				return r_PIsAssembly;
			}
		}

		/// <summary>
		/// Boolean IsFamily
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFamily;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFamily
		{
			get
			{
				if(r_PIsFamily == null)
				{
					r_PIsFamily = new(this, "IsFamily", -1);
					r_PIsFamily.SetBelong(this.instance);
				}
				return r_PIsFamily;
			}
		}

		/// <summary>
		/// Boolean IsFamilyAndAssembly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFamilyAndAssembly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFamilyAndAssembly
		{
			get
			{
				if(r_PIsFamilyAndAssembly == null)
				{
					r_PIsFamilyAndAssembly = new(this, "IsFamilyAndAssembly", -1);
					r_PIsFamilyAndAssembly.SetBelong(this.instance);
				}
				return r_PIsFamilyAndAssembly;
			}
		}

		/// <summary>
		/// Boolean IsFamilyOrAssembly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFamilyOrAssembly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFamilyOrAssembly
		{
			get
			{
				if(r_PIsFamilyOrAssembly == null)
				{
					r_PIsFamilyOrAssembly = new(this, "IsFamilyOrAssembly", -1);
					r_PIsFamilyOrAssembly.SetBelong(this.instance);
				}
				return r_PIsFamilyOrAssembly;
			}
		}

		/// <summary>
		/// Boolean IsPrivate
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsPrivate;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsPrivate
		{
			get
			{
				if(r_PIsPrivate == null)
				{
					r_PIsPrivate = new(this, "IsPrivate", -1);
					r_PIsPrivate.SetBelong(this.instance);
				}
				return r_PIsPrivate;
			}
		}

		/// <summary>
		/// Boolean IsPublic
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsPublic;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsPublic
		{
			get
			{
				if(r_PIsPublic == null)
				{
					r_PIsPublic = new(this, "IsPublic", -1);
					r_PIsPublic.SetBelong(this.instance);
				}
				return r_PIsPublic;
			}
		}

		/// <summary>
		/// Boolean IsConstructedGenericMethod
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsConstructedGenericMethod;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsConstructedGenericMethod
		{
			get
			{
				if(r_PIsConstructedGenericMethod == null)
				{
					r_PIsConstructedGenericMethod = new(this, "IsConstructedGenericMethod", -1);
					r_PIsConstructedGenericMethod.SetBelong(this.instance);
				}
				return r_PIsConstructedGenericMethod;
			}
		}

		/// <summary>
		/// Boolean IsGenericMethod
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsGenericMethod;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsGenericMethod
		{
			get
			{
				if(r_PIsGenericMethod == null)
				{
					r_PIsGenericMethod = new(this, "IsGenericMethod", -1);
					r_PIsGenericMethod.SetBelong(this.instance);
				}
				return r_PIsGenericMethod;
			}
		}

		/// <summary>
		/// Boolean IsGenericMethodDefinition
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsGenericMethodDefinition;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsGenericMethodDefinition
		{
			get
			{
				if(r_PIsGenericMethodDefinition == null)
				{
					r_PIsGenericMethodDefinition = new(this, "IsGenericMethodDefinition", -1);
					r_PIsGenericMethodDefinition.SetBelong(this.instance);
				}
				return r_PIsGenericMethodDefinition;
			}
		}

		/// <summary>
		/// Boolean ContainsGenericParameters
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PContainsGenericParameters;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPContainsGenericParameters
		{
			get
			{
				if(r_PContainsGenericParameters == null)
				{
					r_PContainsGenericParameters = new(this, "ContainsGenericParameters", -1);
					r_PContainsGenericParameters.SetBelong(this.instance);
				}
				return r_PContainsGenericParameters;
			}
		}

		/// <summary>
		/// System.RuntimeMethodHandle MethodHandle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntimeMethodHandle r_PMethodHandle;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntimeMethodHandle RPMethodHandle
		{
			get
			{
				if(r_PMethodHandle == null)
				{
					r_PMethodHandle = new(this, "MethodHandle", -1);
					r_PMethodHandle.SetBelong(this.instance);
				}
				return r_PMethodHandle;
			}
		}

		/// <summary>
		/// Boolean IsSecurityCritical
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSecurityCritical;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSecurityCritical
		{
			get
			{
				if(r_PIsSecurityCritical == null)
				{
					r_PIsSecurityCritical = new(this, "IsSecurityCritical", -1);
					r_PIsSecurityCritical.SetBelong(this.instance);
				}
				return r_PIsSecurityCritical;
			}
		}

		/// <summary>
		/// Boolean IsSecuritySafeCritical
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSecuritySafeCritical;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSecuritySafeCritical
		{
			get
			{
				if(r_PIsSecuritySafeCritical == null)
				{
					r_PIsSecuritySafeCritical = new(this, "IsSecuritySafeCritical", -1);
					r_PIsSecuritySafeCritical.SetBelong(this.instance);
				}
				return r_PIsSecuritySafeCritical;
			}
		}

		/// <summary>
		/// Boolean IsSecurityTransparent
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSecurityTransparent;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSecurityTransparent
		{
			get
			{
				if(r_PIsSecurityTransparent == null)
				{
					r_PIsSecurityTransparent = new(this, "IsSecurityTransparent", -1);
					r_PIsSecurityTransparent.SetBelong(this.instance);
				}
				return r_PIsSecurityTransparent;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.Type DeclaringType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PDeclaringType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPDeclaringType
		{
			get
			{
				if(r_PDeclaringType == null)
				{
					r_PDeclaringType = new(this, "DeclaringType", -1);
					r_PDeclaringType.SetBelong(this.instance);
				}
				return r_PDeclaringType;
			}
		}

		/// <summary>
		/// System.Type ReflectedType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PReflectedType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPReflectedType
		{
			get
			{
				if(r_PReflectedType == null)
				{
					r_PReflectedType = new(this, "ReflectedType", -1);
					r_PReflectedType.SetBelong(this.instance);
				}
				return r_PReflectedType;
			}
		}

		/// <summary>
		/// System.Reflection.Module Module
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RModule r_PModule;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RModule RPModule
		{
			get
			{
				if(r_PModule == null)
				{
					r_PModule = new(this, "Module", -1);
					r_PModule.SetBelong(this.instance);
				}
				return r_PModule;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> r_PCustomAttributes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> RPCustomAttributes
		{
			get
			{
				if(r_PCustomAttributes == null)
				{
					r_PCustomAttributes = new(this, "CustomAttributes", -1);
					r_PCustomAttributes.SetBelong(this.instance);
				}
				return r_PCustomAttributes;
			}
		}

		/// <summary>
		/// Int32 MetadataToken
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PMetadataToken;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPMetadataToken
		{
			get
			{
				if(r_PMetadataToken == null)
				{
					r_PMetadataToken = new(this, "MetadataToken", -1);
					r_PMetadataToken.SetBelong(this.instance);
				}
				return r_PMetadataToken;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Object[])
		/// </summary>
		protected RMethod r_MInvoke_ObjectArray;
		public virtual RMethod RMInvoke_ObjectArray
		{
			get
			{
				if(r_MInvoke_ObjectArray == null)
				{
					r_MInvoke_ObjectArray = new(this, "Invoke", 0, typeof(System.Object).MakeArrayType());
					r_MInvoke_ObjectArray.SetBelong(this.instance);
				}
				return r_MInvoke_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MInvoke_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RMInvoke_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_MInvoke_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_MInvoke_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "Invoke", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_MInvoke_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_MInvoke_BindingFlags_Binder_ObjectArray_CultureInfo;
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
		/// Boolean op_Equality(System.Reflection.ConstructorInfo, System.Reflection.ConstructorInfo)
		/// </summary>
		protected static RMethod r_Mop_Equality_ConstructorInfo_ConstructorInfo;
		public static RMethod RMop_Equality_ConstructorInfo_ConstructorInfo
		{
			get
			{
				if(r_Mop_Equality_ConstructorInfo_ConstructorInfo == null)
				{
					r_Mop_Equality_ConstructorInfo_ConstructorInfo = new(typeof(System.Reflection.ConstructorInfo), "op_Equality", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Reflection.ConstructorInfo));
					r_Mop_Equality_ConstructorInfo_ConstructorInfo.SetBelong(null);
				}
				return r_Mop_Equality_ConstructorInfo_ConstructorInfo;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.ConstructorInfo, System.Reflection.ConstructorInfo)
		/// </summary>
		protected static RMethod r_Mop_Inequality_ConstructorInfo_ConstructorInfo;
		public static RMethod RMop_Inequality_ConstructorInfo_ConstructorInfo
		{
			get
			{
				if(r_Mop_Inequality_ConstructorInfo_ConstructorInfo == null)
				{
					r_Mop_Inequality_ConstructorInfo_ConstructorInfo = new(typeof(System.Reflection.ConstructorInfo), "op_Inequality", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Reflection.ConstructorInfo));
					r_Mop_Inequality_ConstructorInfo_ConstructorInfo.SetBelong(null);
				}
				return r_Mop_Inequality_ConstructorInfo_ConstructorInfo;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ConstructorInfo.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ConstructorInfo.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// System.Type System.Runtime.InteropServices._ConstructorInfo.GetType()
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetType;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetType
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetType == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetType = new(this, "System.Runtime.InteropServices._ConstructorInfo.GetType", 0);
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetType.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetType;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ConstructorInfo.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ConstructorInfo.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ConstructorInfo.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._ConstructorInfo.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ConstructorInfo.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._ConstructorInfo.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Object System.Runtime.InteropServices._ConstructorInfo.Invoke_2(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_2_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_2_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_2_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_2_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "System.Runtime.InteropServices._ConstructorInfo.Invoke_2", 0, typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_2_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_2_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Object System.Runtime.InteropServices._ConstructorInfo.Invoke_3(System.Object, System.Object[])
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_3_Object_ObjectArray;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_3_Object_ObjectArray
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_3_Object_ObjectArray == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_3_Object_ObjectArray = new(this, "System.Runtime.InteropServices._ConstructorInfo.Invoke_3", 0, typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_3_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_3_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object System.Runtime.InteropServices._ConstructorInfo.Invoke_4(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_4_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_4_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_4_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_4_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "System.Runtime.InteropServices._ConstructorInfo.Invoke_4", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_4_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_4_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Object System.Runtime.InteropServices._ConstructorInfo.Invoke_5(System.Object[])
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_5_ObjectArray;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_5_ObjectArray
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_5_ObjectArray == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_5_ObjectArray = new(this, "System.Runtime.InteropServices._ConstructorInfo.Invoke_5", 0, typeof(System.Object).MakeArrayType());
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_5_ObjectArray.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_5_ObjectArray;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParameters()
		/// </summary>
		protected RMethod r_MGetParameters;
		public virtual RMethod RMGetParameters
		{
			get
			{
				if(r_MGetParameters == null)
				{
					r_MGetParameters = new(this, "GetParameters", 0);
					r_MGetParameters.SetBelong(this.instance);
				}
				return r_MGetParameters;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes GetMethodImplementationFlags()
		/// </summary>
		protected RMethod r_MGetMethodImplementationFlags;
		public virtual RMethod RMGetMethodImplementationFlags
		{
			get
			{
				if(r_MGetMethodImplementationFlags == null)
				{
					r_MGetMethodImplementationFlags = new(this, "GetMethodImplementationFlags", 0);
					r_MGetMethodImplementationFlags.SetBelong(this.instance);
				}
				return r_MGetMethodImplementationFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBody GetMethodBody()
		/// </summary>
		protected RMethod r_MGetMethodBody;
		public virtual RMethod RMGetMethodBody
		{
			get
			{
				if(r_MGetMethodBody == null)
				{
					r_MGetMethodBody = new(this, "GetMethodBody", 0);
					r_MGetMethodBody.SetBelong(this.instance);
				}
				return r_MGetMethodBody;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericArguments()
		/// </summary>
		protected RMethod r_MGetGenericArguments;
		public virtual RMethod RMGetGenericArguments
		{
			get
			{
				if(r_MGetGenericArguments == null)
				{
					r_MGetGenericArguments = new(this, "GetGenericArguments", 0);
					r_MGetGenericArguments.SetBelong(this.instance);
				}
				return r_MGetGenericArguments;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Object, System.Object[])
		/// </summary>
		protected RMethod r_MInvoke_Object_ObjectArray;
		public virtual RMethod RMInvoke_Object_ObjectArray
		{
			get
			{
				if(r_MInvoke_Object_ObjectArray == null)
				{
					r_MInvoke_Object_ObjectArray = new(this, "Invoke", 0, typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_MInvoke_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_MInvoke_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RMInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "Invoke", 0, typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParametersInternal()
		/// </summary>
		protected RMethod r_MGetParametersInternal;
		public virtual RMethod RMGetParametersInternal
		{
			get
			{
				if(r_MGetParametersInternal == null)
				{
					r_MGetParametersInternal = new(this, "GetParametersInternal", 0);
					r_MGetParametersInternal.SetBelong(this.instance);
				}
				return r_MGetParametersInternal;
			}
		}

		/// <summary>
		/// Int32 GetParametersCount()
		/// </summary>
		protected RMethod r_MGetParametersCount;
		public virtual RMethod RMGetParametersCount
		{
			get
			{
				if(r_MGetParametersCount == null)
				{
					r_MGetParametersCount = new(this, "GetParametersCount", 0);
					r_MGetParametersCount.SetBelong(this.instance);
				}
				return r_MGetParametersCount;
			}
		}

		/// <summary>
		/// System.Type GetParameterType(Int32)
		/// </summary>
		protected RMethod r_MGetParameterType_Int32;
		public virtual RMethod RMGetParameterType_Int32
		{
			get
			{
				if(r_MGetParameterType_Int32 == null)
				{
					r_MGetParameterType_Int32 = new(this, "GetParameterType", 0, typeof(System.Int32));
					r_MGetParameterType_Int32.SetBelong(this.instance);
				}
				return r_MGetParameterType_Int32;
			}
		}

		/// <summary>
		/// Int32 get_next_table_index(System.Object, Int32, Int32)
		/// </summary>
		protected RMethod r_Mget_next_table_index_Object_Int32_Int32;
		public virtual RMethod RMget_next_table_index_Object_Int32_Int32
		{
			get
			{
				if(r_Mget_next_table_index_Object_Int32_Int32 == null)
				{
					r_Mget_next_table_index_Object_Int32_Int32 = new(this, "get_next_table_index", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_Mget_next_table_index_Object_Int32_Int32.SetBelong(this.instance);
				}
				return r_Mget_next_table_index_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String FormatNameAndSig(Boolean)
		/// </summary>
		protected RMethod r_MFormatNameAndSig_Boolean;
		public virtual RMethod RMFormatNameAndSig_Boolean
		{
			get
			{
				if(r_MFormatNameAndSig_Boolean == null)
				{
					r_MFormatNameAndSig_Boolean = new(this, "FormatNameAndSig", 0, typeof(System.Boolean));
					r_MFormatNameAndSig_Boolean.SetBelong(this.instance);
				}
				return r_MFormatNameAndSig_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetParameterTypes()
		/// </summary>
		protected RMethod r_MGetParameterTypes;
		public virtual RMethod RMGetParameterTypes
		{
			get
			{
				if(r_MGetParameterTypes == null)
				{
					r_MGetParameterTypes = new(this, "GetParameterTypes", 0);
					r_MGetParameterTypes.SetBelong(this.instance);
				}
				return r_MGetParameterTypes;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParametersNoCopy()
		/// </summary>
		protected RMethod r_MGetParametersNoCopy;
		public virtual RMethod RMGetParametersNoCopy
		{
			get
			{
				if(r_MGetParametersNoCopy == null)
				{
					r_MGetParametersNoCopy = new(this, "GetParametersNoCopy", 0);
					r_MGetParametersNoCopy.SetBelong(this.instance);
				}
				return r_MGetParametersNoCopy;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_MHasSameMetadataDefinitionAs_MemberInfo;
		public virtual RMethod RMHasSameMetadataDefinitionAs_MemberInfo
		{
			get
			{
				if(r_MHasSameMetadataDefinitionAs_MemberInfo == null)
				{
					r_MHasSameMetadataDefinitionAs_MemberInfo = new(this, "HasSameMetadataDefinitionAs", 0, typeof(System.Reflection.MemberInfo));
					r_MHasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.instance);
				}
				return r_MHasSameMetadataDefinitionAs_MemberInfo;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MIsDefined_Type_Boolean;
		public virtual RMethod RMIsDefined_Type_Boolean
		{
			get
			{
				if(r_MIsDefined_Type_Boolean == null)
				{
					r_MIsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
					r_MIsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_MIsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_MGetCustomAttributes_Boolean;
		public virtual RMethod RMGetCustomAttributes_Boolean
		{
			get
			{
				if(r_MGetCustomAttributes_Boolean == null)
				{
					r_MGetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
					r_MGetCustomAttributes_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetCustomAttributes_Type_Boolean;
		public virtual RMethod RMGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_MGetCustomAttributes_Type_Boolean == null)
				{
					r_MGetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
					r_MGetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_MGetCustomAttributesData;
		public virtual RMethod RMGetCustomAttributesData
		{
			get
			{
				if(r_MGetCustomAttributesData == null)
				{
					r_MGetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
					r_MGetCustomAttributesData.SetBelong(this.instance);
				}
				return r_MGetCustomAttributesData;
			}
		}

		/// <summary>
		/// Boolean CacheEquals(System.Object)
		/// </summary>
		protected RMethod r_MCacheEquals_Object;
		public virtual RMethod RMCacheEquals_Object
		{
			get
			{
				if(r_MCacheEquals_Object == null)
				{
					r_MCacheEquals_Object = new(this, "CacheEquals", 0, typeof(System.Object));
					r_MCacheEquals_Object.SetBelong(this.instance);
				}
				return r_MCacheEquals_Object;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAsCore[TOther](System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
		public virtual RMethod RMHasSameMetadataDefinitionAsCore_GTOther_MemberInfo
		{
			get
			{
				if(r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo == null)
				{
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo = new(this, "HasSameMetadataDefinitionAsCore", 1, typeof(System.Reflection.MemberInfo));
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.instance);
				}
				return r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
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


        public RConstructorInfo() : base("System.Reflection.ConstructorInfo")
        {
        }

        public RConstructorInfo(System.Object instance) : base("System.Reflection.ConstructorInfo")
		{
            SetInstance(instance);
		}

        public RConstructorInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RConstructorInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object Invoke(System.Object[] @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameters};
            var ___result = RMInvoke_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Invoke(System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @parameters, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@invokeAttr, @binder, @parameters, @culture};
            var ___result = RMInvoke_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public static System.Boolean op_Equality(System.Reflection.ConstructorInfo @left, System.Reflection.ConstructorInfo @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_ConstructorInfo_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.ConstructorInfo @left, System.Reflection.ConstructorInfo @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_ConstructorInfo_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type System__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object System__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_2(System.Object @obj, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @parameters, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @parameters, @culture};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_2_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object System__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_3(System.Object @obj, System.Object[] @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @parameters};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_3_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object System__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_4(System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @parameters, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@invokeAttr, @binder, @parameters, @culture};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_4_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object System__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_5(System.Object[] @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameters};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorInfo__2__Invoke_5_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetParameters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParameters.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
        }


        public virtual System.Reflection.MethodImplAttributes GetMethodImplementationFlags()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethodImplementationFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodImplAttributes)___result;
        }


        public virtual System.Reflection.MethodBody GetMethodBody()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethodBody.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBody)___result;
        }


        public virtual System.Type[] GetGenericArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericArguments.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Object Invoke(System.Object @obj, System.Object[] @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @parameters};
            var ___result = RMInvoke_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Invoke(System.Object @obj, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @parameters, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @parameters, @culture};
            var ___result = RMInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetParametersInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParametersInternal.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
        }


        public virtual System.Int32 GetParametersCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParametersCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetParameterType(System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RMGetParameterType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Int32 get_next_table_index(System.Object @obj, System.Int32 @table, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @table, @count};
            var ___result = RMget_next_table_index_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String FormatNameAndSig(System.Boolean @serialization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serialization};
            var ___result = RMFormatNameAndSig_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Type[] GetParameterTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParameterTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetParametersNoCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParametersNoCopy.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RMGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Boolean CacheEquals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMCacheEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAsCore<TOther>(System.Reflection.MemberInfo @other) where TOther : System.Reflection.MemberInfo
        {

            var ___genericsType = new Type[] {typeof(TOther)};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}