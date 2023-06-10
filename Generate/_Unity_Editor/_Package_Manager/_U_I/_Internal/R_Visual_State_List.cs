
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.VisualStateList
	/// </summary>
    public partial class RVisualStateList : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.VisualStateList");
            }
        }

        public RVisualStateList() : base("UnityEditor.PackageManager.UI.Internal.VisualStateList")
        {
        }

        public RVisualStateList(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.VisualStateList")
		{
            SetInstance(instance);
		}

        public RVisualStateList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVisualStateList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.VisualState] m_OrderedVisualStates
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> r_Fm_OrderedVisualStates;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> RFm_OrderedVisualStates
		{
			get
			{
				if(r_Fm_OrderedVisualStates == null)
				{
					r_Fm_OrderedVisualStates = new(this, "m_OrderedVisualStates");
				}
				return r_Fm_OrderedVisualStates;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] m_UniqueIdToIndexLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RInt32> r_Fm_UniqueIdToIndexLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RInt32> RFm_UniqueIdToIndexLookup
		{
			get
			{
				if(r_Fm_UniqueIdToIndexLookup == null)
				{
					r_Fm_UniqueIdToIndexLookup = new(this, "m_UniqueIdToIndexLookup");
				}
				return r_Fm_UniqueIdToIndexLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.VisualState] orderedList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> r_PorderedList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> RPorderedList
		{
			get
			{
				if(r_PorderedList == null)
				{
					r_PorderedList = new(this, "orderedList", -1);
				}
				return r_PorderedList;
			}
		}

		/// <summary>
		/// Int64 numItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PnumItems;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPnumItems
		{
			get
			{
				if(r_PnumItems == null)
				{
					r_PnumItems = new(this, "numItems", -1);
				}
				return r_PnumItems;
			}
		}

		/// <summary>
		/// Int64 numTotalItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PnumTotalItems;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPnumTotalItems
		{
			get
			{
				if(r_PnumTotalItems == null)
				{
					r_PnumTotalItems = new(this, "numTotalItems", -1);
				}
				return r_PnumTotalItems;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
				}
				return r_MOnAfterDeserialize;
			}
		}

		/// <summary>
		/// Void Rebuild(System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_MRebuild_IEnumerable_d_String_p_;
		public virtual RMethod RMRebuild_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MRebuild_IEnumerable_d_String_p_ == null)
				{
					r_MRebuild_IEnumerable_d_String_p_ = new(this, "Rebuild", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)));
				}
				return r_MRebuild_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// Void Rebuild(System.Collections.Generic.IEnumerable`1[UnityEditor.Tuple`3[System.String,System.String,System.Boolean]])
		/// </summary>
		protected RMethod r_MRebuild_IEnumerable_d_Tuple_d_String_String_Boolean_p__p_;
		public virtual RMethod RMRebuild_IEnumerable_d_Tuple_d_String_String_Boolean_p__p_
		{
			get
			{
				if(r_MRebuild_IEnumerable_d_Tuple_d_String_String_Boolean_p__p_ == null)
				{
					r_MRebuild_IEnumerable_d_Tuple_d_String_String_Boolean_p__p_ = new(this, "Rebuild", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.Tuple`3").MakeGenericType(typeof(System.String), typeof(System.String), typeof(System.Boolean))));
				}
				return r_MRebuild_IEnumerable_d_Tuple_d_String_String_Boolean_p__p_;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.VisualState GetVisualState(System.String)
		/// </summary>
		protected RMethod r_MGetVisualState_String;
		public virtual RMethod RMGetVisualState_String
		{
			get
			{
				if(r_MGetVisualState_String == null)
				{
					r_MGetVisualState_String = new(this, "GetVisualState", 0, typeof(System.String));
				}
				return r_MGetVisualState_String;
			}
		}

		/// <summary>
		/// Boolean Contains(System.String)
		/// </summary>
		protected RMethod r_MContains_String;
		public virtual RMethod RMContains_String
		{
			get
			{
				if(r_MContains_String == null)
				{
					r_MContains_String = new(this, "Contains", 0, typeof(System.String));
				}
				return r_MContains_String;
			}
		}

		/// <summary>
		/// Void SetupLookupTable()
		/// </summary>
		protected RMethod r_MSetupLookupTable;
		public virtual RMethod RMSetupLookupTable
		{
			get
			{
				if(r_MSetupLookupTable == null)
				{
					r_MSetupLookupTable = new(this, "SetupLookupTable", 0);
				}
				return r_MSetupLookupTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[UnityEditor.PackageManager.UI.Internal.VisualState] GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
				}
				return r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.VisualState <Rebuild>b__10_0(System.String)
		/// </summary>
		protected RMethod r_M__0__Rebuild__1__b__10_0_String;
		public virtual RMethod RM__0__Rebuild__1__b__10_0_String
		{
			get
			{
				if(r_M__0__Rebuild__1__b__10_0_String == null)
				{
					r_M__0__Rebuild__1__b__10_0_String = new(this, "<Rebuild>b__10_0", 0, typeof(System.String));
				}
				return r_M__0__Rebuild__1__b__10_0_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.VisualState <Rebuild>b__11_0(UnityEditor.Tuple`3[System.String,System.String,System.Boolean])
		/// </summary>
		protected RMethod r_M__0__Rebuild__1__b__11_0_Tuple_d_String_String_Boolean_p_;
		public virtual RMethod RM__0__Rebuild__1__b__11_0_Tuple_d_String_String_Boolean_p_
		{
			get
			{
				if(r_M__0__Rebuild__1__b__11_0_Tuple_d_String_String_Boolean_p_ == null)
				{
					r_M__0__Rebuild__1__b__11_0_Tuple_d_String_String_Boolean_p_ = new(this, "<Rebuild>b__11_0", 0,  ReflectionUtils.GetType("UnityEditor.Tuple`3").MakeGenericType(typeof(System.String), typeof(System.String), typeof(System.Boolean)));
				}
				return r_M__0__Rebuild__1__b__11_0_Tuple_d_String_String_Boolean_p_;
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


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rebuild(System.Collections.Generic.IEnumerable<System.String> @packageUniqueIds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueIds};
            var ___result = RMRebuild_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rebuild(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RTuple<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RBoolean>> @orderedPackageIdGroupsAndDefaultLockedStates)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@orderedPackageIdGroupsAndDefaultLockedStates.Value};
            var ___result = RMRebuild_IEnumerable_d_Tuple_d_String_String_Boolean_p__p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState GetVisualState(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMGetVisualState_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState(___result);
        }


        public virtual System.Boolean Contains(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetupLookupTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetupLookupTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState> GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState>(___result);
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState __0__Rebuild__1__b__10_0(System.String @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RM__0__Rebuild__1__b__10_0_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState __0__Rebuild__1__b__11_0(Hvak.Editor.Refleaction.RUnityEditor.RTuple<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RBoolean> @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t.Value};
            var ___result = RM__0__Rebuild__1__b__11_0_Tuple_d_String_String_Boolean_p_.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RVisualState(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
