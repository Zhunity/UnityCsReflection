
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.DefaultDragAndDropClient
	/// </summary>
    public partial class RDefaultDragAndDropClient : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.DefaultDragAndDropClient");
            }
        }

        public RDefaultDragAndDropClient() : base("UnityEngine.UIElements.DefaultDragAndDropClient")
        {
        }

        public RDefaultDragAndDropClient(System.Object instance) : base("UnityEngine.UIElements.DefaultDragAndDropClient")
		{
            SetInstance(instance);
		}

        public RDefaultDragAndDropClient(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDefaultDragAndDropClient(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.StartDragArgs m_StartDragArgs
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStartDragArgs r_Fm_StartDragArgs;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStartDragArgs RFm_StartDragArgs
		{
			get
			{
				if(r_Fm_StartDragArgs == null)
				{
					r_Fm_StartDragArgs = new(this, "m_StartDragArgs");
				}
				return r_Fm_StartDragArgs;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PuserData;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPuserData
		{
			get
			{
				if(r_PuserData == null)
				{
					r_PuserData = new(this, "userData", -1);
				}
				return r_PuserData;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.Object] unityObjectReferences
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RObject> r_PunityObjectReferences;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RObject> RPunityObjectReferences
		{
			get
			{
				if(r_PunityObjectReferences == null)
				{
					r_PunityObjectReferences = new(this, "unityObjectReferences", -1);
				}
				return r_PunityObjectReferences;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IDragAndDropData data
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIDragAndDropData r_Pdata;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIDragAndDropData RPdata
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
		/// Void StartDrag(UnityEngine.UIElements.StartDragArgs)
		/// </summary>
		protected RMethod r_MStartDrag_StartDragArgs;
		public virtual RMethod RMStartDrag_StartDragArgs
		{
			get
			{
				if(r_MStartDrag_StartDragArgs == null)
				{
					r_MStartDrag_StartDragArgs = new(this, "StartDrag", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StartDragArgs"));
				}
				return r_MStartDrag_StartDragArgs;
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

		/// <summary>
		/// System.Object GetGenericData(System.String)
		/// </summary>
		protected RMethod r_MGetGenericData_String;
		public virtual RMethod RMGetGenericData_String
		{
			get
			{
				if(r_MGetGenericData_String == null)
				{
					r_MGetGenericData_String = new(this, "GetGenericData", 0, typeof(System.String));
				}
				return r_MGetGenericData_String;
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


        public virtual void StartDrag(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStartDragArgs @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args.Value};
            var ___result = RMStartDrag_StartDragArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AcceptDrag()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAcceptDrag.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVisualMode(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragVisualMode @visualMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visualMode.Value};
            var ___result = RMSetVisualMode_DragVisualMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetGenericData(System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetGenericData_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
