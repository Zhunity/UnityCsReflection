
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleProperty
	/// </summary>
    public partial class RStyleProperty : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.StyleProperty");
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


		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.Int32 m_Line
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Line;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Line
		{
			get
			{
				if(r_Fm_Line == null)
				{
					r_Fm_Line = new(this, "m_Line");
				}
				return r_Fm_Line;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueHandle[] m_Values
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle> r_Fm_Values;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle> RFm_Values
		{
			get
			{
				if(r_Fm_Values == null)
				{
					r_Fm_Values = new(this, "m_Values");
				}
				return r_Fm_Values;
			}
		}

		/// <summary>
		/// System.Boolean isCustomProperty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisCustomProperty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisCustomProperty
		{
			get
			{
				if(r_FisCustomProperty == null)
				{
					r_FisCustomProperty = new(this, "isCustomProperty");
				}
				return r_FisCustomProperty;
			}
		}

		/// <summary>
		/// System.Boolean requireVariableResolve
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FrequireVariableResolve;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFrequireVariableResolve
		{
			get
			{
				if(r_FrequireVariableResolve == null)
				{
					r_FrequireVariableResolve = new(this, "requireVariableResolve");
				}
				return r_FrequireVariableResolve;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// Int32 line
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pline;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPline
		{
			get
			{
				if(r_Pline == null)
				{
					r_Pline = new(this, "line", -1);
				}
				return r_Pline;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueHandle[] values
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle> r_Pvalues;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle> RPvalues
		{
			get
			{
				if(r_Pvalues == null)
				{
					r_Pvalues = new(this, "values", -1);
				}
				return r_Pvalues;
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
