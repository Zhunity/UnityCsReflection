
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.REvents
{
	/// <summary>
	/// UnityEngine.Events.ArgumentCache
	/// </summary>
    public partial class RArgumentCache : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.Events.ArgumentCache");
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


		/// <summary>
		/// UnityEngine.Object m_ObjectArgument
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RObject r_Fm_ObjectArgument;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RObject RFm_ObjectArgument
		{
			get
			{
				if(r_Fm_ObjectArgument == null)
				{
					r_Fm_ObjectArgument = new(this, "m_ObjectArgument");
				}
				return r_Fm_ObjectArgument;
			}
		}

		/// <summary>
		/// System.String m_ObjectArgumentAssemblyTypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ObjectArgumentAssemblyTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ObjectArgumentAssemblyTypeName
		{
			get
			{
				if(r_Fm_ObjectArgumentAssemblyTypeName == null)
				{
					r_Fm_ObjectArgumentAssemblyTypeName = new(this, "m_ObjectArgumentAssemblyTypeName");
				}
				return r_Fm_ObjectArgumentAssemblyTypeName;
			}
		}

		/// <summary>
		/// System.Int32 m_IntArgument
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_IntArgument;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_IntArgument
		{
			get
			{
				if(r_Fm_IntArgument == null)
				{
					r_Fm_IntArgument = new(this, "m_IntArgument");
				}
				return r_Fm_IntArgument;
			}
		}

		/// <summary>
		/// System.Single m_FloatArgument
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_FloatArgument;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_FloatArgument
		{
			get
			{
				if(r_Fm_FloatArgument == null)
				{
					r_Fm_FloatArgument = new(this, "m_FloatArgument");
				}
				return r_Fm_FloatArgument;
			}
		}

		/// <summary>
		/// System.String m_StringArgument
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_StringArgument;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_StringArgument
		{
			get
			{
				if(r_Fm_StringArgument == null)
				{
					r_Fm_StringArgument = new(this, "m_StringArgument");
				}
				return r_Fm_StringArgument;
			}
		}

		/// <summary>
		/// System.Boolean m_BoolArgument
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_BoolArgument;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_BoolArgument
		{
			get
			{
				if(r_Fm_BoolArgument == null)
				{
					r_Fm_BoolArgument = new(this, "m_BoolArgument");
				}
				return r_Fm_BoolArgument;
			}
		}

		/// <summary>
		/// UnityEngine.Object unityObjectArgument
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RObject r_PunityObjectArgument;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RObject RPunityObjectArgument
		{
			get
			{
				if(r_PunityObjectArgument == null)
				{
					r_PunityObjectArgument = new(this, "unityObjectArgument", -1);
				}
				return r_PunityObjectArgument;
			}
		}

		/// <summary>
		/// System.String unityObjectArgumentAssemblyTypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PunityObjectArgumentAssemblyTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPunityObjectArgumentAssemblyTypeName
		{
			get
			{
				if(r_PunityObjectArgumentAssemblyTypeName == null)
				{
					r_PunityObjectArgumentAssemblyTypeName = new(this, "unityObjectArgumentAssemblyTypeName", -1);
				}
				return r_PunityObjectArgumentAssemblyTypeName;
			}
		}

		/// <summary>
		/// Int32 intArgument
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PintArgument;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPintArgument
		{
			get
			{
				if(r_PintArgument == null)
				{
					r_PintArgument = new(this, "intArgument", -1);
				}
				return r_PintArgument;
			}
		}

		/// <summary>
		/// Single floatArgument
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PfloatArgument;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfloatArgument
		{
			get
			{
				if(r_PfloatArgument == null)
				{
					r_PfloatArgument = new(this, "floatArgument", -1);
				}
				return r_PfloatArgument;
			}
		}

		/// <summary>
		/// System.String stringArgument
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PstringArgument;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPstringArgument
		{
			get
			{
				if(r_PstringArgument == null)
				{
					r_PstringArgument = new(this, "stringArgument", -1);
				}
				return r_PstringArgument;
			}
		}

		/// <summary>
		/// Boolean boolArgument
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PboolArgument;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPboolArgument
		{
			get
			{
				if(r_PboolArgument == null)
				{
					r_PboolArgument = new(this, "boolArgument", -1);
				}
				return r_PboolArgument;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
				}
				return r_MOnAfterDeserialize;
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


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
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
