
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.PropertyHandlerCache
	/// </summary>
    public partial class RPropertyHandlerCache : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PropertyHandlerCache");
            }
        }

        public RPropertyHandlerCache() : base("UnityEditor.PropertyHandlerCache")
        {
        }

        public RPropertyHandlerCache(System.Object instance) : base("UnityEditor.PropertyHandlerCache")
		{
            SetInstance(instance);
		}

        public RPropertyHandlerCache(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPropertyHandlerCache(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEditor.PropertyHandler] m_PropertyHandlers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandler> r_Fm_PropertyHandlers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandler> RFm_PropertyHandlers
		{
			get
			{
				if(r_Fm_PropertyHandlers == null)
				{
					r_Fm_PropertyHandlers = new(this, "m_PropertyHandlers");
				}
				return r_Fm_PropertyHandlers;
			}
		}

		/// <summary>
		/// UnityEditor.PropertyHandler GetHandler(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_MGetHandler_SerializedProperty;
		public virtual RMethod RMGetHandler_SerializedProperty
		{
			get
			{
				if(r_MGetHandler_SerializedProperty == null)
				{
					r_MGetHandler_SerializedProperty = new(this, "GetHandler", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MGetHandler_SerializedProperty;
			}
		}

		/// <summary>
		/// Void SetHandler(UnityEditor.SerializedProperty, UnityEditor.PropertyHandler)
		/// </summary>
		protected RMethod r_MSetHandler_SerializedProperty_PropertyHandler;
		public virtual RMethod RMSetHandler_SerializedProperty_PropertyHandler
		{
			get
			{
				if(r_MSetHandler_SerializedProperty_PropertyHandler == null)
				{
					r_MSetHandler_SerializedProperty_PropertyHandler = new(this, "SetHandler", 0, typeof(UnityEditor.SerializedProperty),  ReflectionUtils.GetType("UnityEditor.PropertyHandler"));
				}
				return r_MSetHandler_SerializedProperty_PropertyHandler;
			}
		}

		/// <summary>
		/// Boolean CanUseSameHandler(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MCanUseSameHandler_SerializedProperty_SerializedProperty;
		public static RMethod RMCanUseSameHandler_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_MCanUseSameHandler_SerializedProperty_SerializedProperty == null)
				{
					r_MCanUseSameHandler_SerializedProperty_SerializedProperty = new( ReflectionUtils.GetType("UnityEditor.PropertyHandlerCache"), "CanUseSameHandler", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
				}
				return r_MCanUseSameHandler_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Int32 GetPropertyHash(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MGetPropertyHash_SerializedProperty;
		public static RMethod RMGetPropertyHash_SerializedProperty
		{
			get
			{
				if(r_MGetPropertyHash_SerializedProperty == null)
				{
					r_MGetPropertyHash_SerializedProperty = new( ReflectionUtils.GetType("UnityEditor.PropertyHandlerCache"), "GetPropertyHash", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MGetPropertyHash_SerializedProperty;
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
				}
				return r_MClear;
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


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandler GetHandler(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RMGetHandler_SerializedProperty.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandler(___result);
        }


        public virtual void SetHandler(UnityEditor.SerializedProperty @property, Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandler @handler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @handler.Value};
            var ___result = RMSetHandler_SerializedProperty_PropertyHandler.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean CanUseSameHandler(UnityEditor.SerializedProperty @p1, UnityEditor.SerializedProperty @p2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p1, @p2};
            var ___result = RMCanUseSameHandler_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GetPropertyHash(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RMGetPropertyHash_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
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
