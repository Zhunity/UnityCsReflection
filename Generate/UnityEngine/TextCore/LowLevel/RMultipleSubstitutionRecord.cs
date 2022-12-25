using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord
	/// </summary>
    public partial class RMultipleSubstitutionRecord : RMember //
    {

		/// <summary>
		/// System.UInt32 m_TargetGlyphID
		/// </summary>
		protected RField r_m_TargetGlyphID;
		public virtual RField Rm_TargetGlyphID
		{
			get
			{
				if(r_m_TargetGlyphID == null)
				{
					r_m_TargetGlyphID = new(this, "m_TargetGlyphID");
					r_m_TargetGlyphID.SetBelong(this.instance);
				}
				return r_m_TargetGlyphID;
			}
		}

		/// <summary>
		/// System.UInt32[] m_SubstituteGlyphIDs
		/// </summary>
		protected RFieldArray<RField> r_m_SubstituteGlyphIDs;
		public virtual RFieldArray<RField> Rm_SubstituteGlyphIDs
		{
			get
			{
				if(r_m_SubstituteGlyphIDs == null)
				{
					r_m_SubstituteGlyphIDs = new(this, "m_SubstituteGlyphIDs");
					r_m_SubstituteGlyphIDs.SetBelong(this.instance);
				}
				return r_m_SubstituteGlyphIDs;
			}
		}

		/// <summary>
		/// UInt32 targetGlyphID
		/// </summary>
		protected RProperty r_targetGlyphID;
		public virtual RProperty RtargetGlyphID
		{
			get
			{
				if(r_targetGlyphID == null)
				{
					r_targetGlyphID = new(this, "targetGlyphID", -1);
					r_targetGlyphID.SetBelong(this.instance);
				}
				return r_targetGlyphID;
			}
		}

		/// <summary>
		/// UInt32[] substituteGlyphIDs
		/// </summary>
		protected RPropertyArray<RProperty> r_substituteGlyphIDs;
		public virtual RPropertyArray<RProperty> RsubstituteGlyphIDs
		{
			get
			{
				if(r_substituteGlyphIDs == null)
				{
					r_substituteGlyphIDs = new(this, "substituteGlyphIDs", -1);
					r_substituteGlyphIDs.SetBelong(this.instance);
				}
				return r_substituteGlyphIDs;
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


        public RMultipleSubstitutionRecord() : base("UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord")
        {
        }

        public RMultipleSubstitutionRecord(System.Object instance) : base("UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord")
		{
            SetInstance(instance);
		}

        public RMultipleSubstitutionRecord(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMultipleSubstitutionRecord(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
