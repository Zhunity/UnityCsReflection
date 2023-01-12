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
		protected RSystem.RObject r_PvisualTree;
		public virtual RSystem.RObject RPvisualTree
		{
			get
			{
				if(r_PvisualTree == null)
				{
					r_PvisualTree = new(this, "visualTree", -1);
					r_PvisualTree.SetBelong(this.instance);
				}
				return r_PvisualTree;
			}
		}

		/// <summary>
		/// Void OnCreate(UnityEditor.IWindowModel)
		/// </summary>
		protected RMethod r_MOnCreate_IWindowModel;
		public virtual RMethod RMOnCreate_IWindowModel
		{
			get
			{
				if(r_MOnCreate_IWindowModel == null)
				{
					r_MOnCreate_IWindowModel = new(this, "OnCreate", 0,  ReflectionUtils.GetType("UnityEditor.IWindowModel"));
					r_MOnCreate_IWindowModel.SetBelong(this.instance);
				}
				return r_MOnCreate_IWindowModel;
			}
		}

		/// <summary>
		/// Void OnDestroy(UnityEditor.IWindowModel)
		/// </summary>
		protected RMethod r_MOnDestroy_IWindowModel;
		public virtual RMethod RMOnDestroy_IWindowModel
		{
			get
			{
				if(r_MOnDestroy_IWindowModel == null)
				{
					r_MOnDestroy_IWindowModel = new(this, "OnDestroy", 0,  ReflectionUtils.GetType("UnityEditor.IWindowModel"));
					r_MOnDestroy_IWindowModel.SetBelong(this.instance);
				}
				return r_MOnDestroy_IWindowModel;
			}
		}

		/// <summary>
		/// Boolean GetTooltip(UnityEngine.Vector2, System.String ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MGetTooltip_Vector2_Out_String_Out_Rect;
		public virtual RMethod RMGetTooltip_Vector2_Out_String_Out_Rect
		{
			get
			{
				if(r_MGetTooltip_Vector2_Out_String_Out_Rect == null)
				{
					r_MGetTooltip_Vector2_Out_String_Out_Rect = new(this, "GetTooltip", 0, typeof(UnityEngine.Vector2), typeof(System.String).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
					r_MGetTooltip_Vector2_Out_String_Out_Rect.SetBelong(this.instance);
				}
				return r_MGetTooltip_Vector2_Out_String_Out_Rect;
			}
		}

		/// <summary>
		/// Void SizeChanged()
		/// </summary>
		protected RMethod r_MSizeChanged;
		public virtual RMethod RMSizeChanged
		{
			get
			{
				if(r_MSizeChanged == null)
				{
					r_MSizeChanged = new(this, "SizeChanged", 0);
					r_MSizeChanged.SetBelong(this.instance);
				}
				return r_MSizeChanged;
			}
		}

		/// <summary>
		/// Void EventInterestsChanged()
		/// </summary>
		protected RMethod r_MEventInterestsChanged;
		public virtual RMethod RMEventInterestsChanged
		{
			get
			{
				if(r_MEventInterestsChanged == null)
				{
					r_MEventInterestsChanged = new(this, "EventInterestsChanged", 0);
					r_MEventInterestsChanged.SetBelong(this.instance);
				}
				return r_MEventInterestsChanged;
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

        public virtual void OnCreate(RUnityEditor.RIWindowModel @model)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@model.Value};
            var ___result = RMOnCreate_IWindowModel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy(RUnityEditor.RIWindowModel @model)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@model.Value};
            var ___result = RMOnDestroy_IWindowModel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetTooltip(UnityEngine.Vector2 @windowMouseCoordinates, out System.String @tooltip, out UnityEngine.Rect @screenRectPosition)
        {
			@tooltip = default;
			@screenRectPosition = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowMouseCoordinates, @tooltip, @screenRectPosition};
            var ___result = RMGetTooltip_Vector2_Out_String_Out_Rect.Invoke(___genericsType, ___parameters);
			@tooltip = (System.String)___parameters[1];
			@screenRectPosition = (UnityEngine.Rect)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void SizeChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSizeChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EventInterestsChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEventInterestsChanged.Invoke(___genericsType, ___parameters);

            
        }


    }
}
