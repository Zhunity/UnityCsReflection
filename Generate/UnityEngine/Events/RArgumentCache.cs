using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.REvents
{
	/// <summary>
	/// UnityEngine.Events.ArgumentCache
	/// </summary>
    public partial class RArgumentCache : RMember //
    {

		/// <summary>
		/// UnityEngine.Object m_ObjectArgument
		/// </summary>
		protected RUnityEngine.RObject r_m_ObjectArgument;
		public virtual RUnityEngine.RObject Rm_ObjectArgument
		{
			get
			{
				if(r_m_ObjectArgument == null)
				{
					r_m_ObjectArgument = new(this, "m_ObjectArgument");
					r_m_ObjectArgument.SetBelong(this.instance);
				}
				return r_m_ObjectArgument;
			}
		}

		/// <summary>
		/// System.String m_ObjectArgumentAssemblyTypeName
		/// </summary>
		protected RField r_m_ObjectArgumentAssemblyTypeName;
		public virtual RField Rm_ObjectArgumentAssemblyTypeName
		{
			get
			{
				if(r_m_ObjectArgumentAssemblyTypeName == null)
				{
					r_m_ObjectArgumentAssemblyTypeName = new(this, "m_ObjectArgumentAssemblyTypeName");
					r_m_ObjectArgumentAssemblyTypeName.SetBelong(this.instance);
				}
				return r_m_ObjectArgumentAssemblyTypeName;
			}
		}

		/// <summary>
		/// System.Int32 m_IntArgument
		/// </summary>
		protected RField r_m_IntArgument;
		public virtual RField Rm_IntArgument
		{
			get
			{
				if(r_m_IntArgument == null)
				{
					r_m_IntArgument = new(this, "m_IntArgument");
					r_m_IntArgument.SetBelong(this.instance);
				}
				return r_m_IntArgument;
			}
		}

		/// <summary>
		/// System.Single m_FloatArgument
		/// </summary>
		protected RField r_m_FloatArgument;
		public virtual RField Rm_FloatArgument
		{
			get
			{
				if(r_m_FloatArgument == null)
				{
					r_m_FloatArgument = new(this, "m_FloatArgument");
					r_m_FloatArgument.SetBelong(this.instance);
				}
				return r_m_FloatArgument;
			}
		}

		/// <summary>
		/// System.String m_StringArgument
		/// </summary>
		protected RField r_m_StringArgument;
		public virtual RField Rm_StringArgument
		{
			get
			{
				if(r_m_StringArgument == null)
				{
					r_m_StringArgument = new(this, "m_StringArgument");
					r_m_StringArgument.SetBelong(this.instance);
				}
				return r_m_StringArgument;
			}
		}

		/// <summary>
		/// System.Boolean m_BoolArgument
		/// </summary>
		protected RField r_m_BoolArgument;
		public virtual RField Rm_BoolArgument
		{
			get
			{
				if(r_m_BoolArgument == null)
				{
					r_m_BoolArgument = new(this, "m_BoolArgument");
					r_m_BoolArgument.SetBelong(this.instance);
				}
				return r_m_BoolArgument;
			}
		}

		/// <summary>
		/// UnityEngine.Object unityObjectArgument
		/// </summary>
		protected RUnityEngine.RObject r_unityObjectArgument;
		public virtual RUnityEngine.RObject RunityObjectArgument
		{
			get
			{
				if(r_unityObjectArgument == null)
				{
					r_unityObjectArgument = new(this, "unityObjectArgument", -1);
					r_unityObjectArgument.SetBelong(this.instance);
				}
				return r_unityObjectArgument;
			}
		}

		/// <summary>
		/// System.String unityObjectArgumentAssemblyTypeName
		/// </summary>
		protected RProperty r_unityObjectArgumentAssemblyTypeName;
		public virtual RProperty RunityObjectArgumentAssemblyTypeName
		{
			get
			{
				if(r_unityObjectArgumentAssemblyTypeName == null)
				{
					r_unityObjectArgumentAssemblyTypeName = new(this, "unityObjectArgumentAssemblyTypeName", -1);
					r_unityObjectArgumentAssemblyTypeName.SetBelong(this.instance);
				}
				return r_unityObjectArgumentAssemblyTypeName;
			}
		}

		/// <summary>
		/// Int32 intArgument
		/// </summary>
		protected RProperty r_intArgument;
		public virtual RProperty RintArgument
		{
			get
			{
				if(r_intArgument == null)
				{
					r_intArgument = new(this, "intArgument", -1);
					r_intArgument.SetBelong(this.instance);
				}
				return r_intArgument;
			}
		}

		/// <summary>
		/// Single floatArgument
		/// </summary>
		protected RProperty r_floatArgument;
		public virtual RProperty RfloatArgument
		{
			get
			{
				if(r_floatArgument == null)
				{
					r_floatArgument = new(this, "floatArgument", -1);
					r_floatArgument.SetBelong(this.instance);
				}
				return r_floatArgument;
			}
		}

		/// <summary>
		/// System.String stringArgument
		/// </summary>
		protected RProperty r_stringArgument;
		public virtual RProperty RstringArgument
		{
			get
			{
				if(r_stringArgument == null)
				{
					r_stringArgument = new(this, "stringArgument", -1);
					r_stringArgument.SetBelong(this.instance);
				}
				return r_stringArgument;
			}
		}

		/// <summary>
		/// Boolean boolArgument
		/// </summary>
		protected RProperty r_boolArgument;
		public virtual RProperty RboolArgument
		{
			get
			{
				if(r_boolArgument == null)
				{
					r_boolArgument = new(this, "boolArgument", -1);
					r_boolArgument.SetBelong(this.instance);
				}
				return r_boolArgument;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_ROnBeforeSerialize;
		public virtual RMethod ROnBeforeSerialize
		{
			get
			{
				if(r_ROnBeforeSerialize == null)
				{
					r_ROnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_ROnBeforeSerialize.SetBelong(this.instance);
				}
				return r_ROnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_ROnAfterDeserialize;
		public virtual RMethod ROnAfterDeserialize
		{
			get
			{
				if(r_ROnAfterDeserialize == null)
				{
					r_ROnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_ROnAfterDeserialize.SetBelong(this.instance);
				}
				return r_ROnAfterDeserialize;
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


        public RArgumentCache() : base("UnityEngine.Events.ArgumentCache")
        {
        }

        public RArgumentCache(System.Object instance) : base("UnityEngine.Events.ArgumentCache")
		{
            SetInstance(instance);
		}

        public RArgumentCache(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RArgumentCache(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
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
