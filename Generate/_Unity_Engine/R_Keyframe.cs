
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Keyframe
	/// </summary>
    public partial class RKeyframe : RMember //
    {

		/// <summary>
		/// System.Single m_Time
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Time;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Time
		{
			get
			{
				if(r_Fm_Time == null)
				{
					r_Fm_Time = new(this, "m_Time");
					r_Fm_Time.SetBelong(this.GetValue());
				}
				return r_Fm_Time;
			}
		}

		/// <summary>
		/// System.Single m_Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Value;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Value
		{
			get
			{
				if(r_Fm_Value == null)
				{
					r_Fm_Value = new(this, "m_Value");
					r_Fm_Value.SetBelong(this.GetValue());
				}
				return r_Fm_Value;
			}
		}

		/// <summary>
		/// System.Single m_InTangent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_InTangent;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_InTangent
		{
			get
			{
				if(r_Fm_InTangent == null)
				{
					r_Fm_InTangent = new(this, "m_InTangent");
					r_Fm_InTangent.SetBelong(this.GetValue());
				}
				return r_Fm_InTangent;
			}
		}

		/// <summary>
		/// System.Single m_OutTangent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_OutTangent;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_OutTangent
		{
			get
			{
				if(r_Fm_OutTangent == null)
				{
					r_Fm_OutTangent = new(this, "m_OutTangent");
					r_Fm_OutTangent.SetBelong(this.GetValue());
				}
				return r_Fm_OutTangent;
			}
		}

		/// <summary>
		/// System.Int32 m_TangentMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_TangentMode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_TangentMode
		{
			get
			{
				if(r_Fm_TangentMode == null)
				{
					r_Fm_TangentMode = new(this, "m_TangentMode");
					r_Fm_TangentMode.SetBelong(this.GetValue());
				}
				return r_Fm_TangentMode;
			}
		}

		/// <summary>
		/// System.Int32 m_WeightedMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_WeightedMode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_WeightedMode
		{
			get
			{
				if(r_Fm_WeightedMode == null)
				{
					r_Fm_WeightedMode = new(this, "m_WeightedMode");
					r_Fm_WeightedMode.SetBelong(this.GetValue());
				}
				return r_Fm_WeightedMode;
			}
		}

		/// <summary>
		/// System.Single m_InWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_InWeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_InWeight
		{
			get
			{
				if(r_Fm_InWeight == null)
				{
					r_Fm_InWeight = new(this, "m_InWeight");
					r_Fm_InWeight.SetBelong(this.GetValue());
				}
				return r_Fm_InWeight;
			}
		}

		/// <summary>
		/// System.Single m_OutWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_OutWeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_OutWeight
		{
			get
			{
				if(r_Fm_OutWeight == null)
				{
					r_Fm_OutWeight = new(this, "m_OutWeight");
					r_Fm_OutWeight.SetBelong(this.GetValue());
				}
				return r_Fm_OutWeight;
			}
		}

		/// <summary>
		/// Single time
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Ptime;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPtime
		{
			get
			{
				if(r_Ptime == null)
				{
					r_Ptime = new(this, "time", -1);
					r_Ptime.SetBelong(this.GetValue());
				}
				return r_Ptime;
			}
		}

		/// <summary>
		/// Single value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pvalue;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPvalue
		{
			get
			{
				if(r_Pvalue == null)
				{
					r_Pvalue = new(this, "value", -1);
					r_Pvalue.SetBelong(this.GetValue());
				}
				return r_Pvalue;
			}
		}

		/// <summary>
		/// Single inTangent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PinTangent;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPinTangent
		{
			get
			{
				if(r_PinTangent == null)
				{
					r_PinTangent = new(this, "inTangent", -1);
					r_PinTangent.SetBelong(this.GetValue());
				}
				return r_PinTangent;
			}
		}

		/// <summary>
		/// Single outTangent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PoutTangent;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPoutTangent
		{
			get
			{
				if(r_PoutTangent == null)
				{
					r_PoutTangent = new(this, "outTangent", -1);
					r_PoutTangent.SetBelong(this.GetValue());
				}
				return r_PoutTangent;
			}
		}

		/// <summary>
		/// Single inWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PinWeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPinWeight
		{
			get
			{
				if(r_PinWeight == null)
				{
					r_PinWeight = new(this, "inWeight", -1);
					r_PinWeight.SetBelong(this.GetValue());
				}
				return r_PinWeight;
			}
		}

		/// <summary>
		/// Single outWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PoutWeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPoutWeight
		{
			get
			{
				if(r_PoutWeight == null)
				{
					r_PoutWeight = new(this, "outWeight", -1);
					r_PoutWeight.SetBelong(this.GetValue());
				}
				return r_PoutWeight;
			}
		}

		/// <summary>
		/// UnityEngine.WeightedMode weightedMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RWeightedMode r_PweightedMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RWeightedMode RPweightedMode
		{
			get
			{
				if(r_PweightedMode == null)
				{
					r_PweightedMode = new(this, "weightedMode", -1);
					r_PweightedMode.SetBelong(this.GetValue());
				}
				return r_PweightedMode;
			}
		}

		/// <summary>
		/// Int32 tangentMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PtangentMode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPtangentMode
		{
			get
			{
				if(r_PtangentMode == null)
				{
					r_PtangentMode = new(this, "tangentMode", -1);
					r_PtangentMode.SetBelong(this.GetValue());
				}
				return r_PtangentMode;
			}
		}

		/// <summary>
		/// Int32 tangentModeInternal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PtangentModeInternal;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPtangentModeInternal
		{
			get
			{
				if(r_PtangentModeInternal == null)
				{
					r_PtangentModeInternal = new(this, "tangentModeInternal", -1);
					r_PtangentModeInternal.SetBelong(this.GetValue());
				}
				return r_PtangentModeInternal;
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


        public RKeyframe() : base("UnityEngine.Keyframe")
        {
        }

        public RKeyframe(System.Object instance) : base("UnityEngine.Keyframe")
		{
            SetInstance(instance);
		}

        public RKeyframe(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RKeyframe(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
