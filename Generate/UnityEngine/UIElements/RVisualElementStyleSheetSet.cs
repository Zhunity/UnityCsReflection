using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.VisualElementStyleSheetSet
	/// </summary>
    public partial class RVisualElementStyleSheetSet : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_Element
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_Element;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_Element
		{
			get
			{
				if(r_m_Element == null)
				{
					r_m_Element = new(this, "m_Element");
					r_m_Element.SetBelong(this.instance);
				}
				return r_m_Element;
			}
		}

		/// <summary>
		/// Int32 count
		/// </summary>
		protected RProperty r_count;
		public virtual RProperty Rcount
		{
			get
			{
				if(r_count == null)
				{
					r_count = new(this, "count", -1);
					r_count.SetBelong(this.instance);
				}
				return r_count;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet Item [Int32]
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheet r_Item_Int32;
		public virtual RUnityEngine.RUIElements.RStyleSheet RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_Add_StyleSheet;
		public virtual RMethod RAdd_StyleSheet
		{
			get
			{
				if(r_Add_StyleSheet == null)
				{
					r_Add_StyleSheet = new(this, "Add", 0, typeof(UnityEngine.UIElements.StyleSheet));
					r_Add_StyleSheet.SetBelong(this.instance);
				}
				return r_Add_StyleSheet;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// Boolean Remove(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_Remove_StyleSheet;
		public virtual RMethod RRemove_StyleSheet
		{
			get
			{
				if(r_Remove_StyleSheet == null)
				{
					r_Remove_StyleSheet = new(this, "Remove", 0, typeof(UnityEngine.UIElements.StyleSheet));
					r_Remove_StyleSheet.SetBelong(this.instance);
				}
				return r_Remove_StyleSheet;
			}
		}

		/// <summary>
		/// Void Swap(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_Swap_StyleSheet_StyleSheet;
		public virtual RMethod RSwap_StyleSheet_StyleSheet
		{
			get
			{
				if(r_Swap_StyleSheet_StyleSheet == null)
				{
					r_Swap_StyleSheet_StyleSheet = new(this, "Swap", 0, typeof(UnityEngine.UIElements.StyleSheet), typeof(UnityEngine.UIElements.StyleSheet));
					r_Swap_StyleSheet_StyleSheet.SetBelong(this.instance);
				}
				return r_Swap_StyleSheet_StyleSheet;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_Contains_StyleSheet;
		public virtual RMethod RContains_StyleSheet
		{
			get
			{
				if(r_Contains_StyleSheet == null)
				{
					r_Contains_StyleSheet = new(this, "Contains", 0, typeof(UnityEngine.UIElements.StyleSheet));
					r_Contains_StyleSheet.SetBelong(this.instance);
				}
				return r_Contains_StyleSheet;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.VisualElementStyleSheetSet)
		/// </summary>
		protected RMethod r_Equals_VisualElementStyleSheetSet;
		public virtual RMethod REquals_VisualElementStyleSheetSet
		{
			get
			{
				if(r_Equals_VisualElementStyleSheetSet == null)
				{
					r_Equals_VisualElementStyleSheetSet = new(this, "Equals", 0, typeof(UnityEngine.UIElements.VisualElementStyleSheetSet));
					r_Equals_VisualElementStyleSheetSet.SetBelong(this.instance);
				}
				return r_Equals_VisualElementStyleSheetSet;
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
		/// Boolean op_Equality(UnityEngine.UIElements.VisualElementStyleSheetSet, UnityEngine.UIElements.VisualElementStyleSheetSet)
		/// </summary>
		protected static RMethod r_op_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet;
		public static RMethod Rop_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet
		{
			get
			{
				if(r_op_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet == null)
				{
					r_op_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet = new(typeof(UnityEngine.UIElements.VisualElementStyleSheetSet), "op_Equality", 0, typeof(UnityEngine.UIElements.VisualElementStyleSheetSet), typeof(UnityEngine.UIElements.VisualElementStyleSheetSet));
					r_op_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet.SetBelong(null);
				}
				return r_op_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.VisualElementStyleSheetSet, UnityEngine.UIElements.VisualElementStyleSheetSet)
		/// </summary>
		protected static RMethod r_op_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet;
		public static RMethod Rop_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet
		{
			get
			{
				if(r_op_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet == null)
				{
					r_op_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet = new(typeof(UnityEngine.UIElements.VisualElementStyleSheetSet), "op_Inequality", 0, typeof(UnityEngine.UIElements.VisualElementStyleSheetSet), typeof(UnityEngine.UIElements.VisualElementStyleSheetSet));
					r_op_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet.SetBelong(null);
				}
				return r_op_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet;
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


        public RVisualElementStyleSheetSet() : base("UnityEngine.UIElements.VisualElementStyleSheetSet")
        {
        }

        public RVisualElementStyleSheetSet(System.Object instance) : base("UnityEngine.UIElements.VisualElementStyleSheetSet")
		{
            SetInstance(instance);
		}

        public RVisualElementStyleSheetSet(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVisualElementStyleSheetSet(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Add(UnityEngine.UIElements.StyleSheet @styleSheet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleSheet};
            var ___result = RAdd_StyleSheet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(UnityEngine.UIElements.StyleSheet @styleSheet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleSheet};
            var ___result = RRemove_StyleSheet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Swap(UnityEngine.UIElements.StyleSheet @old, UnityEngine.UIElements.StyleSheet @new)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@old, @new};
            var ___result = RSwap_StyleSheet_StyleSheet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(UnityEngine.UIElements.StyleSheet @styleSheet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleSheet};
            var ___result = RContains_StyleSheet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.VisualElementStyleSheetSet @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_VisualElementStyleSheetSet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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


        public static System.Boolean op_Equality(UnityEngine.UIElements.VisualElementStyleSheetSet @left, UnityEngine.UIElements.VisualElementStyleSheetSet @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.VisualElementStyleSheetSet @left, UnityEngine.UIElements.VisualElementStyleSheetSet @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
