using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleProperty
	/// </summary>
    public partial class RStyleProperty : RMember //
    {

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected RSystem.RString r_m_Name;
		public virtual RSystem.RString Rm_Name
		{
			get
			{
				if(r_m_Name == null)
				{
					r_m_Name = new(this, "m_Name");
					r_m_Name.SetBelong(this.instance);
				}
				return r_m_Name;
			}
		}

		/// <summary>
		/// System.Int32 m_Line
		/// </summary>
		protected RSystem.RInt32 r_m_Line;
		public virtual RSystem.RInt32 Rm_Line
		{
			get
			{
				if(r_m_Line == null)
				{
					r_m_Line = new(this, "m_Line");
					r_m_Line.SetBelong(this.instance);
				}
				return r_m_Line;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueHandle[] m_Values
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleValueHandle> r_m_Values;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleValueHandle> Rm_Values
		{
			get
			{
				if(r_m_Values == null)
				{
					r_m_Values = new(this, "m_Values");
					r_m_Values.SetBelong(this.instance);
				}
				return r_m_Values;
			}
		}

		/// <summary>
		/// System.Boolean isCustomProperty
		/// </summary>
		protected RSystem.RBoolean r_isCustomProperty;
		public virtual RSystem.RBoolean RisCustomProperty
		{
			get
			{
				if(r_isCustomProperty == null)
				{
					r_isCustomProperty = new(this, "isCustomProperty");
					r_isCustomProperty.SetBelong(this.instance);
				}
				return r_isCustomProperty;
			}
		}

		/// <summary>
		/// System.Boolean requireVariableResolve
		/// </summary>
		protected RSystem.RBoolean r_requireVariableResolve;
		public virtual RSystem.RBoolean RrequireVariableResolve
		{
			get
			{
				if(r_requireVariableResolve == null)
				{
					r_requireVariableResolve = new(this, "requireVariableResolve");
					r_requireVariableResolve.SetBelong(this.instance);
				}
				return r_requireVariableResolve;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_name;
		public virtual RSystem.RString Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// Int32 line
		/// </summary>
		protected RSystem.RInt32 r_line;
		public virtual RSystem.RInt32 Rline
		{
			get
			{
				if(r_line == null)
				{
					r_line = new(this, "line", -1);
					r_line.SetBelong(this.instance);
				}
				return r_line;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueHandle[] values
		/// </summary>
		protected RPropertyArray<RUnityEngine.RUIElements.RStyleValueHandle> r_values;
		public virtual RPropertyArray<RUnityEngine.RUIElements.RStyleValueHandle> Rvalues
		{
			get
			{
				if(r_values == null)
				{
					r_values = new(this, "values", -1);
					r_values.SetBelong(this.instance);
				}
				return r_values;
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


        public RStyleProperty() : base("UnityEngine.UIElements.StyleProperty")
        {
        }

        public RStyleProperty(System.Object instance) : base("UnityEngine.UIElements.StyleProperty")
		{
            SetInstance(instance);
		}

        public RStyleProperty(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleProperty(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
