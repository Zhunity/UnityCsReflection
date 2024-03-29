
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.PageSelection
	/// </summary>
    public partial class RPageSelection : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageSelection");
            }
        }

        public RPageSelection() : base("UnityEditor.PackageManager.UI.Internal.PageSelection")
        {
        }

        public RPageSelection(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PageSelection")
		{
            SetInstance(instance);
		}

        public RPageSelection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPageSelection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair] m_PreviousSelections
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> r_Fm_PreviousSelections;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> RFm_PreviousSelections
		{
			get
			{
				if(r_Fm_PreviousSelections == null)
				{
					r_Fm_PreviousSelections = new(this, "m_PreviousSelections");
				}
				return r_Fm_PreviousSelections;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair] m_SelectionsLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> r_Fm_SelectionsLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> RFm_SelectionsLookup
		{
			get
			{
				if(r_Fm_SelectionsLookup == null)
				{
					r_Fm_SelectionsLookup = new(this, "m_SelectionsLookup");
				}
				return r_Fm_SelectionsLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_OrderedSelections
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_OrderedSelections;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_OrderedSelections
		{
			get
			{
				if(r_Fm_OrderedSelections == null)
				{
					r_Fm_OrderedSelections = new(this, "m_OrderedSelections");
				}
				return r_Fm_OrderedSelections;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair[] m_SerializedSelectionsLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> r_Fm_SerializedSelectionsLookup;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> RFm_SerializedSelectionsLookup
		{
			get
			{
				if(r_Fm_SerializedSelectionsLookup == null)
				{
					r_Fm_SerializedSelectionsLookup = new(this, "m_SerializedSelectionsLookup");
				}
				return r_Fm_SerializedSelectionsLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair] previousSelections
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> r_PpreviousSelections;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> RPpreviousSelections
		{
			get
			{
				if(r_PpreviousSelections == null)
				{
					r_PpreviousSelections = new(this, "previousSelections", -1);
				}
				return r_PpreviousSelections;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair] orderedSelections
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> r_PorderedSelections;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> RPorderedSelections
		{
			get
			{
				if(r_PorderedSelections == null)
				{
					r_PorderedSelections = new(this, "orderedSelections", -1);
				}
				return r_PorderedSelections;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair firstSelection
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair r_PfirstSelection;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair RPfirstSelection
		{
			get
			{
				if(r_PfirstSelection == null)
				{
					r_PfirstSelection = new(this, "firstSelection", -1);
				}
				return r_PfirstSelection;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair lastSelection
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair r_PlastSelection;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair RPlastSelection
		{
			get
			{
				if(r_PlastSelection == null)
				{
					r_PlastSelection = new(this, "lastSelection", -1);
				}
				return r_PlastSelection;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Boolean SetNewSelection(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair])
		/// </summary>
		protected RMethod r_MSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_;
		public virtual RMethod RMSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_
		{
			get
			{
				if(r_MSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_ == null)
				{
					r_MSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_ = new(this, "SetNewSelection", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair")));
				}
				return r_MSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_;
			}
		}

		/// <summary>
		/// Void TrimOrderedSelection()
		/// </summary>
		protected RMethod r_MTrimOrderedSelection;
		public virtual RMethod RMTrimOrderedSelection
		{
			get
			{
				if(r_MTrimOrderedSelection == null)
				{
					r_MTrimOrderedSelection = new(this, "TrimOrderedSelection", 0);
				}
				return r_MTrimOrderedSelection;
			}
		}

		/// <summary>
		/// Boolean AmendSelection(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair], System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair])
		/// </summary>
		protected RMethod r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_;
		public virtual RMethod RMAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_
		{
			get
			{
				if(r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_ == null)
				{
					r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_ = new(this, "AmendSelection", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair")),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair")));
				}
				return r_MAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_;
			}
		}

		/// <summary>
		/// Boolean ToggleSelection(System.String)
		/// </summary>
		protected RMethod r_MToggleSelection_String;
		public virtual RMethod RMToggleSelection_String
		{
			get
			{
				if(r_MToggleSelection_String == null)
				{
					r_MToggleSelection_String = new(this, "ToggleSelection", 0, typeof(System.String));
				}
				return r_MToggleSelection_String;
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
		/// Boolean TryGetValue(System.String, UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_String_Out_PackageAndVersionIdPair;
		public virtual RMethod RMTryGetValue_String_Out_PackageAndVersionIdPair
		{
			get
			{
				if(r_MTryGetValue_String_Out_PackageAndVersionIdPair == null)
				{
					r_MTryGetValue_String_Out_PackageAndVersionIdPair = new(this, "TryGetValue", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair").MakeByRefType());
				}
				return r_MTryGetValue_String_Out_PackageAndVersionIdPair;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair] GetEnumerator()
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
		/// UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair <get_orderedSelections>b__7_0(System.String)
		/// </summary>
		protected RMethod r_M__0__get_orderedSelections__1__b__7_0_String;
		public virtual RMethod RM__0__get_orderedSelections__1__b__7_0_String
		{
			get
			{
				if(r_M__0__get_orderedSelections__1__b__7_0_String == null)
				{
					r_M__0__get_orderedSelections__1__b__7_0_String = new(this, "<get_orderedSelections>b__7_0", 0, typeof(System.String));
				}
				return r_M__0__get_orderedSelections__1__b__7_0_String;
			}
		}

		/// <summary>
		/// Boolean <TrimOrderedSelection>b__15_0(System.String)
		/// </summary>
		protected RMethod r_M__0__TrimOrderedSelection__1__b__15_0_String;
		public virtual RMethod RM__0__TrimOrderedSelection__1__b__15_0_String
		{
			get
			{
				if(r_M__0__TrimOrderedSelection__1__b__15_0_String == null)
				{
					r_M__0__TrimOrderedSelection__1__b__15_0_String = new(this, "<TrimOrderedSelection>b__15_0", 0, typeof(System.String));
				}
				return r_M__0__TrimOrderedSelection__1__b__15_0_String;
			}
		}

		/// <summary>
		/// Boolean <AmendSelection>b__16_0(UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair)
		/// </summary>
		protected RMethod r_M__0__AmendSelection__1__b__16_0_PackageAndVersionIdPair;
		public virtual RMethod RM__0__AmendSelection__1__b__16_0_PackageAndVersionIdPair
		{
			get
			{
				if(r_M__0__AmendSelection__1__b__16_0_PackageAndVersionIdPair == null)
				{
					r_M__0__AmendSelection__1__b__16_0_PackageAndVersionIdPair = new(this, "<AmendSelection>b__16_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair"));
				}
				return r_M__0__AmendSelection__1__b__16_0_PackageAndVersionIdPair;
			}
		}

		/// <summary>
		/// Boolean <AmendSelection>b__16_1(UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair)
		/// </summary>
		protected RMethod r_M__0__AmendSelection__1__b__16_1_PackageAndVersionIdPair;
		public virtual RMethod RM__0__AmendSelection__1__b__16_1_PackageAndVersionIdPair
		{
			get
			{
				if(r_M__0__AmendSelection__1__b__16_1_PackageAndVersionIdPair == null)
				{
					r_M__0__AmendSelection__1__b__16_1_PackageAndVersionIdPair = new(this, "<AmendSelection>b__16_1", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair"));
				}
				return r_M__0__AmendSelection__1__b__16_1_PackageAndVersionIdPair;
			}
		}

		/// <summary>
		/// Boolean <AmendSelection>b__16_2(UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair)
		/// </summary>
		protected RMethod r_M__0__AmendSelection__1__b__16_2_PackageAndVersionIdPair;
		public virtual RMethod RM__0__AmendSelection__1__b__16_2_PackageAndVersionIdPair
		{
			get
			{
				if(r_M__0__AmendSelection__1__b__16_2_PackageAndVersionIdPair == null)
				{
					r_M__0__AmendSelection__1__b__16_2_PackageAndVersionIdPair = new(this, "<AmendSelection>b__16_2", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageAndVersionIdPair"));
				}
				return r_M__0__AmendSelection__1__b__16_2_PackageAndVersionIdPair;
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


        public virtual System.Boolean SetNewSelection(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @packageAndVersionIds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageAndVersionIds.Value};
            var ___result = RMSetNewSelection_IEnumerable_d_PackageAndVersionIdPair_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void TrimOrderedSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTrimOrderedSelection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AmendSelection(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @toAddOrUpdate, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> @toRemove)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toAddOrUpdate.Value, @toRemove.Value};
            var ___result = RMAmendSelection_IEnumerable_d_PackageAndVersionIdPair_p__IEnumerable_d_PackageAndVersionIdPair_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean ToggleSelection(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMToggleSelection_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public virtual System.Boolean Contains(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMContains_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryGetValue(System.String @packageUniqueId, out Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId, @value.Value};
            var ___result = RMTryGetValue_String_Out_PackageAndVersionIdPair.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair> GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair>>(___result);
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.IEnumerator>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair __0__get_orderedSelections__1__b__7_0(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RM__0__get_orderedSelections__1__b__7_0_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair>(___result);
        }


        public virtual System.Boolean __0__TrimOrderedSelection__1__b__15_0(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RM__0__TrimOrderedSelection__1__b__15_0_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean __0__AmendSelection__1__b__16_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RM__0__AmendSelection__1__b__16_0_PackageAndVersionIdPair.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean __0__AmendSelection__1__b__16_1(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RM__0__AmendSelection__1__b__16_1_PackageAndVersionIdPair.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean __0__AmendSelection__1__b__16_2(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageAndVersionIdPair @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RM__0__AmendSelection__1__b__16_2_PackageAndVersionIdPair.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
