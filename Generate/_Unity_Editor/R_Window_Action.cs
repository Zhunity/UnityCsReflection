
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.WindowAction
	/// </summary>
    public partial class RWindowAction : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.WindowAction");
            }
        }

        public RWindowAction() : base("UnityEditor.WindowAction")
        {
        }

        public RWindowAction(System.Object instance) : base("UnityEditor.WindowAction")
		{
            SetInstance(instance);
		}

        public RWindowAction(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWindowAction(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fid;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFid
		{
			get
			{
				if(r_Fid == null)
				{
					r_Fid = new(this, "id");
				}
				return r_Fid;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction+ExecuteHandler executeHandler
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RWindowAction.RExecuteHandler r_FexecuteHandler;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RWindowAction.RExecuteHandler RFexecuteHandler
		{
			get
			{
				if(r_FexecuteHandler == null)
				{
					r_FexecuteHandler = new(this, "executeHandler");
				}
				return r_FexecuteHandler;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_FuserData;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFuserData
		{
			get
			{
				if(r_FuserData == null)
				{
					r_FuserData = new(this, "userData");
				}
				return r_FuserData;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction+ValidateHandler validateHandler
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RWindowAction.RValidateHandler r_FvalidateHandler;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RWindowAction.RValidateHandler RFvalidateHandler
		{
			get
			{
				if(r_FvalidateHandler == null)
				{
					r_FvalidateHandler = new(this, "validateHandler");
				}
				return r_FvalidateHandler;
			}
		}

		/// <summary>
		/// System.String menuPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FmenuPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFmenuPath
		{
			get
			{
				if(r_FmenuPath == null)
				{
					r_FmenuPath = new(this, "menuPath");
				}
				return r_FmenuPath;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Single] width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RSingle> r_Fwidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RSingle> RFwidth
		{
			get
			{
				if(r_Fwidth == null)
				{
					r_Fwidth = new(this, "width");
				}
				return r_Fwidth;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D icon
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Ficon;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RFicon
		{
			get
			{
				if(r_Ficon == null)
				{
					r_Ficon = new(this, "icon");
				}
				return r_Ficon;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction+DrawHandler drawHandler
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RWindowAction.RDrawHandler r_FdrawHandler;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RWindowAction.RDrawHandler RFdrawHandler
		{
			get
			{
				if(r_FdrawHandler == null)
				{
					r_FdrawHandler = new(this, "drawHandler");
				}
				return r_FdrawHandler;
			}
		}

		/// <summary>
		/// System.Int32 priority
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fpriority;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpriority
		{
			get
			{
				if(r_Fpriority == null)
				{
					r_Fpriority = new(this, "priority");
				}
				return r_Fpriority;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction CreateWindowMenuItem(System.String, ExecuteHandler, System.String)
		/// </summary>
		protected static RMethod r_MCreateWindowMenuItem_String_ExecuteHandler_String;
		public static RMethod RMCreateWindowMenuItem_String_ExecuteHandler_String
		{
			get
			{
				if(r_MCreateWindowMenuItem_String_ExecuteHandler_String == null)
				{
					r_MCreateWindowMenuItem_String_ExecuteHandler_String = new(Type, "CreateWindowMenuItem", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEditor.WindowAction+ExecuteHandler"), typeof(System.String));
				}
				return r_MCreateWindowMenuItem_String_ExecuteHandler_String;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction CreateWindowActionButton(System.String, ExecuteHandler, System.String, Single, UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_MCreateWindowActionButton_String_ExecuteHandler_String_Single_Texture2D;
		public static RMethod RMCreateWindowActionButton_String_ExecuteHandler_String_Single_Texture2D
		{
			get
			{
				if(r_MCreateWindowActionButton_String_ExecuteHandler_String_Single_Texture2D == null)
				{
					r_MCreateWindowActionButton_String_ExecuteHandler_String_Single_Texture2D = new(Type, "CreateWindowActionButton", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEditor.WindowAction+ExecuteHandler"), typeof(System.String), typeof(System.Single), typeof(UnityEngine.Texture2D));
				}
				return r_MCreateWindowActionButton_String_ExecuteHandler_String_Single_Texture2D;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction CreateWindowActionButton(System.String, ExecuteHandler, System.String, Single, DrawHandler)
		/// </summary>
		protected static RMethod r_MCreateWindowActionButton_String_ExecuteHandler_String_Single_DrawHandler;
		public static RMethod RMCreateWindowActionButton_String_ExecuteHandler_String_Single_DrawHandler
		{
			get
			{
				if(r_MCreateWindowActionButton_String_ExecuteHandler_String_Single_DrawHandler == null)
				{
					r_MCreateWindowActionButton_String_ExecuteHandler_String_Single_DrawHandler = new(Type, "CreateWindowActionButton", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEditor.WindowAction+ExecuteHandler"), typeof(System.String), typeof(System.Single),  ReflectionUtils.GetType("UnityEditor.WindowAction+DrawHandler"));
				}
				return r_MCreateWindowActionButton_String_ExecuteHandler_String_Single_DrawHandler;
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


        public static Hvak.Editor.Refleaction.RUnityEditor.RWindowAction CreateWindowMenuItem(System.String @id, Hvak.Editor.Refleaction.RUnityEditor.RWindowAction.RExecuteHandler @executeHandler, System.String @menuPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @executeHandler.Value, @menuPath};
            var ___result = RMCreateWindowMenuItem_String_ExecuteHandler_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RWindowAction>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEditor.RWindowAction CreateWindowActionButton(System.String @id, Hvak.Editor.Refleaction.RUnityEditor.RWindowAction.RExecuteHandler @executeHandler, System.String @menuPath, System.Single @width, UnityEngine.Texture2D @icon)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @executeHandler.Value, @menuPath, @width, @icon};
            var ___result = RMCreateWindowActionButton_String_ExecuteHandler_String_Single_Texture2D.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RWindowAction>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEditor.RWindowAction CreateWindowActionButton(System.String @id, Hvak.Editor.Refleaction.RUnityEditor.RWindowAction.RExecuteHandler @executeHandler, System.String @menuPath, System.Single @width, Hvak.Editor.Refleaction.RUnityEditor.RWindowAction.RDrawHandler @drawHandler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @executeHandler.Value, @menuPath, @width, @drawHandler.Value};
            var ___result = RMCreateWindowActionButton_String_ExecuteHandler_String_Single_DrawHandler.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RWindowAction>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
