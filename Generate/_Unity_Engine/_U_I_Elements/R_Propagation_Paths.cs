
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.PropagationPaths
	/// </summary>
    public partial class RPropagationPaths : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.ObjectPool`1[UnityEngine.UIElements.PropagationPaths] s_Pool
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RObjectPool<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths> r_Fs_Pool;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RObjectPool<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths> RFs_Pool
		{
			get
			{
				if(r_Fs_Pool == null)
				{
					r_Fs_Pool = new( ReflectionUtils.GetType("UnityEngine.UIElements.PropagationPaths"), "s_Pool");
				}
				return r_Fs_Pool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] trickleDownPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_FtrickleDownPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RFtrickleDownPath
		{
			get
			{
				if(r_FtrickleDownPath == null)
				{
					r_FtrickleDownPath = new(this, "trickleDownPath");
				}
				return r_FtrickleDownPath;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] targetElements
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_FtargetElements;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RFtargetElements
		{
			get
			{
				if(r_FtargetElements == null)
				{
					r_FtargetElements = new(this, "targetElements");
				}
				return r_FtargetElements;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] bubbleUpPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_FbubbleUpPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RFbubbleUpPath
		{
			get
			{
				if(r_FbubbleUpPath == null)
				{
					r_FbubbleUpPath = new(this, "bubbleUpPath");
				}
				return r_FbubbleUpPath;
			}
		}

		/// <summary>
		/// System.Int32 k_DefaultPropagationDepth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_DefaultPropagationDepth;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_DefaultPropagationDepth
		{
			get
			{
				if(r_Fk_DefaultPropagationDepth == null)
				{
					r_Fk_DefaultPropagationDepth = new( ReflectionUtils.GetType("UnityEngine.UIElements.PropagationPaths"), "k_DefaultPropagationDepth");
				}
				return r_Fk_DefaultPropagationDepth;
			}
		}

		/// <summary>
		/// System.Int32 k_DefaultTargetCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_DefaultTargetCount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_DefaultTargetCount
		{
			get
			{
				if(r_Fk_DefaultTargetCount == null)
				{
					r_Fk_DefaultTargetCount = new( ReflectionUtils.GetType("UnityEngine.UIElements.PropagationPaths"), "k_DefaultTargetCount");
				}
				return r_Fk_DefaultTargetCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPaths Copy(UnityEngine.UIElements.PropagationPaths)
		/// </summary>
		protected static RMethod r_MCopy_PropagationPaths;
		public static RMethod RMCopy_PropagationPaths
		{
			get
			{
				if(r_MCopy_PropagationPaths == null)
				{
					r_MCopy_PropagationPaths = new( ReflectionUtils.GetType("UnityEngine.UIElements.PropagationPaths"), "Copy", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.PropagationPaths"));
				}
				return r_MCopy_PropagationPaths;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PropagationPaths Build(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected static RMethod r_MBuild_VisualElement_EventBase;
		public static RMethod RMBuild_VisualElement_EventBase
		{
			get
			{
				if(r_MBuild_VisualElement_EventBase == null)
				{
					r_MBuild_VisualElement_EventBase = new( ReflectionUtils.GetType("UnityEngine.UIElements.PropagationPaths"), "Build", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MBuild_VisualElement_EventBase;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_MRelease;
		public virtual RMethod RMRelease
		{
			get
			{
				if(r_MRelease == null)
				{
					r_MRelease = new(this, "Release", 0);
				}
				return r_MRelease;
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

        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths Copy(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths @paths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@paths.Value};
            var ___result = RMCopy_PropagationPaths.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths Build(UnityEngine.UIElements.VisualElement @elem, UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem, @evt};
            var ___result = RMBuild_VisualElement_EventBase.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths(___result);
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRelease.Invoke(___genericsType, ___parameters);

            
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
