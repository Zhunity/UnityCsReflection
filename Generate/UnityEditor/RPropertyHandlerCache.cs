using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.PropertyHandlerCache
	/// </summary>
    public partial class RPropertyHandlerCache : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEditor.PropertyHandler] m_PropertyHandlers
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RInt32, RUnityEditor.RPropertyHandler> r_m_PropertyHandlers;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RInt32, RUnityEditor.RPropertyHandler> Rm_PropertyHandlers
		{
			get
			{
				if(r_m_PropertyHandlers == null)
				{
					r_m_PropertyHandlers = new(this, "m_PropertyHandlers");
					r_m_PropertyHandlers.SetBelong(this.instance);
				}
				return r_m_PropertyHandlers;
			}
		}

		/// <summary>
		/// UnityEditor.PropertyHandler GetHandler(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_GetHandler_SerializedProperty;
		public virtual RMethod RGetHandler_SerializedProperty
		{
			get
			{
				if(r_GetHandler_SerializedProperty == null)
				{
					r_GetHandler_SerializedProperty = new(this, "GetHandler", 0, typeof(UnityEditor.SerializedProperty));
					r_GetHandler_SerializedProperty.SetBelong(this.instance);
				}
				return r_GetHandler_SerializedProperty;
			}
		}

		/// <summary>
		/// Void SetHandler(UnityEditor.SerializedProperty, UnityEditor.PropertyHandler)
		/// </summary>
		protected RMethod r_SetHandler_SerializedProperty_PropertyHandler;
		public virtual RMethod RSetHandler_SerializedProperty_PropertyHandler
		{
			get
			{
				if(r_SetHandler_SerializedProperty_PropertyHandler == null)
				{
					r_SetHandler_SerializedProperty_PropertyHandler = new(this, "SetHandler", 0, typeof(UnityEditor.SerializedProperty),  ReflectionUtils.GetType("UnityEditor.PropertyHandler"));
					r_SetHandler_SerializedProperty_PropertyHandler.SetBelong(this.instance);
				}
				return r_SetHandler_SerializedProperty_PropertyHandler;
			}
		}

		/// <summary>
		/// Boolean CanUseSameHandler(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_CanUseSameHandler_SerializedProperty_SerializedProperty;
		public static RMethod RCanUseSameHandler_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_CanUseSameHandler_SerializedProperty_SerializedProperty == null)
				{
					r_CanUseSameHandler_SerializedProperty_SerializedProperty = new( ReflectionUtils.GetType("UnityEditor.PropertyHandlerCache"), "CanUseSameHandler", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
					r_CanUseSameHandler_SerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_CanUseSameHandler_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Int32 GetPropertyHash(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_GetPropertyHash_SerializedProperty;
		public static RMethod RGetPropertyHash_SerializedProperty
		{
			get
			{
				if(r_GetPropertyHash_SerializedProperty == null)
				{
					r_GetPropertyHash_SerializedProperty = new( ReflectionUtils.GetType("UnityEditor.PropertyHandlerCache"), "GetPropertyHash", 0, typeof(UnityEditor.SerializedProperty));
					r_GetPropertyHash_SerializedProperty.SetBelong(null);
				}
				return r_GetPropertyHash_SerializedProperty;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
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

        public virtual RUnityEditor.RPropertyHandler GetHandler(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RGetHandler_SerializedProperty.Invoke(___genericsType, ___parameters);

            return new RUnityEditor.RPropertyHandler(___result);
        }


        public virtual void SetHandler(UnityEditor.SerializedProperty @property, RUnityEditor.RPropertyHandler @handler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @handler.Value};
            var ___result = RSetHandler_SerializedProperty_PropertyHandler.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean CanUseSameHandler(UnityEditor.SerializedProperty @p1, UnityEditor.SerializedProperty @p2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p1, @p2};
            var ___result = RCanUseSameHandler_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GetPropertyHash(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RGetPropertyHash_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
