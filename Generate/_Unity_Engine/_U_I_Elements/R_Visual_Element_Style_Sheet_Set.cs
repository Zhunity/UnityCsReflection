
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
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_Element;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_Element
		{
			get
			{
				if(r_Fm_Element == null)
				{
					r_Fm_Element = new(this, "m_Element");
					r_Fm_Element.SetBelong(this.instance);
				}
				return r_Fm_Element;
			}
		}

		/// <summary>
		/// Int32 count
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Pcount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPcount
		{
			get
			{
				if(r_Pcount == null)
				{
					r_Pcount = new(this, "count", -1);
					r_Pcount.SetBelong(this.instance);
				}
				return r_Pcount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet Item [Int32]
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet r_PItem_Int32;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_PItem_Int32.SetBelong(this.instance);
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_MAdd_StyleSheet;
		public virtual RMethod RMAdd_StyleSheet
		{
			get
			{
				if(r_MAdd_StyleSheet == null)
				{
					r_MAdd_StyleSheet = new(this, "Add", 0, typeof(UnityEngine.UIElements.StyleSheet));
					r_MAdd_StyleSheet.SetBelong(this.instance);
				}
				return r_MAdd_StyleSheet;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
					r_MClear.SetBelong(this.instance);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// Boolean Remove(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_MRemove_StyleSheet;
		public virtual RMethod RMRemove_StyleSheet
		{
			get
			{
				if(r_MRemove_StyleSheet == null)
				{
					r_MRemove_StyleSheet = new(this, "Remove", 0, typeof(UnityEngine.UIElements.StyleSheet));
					r_MRemove_StyleSheet.SetBelong(this.instance);
				}
				return r_MRemove_StyleSheet;
			}
		}

		/// <summary>
		/// Void Swap(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_MSwap_StyleSheet_StyleSheet;
		public virtual RMethod RMSwap_StyleSheet_StyleSheet
		{
			get
			{
				if(r_MSwap_StyleSheet_StyleSheet == null)
				{
					r_MSwap_StyleSheet_StyleSheet = new(this, "Swap", 0, typeof(UnityEngine.UIElements.StyleSheet), typeof(UnityEngine.UIElements.StyleSheet));
					r_MSwap_StyleSheet_StyleSheet.SetBelong(this.instance);
				}
				return r_MSwap_StyleSheet_StyleSheet;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_MContains_StyleSheet;
		public virtual RMethod RMContains_StyleSheet
		{
			get
			{
				if(r_MContains_StyleSheet == null)
				{
					r_MContains_StyleSheet = new(this, "Contains", 0, typeof(UnityEngine.UIElements.StyleSheet));
					r_MContains_StyleSheet.SetBelong(this.instance);
				}
				return r_MContains_StyleSheet;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.VisualElementStyleSheetSet)
		/// </summary>
		protected RMethod r_MEquals_VisualElementStyleSheetSet;
		public virtual RMethod RMEquals_VisualElementStyleSheetSet
		{
			get
			{
				if(r_MEquals_VisualElementStyleSheetSet == null)
				{
					r_MEquals_VisualElementStyleSheetSet = new(this, "Equals", 0, typeof(UnityEngine.UIElements.VisualElementStyleSheetSet));
					r_MEquals_VisualElementStyleSheetSet.SetBelong(this.instance);
				}
				return r_MEquals_VisualElementStyleSheetSet;
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
		/// Boolean op_Equality(UnityEngine.UIElements.VisualElementStyleSheetSet, UnityEngine.UIElements.VisualElementStyleSheetSet)
		/// </summary>
		protected static RMethod r_Mop_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet;
		public static RMethod RMop_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet
		{
			get
			{
				if(r_Mop_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet == null)
				{
					r_Mop_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet = new(typeof(UnityEngine.UIElements.VisualElementStyleSheetSet), "op_Equality", 0, typeof(UnityEngine.UIElements.VisualElementStyleSheetSet), typeof(UnityEngine.UIElements.VisualElementStyleSheetSet));
					r_Mop_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet.SetBelong(null);
				}
				return r_Mop_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.VisualElementStyleSheetSet, UnityEngine.UIElements.VisualElementStyleSheetSet)
		/// </summary>
		protected static RMethod r_Mop_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet;
		public static RMethod RMop_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet
		{
			get
			{
				if(r_Mop_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet == null)
				{
					r_Mop_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet = new(typeof(UnityEngine.UIElements.VisualElementStyleSheetSet), "op_Inequality", 0, typeof(UnityEngine.UIElements.VisualElementStyleSheetSet), typeof(UnityEngine.UIElements.VisualElementStyleSheetSet));
					r_Mop_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet.SetBelong(null);
				}
				return r_Mop_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet;
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
            var ___result = RMAdd_StyleSheet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(UnityEngine.UIElements.StyleSheet @styleSheet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleSheet};
            var ___result = RMRemove_StyleSheet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Swap(UnityEngine.UIElements.StyleSheet @old, UnityEngine.UIElements.StyleSheet @new)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@old, @new};
            var ___result = RMSwap_StyleSheet_StyleSheet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(UnityEngine.UIElements.StyleSheet @styleSheet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleSheet};
            var ___result = RMContains_StyleSheet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.VisualElementStyleSheetSet @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_VisualElementStyleSheetSet.Invoke(___genericsType, ___parameters);

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


        public static System.Boolean op_Equality(UnityEngine.UIElements.VisualElementStyleSheetSet @left, UnityEngine.UIElements.VisualElementStyleSheetSet @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_VisualElementStyleSheetSet_VisualElementStyleSheetSet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.VisualElementStyleSheetSet @left, UnityEngine.UIElements.VisualElementStyleSheetSet @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_VisualElementStyleSheetSet_VisualElementStyleSheetSet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
