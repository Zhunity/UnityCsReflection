using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Keyframe
	/// </summary>
    public partial class RKeyframe : RMember //
    {

		/// <summary>
		/// System.Single m_Time
		/// </summary>
		protected RField r_m_Time;
		public virtual RField Rm_Time
		{
			get
			{
				if(r_m_Time == null)
				{
					r_m_Time = new(this, "m_Time");
					r_m_Time.SetBelong(this.instance);
				}
				return r_m_Time;
			}
		}

		/// <summary>
		/// System.Single m_Value
		/// </summary>
		protected RField r_m_Value;
		public virtual RField Rm_Value
		{
			get
			{
				if(r_m_Value == null)
				{
					r_m_Value = new(this, "m_Value");
					r_m_Value.SetBelong(this.instance);
				}
				return r_m_Value;
			}
		}

		/// <summary>
		/// System.Single m_InTangent
		/// </summary>
		protected RField r_m_InTangent;
		public virtual RField Rm_InTangent
		{
			get
			{
				if(r_m_InTangent == null)
				{
					r_m_InTangent = new(this, "m_InTangent");
					r_m_InTangent.SetBelong(this.instance);
				}
				return r_m_InTangent;
			}
		}

		/// <summary>
		/// System.Single m_OutTangent
		/// </summary>
		protected RField r_m_OutTangent;
		public virtual RField Rm_OutTangent
		{
			get
			{
				if(r_m_OutTangent == null)
				{
					r_m_OutTangent = new(this, "m_OutTangent");
					r_m_OutTangent.SetBelong(this.instance);
				}
				return r_m_OutTangent;
			}
		}

		/// <summary>
		/// System.Int32 m_TangentMode
		/// </summary>
		protected RField r_m_TangentMode;
		public virtual RField Rm_TangentMode
		{
			get
			{
				if(r_m_TangentMode == null)
				{
					r_m_TangentMode = new(this, "m_TangentMode");
					r_m_TangentMode.SetBelong(this.instance);
				}
				return r_m_TangentMode;
			}
		}

		/// <summary>
		/// System.Int32 m_WeightedMode
		/// </summary>
		protected RField r_m_WeightedMode;
		public virtual RField Rm_WeightedMode
		{
			get
			{
				if(r_m_WeightedMode == null)
				{
					r_m_WeightedMode = new(this, "m_WeightedMode");
					r_m_WeightedMode.SetBelong(this.instance);
				}
				return r_m_WeightedMode;
			}
		}

		/// <summary>
		/// System.Single m_InWeight
		/// </summary>
		protected RField r_m_InWeight;
		public virtual RField Rm_InWeight
		{
			get
			{
				if(r_m_InWeight == null)
				{
					r_m_InWeight = new(this, "m_InWeight");
					r_m_InWeight.SetBelong(this.instance);
				}
				return r_m_InWeight;
			}
		}

		/// <summary>
		/// System.Single m_OutWeight
		/// </summary>
		protected RField r_m_OutWeight;
		public virtual RField Rm_OutWeight
		{
			get
			{
				if(r_m_OutWeight == null)
				{
					r_m_OutWeight = new(this, "m_OutWeight");
					r_m_OutWeight.SetBelong(this.instance);
				}
				return r_m_OutWeight;
			}
		}

		/// <summary>
		/// Single time
		/// </summary>
		protected RProperty r_time;
		public virtual RProperty Rtime
		{
			get
			{
				if(r_time == null)
				{
					r_time = new(this, "time", -1);
					r_time.SetBelong(this.instance);
				}
				return r_time;
			}
		}

		/// <summary>
		/// Single value
		/// </summary>
		protected RProperty r_value;
		public virtual RProperty Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value", -1);
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// Single inTangent
		/// </summary>
		protected RProperty r_inTangent;
		public virtual RProperty RinTangent
		{
			get
			{
				if(r_inTangent == null)
				{
					r_inTangent = new(this, "inTangent", -1);
					r_inTangent.SetBelong(this.instance);
				}
				return r_inTangent;
			}
		}

		/// <summary>
		/// Single outTangent
		/// </summary>
		protected RProperty r_outTangent;
		public virtual RProperty RoutTangent
		{
			get
			{
				if(r_outTangent == null)
				{
					r_outTangent = new(this, "outTangent", -1);
					r_outTangent.SetBelong(this.instance);
				}
				return r_outTangent;
			}
		}

		/// <summary>
		/// Single inWeight
		/// </summary>
		protected RProperty r_inWeight;
		public virtual RProperty RinWeight
		{
			get
			{
				if(r_inWeight == null)
				{
					r_inWeight = new(this, "inWeight", -1);
					r_inWeight.SetBelong(this.instance);
				}
				return r_inWeight;
			}
		}

		/// <summary>
		/// Single outWeight
		/// </summary>
		protected RProperty r_outWeight;
		public virtual RProperty RoutWeight
		{
			get
			{
				if(r_outWeight == null)
				{
					r_outWeight = new(this, "outWeight", -1);
					r_outWeight.SetBelong(this.instance);
				}
				return r_outWeight;
			}
		}

		/// <summary>
		/// UnityEngine.WeightedMode weightedMode
		/// </summary>
		protected RProperty r_weightedMode;
		public virtual RProperty RweightedMode
		{
			get
			{
				if(r_weightedMode == null)
				{
					r_weightedMode = new(this, "weightedMode", -1);
					r_weightedMode.SetBelong(this.instance);
				}
				return r_weightedMode;
			}
		}

		/// <summary>
		/// Int32 tangentMode
		/// </summary>
		protected RProperty r_tangentMode;
		public virtual RProperty RtangentMode
		{
			get
			{
				if(r_tangentMode == null)
				{
					r_tangentMode = new(this, "tangentMode", -1);
					r_tangentMode.SetBelong(this.instance);
				}
				return r_tangentMode;
			}
		}

		/// <summary>
		/// Int32 tangentModeInternal
		/// </summary>
		protected RProperty r_tangentModeInternal;
		public virtual RProperty RtangentModeInternal
		{
			get
			{
				if(r_tangentModeInternal == null)
				{
					r_tangentModeInternal = new(this, "tangentModeInternal", -1);
					r_tangentModeInternal.SetBelong(this.instance);
				}
				return r_tangentModeInternal;
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

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
