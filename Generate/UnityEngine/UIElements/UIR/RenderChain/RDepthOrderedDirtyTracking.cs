using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RRenderChain
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking
	/// </summary>
    public partial class RDepthOrderedDirtyTracking : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] heads
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> r_heads;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> Rheads
		{
			get
			{
				if(r_heads == null)
				{
					r_heads = new(this, "heads");
					r_heads.SetBelong(this.instance);
				}
				return r_heads;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] tails
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> r_tails;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> Rtails
		{
			get
			{
				if(r_tails == null)
				{
					r_tails = new(this, "tails");
					r_tails.SetBelong(this.instance);
				}
				return r_tails;
			}
		}

		/// <summary>
		/// System.Int32[] minDepths
		/// </summary>
		protected RFieldArray<RField> r_minDepths;
		public virtual RFieldArray<RField> RminDepths
		{
			get
			{
				if(r_minDepths == null)
				{
					r_minDepths = new(this, "minDepths");
					r_minDepths.SetBelong(this.instance);
				}
				return r_minDepths;
			}
		}

		/// <summary>
		/// System.Int32[] maxDepths
		/// </summary>
		protected RFieldArray<RField> r_maxDepths;
		public virtual RFieldArray<RField> RmaxDepths
		{
			get
			{
				if(r_maxDepths == null)
				{
					r_maxDepths = new(this, "maxDepths");
					r_maxDepths.SetBelong(this.instance);
				}
				return r_maxDepths;
			}
		}

		/// <summary>
		/// System.UInt32 dirtyID
		/// </summary>
		protected RField r_dirtyID;
		public virtual RField RdirtyID
		{
			get
			{
				if(r_dirtyID == null)
				{
					r_dirtyID = new(this, "dirtyID");
					r_dirtyID.SetBelong(this.instance);
				}
				return r_dirtyID;
			}
		}

		/// <summary>
		/// Void EnsureFits(Int32)
		/// </summary>
		protected RMethod r_EnsureFits_Int32;
		public virtual RMethod REnsureFits_Int32
		{
			get
			{
				if(r_EnsureFits_Int32 == null)
				{
					r_EnsureFits_Int32 = new(this, "EnsureFits", 0, typeof(System.Int32));
					r_EnsureFits_Int32.SetBelong(this.instance);
				}
				return r_EnsureFits_Int32;
			}
		}

		/// <summary>
		/// Void RegisterDirty(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UIR.RenderDataDirtyTypes, UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses)
		/// </summary>
		protected RMethod r_RegisterDirty_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses;
		public virtual RMethod RRegisterDirty_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses
		{
			get
			{
				if(r_RegisterDirty_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses == null)
				{
					r_RegisterDirty_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses = new(this, "RegisterDirty", 0, typeof(UnityEngine.UIElements.VisualElement),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderDataDirtyTypes"),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses"));
					r_RegisterDirty_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses.SetBelong(this.instance);
				}
				return r_RegisterDirty_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses;
			}
		}

		/// <summary>
		/// Void ClearDirty(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UIR.RenderDataDirtyTypes)
		/// </summary>
		protected RMethod r_ClearDirty_VisualElement_RenderDataDirtyTypes;
		public virtual RMethod RClearDirty_VisualElement_RenderDataDirtyTypes
		{
			get
			{
				if(r_ClearDirty_VisualElement_RenderDataDirtyTypes == null)
				{
					r_ClearDirty_VisualElement_RenderDataDirtyTypes = new(this, "ClearDirty", 0, typeof(UnityEngine.UIElements.VisualElement),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderDataDirtyTypes"));
					r_ClearDirty_VisualElement_RenderDataDirtyTypes.SetBelong(this.instance);
				}
				return r_ClearDirty_VisualElement_RenderDataDirtyTypes;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
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


        public RDepthOrderedDirtyTracking() : base("UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking")
        {
        }

        public RDepthOrderedDirtyTracking(System.Object instance) : base("UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking")
		{
            SetInstance(instance);
		}

        public RDepthOrderedDirtyTracking(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDepthOrderedDirtyTracking(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void EnsureFits(System.Int32  @maxDepth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@maxDepth};
            var ___result = REnsureFits_Int32.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
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
}