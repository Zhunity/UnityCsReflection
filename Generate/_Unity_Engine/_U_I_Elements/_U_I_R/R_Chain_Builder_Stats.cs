
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.ChainBuilderStats
	/// </summary>
    public partial class RChainBuilderStats : RMember //
    {

		/// <summary>
		/// System.UInt32 elementsAdded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FelementsAdded;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFelementsAdded
		{
			get
			{
				if(r_FelementsAdded == null)
				{
					r_FelementsAdded = new(this, "elementsAdded");
					r_FelementsAdded.SetBelong(this.GetValue());
				}
				return r_FelementsAdded;
			}
		}

		/// <summary>
		/// System.UInt32 elementsRemoved
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FelementsRemoved;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFelementsRemoved
		{
			get
			{
				if(r_FelementsRemoved == null)
				{
					r_FelementsRemoved = new(this, "elementsRemoved");
					r_FelementsRemoved.SetBelong(this.GetValue());
				}
				return r_FelementsRemoved;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveClipUpdates
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FrecursiveClipUpdates;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFrecursiveClipUpdates
		{
			get
			{
				if(r_FrecursiveClipUpdates == null)
				{
					r_FrecursiveClipUpdates = new(this, "recursiveClipUpdates");
					r_FrecursiveClipUpdates.SetBelong(this.GetValue());
				}
				return r_FrecursiveClipUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveClipUpdatesExpanded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FrecursiveClipUpdatesExpanded;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFrecursiveClipUpdatesExpanded
		{
			get
			{
				if(r_FrecursiveClipUpdatesExpanded == null)
				{
					r_FrecursiveClipUpdatesExpanded = new(this, "recursiveClipUpdatesExpanded");
					r_FrecursiveClipUpdatesExpanded.SetBelong(this.GetValue());
				}
				return r_FrecursiveClipUpdatesExpanded;
			}
		}

		/// <summary>
		/// System.UInt32 nonRecursiveClipUpdates
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FnonRecursiveClipUpdates;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFnonRecursiveClipUpdates
		{
			get
			{
				if(r_FnonRecursiveClipUpdates == null)
				{
					r_FnonRecursiveClipUpdates = new(this, "nonRecursiveClipUpdates");
					r_FnonRecursiveClipUpdates.SetBelong(this.GetValue());
				}
				return r_FnonRecursiveClipUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveTransformUpdates
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FrecursiveTransformUpdates;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFrecursiveTransformUpdates
		{
			get
			{
				if(r_FrecursiveTransformUpdates == null)
				{
					r_FrecursiveTransformUpdates = new(this, "recursiveTransformUpdates");
					r_FrecursiveTransformUpdates.SetBelong(this.GetValue());
				}
				return r_FrecursiveTransformUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveTransformUpdatesExpanded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FrecursiveTransformUpdatesExpanded;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFrecursiveTransformUpdatesExpanded
		{
			get
			{
				if(r_FrecursiveTransformUpdatesExpanded == null)
				{
					r_FrecursiveTransformUpdatesExpanded = new(this, "recursiveTransformUpdatesExpanded");
					r_FrecursiveTransformUpdatesExpanded.SetBelong(this.GetValue());
				}
				return r_FrecursiveTransformUpdatesExpanded;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveOpacityUpdates
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FrecursiveOpacityUpdates;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFrecursiveOpacityUpdates
		{
			get
			{
				if(r_FrecursiveOpacityUpdates == null)
				{
					r_FrecursiveOpacityUpdates = new(this, "recursiveOpacityUpdates");
					r_FrecursiveOpacityUpdates.SetBelong(this.GetValue());
				}
				return r_FrecursiveOpacityUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveOpacityUpdatesExpanded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FrecursiveOpacityUpdatesExpanded;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFrecursiveOpacityUpdatesExpanded
		{
			get
			{
				if(r_FrecursiveOpacityUpdatesExpanded == null)
				{
					r_FrecursiveOpacityUpdatesExpanded = new(this, "recursiveOpacityUpdatesExpanded");
					r_FrecursiveOpacityUpdatesExpanded.SetBelong(this.GetValue());
				}
				return r_FrecursiveOpacityUpdatesExpanded;
			}
		}

		/// <summary>
		/// System.UInt32 opacityIdUpdates
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FopacityIdUpdates;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFopacityIdUpdates
		{
			get
			{
				if(r_FopacityIdUpdates == null)
				{
					r_FopacityIdUpdates = new(this, "opacityIdUpdates");
					r_FopacityIdUpdates.SetBelong(this.GetValue());
				}
				return r_FopacityIdUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 colorUpdates
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FcolorUpdates;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFcolorUpdates
		{
			get
			{
				if(r_FcolorUpdates == null)
				{
					r_FcolorUpdates = new(this, "colorUpdates");
					r_FcolorUpdates.SetBelong(this.GetValue());
				}
				return r_FcolorUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 colorUpdatesExpanded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FcolorUpdatesExpanded;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFcolorUpdatesExpanded
		{
			get
			{
				if(r_FcolorUpdatesExpanded == null)
				{
					r_FcolorUpdatesExpanded = new(this, "colorUpdatesExpanded");
					r_FcolorUpdatesExpanded.SetBelong(this.GetValue());
				}
				return r_FcolorUpdatesExpanded;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveVisualUpdates
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FrecursiveVisualUpdates;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFrecursiveVisualUpdates
		{
			get
			{
				if(r_FrecursiveVisualUpdates == null)
				{
					r_FrecursiveVisualUpdates = new(this, "recursiveVisualUpdates");
					r_FrecursiveVisualUpdates.SetBelong(this.GetValue());
				}
				return r_FrecursiveVisualUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 recursiveVisualUpdatesExpanded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FrecursiveVisualUpdatesExpanded;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFrecursiveVisualUpdatesExpanded
		{
			get
			{
				if(r_FrecursiveVisualUpdatesExpanded == null)
				{
					r_FrecursiveVisualUpdatesExpanded = new(this, "recursiveVisualUpdatesExpanded");
					r_FrecursiveVisualUpdatesExpanded.SetBelong(this.GetValue());
				}
				return r_FrecursiveVisualUpdatesExpanded;
			}
		}

		/// <summary>
		/// System.UInt32 nonRecursiveVisualUpdates
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FnonRecursiveVisualUpdates;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFnonRecursiveVisualUpdates
		{
			get
			{
				if(r_FnonRecursiveVisualUpdates == null)
				{
					r_FnonRecursiveVisualUpdates = new(this, "nonRecursiveVisualUpdates");
					r_FnonRecursiveVisualUpdates.SetBelong(this.GetValue());
				}
				return r_FnonRecursiveVisualUpdates;
			}
		}

		/// <summary>
		/// System.UInt32 dirtyProcessed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FdirtyProcessed;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFdirtyProcessed
		{
			get
			{
				if(r_FdirtyProcessed == null)
				{
					r_FdirtyProcessed = new(this, "dirtyProcessed");
					r_FdirtyProcessed.SetBelong(this.GetValue());
				}
				return r_FdirtyProcessed;
			}
		}

		/// <summary>
		/// System.UInt32 nudgeTransformed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FnudgeTransformed;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFnudgeTransformed
		{
			get
			{
				if(r_FnudgeTransformed == null)
				{
					r_FnudgeTransformed = new(this, "nudgeTransformed");
					r_FnudgeTransformed.SetBelong(this.GetValue());
				}
				return r_FnudgeTransformed;
			}
		}

		/// <summary>
		/// System.UInt32 boneTransformed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FboneTransformed;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFboneTransformed
		{
			get
			{
				if(r_FboneTransformed == null)
				{
					r_FboneTransformed = new(this, "boneTransformed");
					r_FboneTransformed.SetBelong(this.GetValue());
				}
				return r_FboneTransformed;
			}
		}

		/// <summary>
		/// System.UInt32 skipTransformed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FskipTransformed;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFskipTransformed
		{
			get
			{
				if(r_FskipTransformed == null)
				{
					r_FskipTransformed = new(this, "skipTransformed");
					r_FskipTransformed.SetBelong(this.GetValue());
				}
				return r_FskipTransformed;
			}
		}

		/// <summary>
		/// System.UInt32 visualUpdateTransformed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FvisualUpdateTransformed;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFvisualUpdateTransformed
		{
			get
			{
				if(r_FvisualUpdateTransformed == null)
				{
					r_FvisualUpdateTransformed = new(this, "visualUpdateTransformed");
					r_FvisualUpdateTransformed.SetBelong(this.GetValue());
				}
				return r_FvisualUpdateTransformed;
			}
		}

		/// <summary>
		/// System.UInt32 updatedMeshAllocations
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FupdatedMeshAllocations;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFupdatedMeshAllocations
		{
			get
			{
				if(r_FupdatedMeshAllocations == null)
				{
					r_FupdatedMeshAllocations = new(this, "updatedMeshAllocations");
					r_FupdatedMeshAllocations.SetBelong(this.GetValue());
				}
				return r_FupdatedMeshAllocations;
			}
		}

		/// <summary>
		/// System.UInt32 newMeshAllocations
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FnewMeshAllocations;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFnewMeshAllocations
		{
			get
			{
				if(r_FnewMeshAllocations == null)
				{
					r_FnewMeshAllocations = new(this, "newMeshAllocations");
					r_FnewMeshAllocations.SetBelong(this.GetValue());
				}
				return r_FnewMeshAllocations;
			}
		}

		/// <summary>
		/// System.UInt32 groupTransformElementsChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FgroupTransformElementsChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFgroupTransformElementsChanged
		{
			get
			{
				if(r_FgroupTransformElementsChanged == null)
				{
					r_FgroupTransformElementsChanged = new(this, "groupTransformElementsChanged");
					r_FgroupTransformElementsChanged.SetBelong(this.GetValue());
				}
				return r_FgroupTransformElementsChanged;
			}
		}

		/// <summary>
		/// System.UInt32 immedateRenderersActive
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FimmedateRenderersActive;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFimmedateRenderersActive
		{
			get
			{
				if(r_FimmedateRenderersActive == null)
				{
					r_FimmedateRenderersActive = new(this, "immedateRenderersActive");
					r_FimmedateRenderersActive.SetBelong(this.GetValue());
				}
				return r_FimmedateRenderersActive;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RChainBuilderStats() : base("UnityEngine.UIElements.UIR.ChainBuilderStats")
        {
        }

        public RChainBuilderStats(System.Object instance) : base("UnityEngine.UIElements.UIR.ChainBuilderStats")
		{
            SetInstance(instance);
		}

        public RChainBuilderStats(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RChainBuilderStats(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
