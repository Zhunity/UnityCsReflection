
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.UIError
	/// </summary>
    public partial class RUIError : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError");
            }
        }

        public RUIError() : base("UnityEditor.PackageManager.UI.Internal.UIError")
        {
        }

        public RUIError(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.UIError")
		{
            SetInstance(instance);
		}

        public RUIError(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUIError(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String k_EntitlementErrorMessage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_EntitlementErrorMessage;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_EntitlementErrorMessage
		{
			get
			{
				if(r_Fk_EntitlementErrorMessage == null)
				{
					r_Fk_EntitlementErrorMessage = new(Type, "k_EntitlementErrorMessage");
				}
				return r_Fk_EntitlementErrorMessage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIError k_EntitlementError
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError r_Fk_EntitlementError;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError RFk_EntitlementError
		{
			get
			{
				if(r_Fk_EntitlementError == null)
				{
					r_Fk_EntitlementError = new(Type, "k_EntitlementError");
				}
				return r_Fk_EntitlementError;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIError k_EntitlementWarning
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError r_Fk_EntitlementWarning;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError RFk_EntitlementWarning
		{
			get
			{
				if(r_Fk_EntitlementWarning == null)
				{
					r_Fk_EntitlementWarning = new(Type, "k_EntitlementWarning");
				}
				return r_Fk_EntitlementWarning;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode m_UIErrorCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_Fm_UIErrorCode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFm_UIErrorCode
		{
			get
			{
				if(r_Fm_UIErrorCode == null)
				{
					r_Fm_UIErrorCode = new(this, "m_UIErrorCode");
				}
				return r_Fm_UIErrorCode;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIError+Attribute m_Attribute
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError.RAttribute r_Fm_Attribute;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError.RAttribute RFm_Attribute
		{
			get
			{
				if(r_Fm_Attribute == null)
				{
					r_Fm_Attribute = new(this, "m_Attribute");
				}
				return r_Fm_Attribute;
			}
		}

		/// <summary>
		/// System.Int32 m_OperationErrorCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_OperationErrorCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_OperationErrorCode
		{
			get
			{
				if(r_Fm_OperationErrorCode == null)
				{
					r_Fm_OperationErrorCode = new(this, "m_OperationErrorCode");
				}
				return r_Fm_OperationErrorCode;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode errorCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_PerrorCode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RPerrorCode
		{
			get
			{
				if(r_PerrorCode == null)
				{
					r_PerrorCode = new(this, "errorCode", -1);
				}
				return r_PerrorCode;
			}
		}

		/// <summary>
		/// Int32 operationErrorCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PoperationErrorCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPoperationErrorCode
		{
			get
			{
				if(r_PoperationErrorCode == null)
				{
					r_PoperationErrorCode = new(this, "operationErrorCode", -1);
				}
				return r_PoperationErrorCode;
			}
		}

		/// <summary>
		/// Attribute attribute
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError.RAttribute r_Pattribute;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError.RAttribute RPattribute
		{
			get
			{
				if(r_Pattribute == null)
				{
					r_Pattribute = new(this, "attribute", -1);
				}
				return r_Pattribute;
			}
		}

		/// <summary>
		/// System.String message
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pmessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPmessage
		{
			get
			{
				if(r_Pmessage == null)
				{
					r_Pmessage = new(this, "message", -1);
				}
				return r_Pmessage;
			}
		}

		/// <summary>
		/// Boolean HasAttribute(Attribute)
		/// </summary>
		protected RMethod r_MHasAttribute_Attribute;
		public virtual RMethod RMHasAttribute_Attribute
		{
			get
			{
				if(r_MHasAttribute_Attribute == null)
				{
					r_MHasAttribute_Attribute = new(this, "HasAttribute", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError+Attribute"));
				}
				return r_MHasAttribute_Attribute;
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


        public virtual System.Boolean HasAttribute(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError.RAttribute @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attribute.Value};
            var ___result = RMHasAttribute_Attribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
