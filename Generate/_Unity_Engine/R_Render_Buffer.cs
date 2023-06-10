
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.RenderBuffer
	/// </summary>
    public partial class RRenderBuffer : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.RenderBuffer);
            }
        }

        public RRenderBuffer() : base("UnityEngine.RenderBuffer")
        {
        }

        public RRenderBuffer(System.Object instance) : base("UnityEngine.RenderBuffer")
		{
            SetInstance(instance);
		}

        public RRenderBuffer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderBuffer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 m_RenderTextureInstanceID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_RenderTextureInstanceID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_RenderTextureInstanceID
		{
			get
			{
				if(r_Fm_RenderTextureInstanceID == null)
				{
					r_Fm_RenderTextureInstanceID = new(this, "m_RenderTextureInstanceID");
				}
				return r_Fm_RenderTextureInstanceID;
			}
		}

		/// <summary>
		/// System.IntPtr m_BufferPtr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_BufferPtr;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_BufferPtr
		{
			get
			{
				if(r_Fm_BufferPtr == null)
				{
					r_Fm_BufferPtr = new(this, "m_BufferPtr");
				}
				return r_Fm_BufferPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction loadAction
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferLoadAction r_PloadAction;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferLoadAction RPloadAction
		{
			get
			{
				if(r_PloadAction == null)
				{
					r_PloadAction = new(this, "loadAction", -1);
				}
				return r_PloadAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction storeAction
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferStoreAction r_PstoreAction;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferStoreAction RPstoreAction
		{
			get
			{
				if(r_PstoreAction == null)
				{
					r_PstoreAction = new(this, "storeAction", -1);
				}
				return r_PstoreAction;
			}
		}

		/// <summary>
		/// Void SetLoadAction(UnityEngine.Rendering.RenderBufferLoadAction)
		/// </summary>
		protected RMethod r_MSetLoadAction_RenderBufferLoadAction;
		public virtual RMethod RMSetLoadAction_RenderBufferLoadAction
		{
			get
			{
				if(r_MSetLoadAction_RenderBufferLoadAction == null)
				{
					r_MSetLoadAction_RenderBufferLoadAction = new(this, "SetLoadAction", 0, typeof(UnityEngine.Rendering.RenderBufferLoadAction));
				}
				return r_MSetLoadAction_RenderBufferLoadAction;
			}
		}

		/// <summary>
		/// Void SetStoreAction(UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected RMethod r_MSetStoreAction_RenderBufferStoreAction;
		public virtual RMethod RMSetStoreAction_RenderBufferStoreAction
		{
			get
			{
				if(r_MSetStoreAction_RenderBufferStoreAction == null)
				{
					r_MSetStoreAction_RenderBufferStoreAction = new(this, "SetStoreAction", 0, typeof(UnityEngine.Rendering.RenderBufferStoreAction));
				}
				return r_MSetStoreAction_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction()
		/// </summary>
		protected RMethod r_MGetLoadAction;
		public virtual RMethod RMGetLoadAction
		{
			get
			{
				if(r_MGetLoadAction == null)
				{
					r_MGetLoadAction = new(this, "GetLoadAction", 0);
				}
				return r_MGetLoadAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction()
		/// </summary>
		protected RMethod r_MGetStoreAction;
		public virtual RMethod RMGetStoreAction
		{
			get
			{
				if(r_MGetStoreAction == null)
				{
					r_MGetStoreAction = new(this, "GetStoreAction", 0);
				}
				return r_MGetStoreAction;
			}
		}

		/// <summary>
		/// IntPtr GetNativeRenderBufferPtr()
		/// </summary>
		protected RMethod r_MGetNativeRenderBufferPtr;
		public virtual RMethod RMGetNativeRenderBufferPtr
		{
			get
			{
				if(r_MGetNativeRenderBufferPtr == null)
				{
					r_MGetNativeRenderBufferPtr = new(this, "GetNativeRenderBufferPtr", 0);
				}
				return r_MGetNativeRenderBufferPtr;
			}
		}

		/// <summary>
		/// Void SetLoadAction_Injected(UnityEngine.RenderBuffer ByRef, UnityEngine.Rendering.RenderBufferLoadAction)
		/// </summary>
		protected static RMethod r_MSetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction;
		public static RMethod RMSetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction
		{
			get
			{
				if(r_MSetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction == null)
				{
					r_MSetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction = new(typeof(UnityEngine.RenderBuffer), "SetLoadAction_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction));
				}
				return r_MSetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction;
			}
		}

		/// <summary>
		/// Void SetStoreAction_Injected(UnityEngine.RenderBuffer ByRef, UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected static RMethod r_MSetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction;
		public static RMethod RMSetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction
		{
			get
			{
				if(r_MSetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction == null)
				{
					r_MSetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction = new(typeof(UnityEngine.RenderBuffer), "SetStoreAction_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferStoreAction));
				}
				return r_MSetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction_Injected(UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected static RMethod r_MGetLoadAction_Injected_Ref_RenderBuffer;
		public static RMethod RMGetLoadAction_Injected_Ref_RenderBuffer
		{
			get
			{
				if(r_MGetLoadAction_Injected_Ref_RenderBuffer == null)
				{
					r_MGetLoadAction_Injected_Ref_RenderBuffer = new(typeof(UnityEngine.RenderBuffer), "GetLoadAction_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType());
				}
				return r_MGetLoadAction_Injected_Ref_RenderBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction_Injected(UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected static RMethod r_MGetStoreAction_Injected_Ref_RenderBuffer;
		public static RMethod RMGetStoreAction_Injected_Ref_RenderBuffer
		{
			get
			{
				if(r_MGetStoreAction_Injected_Ref_RenderBuffer == null)
				{
					r_MGetStoreAction_Injected_Ref_RenderBuffer = new(typeof(UnityEngine.RenderBuffer), "GetStoreAction_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType());
				}
				return r_MGetStoreAction_Injected_Ref_RenderBuffer;
			}
		}

		/// <summary>
		/// IntPtr GetNativeRenderBufferPtr_Injected(UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected static RMethod r_MGetNativeRenderBufferPtr_Injected_Ref_RenderBuffer;
		public static RMethod RMGetNativeRenderBufferPtr_Injected_Ref_RenderBuffer
		{
			get
			{
				if(r_MGetNativeRenderBufferPtr_Injected_Ref_RenderBuffer == null)
				{
					r_MGetNativeRenderBufferPtr_Injected_Ref_RenderBuffer = new(typeof(UnityEngine.RenderBuffer), "GetNativeRenderBufferPtr_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType());
				}
				return r_MGetNativeRenderBufferPtr_Injected_Ref_RenderBuffer;
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


        public virtual void SetLoadAction(UnityEngine.Rendering.RenderBufferLoadAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RMSetLoadAction_RenderBufferLoadAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStoreAction(UnityEngine.Rendering.RenderBufferStoreAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RMSetStoreAction_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLoadAction.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderBufferLoadAction)___result;
        }


        public virtual UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetStoreAction.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderBufferStoreAction)___result;
        }


        public virtual System.IntPtr GetNativeRenderBufferPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNativeRenderBufferPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void SetLoadAction_Injected(ref UnityEngine.RenderBuffer @_unity_self, UnityEngine.Rendering.RenderBufferLoadAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @action};
            var ___result = RMSetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.RenderBuffer)___parameters[0];

            
        }


        public static void SetStoreAction_Injected(ref UnityEngine.RenderBuffer @_unity_self, UnityEngine.Rendering.RenderBufferStoreAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @action};
            var ___result = RMSetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.RenderBuffer)___parameters[0];

            
        }


        public static UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction_Injected(ref UnityEngine.RenderBuffer @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMGetLoadAction_Injected_Ref_RenderBuffer.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.RenderBuffer)___parameters[0];

            return (UnityEngine.Rendering.RenderBufferLoadAction)___result;
        }


        public static UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction_Injected(ref UnityEngine.RenderBuffer @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMGetStoreAction_Injected_Ref_RenderBuffer.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.RenderBuffer)___parameters[0];

            return (UnityEngine.Rendering.RenderBufferStoreAction)___result;
        }


        public static System.IntPtr GetNativeRenderBufferPtr_Injected(ref UnityEngine.RenderBuffer @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMGetNativeRenderBufferPtr_Injected_Ref_RenderBuffer.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.RenderBuffer)___parameters[0];

            return (System.IntPtr)___result;
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
