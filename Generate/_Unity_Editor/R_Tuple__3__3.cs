
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.Tuple`3
	/// </summary>
    public partial class RTuple<T1, T2, T3> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.Tuple`3").MakeGenericType(TypeToString.GetType(typeof(T1)), TypeToString.GetType(typeof(T2)), TypeToString.GetType(typeof(T3)));
            }
        }

        public RTuple() : base("UnityEditor.Tuple`3")
        {
        }

        public RTuple(System.Object instance) : base("UnityEditor.Tuple`3")
		{
            SetInstance(instance);
		}

        public RTuple(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTuple(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// T1 m_Item1
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fm_Item1;
		public virtual Hvak.Editor.Refleaction.RField RFm_Item1
		{
			get
			{
				if(r_Fm_Item1 == null)
				{
					r_Fm_Item1 = new(this, "m_Item1");
				}
				return r_Fm_Item1;
			}
		}

		/// <summary>
		/// T2 m_Item2
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fm_Item2;
		public virtual Hvak.Editor.Refleaction.RField RFm_Item2
		{
			get
			{
				if(r_Fm_Item2 == null)
				{
					r_Fm_Item2 = new(this, "m_Item2");
				}
				return r_Fm_Item2;
			}
		}

		/// <summary>
		/// T3 m_Item3
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fm_Item3;
		public virtual Hvak.Editor.Refleaction.RField RFm_Item3
		{
			get
			{
				if(r_Fm_Item3 == null)
				{
					r_Fm_Item3 = new(this, "m_Item3");
				}
				return r_Fm_Item3;
			}
		}

		/// <summary>
		/// T1 Item1
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PItem1;
		public virtual Hvak.Editor.Refleaction.RProperty RPItem1
		{
			get
			{
				if(r_PItem1 == null)
				{
					r_PItem1 = new(this, "Item1", -1);
				}
				return r_PItem1;
			}
		}

		/// <summary>
		/// T2 Item2
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PItem2;
		public virtual Hvak.Editor.Refleaction.RProperty RPItem2
		{
			get
			{
				if(r_PItem2 == null)
				{
					r_PItem2 = new(this, "Item2", -1);
				}
				return r_PItem2;
			}
		}

		/// <summary>
		/// T3 Item3
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PItem3;
		public virtual Hvak.Editor.Refleaction.RProperty RPItem3
		{
			get
			{
				if(r_PItem3 == null)
				{
					r_PItem3 = new(this, "Item3", -1);
				}
				return r_PItem3;
			}
		}

		/// <summary>
		/// Int32 UnityEditor.ITuple.Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PUnityEditor__2__ITuple__2__Length;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPUnityEditor__2__ITuple__2__Length
		{
			get
			{
				if(r_PUnityEditor__2__ITuple__2__Length == null)
				{
					r_PUnityEditor__2__ITuple__2__Length = new(this, "UnityEditor.ITuple.Length", -1);
				}
				return r_PUnityEditor__2__ITuple__2__Length;
			}
		}

		/// <summary>
		/// System.Object UnityEditor.ITuple.Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PUnityEditor__2__ITuple__2__Item_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPUnityEditor__2__ITuple__2__Item_Int32
		{
			get
			{
				if(r_PUnityEditor__2__ITuple__2__Item_Int32 == null)
				{
					r_PUnityEditor__2__ITuple__2__Item_Int32 = new(this, "UnityEditor.ITuple.Item", -1, typeof(System.Int32));
				}
				return r_PUnityEditor__2__ITuple__2__Item_Int32;
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
		/// Boolean UnityEditor.IStructuralEquatable.Equals(System.Object, System.Collections.IEqualityComparer)
		/// </summary>
		protected RMethod r_MUnityEditor__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer;
		public virtual RMethod RMUnityEditor__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer
		{
			get
			{
				if(r_MUnityEditor__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer == null)
				{
					r_MUnityEditor__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer = new(this, "UnityEditor.IStructuralEquatable.Equals", 0, typeof(System.Object), typeof(System.Collections.IEqualityComparer));
				}
				return r_MUnityEditor__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer;
			}
		}

		/// <summary>
		/// Int32 System.IComparable.CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__IComparable__2__CompareTo_Object;
		public virtual RMethod RMSystem__2__IComparable__2__CompareTo_Object
		{
			get
			{
				if(r_MSystem__2__IComparable__2__CompareTo_Object == null)
				{
					r_MSystem__2__IComparable__2__CompareTo_Object = new(this, "System.IComparable.CompareTo", 0, typeof(System.Object));
				}
				return r_MSystem__2__IComparable__2__CompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 UnityEditor.IStructuralComparable.CompareTo(System.Object, System.Collections.IComparer)
		/// </summary>
		protected RMethod r_MUnityEditor__2__IStructuralComparable__2__CompareTo_Object_IComparer;
		public virtual RMethod RMUnityEditor__2__IStructuralComparable__2__CompareTo_Object_IComparer
		{
			get
			{
				if(r_MUnityEditor__2__IStructuralComparable__2__CompareTo_Object_IComparer == null)
				{
					r_MUnityEditor__2__IStructuralComparable__2__CompareTo_Object_IComparer = new(this, "UnityEditor.IStructuralComparable.CompareTo", 0, typeof(System.Object), typeof(System.Collections.IComparer));
				}
				return r_MUnityEditor__2__IStructuralComparable__2__CompareTo_Object_IComparer;
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
		/// Int32 UnityEditor.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer)
		/// </summary>
		protected RMethod r_MUnityEditor__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer;
		public virtual RMethod RMUnityEditor__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer
		{
			get
			{
				if(r_MUnityEditor__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer == null)
				{
					r_MUnityEditor__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer = new(this, "UnityEditor.IStructuralEquatable.GetHashCode", 0, typeof(System.Collections.IEqualityComparer));
				}
				return r_MUnityEditor__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer;
			}
		}

		/// <summary>
		/// Int32 UnityEditor.ITupleInternal.GetHashCode(System.Collections.IEqualityComparer)
		/// </summary>
		protected RMethod r_MUnityEditor__2__ITupleInternal__2__GetHashCode_IEqualityComparer;
		public virtual RMethod RMUnityEditor__2__ITupleInternal__2__GetHashCode_IEqualityComparer
		{
			get
			{
				if(r_MUnityEditor__2__ITupleInternal__2__GetHashCode_IEqualityComparer == null)
				{
					r_MUnityEditor__2__ITupleInternal__2__GetHashCode_IEqualityComparer = new(this, "UnityEditor.ITupleInternal.GetHashCode", 0, typeof(System.Collections.IEqualityComparer));
				}
				return r_MUnityEditor__2__ITupleInternal__2__GetHashCode_IEqualityComparer;
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
		/// System.String UnityEditor.ITupleInternal.ToString(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_MUnityEditor__2__ITupleInternal__2__ToString_StringBuilder;
		public virtual RMethod RMUnityEditor__2__ITupleInternal__2__ToString_StringBuilder
		{
			get
			{
				if(r_MUnityEditor__2__ITupleInternal__2__ToString_StringBuilder == null)
				{
					r_MUnityEditor__2__ITupleInternal__2__ToString_StringBuilder = new(this, "UnityEditor.ITupleInternal.ToString", 0, typeof(System.Text.StringBuilder));
				}
				return r_MUnityEditor__2__ITupleInternal__2__ToString_StringBuilder;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEditor__2__IStructuralEquatable__2__Equals(System.Object @other, System.Collections.IEqualityComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @comparer};
            var ___result = RMUnityEditor__2__IStructuralEquatable__2__Equals_Object_IEqualityComparer.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 System__2__IComparable__2__CompareTo(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMSystem__2__IComparable__2__CompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 UnityEditor__2__IStructuralComparable__2__CompareTo(System.Object @other, System.Collections.IComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @comparer};
            var ___result = RMUnityEditor__2__IStructuralComparable__2__CompareTo_Object_IComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 UnityEditor__2__IStructuralEquatable__2__GetHashCode(System.Collections.IEqualityComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer};
            var ___result = RMUnityEditor__2__IStructuralEquatable__2__GetHashCode_IEqualityComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 UnityEditor__2__ITupleInternal__2__GetHashCode(System.Collections.IEqualityComparer @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer};
            var ___result = RMUnityEditor__2__ITupleInternal__2__GetHashCode_IEqualityComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String UnityEditor__2__ITupleInternal__2__ToString(System.Text.StringBuilder @sb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb};
            var ___result = RMUnityEditor__2__ITupleInternal__2__ToString_StringBuilder.Invoke(___genericsType, ___parameters);

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
