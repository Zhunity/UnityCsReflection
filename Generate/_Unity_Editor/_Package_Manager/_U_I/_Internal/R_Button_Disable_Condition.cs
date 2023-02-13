
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.ButtonDisableCondition
	/// </summary>
    public partial class RButtonDisableCondition : RMember //
    {

		/// <summary>
		/// System.Func`1[System.Boolean] m_Condition
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RFunc<SMFrame.Editor.Refleaction.RSystem.RBoolean> r_Fm_Condition;
		public virtual SMFrame.Editor.Refleaction.RSystem.RFunc<SMFrame.Editor.Refleaction.RSystem.RBoolean> RFm_Condition
		{
			get
			{
				if(r_Fm_Condition == null)
				{
					r_Fm_Condition = new(this, "m_Condition");
					r_Fm_Condition.SetBelong(this.instance);
				}
				return r_Fm_Condition;
			}
		}

		/// <summary>
		/// System.String <tooltip>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_F__0__tooltip__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RF__0__tooltip__1__k__BackingField
		{
			get
			{
				if(r_F__0__tooltip__1__k__BackingField == null)
				{
					r_F__0__tooltip__1__k__BackingField = new(this, "<tooltip>k__BackingField");
					r_F__0__tooltip__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__tooltip__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Boolean] m_Value
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RNullable<SMFrame.Editor.Refleaction.RSystem.RBoolean> r_Fm_Value;
		public virtual SMFrame.Editor.Refleaction.RSystem.RNullable<SMFrame.Editor.Refleaction.RSystem.RBoolean> RFm_Value
		{
			get
			{
				if(r_Fm_Value == null)
				{
					r_Fm_Value = new(this, "m_Value");
					r_Fm_Value.SetBelong(this.instance);
				}
				return r_Fm_Value;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Ptooltip;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
					r_Ptooltip.SetBelong(this.instance);
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// Boolean value
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Pvalue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPvalue
		{
			get
			{
				if(r_Pvalue == null)
				{
					r_Pvalue = new(this, "value", -1);
					r_Pvalue.SetBelong(this.instance);
				}
				return r_Pvalue;
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


        public RButtonDisableCondition() : base("UnityEditor.PackageManager.UI.Internal.ButtonDisableCondition")
        {
        }

        public RButtonDisableCondition(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.ButtonDisableCondition")
		{
            SetInstance(instance);
		}

        public RButtonDisableCondition(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RButtonDisableCondition(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
