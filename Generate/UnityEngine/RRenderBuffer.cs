using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.RenderBuffer
	/// </summary>
    public partial class RRenderBuffer : RMember //
    {

		/// <summary>
		/// System.Int32 m_RenderTextureInstanceID
		/// </summary>
		protected RSystem.RInt32 r_m_RenderTextureInstanceID;
		public virtual RSystem.RInt32 Rm_RenderTextureInstanceID
		{
			get
			{
				if(r_m_RenderTextureInstanceID == null)
				{
					r_m_RenderTextureInstanceID = new(this, "m_RenderTextureInstanceID");
					r_m_RenderTextureInstanceID.SetBelong(this.instance);
				}
				return r_m_RenderTextureInstanceID;
			}
		}

		/// <summary>
		/// System.IntPtr m_BufferPtr
		/// </summary>
		protected RSystem.RIntPtr r_m_BufferPtr;
		public virtual RSystem.RIntPtr Rm_BufferPtr
		{
			get
			{
				if(r_m_BufferPtr == null)
				{
					r_m_BufferPtr = new(this, "m_BufferPtr");
					r_m_BufferPtr.SetBelong(this.instance);
				}
				return r_m_BufferPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction loadAction
		/// </summary>
		protected RProperty r_loadAction;
		public virtual RProperty RloadAction
		{
			get
			{
				if(r_loadAction == null)
				{
					r_loadAction = new(this, "loadAction", -1);
					r_loadAction.SetBelong(this.instance);
				}
				return r_loadAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction storeAction
		/// </summary>
		protected RProperty r_storeAction;
		public virtual RProperty RstoreAction
		{
			get
			{
				if(r_storeAction == null)
				{
					r_storeAction = new(this, "storeAction", -1);
					r_storeAction.SetBelong(this.instance);
				}
				return r_storeAction;
			}
		}

		/// <summary>
		/// Void SetLoadAction(UnityEngine.Rendering.RenderBufferLoadAction)
		/// </summary>
		protected RMethod r_SetLoadAction_RenderBufferLoadAction;
		public virtual RMethod RSetLoadAction_RenderBufferLoadAction
		{
			get
			{
				if(r_SetLoadAction_RenderBufferLoadAction == null)
				{
					r_SetLoadAction_RenderBufferLoadAction = new(this, "SetLoadAction", 0, typeof(UnityEngine.Rendering.RenderBufferLoadAction));
					r_SetLoadAction_RenderBufferLoadAction.SetBelong(this.instance);
				}
				return r_SetLoadAction_RenderBufferLoadAction;
			}
		}

		/// <summary>
		/// Void SetStoreAction(UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected RMethod r_SetStoreAction_RenderBufferStoreAction;
		public virtual RMethod RSetStoreAction_RenderBufferStoreAction
		{
			get
			{
				if(r_SetStoreAction_RenderBufferStoreAction == null)
				{
					r_SetStoreAction_RenderBufferStoreAction = new(this, "SetStoreAction", 0, typeof(UnityEngine.Rendering.RenderBufferStoreAction));
					r_SetStoreAction_RenderBufferStoreAction.SetBelong(this.instance);
				}
				return r_SetStoreAction_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction()
		/// </summary>
		protected RMethod r_GetLoadAction;
		public virtual RMethod RGetLoadAction
		{
			get
			{
				if(r_GetLoadAction == null)
				{
					r_GetLoadAction = new(this, "GetLoadAction", 0);
					r_GetLoadAction.SetBelong(this.instance);
				}
				return r_GetLoadAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction()
		/// </summary>
		protected RMethod r_GetStoreAction;
		public virtual RMethod RGetStoreAction
		{
			get
			{
				if(r_GetStoreAction == null)
				{
					r_GetStoreAction = new(this, "GetStoreAction", 0);
					r_GetStoreAction.SetBelong(this.instance);
				}
				return r_GetStoreAction;
			}
		}

		/// <summary>
		/// IntPtr GetNativeRenderBufferPtr()
		/// </summary>
		protected RMethod r_GetNativeRenderBufferPtr;
		public virtual RMethod RGetNativeRenderBufferPtr
		{
			get
			{
				if(r_GetNativeRenderBufferPtr == null)
				{
					r_GetNativeRenderBufferPtr = new(this, "GetNativeRenderBufferPtr", 0);
					r_GetNativeRenderBufferPtr.SetBelong(this.instance);
				}
				return r_GetNativeRenderBufferPtr;
			}
		}

		/// <summary>
		/// Void SetLoadAction_Injected(UnityEngine.RenderBuffer ByRef, UnityEngine.Rendering.RenderBufferLoadAction)
		/// </summary>
		protected static RMethod r_SetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction;
		public static RMethod RSetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction
		{
			get
			{
				if(r_SetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction == null)
				{
					r_SetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction = new(typeof(UnityEngine.RenderBuffer), "SetLoadAction_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferLoadAction));
					r_SetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction.SetBelong(null);
				}
				return r_SetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction;
			}
		}

		/// <summary>
		/// Void SetStoreAction_Injected(UnityEngine.RenderBuffer ByRef, UnityEngine.Rendering.RenderBufferStoreAction)
		/// </summary>
		protected static RMethod r_SetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction;
		public static RMethod RSetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction
		{
			get
			{
				if(r_SetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction == null)
				{
					r_SetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction = new(typeof(UnityEngine.RenderBuffer), "SetStoreAction_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType(), typeof(UnityEngine.Rendering.RenderBufferStoreAction));
					r_SetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction.SetBelong(null);
				}
				return r_SetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction_Injected(UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected static RMethod r_GetLoadAction_Injected_Ref_RenderBuffer;
		public static RMethod RGetLoadAction_Injected_Ref_RenderBuffer
		{
			get
			{
				if(r_GetLoadAction_Injected_Ref_RenderBuffer == null)
				{
					r_GetLoadAction_Injected_Ref_RenderBuffer = new(typeof(UnityEngine.RenderBuffer), "GetLoadAction_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType());
					r_GetLoadAction_Injected_Ref_RenderBuffer.SetBelong(null);
				}
				return r_GetLoadAction_Injected_Ref_RenderBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction_Injected(UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected static RMethod r_GetStoreAction_Injected_Ref_RenderBuffer;
		public static RMethod RGetStoreAction_Injected_Ref_RenderBuffer
		{
			get
			{
				if(r_GetStoreAction_Injected_Ref_RenderBuffer == null)
				{
					r_GetStoreAction_Injected_Ref_RenderBuffer = new(typeof(UnityEngine.RenderBuffer), "GetStoreAction_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType());
					r_GetStoreAction_Injected_Ref_RenderBuffer.SetBelong(null);
				}
				return r_GetStoreAction_Injected_Ref_RenderBuffer;
			}
		}

		/// <summary>
		/// IntPtr GetNativeRenderBufferPtr_Injected(UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected static RMethod r_GetNativeRenderBufferPtr_Injected_Ref_RenderBuffer;
		public static RMethod RGetNativeRenderBufferPtr_Injected_Ref_RenderBuffer
		{
			get
			{
				if(r_GetNativeRenderBufferPtr_Injected_Ref_RenderBuffer == null)
				{
					r_GetNativeRenderBufferPtr_Injected_Ref_RenderBuffer = new(typeof(UnityEngine.RenderBuffer), "GetNativeRenderBufferPtr_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType());
					r_GetNativeRenderBufferPtr_Injected_Ref_RenderBuffer.SetBelong(null);
				}
				return r_GetNativeRenderBufferPtr_Injected_Ref_RenderBuffer;
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

        public virtual void SetLoadAction(UnityEngine.Rendering.RenderBufferLoadAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RSetLoadAction_RenderBufferLoadAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStoreAction(UnityEngine.Rendering.RenderBufferStoreAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RSetStoreAction_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLoadAction.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderBufferLoadAction)___result;
        }


        public virtual UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetStoreAction.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.RenderBufferStoreAction)___result;
        }


        public virtual System.IntPtr GetNativeRenderBufferPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeRenderBufferPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void SetLoadAction_Injected(ref UnityEngine.RenderBuffer @_unity_self, UnityEngine.Rendering.RenderBufferLoadAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @action};
            var ___result = RSetLoadAction_Injected_Ref_RenderBuffer_RenderBufferLoadAction.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.RenderBuffer)___parameters[0];

            
        }


        public static void SetStoreAction_Injected(ref UnityEngine.RenderBuffer @_unity_self, UnityEngine.Rendering.RenderBufferStoreAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @action};
            var ___result = RSetStoreAction_Injected_Ref_RenderBuffer_RenderBufferStoreAction.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.RenderBuffer)___parameters[0];

            
        }


        public static UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction_Injected(ref UnityEngine.RenderBuffer @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetLoadAction_Injected_Ref_RenderBuffer.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.RenderBuffer)___parameters[0];

            return (UnityEngine.Rendering.RenderBufferLoadAction)___result;
        }


        public static UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction_Injected(ref UnityEngine.RenderBuffer @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetStoreAction_Injected_Ref_RenderBuffer.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.RenderBuffer)___parameters[0];

            return (UnityEngine.Rendering.RenderBufferStoreAction)___result;
        }


        public static System.IntPtr GetNativeRenderBufferPtr_Injected(ref UnityEngine.RenderBuffer @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RGetNativeRenderBufferPtr_Injected_Ref_RenderBuffer.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.RenderBuffer)___parameters[0];

            return (System.IntPtr)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
