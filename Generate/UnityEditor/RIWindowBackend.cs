using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.IWindowBackend
	/// </summary>
    public partial class RIWindowBackend : RMember //
    {

		/// <summary>
		/// System.Object visualTree
		/// </summary>
		protected RSystem.RObject r_visualTree;
		public virtual RSystem.RObject RvisualTree
		{
			get
			{
				if(r_visualTree == null)
				{
					r_visualTree = new(this, "visualTree", -1);
					r_visualTree.SetBelong(this.instance);
				}
				return r_visualTree;
			}
		}

		/// <summary>
		/// Void OnCreate(UnityEditor.IWindowModel)
		/// </summary>
		protected RMethod r_ROnCreate_IWindowModel;
		public virtual RMethod ROnCreate_IWindowModel
		{
			get
			{
				if(r_ROnCreate_IWindowModel == null)
				{
					r_ROnCreate_IWindowModel = new(this, "OnCreate", 0,  ReleactionUtils.GetType("UnityEditor.IWindowModel"));
					r_ROnCreate_IWindowModel.SetBelong(this.instance);
				}
				return r_ROnCreate_IWindowModel;
			}
		}

		/// <summary>
		/// Void OnDestroy(UnityEditor.IWindowModel)
		/// </summary>
		protected RMethod r_ROnDestroy_IWindowModel;
		public virtual RMethod ROnDestroy_IWindowModel
		{
			get
			{
				if(r_ROnDestroy_IWindowModel == null)
				{
					r_ROnDestroy_IWindowModel = new(this, "OnDestroy", 0,  ReleactionUtils.GetType("UnityEditor.IWindowModel"));
					r_ROnDestroy_IWindowModel.SetBelong(this.instance);
				}
				return r_ROnDestroy_IWindowModel;
			}
		}

		/// <summary>
		/// Boolean GetTooltip(UnityEngine.Vector2, System.String ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_RGetTooltip_Vector2_Out_String_Out_Rect;
		public virtual RMethod RGetTooltip_Vector2_Out_String_Out_Rect
		{
			get
			{
				if(r_RGetTooltip_Vector2_Out_String_Out_Rect == null)
				{
					r_RGetTooltip_Vector2_Out_String_Out_Rect = new(this, "GetTooltip", 0, typeof(UnityEngine.Vector2), typeof(System.String).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
					r_RGetTooltip_Vector2_Out_String_Out_Rect.SetBelong(this.instance);
				}
				return r_RGetTooltip_Vector2_Out_String_Out_Rect;
			}
		}

		/// <summary>
		/// Void SizeChanged()
		/// </summary>
		protected RMethod r_RSizeChanged;
		public virtual RMethod RSizeChanged
		{
			get
			{
				if(r_RSizeChanged == null)
				{
					r_RSizeChanged = new(this, "SizeChanged", 0);
					r_RSizeChanged.SetBelong(this.instance);
				}
				return r_RSizeChanged;
			}
		}

		/// <summary>
		/// Void EventInterestsChanged()
		/// </summary>
		protected RMethod r_REventInterestsChanged;
		public virtual RMethod REventInterestsChanged
		{
			get
			{
				if(r_REventInterestsChanged == null)
				{
					r_REventInterestsChanged = new(this, "EventInterestsChanged", 0);
					r_REventInterestsChanged.SetBelong(this.instance);
				}
				return r_REventInterestsChanged;
			}
		}


        public RIWindowBackend() : base("UnityEditor.IWindowBackend")
        {
        }

        public RIWindowBackend(System.Object instance) : base("UnityEditor.IWindowBackend")
		{
            SetInstance(instance);
		}

        public RIWindowBackend(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIWindowBackend(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }



        public virtual System.Boolean GetTooltip(UnityEngine.Vector2  @windowMouseCoordinates, out System.String  @tooltip, out UnityEngine.Rect  @screenRectPosition)
        {
			tooltip = default;
			screenRectPosition = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowMouseCoordinates, @tooltip, @screenRectPosition};
            var ___result = RGetTooltip_Vector2_Out_String_Out_Rect.Invoke(___genericsType, ___parameters);
			tooltip = (System.String)___parameters[1];
			screenRectPosition = (UnityEngine.Rect)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void SizeChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSizeChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EventInterestsChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REventInterestsChanged.Invoke(___genericsType, ___parameters);

            
        }


    }
}
