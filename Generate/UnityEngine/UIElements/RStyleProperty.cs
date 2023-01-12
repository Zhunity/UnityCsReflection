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
		protected RSystem.RString r_Fm_Name;
		public virtual RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
					r_Fm_Name.SetBelong(this.instance);
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.Int32 m_Line
		/// </summary>
		protected RSystem.RInt32 r_Fm_Line;
		public virtual RSystem.RInt32 RFm_Line
		{
			get
			{
				if(r_Fm_Line == null)
				{
					r_Fm_Line = new(this, "m_Line");
					r_Fm_Line.SetBelong(this.instance);
				}
				return r_Fm_Line;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueHandle[] m_Values
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleValueHandle> r_Fm_Values;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleValueHandle> RFm_Values
		{
			get
			{
				if(r_Fm_Values == null)
				{
					r_Fm_Values = new(this, "m_Values");
					r_Fm_Values.SetBelong(this.instance);
				}
				return r_Fm_Values;
			}
		}

		/// <summary>
		/// System.Boolean isCustomProperty
		/// </summary>
		protected RSystem.RBoolean r_FisCustomProperty;
		public virtual RSystem.RBoolean RFisCustomProperty
		{
			get
			{
				if(r_FisCustomProperty == null)
				{
					r_FisCustomProperty = new(this, "isCustomProperty");
					r_FisCustomProperty.SetBelong(this.instance);
				}
				return r_FisCustomProperty;
			}
		}

		/// <summary>
		/// System.Boolean requireVariableResolve
		/// </summary>
		protected RSystem.RBoolean r_FrequireVariableResolve;
		public virtual RSystem.RBoolean RFrequireVariableResolve
		{
			get
			{
				if(r_FrequireVariableResolve == null)
				{
					r_FrequireVariableResolve = new(this, "requireVariableResolve");
					r_FrequireVariableResolve.SetBelong(this.instance);
				}
				return r_FrequireVariableResolve;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_Pname;
		public virtual RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// Int32 line
		/// </summary>
		protected RSystem.RInt32 r_Pline;
		public virtual RSystem.RInt32 RPline
		{
			get
			{
				if(r_Pline == null)
				{
					r_Pline = new(this, "line", -1);
					r_Pline.SetBelong(this.instance);
				}
				return r_Pline;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueHandle[] values
		/// </summary>
		protected RPropertyArray<RUnityEngine.RUIElements.RStyleValueHandle> r_Pvalues;
		public virtual RPropertyArray<RUnityEngine.RUIElements.RStyleValueHandle> RPvalues
		{
			get
			{
				if(r_Pvalues == null)
				{
					r_Pvalues = new(this, "values", -1);
					r_Pvalues.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
