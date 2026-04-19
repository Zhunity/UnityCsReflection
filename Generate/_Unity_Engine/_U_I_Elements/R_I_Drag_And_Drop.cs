
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.IDragAndDrop
	/// </summary>
    public partial class RIDragAndDrop : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.IDragAndDrop");
            }
        }

        public RIDragAndDrop() : base("UnityEngine.UIElements.IDragAndDrop")
        {
        }

        public RIDragAndDrop(System.Object instance) : base("UnityEngine.UIElements.IDragAndDrop")
		{
            SetInstance(instance);
		}

        public RIDragAndDrop(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDragAndDrop(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.DragAndDropData data
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropData r_Pdata;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropData RPdata
		{
			get
			{
				if(r_Pdata == null)
				{
					r_Pdata = new(this, "data", -1);
				}
				return r_Pdata;
			}
		}

		/// <summary>
		/// Void StartDrag(UnityEngine.UIElements.StartDragArgs, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MStartDrag_StartDragArgs_Vector3;
		public virtual RMethod RMStartDrag_StartDragArgs_Vector3
		{
			get
			{
				if(r_MStartDrag_StartDragArgs_Vector3 == null)
				{
					r_MStartDrag_StartDragArgs_Vector3 = new(this, "StartDrag", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StartDragArgs"), typeof(UnityEngine.Vector3));
				}
				return r_MStartDrag_StartDragArgs_Vector3;
			}
		}

		/// <summary>
		/// Void UpdateDrag(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MUpdateDrag_Vector3;
		public virtual RMethod RMUpdateDrag_Vector3
		{
			get
			{
				if(r_MUpdateDrag_Vector3 == null)
				{
					r_MUpdateDrag_Vector3 = new(this, "UpdateDrag", 0, typeof(UnityEngine.Vector3));
				}
				return r_MUpdateDrag_Vector3;
			}
		}

		/// <summary>
		/// Void AcceptDrag()
		/// </summary>
		protected RMethod r_MAcceptDrag;
		public virtual RMethod RMAcceptDrag
		{
			get
			{
				if(r_MAcceptDrag == null)
				{
					r_MAcceptDrag = new(this, "AcceptDrag", 0);
				}
				return r_MAcceptDrag;
			}
		}

		/// <summary>
		/// Void DragCleanup()
		/// </summary>
		protected RMethod r_MDragCleanup;
		public virtual RMethod RMDragCleanup
		{
			get
			{
				if(r_MDragCleanup == null)
				{
					r_MDragCleanup = new(this, "DragCleanup", 0);
				}
				return r_MDragCleanup;
			}
		}

		/// <summary>
		/// Void SetVisualMode(UnityEngine.UIElements.DragVisualMode)
		/// </summary>
		protected RMethod r_MSetVisualMode_DragVisualMode;
		public virtual RMethod RMSetVisualMode_DragVisualMode
		{
			get
			{
				if(r_MSetVisualMode_DragVisualMode == null)
				{
					r_MSetVisualMode_DragVisualMode = new(this, "SetVisualMode", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.DragVisualMode"));
				}
				return r_MSetVisualMode_DragVisualMode;
			}
		}


        public virtual void StartDrag(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStartDragArgs @args, UnityEngine.Vector3 @pointerPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value, @pointerPosition};
            var ___result = RMStartDrag_StartDragArgs_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateDrag(UnityEngine.Vector3 @pointerPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerPosition};
            var ___result = RMUpdateDrag_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AcceptDrag()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAcceptDrag.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DragCleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDragCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVisualMode(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragVisualMode @visualMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visualMode.Value};
            var ___result = RMSetVisualMode_DragVisualMode.Invoke(___genericsType, ___parameters);

            
        }


    }
}
