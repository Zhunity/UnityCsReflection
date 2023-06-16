
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RRenderChain
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking
	/// </summary>
    public partial class RDepthOrderedDirtyTracking : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking");
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


		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] heads
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_Fheads;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RFheads
		{
			get
			{
				if(r_Fheads == null)
				{
					r_Fheads = new(this, "heads");
				}
				return r_Fheads;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] tails
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_Ftails;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RFtails
		{
			get
			{
				if(r_Ftails == null)
				{
					r_Ftails = new(this, "tails");
				}
				return r_Ftails;
			}
		}

		/// <summary>
		/// System.Int32[] minDepths
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FminDepths;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFminDepths
		{
			get
			{
				if(r_FminDepths == null)
				{
					r_FminDepths = new(this, "minDepths");
				}
				return r_FminDepths;
			}
		}

		/// <summary>
		/// System.Int32[] maxDepths
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_FmaxDepths;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFmaxDepths
		{
			get
			{
				if(r_FmaxDepths == null)
				{
					r_FmaxDepths = new(this, "maxDepths");
				}
				return r_FmaxDepths;
			}
		}

		/// <summary>
		/// System.UInt32 dirtyID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FdirtyID;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFdirtyID
		{
			get
			{
				if(r_FdirtyID == null)
				{
					r_FdirtyID = new(this, "dirtyID");
				}
				return r_FdirtyID;
			}
		}

		/// <summary>
		/// Void EnsureFits(Int32)
		/// </summary>
		protected RMethod r_MEnsureFits_Int32;
		public virtual RMethod RMEnsureFits_Int32
		{
			get
			{
				if(r_MEnsureFits_Int32 == null)
				{
					r_MEnsureFits_Int32 = new(this, "EnsureFits", 0, typeof(System.Int32));
				}
				return r_MEnsureFits_Int32;
			}
		}

		/// <summary>
		/// Void RegisterDirty(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UIR.RenderDataDirtyTypes, UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses)
		/// </summary>
		protected RMethod r_MRegisterDirty_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses;
		public virtual RMethod RMRegisterDirty_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses
		{
			get
			{
				if(r_MRegisterDirty_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses == null)
				{
					r_MRegisterDirty_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses = new(this, "RegisterDirty", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderDataDirtyTypes"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses"));
				}
				return r_MRegisterDirty_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses;
			}
		}

		/// <summary>
		/// Void ClearDirty(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UIR.RenderDataDirtyTypes)
		/// </summary>
		protected RMethod r_MClearDirty_VisualElement_RenderDataDirtyTypes;
		public virtual RMethod RMClearDirty_VisualElement_RenderDataDirtyTypes
		{
			get
			{
				if(r_MClearDirty_VisualElement_RenderDataDirtyTypes == null)
				{
					r_MClearDirty_VisualElement_RenderDataDirtyTypes = new(this, "ClearDirty", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderDataDirtyTypes"));
				}
				return r_MClearDirty_VisualElement_RenderDataDirtyTypes;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
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


        public virtual void EnsureFits(System.Int32 @maxDepth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@maxDepth};
            var ___result = RMEnsureFits_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterDirty(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes @dirtyTypes, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypeClasses @dirtyTypeClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @dirtyTypes.Value, @dirtyTypeClass.Value};
            var ___result = RMRegisterDirty_VisualElement_RenderDataDirtyTypes_RenderDataDirtyTypeClasses.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearDirty(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes @dirtyTypesInverse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @dirtyTypesInverse.Value};
            var ___result = RMClearDirty_VisualElement_RenderDataDirtyTypes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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
}