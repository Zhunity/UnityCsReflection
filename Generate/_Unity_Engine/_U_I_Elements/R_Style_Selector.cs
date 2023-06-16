
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.StyleSelector
	/// </summary>
    public partial class RStyleSelector : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSelector");
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


		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart[] m_Parts
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart> r_Fm_Parts;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart> RFm_Parts
		{
			get
			{
				if(r_Fm_Parts == null)
				{
					r_Fm_Parts = new(this, "m_Parts");
				}
				return r_Fm_Parts;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorRelationship m_PreviousRelationship
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorRelationship r_Fm_PreviousRelationship;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorRelationship RFm_PreviousRelationship
		{
			get
			{
				if(r_Fm_PreviousRelationship == null)
				{
					r_Fm_PreviousRelationship = new(this, "m_PreviousRelationship");
				}
				return r_Fm_PreviousRelationship;
			}
		}

		/// <summary>
		/// System.Int32 pseudoStateMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FpseudoStateMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpseudoStateMask
		{
			get
			{
				if(r_FpseudoStateMask == null)
				{
					r_FpseudoStateMask = new(this, "pseudoStateMask");
				}
				return r_FpseudoStateMask;
			}
		}

		/// <summary>
		/// System.Int32 negatedPseudoStateMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FnegatedPseudoStateMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnegatedPseudoStateMask
		{
			get
			{
				if(r_FnegatedPseudoStateMask == null)
				{
					r_FnegatedPseudoStateMask = new(this, "negatedPseudoStateMask");
				}
				return r_FnegatedPseudoStateMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorPart[] parts
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart> r_Pparts;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart> RPparts
		{
			get
			{
				if(r_Pparts == null)
				{
					r_Pparts = new(this, "parts", -1);
				}
				return r_Pparts;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelectorRelationship previousRelationship
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorRelationship r_PpreviousRelationship;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorRelationship RPpreviousRelationship
		{
			get
			{
				if(r_PpreviousRelationship == null)
				{
					r_PpreviousRelationship = new(this, "previousRelationship", -1);
				}
				return r_PpreviousRelationship;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
