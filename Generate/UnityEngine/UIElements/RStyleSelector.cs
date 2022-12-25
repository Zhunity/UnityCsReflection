using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSelector
	/// </summary>
    public partial class RStyleSelector : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart[] m_Parts
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleSelectorPart> r_m_Parts;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleSelectorPart> Rm_Parts
		{
			get
			{
				if(r_m_Parts == null)
				{
					r_m_Parts = new(this, "m_Parts");
					r_m_Parts.SetBelong(this.instance);
				}
				return r_m_Parts;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorRelationship m_PreviousRelationship
		/// </summary>
		protected RField r_m_PreviousRelationship;
		public virtual RField Rm_PreviousRelationship
		{
			get
			{
				if(r_m_PreviousRelationship == null)
				{
					r_m_PreviousRelationship = new(this, "m_PreviousRelationship");
					r_m_PreviousRelationship.SetBelong(this.instance);
				}
				return r_m_PreviousRelationship;
			}
		}

		/// <summary>
		/// System.Int32 pseudoStateMask
		/// </summary>
		protected RField r_pseudoStateMask;
		public virtual RField RpseudoStateMask
		{
			get
			{
				if(r_pseudoStateMask == null)
				{
					r_pseudoStateMask = new(this, "pseudoStateMask");
					r_pseudoStateMask.SetBelong(this.instance);
				}
				return r_pseudoStateMask;
			}
		}

		/// <summary>
		/// System.Int32 negatedPseudoStateMask
		/// </summary>
		protected RField r_negatedPseudoStateMask;
		public virtual RField RnegatedPseudoStateMask
		{
			get
			{
				if(r_negatedPseudoStateMask == null)
				{
					r_negatedPseudoStateMask = new(this, "negatedPseudoStateMask");
					r_negatedPseudoStateMask.SetBelong(this.instance);
				}
				return r_negatedPseudoStateMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart[] parts
		/// </summary>
		protected RPropertyArray<RUnityEngine.RUIElements.RStyleSelectorPart> r_parts;
		public virtual RPropertyArray<RUnityEngine.RUIElements.RStyleSelectorPart> Rparts
		{
			get
			{
				if(r_parts == null)
				{
					r_parts = new(this, "parts", -1);
					r_parts.SetBelong(this.instance);
				}
				return r_parts;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorRelationship previousRelationship
		/// </summary>
		protected RProperty r_previousRelationship;
		public virtual RProperty RpreviousRelationship
		{
			get
			{
				if(r_previousRelationship == null)
				{
					r_previousRelationship = new(this, "previousRelationship", -1);
					r_previousRelationship.SetBelong(this.instance);
				}
				return r_previousRelationship;
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


        public RStyleSelector() : base("UnityEngine.UIElements.StyleSelector")
        {
        }

        public RStyleSelector(System.Object instance) : base("UnityEngine.UIElements.StyleSelector")
		{
            SetInstance(instance);
		}

        public RStyleSelector(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleSelector(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
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


    }
}
