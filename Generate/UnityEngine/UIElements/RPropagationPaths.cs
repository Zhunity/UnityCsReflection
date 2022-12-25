using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.PropagationPaths
	/// </summary>
    public partial class RPropagationPaths : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.ObjectPool`1[UnityEngine.UIElements.PropagationPaths] s_Pool
		/// </summary>
		protected static RUnityEngine.RUIElements.RObjectPool<RUnityEngine.RUIElements.RPropagationPaths> r_s_Pool;
		public static RUnityEngine.RUIElements.RObjectPool<RUnityEngine.RUIElements.RPropagationPaths> Rs_Pool
		{
			get
			{
				if(r_s_Pool == null)
				{
					r_s_Pool = new( ReleactionUtils.GetType("UnityEngine.UIElements.PropagationPaths"), "s_Pool");
					r_s_Pool.SetBelong(null);
				}
				return r_s_Pool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] trickleDownPath
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> r_trickleDownPath;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> RtrickleDownPath
		{
			get
			{
				if(r_trickleDownPath == null)
				{
					r_trickleDownPath = new(this, "trickleDownPath");
					r_trickleDownPath.SetBelong(this.instance);
				}
				return r_trickleDownPath;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] targetElements
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> r_targetElements;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> RtargetElements
		{
			get
			{
				if(r_targetElements == null)
				{
					r_targetElements = new(this, "targetElements");
					r_targetElements.SetBelong(this.instance);
				}
				return r_targetElements;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] bubbleUpPath
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> r_bubbleUpPath;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> RbubbleUpPath
		{
			get
			{
				if(r_bubbleUpPath == null)
				{
					r_bubbleUpPath = new(this, "bubbleUpPath");
					r_bubbleUpPath.SetBelong(this.instance);
				}
				return r_bubbleUpPath;
			}
		}

		/// <summary>
		/// System.Int32 k_DefaultPropagationDepth
		/// </summary>
		protected static RField r_k_DefaultPropagationDepth;
		public static RField Rk_DefaultPropagationDepth
		{
			get
			{
				if(r_k_DefaultPropagationDepth == null)
				{
					r_k_DefaultPropagationDepth = new( ReleactionUtils.GetType("UnityEngine.UIElements.PropagationPaths"), "k_DefaultPropagationDepth");
					r_k_DefaultPropagationDepth.SetBelong(null);
				}
				return r_k_DefaultPropagationDepth;
			}
		}

		/// <summary>
		/// System.Int32 k_DefaultTargetCount
		/// </summary>
		protected static RField r_k_DefaultTargetCount;
		public static RField Rk_DefaultTargetCount
		{
			get
			{
				if(r_k_DefaultTargetCount == null)
				{
					r_k_DefaultTargetCount = new( ReleactionUtils.GetType("UnityEngine.UIElements.PropagationPaths"), "k_DefaultTargetCount");
					r_k_DefaultTargetCount.SetBelong(null);
				}
				return r_k_DefaultTargetCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPaths Copy(UnityEngine.UIElements.PropagationPaths)
		/// </summary>
		protected static RMethod r_RCopy_PropagationPaths;
		public static RMethod RCopy_PropagationPaths
		{
			get
			{
				if(r_RCopy_PropagationPaths == null)
				{
					r_RCopy_PropagationPaths = new( ReleactionUtils.GetType("UnityEngine.UIElements.PropagationPaths"), "Copy", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.PropagationPaths"));
					r_RCopy_PropagationPaths.SetBelong(null);
				}
				return r_RCopy_PropagationPaths;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPaths Build(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected static RMethod r_RBuild_VisualElement_EventBase;
		public static RMethod RBuild_VisualElement_EventBase
		{
			get
			{
				if(r_RBuild_VisualElement_EventBase == null)
				{
					r_RBuild_VisualElement_EventBase = new( ReleactionUtils.GetType("UnityEngine.UIElements.PropagationPaths"), "Build", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.EventBase));
					r_RBuild_VisualElement_EventBase.SetBelong(null);
				}
				return r_RBuild_VisualElement_EventBase;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_RRelease;
		public virtual RMethod RRelease
		{
			get
			{
				if(r_RRelease == null)
				{
					r_RRelease = new(this, "Release", 0);
					r_RRelease.SetBelong(this.instance);
				}
				return r_RRelease;
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


        public RPropagationPaths() : base("UnityEngine.UIElements.PropagationPaths")
        {
        }

        public RPropagationPaths(System.Object instance) : base("UnityEngine.UIElements.PropagationPaths")
		{
            SetInstance(instance);
		}

        public RPropagationPaths(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPropagationPaths(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public static System.Object Build(UnityEngine.UIElements.VisualElement  @elem, UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem, @evt};
            var ___result = RBuild_VisualElement_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRelease.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
