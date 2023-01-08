using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord
	/// </summary>
    public partial class RLigatureSubstitutionRecord : RMember //
    {

		/// <summary>
		/// System.UInt32[] m_ComponentGlyphIDs
		/// </summary>
		protected RFieldArray<RField> r_m_ComponentGlyphIDs;
		public virtual RFieldArray<RField> Rm_ComponentGlyphIDs
		{
			get
			{
				if(r_m_ComponentGlyphIDs == null)
				{
					r_m_ComponentGlyphIDs = new(this, "m_ComponentGlyphIDs");
					r_m_ComponentGlyphIDs.SetBelong(this.instance);
				}
				return r_m_ComponentGlyphIDs;
			}
		}

		/// <summary>
		/// System.UInt32 m_LigatureGlyphID
		/// </summary>
		protected RField r_m_LigatureGlyphID;
		public virtual RField Rm_LigatureGlyphID
		{
			get
			{
				if(r_m_LigatureGlyphID == null)
				{
					r_m_LigatureGlyphID = new(this, "m_LigatureGlyphID");
					r_m_LigatureGlyphID.SetBelong(this.instance);
				}
				return r_m_LigatureGlyphID;
			}
		}

		/// <summary>
		/// UInt32[] componentGlyphIDs
		/// </summary>
		protected RPropertyArray<RProperty> r_componentGlyphIDs;
		public virtual RPropertyArray<RProperty> RcomponentGlyphIDs
		{
			get
			{
				if(r_componentGlyphIDs == null)
				{
					r_componentGlyphIDs = new(this, "componentGlyphIDs", -1);
					r_componentGlyphIDs.SetBelong(this.instance);
				}
				return r_componentGlyphIDs;
			}
		}

		/// <summary>
		/// UInt32 ligatureGlyphID
		/// </summary>
		protected RProperty r_ligatureGlyphID;
		public virtual RProperty RligatureGlyphID
		{
			get
			{
				if(r_ligatureGlyphID == null)
				{
					r_ligatureGlyphID = new(this, "ligatureGlyphID", -1);
					r_ligatureGlyphID.SetBelong(this.instance);
				}
				return r_ligatureGlyphID;
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


        public RLigatureSubstitutionRecord() : base("UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord")
        {
        }

        public RLigatureSubstitutionRecord(System.Object instance) : base("UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord")
		{
            SetInstance(instance);
		}

        public RLigatureSubstitutionRecord(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLigatureSubstitutionRecord(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
