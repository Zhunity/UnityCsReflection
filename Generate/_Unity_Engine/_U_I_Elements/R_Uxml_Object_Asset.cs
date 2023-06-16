
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UxmlObjectAsset
	/// </summary>
    public partial class RUxmlObjectAsset : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UxmlObjectAsset");
            }
        }

        public RUxmlObjectAsset() : base("UnityEngine.UIElements.UxmlObjectAsset")
        {
        }

        public RUxmlObjectAsset(System.Object instance) : base("UnityEngine.UIElements.UxmlObjectAsset")
		{
            SetInstance(instance);
		}

        public RUxmlObjectAsset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUxmlObjectAsset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_Properties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_Properties;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_Properties
		{
			get
			{
				if(r_Fm_Properties == null)
				{
					r_Fm_Properties = new(this, "m_Properties");
				}
				return r_Fm_Properties;
			}
		}

		/// <summary>
		/// System.String fullTypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PfullTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPfullTypeName
		{
			get
			{
				if(r_PfullTypeName == null)
				{
					r_PfullTypeName = new(this, "fullTypeName", -1);
				}
				return r_PfullTypeName;
			}
		}

		/// <summary>
		/// Int32 id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pid;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// Int32 orderInDocument
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PorderInDocument;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPorderInDocument
		{
			get
			{
				if(r_PorderInDocument == null)
				{
					r_PorderInDocument = new(this, "orderInDocument", -1);
				}
				return r_PorderInDocument;
			}
		}

		/// <summary>
		/// Int32 parentId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PparentId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPparentId
		{
			get
			{
				if(r_PparentId == null)
				{
					r_PparentId = new(this, "parentId", -1);
				}
				return r_PparentId;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetProperties()
		/// </summary>
		protected RMethod r_MGetProperties;
		public virtual RMethod RMGetProperties
		{
			get
			{
				if(r_MGetProperties == null)
				{
					r_MGetProperties = new(this, "GetProperties", 0);
				}
				return r_MGetProperties;
			}
		}

		/// <summary>
		/// Boolean HasParent()
		/// </summary>
		protected RMethod r_MHasParent;
		public virtual RMethod RMHasParent
		{
			get
			{
				if(r_MHasParent == null)
				{
					r_MHasParent = new(this, "HasParent", 0);
				}
				return r_MHasParent;
			}
		}

		/// <summary>
		/// Boolean HasAttribute(System.String)
		/// </summary>
		protected RMethod r_MHasAttribute_String;
		public virtual RMethod RMHasAttribute_String
		{
			get
			{
				if(r_MHasAttribute_String == null)
				{
					r_MHasAttribute_String = new(this, "HasAttribute", 0, typeof(System.String));
				}
				return r_MHasAttribute_String;
			}
		}

		/// <summary>
		/// System.String GetAttributeValue(System.String)
		/// </summary>
		protected RMethod r_MGetAttributeValue_String;
		public virtual RMethod RMGetAttributeValue_String
		{
			get
			{
				if(r_MGetAttributeValue_String == null)
				{
					r_MGetAttributeValue_String = new(this, "GetAttributeValue", 0, typeof(System.String));
				}
				return r_MGetAttributeValue_String;
			}
		}

		/// <summary>
		/// Boolean TryGetAttributeValue(System.String, System.String ByRef)
		/// </summary>
		protected RMethod r_MTryGetAttributeValue_String_Out_String;
		public virtual RMethod RMTryGetAttributeValue_String_Out_String
		{
			get
			{
				if(r_MTryGetAttributeValue_String_Out_String == null)
				{
					r_MTryGetAttributeValue_String_Out_String = new(this, "TryGetAttributeValue", 0, typeof(System.String), typeof(System.String).MakeByRefType());
				}
				return r_MTryGetAttributeValue_String_Out_String;
			}
		}

		/// <summary>
		/// Void SetAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_MSetAttribute_String_String;
		public virtual RMethod RMSetAttribute_String_String
		{
			get
			{
				if(r_MSetAttribute_String_String == null)
				{
					r_MSetAttribute_String_String = new(this, "SetAttribute", 0, typeof(System.String), typeof(System.String));
				}
				return r_MSetAttribute_String_String;
			}
		}

		/// <summary>
		/// Void RemoveAttribute(System.String)
		/// </summary>
		protected RMethod r_MRemoveAttribute_String;
		public virtual RMethod RMRemoveAttribute_String
		{
			get
			{
				if(r_MRemoveAttribute_String == null)
				{
					r_MRemoveAttribute_String = new(this, "RemoveAttribute", 0, typeof(System.String));
				}
				return r_MRemoveAttribute_String;
			}
		}

		/// <summary>
		/// Int32 GetPropertiesDirtyCount()
		/// </summary>
		protected RMethod r_MGetPropertiesDirtyCount;
		public virtual RMethod RMGetPropertiesDirtyCount
		{
			get
			{
				if(r_MGetPropertiesDirtyCount == null)
				{
					r_MGetPropertiesDirtyCount = new(this, "GetPropertiesDirtyCount", 0);
				}
				return r_MGetPropertiesDirtyCount;
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


        public virtual System.Collections.Generic.List<System.String> GetProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetProperties.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.List<System.String>>(___result);
        }


        public virtual System.Boolean HasParent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasParent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasAttribute(System.String @attributeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeName};
            var ___result = RMHasAttribute_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String GetAttributeValue(System.String @attributeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeName};
            var ___result = RMGetAttributeValue_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean TryGetAttributeValue(System.String @propertyName, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @value};
            var ___result = RMTryGetAttributeValue_String_Out_String.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<System.String>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SetAttribute(System.String @name, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMSetAttribute_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAttribute(System.String @attributeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeName};
            var ___result = RMRemoveAttribute_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetPropertiesDirtyCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPropertiesDirtyCount.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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
