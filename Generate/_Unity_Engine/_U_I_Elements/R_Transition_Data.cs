
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TransitionData
	/// </summary>
    public partial class RTransitionData : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue] transitionDelay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> r_FtransitionDelay;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> RFtransitionDelay
		{
			get
			{
				if(r_FtransitionDelay == null)
				{
					r_FtransitionDelay = new(this, "transitionDelay");
					r_FtransitionDelay.SetBelong(this.GetValue());
				}
				return r_FtransitionDelay;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue] transitionDuration
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> r_FtransitionDuration;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> RFtransitionDuration
		{
			get
			{
				if(r_FtransitionDuration == null)
				{
					r_FtransitionDuration = new(this, "transitionDuration");
					r_FtransitionDuration.SetBelong(this.GetValue());
				}
				return r_FtransitionDuration;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StylePropertyName] transitionProperty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStylePropertyName> r_FtransitionProperty;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStylePropertyName> RFtransitionProperty
		{
			get
			{
				if(r_FtransitionProperty == null)
				{
					r_FtransitionProperty = new(this, "transitionProperty");
					r_FtransitionProperty.SetBelong(this.GetValue());
				}
				return r_FtransitionProperty;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EasingFunction] transitionTimingFunction
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingFunction> r_FtransitionTimingFunction;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingFunction> RFtransitionTimingFunction
		{
			get
			{
				if(r_FtransitionTimingFunction == null)
				{
					r_FtransitionTimingFunction = new(this, "transitionTimingFunction");
					r_FtransitionTimingFunction.SetBelong(this.GetValue());
				}
				return r_FtransitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransitionData Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
					r_MCopy.SetBelong(this.GetValue());
				}
				return r_MCopy;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.UIElements.TransitionData ByRef)
		/// </summary>
		protected RMethod r_MCopyFrom_Ref_TransitionData;
		public virtual RMethod RMCopyFrom_Ref_TransitionData
		{
			get
			{
				if(r_MCopyFrom_Ref_TransitionData == null)
				{
					r_MCopyFrom_Ref_TransitionData = new(this, "CopyFrom", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData").MakeByRefType());
					r_MCopyFrom_Ref_TransitionData.SetBelong(this.GetValue());
				}
				return r_MCopyFrom_Ref_TransitionData;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.TransitionData, UnityEngine.UIElements.TransitionData)
		/// </summary>
		protected static RMethod r_Mop_Equality_TransitionData_TransitionData;
		public static RMethod RMop_Equality_TransitionData_TransitionData
		{
			get
			{
				if(r_Mop_Equality_TransitionData_TransitionData == null)
				{
					r_Mop_Equality_TransitionData_TransitionData = new( ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"),  ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"));
					r_Mop_Equality_TransitionData_TransitionData.SetBelong(null);
				}
				return r_Mop_Equality_TransitionData_TransitionData;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TransitionData, UnityEngine.UIElements.TransitionData)
		/// </summary>
		protected static RMethod r_Mop_Inequality_TransitionData_TransitionData;
		public static RMethod RMop_Inequality_TransitionData_TransitionData
		{
			get
			{
				if(r_Mop_Inequality_TransitionData_TransitionData == null)
				{
					r_Mop_Inequality_TransitionData_TransitionData = new( ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"),  ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"));
					r_Mop_Inequality_TransitionData_TransitionData.SetBelong(null);
				}
				return r_Mop_Inequality_TransitionData_TransitionData;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.TransitionData)
		/// </summary>
		protected RMethod r_MEquals_TransitionData;
		public virtual RMethod RMEquals_TransitionData
		{
			get
			{
				if(r_MEquals_TransitionData == null)
				{
					r_MEquals_TransitionData = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TransitionData"));
					r_MEquals_TransitionData.SetBelong(this.GetValue());
				}
				return r_MEquals_TransitionData;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
					r_MFinalize.SetBelong(this.GetValue());
				}
				return r_MFinalize;
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RTransitionData() : base("UnityEngine.UIElements.TransitionData")
        {
        }

        public RTransitionData(System.Object instance) : base("UnityEngine.UIElements.TransitionData")
		{
            SetInstance(instance);
		}

        public RTransitionData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTransitionData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransitionData Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransitionData(___result);
        }


        public virtual void CopyFrom(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransitionData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCopyFrom_Ref_TransitionData.Invoke(___genericsType, ___parameters);
			@other = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransitionData(___parameters[0]);

            
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransitionData @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransitionData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_TransitionData_TransitionData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransitionData @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransitionData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_TransitionData_TransitionData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransitionData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_TransitionData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
