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
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEditor.RPropertyHandler> r_m_PropertyHandlers;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEditor.RPropertyHandler> Rm_PropertyHandlers
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
		protected RMethod r_RGetHandler_SerializedProperty;
		public virtual RMethod RGetHandler_SerializedProperty
		{
			get
			{
				if(r_RGetHandler_SerializedProperty == null)
				{
					r_RGetHandler_SerializedProperty = new(this, "GetHandler", 0, typeof(UnityEditor.SerializedProperty));
					r_RGetHandler_SerializedProperty.SetBelong(this.instance);
				}
				return r_RGetHandler_SerializedProperty;
			}
		}

		/// <summary>
		/// Void SetHandler(UnityEditor.SerializedProperty, UnityEditor.PropertyHandler)
		/// </summary>
		protected RMethod r_RSetHandler_SerializedProperty_PropertyHandler;
		public virtual RMethod RSetHandler_SerializedProperty_PropertyHandler
		{
			get
			{
				if(r_RSetHandler_SerializedProperty_PropertyHandler == null)
				{
					r_RSetHandler_SerializedProperty_PropertyHandler = new(this, "SetHandler", 0, typeof(UnityEditor.SerializedProperty),  ReleactionUtils.GetType("UnityEditor.PropertyHandler"));
					r_RSetHandler_SerializedProperty_PropertyHandler.SetBelong(this.instance);
				}
				return r_RSetHandler_SerializedProperty_PropertyHandler;
			}
		}

		/// <summary>
		/// Boolean CanUseSameHandler(UnityEditor.SerializedProperty, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_RCanUseSameHandler_SerializedProperty_SerializedProperty;
		public static RMethod RCanUseSameHandler_SerializedProperty_SerializedProperty
		{
			get
			{
				if(r_RCanUseSameHandler_SerializedProperty_SerializedProperty == null)
				{
					r_RCanUseSameHandler_SerializedProperty_SerializedProperty = new( ReleactionUtils.GetType("UnityEditor.PropertyHandlerCache"), "CanUseSameHandler", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.SerializedProperty));
					r_RCanUseSameHandler_SerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_RCanUseSameHandler_SerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Int32 GetPropertyHash(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_RGetPropertyHash_SerializedProperty;
		public static RMethod RGetPropertyHash_SerializedProperty
		{
			get
			{
				if(r_RGetPropertyHash_SerializedProperty == null)
				{
					r_RGetPropertyHash_SerializedProperty = new( ReleactionUtils.GetType("UnityEditor.PropertyHandlerCache"), "GetPropertyHash", 0, typeof(UnityEditor.SerializedProperty));
					r_RGetPropertyHash_SerializedProperty.SetBelong(null);
				}
				return r_RGetPropertyHash_SerializedProperty;
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

        public virtual System.Object GetHandler(UnityEditor.SerializedProperty  @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RGetHandler_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public static System.Boolean CanUseSameHandler(UnityEditor.SerializedProperty  @p1, UnityEditor.SerializedProperty  @p2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p1, @p2};
            var ___result = RCanUseSameHandler_SerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GetPropertyHash(UnityEditor.SerializedProperty  @property)
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
