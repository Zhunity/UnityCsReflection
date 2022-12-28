using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.WindowAction
	/// </summary>
    public partial class RWindowAction : RMember //
    {

		/// <summary>
		/// System.String id
		/// </summary>
		protected RField r_id;
		public virtual RField Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id");
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction+ExecuteHandler executeHandler
		/// </summary>
		protected RUnityEditor.RWindowAction.RExecuteHandler r_executeHandler;
		public virtual RUnityEditor.RWindowAction.RExecuteHandler RexecuteHandler
		{
			get
			{
				if(r_executeHandler == null)
				{
					r_executeHandler = new(this, "executeHandler");
					r_executeHandler.SetBelong(this.instance);
				}
				return r_executeHandler;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected RSystem.RObject r_userData;
		public virtual RSystem.RObject RuserData
		{
			get
			{
				if(r_userData == null)
				{
					r_userData = new(this, "userData");
					r_userData.SetBelong(this.instance);
				}
				return r_userData;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction+ValidateHandler validateHandler
		/// </summary>
		protected RUnityEditor.RWindowAction.RValidateHandler r_validateHandler;
		public virtual RUnityEditor.RWindowAction.RValidateHandler RvalidateHandler
		{
			get
			{
				if(r_validateHandler == null)
				{
					r_validateHandler = new(this, "validateHandler");
					r_validateHandler.SetBelong(this.instance);
				}
				return r_validateHandler;
			}
		}

		/// <summary>
		/// System.String menuPath
		/// </summary>
		protected RField r_menuPath;
		public virtual RField RmenuPath
		{
			get
			{
				if(r_menuPath == null)
				{
					r_menuPath = new(this, "menuPath");
					r_menuPath.SetBelong(this.instance);
				}
				return r_menuPath;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Single] width
		/// </summary>
		protected RField r_width;
		public virtual RField Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width");
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D icon
		/// </summary>
		protected RUnityEngine.RTexture2D r_icon;
		public virtual RUnityEngine.RTexture2D Ricon
		{
			get
			{
				if(r_icon == null)
				{
					r_icon = new(this, "icon");
					r_icon.SetBelong(this.instance);
				}
				return r_icon;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction+DrawHandler drawHandler
		/// </summary>
		protected RUnityEditor.RWindowAction.RDrawHandler r_drawHandler;
		public virtual RUnityEditor.RWindowAction.RDrawHandler RdrawHandler
		{
			get
			{
				if(r_drawHandler == null)
				{
					r_drawHandler = new(this, "drawHandler");
					r_drawHandler.SetBelong(this.instance);
				}
				return r_drawHandler;
			}
		}

		/// <summary>
		/// System.Int32 priority
		/// </summary>
		protected RField r_priority;
		public virtual RField Rpriority
		{
			get
			{
				if(r_priority == null)
				{
					r_priority = new(this, "priority");
					r_priority.SetBelong(this.instance);
				}
				return r_priority;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction CreateWindowMenuItem(System.String, ExecuteHandler, System.String)
		/// </summary>
		protected static RMethod r_RCreateWindowMenuItem_String_ExecuteHandler_String;
		public static RMethod RCreateWindowMenuItem_String_ExecuteHandler_String
		{
			get
			{
				if(r_RCreateWindowMenuItem_String_ExecuteHandler_String == null)
				{
					r_RCreateWindowMenuItem_String_ExecuteHandler_String = new( ReleactionUtils.GetType("UnityEditor.WindowAction"), "CreateWindowMenuItem", 0, typeof(System.String),  ReleactionUtils.GetType("UnityEditor.WindowAction+ExecuteHandler"), typeof(System.String));
					r_RCreateWindowMenuItem_String_ExecuteHandler_String.SetBelong(null);
				}
				return r_RCreateWindowMenuItem_String_ExecuteHandler_String;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction CreateWindowActionButton(System.String, ExecuteHandler, System.String, Single, UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_RCreateWindowActionButton_String_ExecuteHandler_String_Single_Texture2D;
		public static RMethod RCreateWindowActionButton_String_ExecuteHandler_String_Single_Texture2D
		{
			get
			{
				if(r_RCreateWindowActionButton_String_ExecuteHandler_String_Single_Texture2D == null)
				{
					r_RCreateWindowActionButton_String_ExecuteHandler_String_Single_Texture2D = new( ReleactionUtils.GetType("UnityEditor.WindowAction"), "CreateWindowActionButton", 0, typeof(System.String),  ReleactionUtils.GetType("UnityEditor.WindowAction+ExecuteHandler"), typeof(System.String), typeof(System.Single), typeof(UnityEngine.Texture2D));
					r_RCreateWindowActionButton_String_ExecuteHandler_String_Single_Texture2D.SetBelong(null);
				}
				return r_RCreateWindowActionButton_String_ExecuteHandler_String_Single_Texture2D;
			}
		}

		/// <summary>
		/// UnityEditor.WindowAction CreateWindowActionButton(System.String, ExecuteHandler, System.String, Single, DrawHandler)
		/// </summary>
		protected static RMethod r_RCreateWindowActionButton_String_ExecuteHandler_String_Single_DrawHandler;
		public static RMethod RCreateWindowActionButton_String_ExecuteHandler_String_Single_DrawHandler
		{
			get
			{
				if(r_RCreateWindowActionButton_String_ExecuteHandler_String_Single_DrawHandler == null)
				{
					r_RCreateWindowActionButton_String_ExecuteHandler_String_Single_DrawHandler = new( ReleactionUtils.GetType("UnityEditor.WindowAction"), "CreateWindowActionButton", 0, typeof(System.String),  ReleactionUtils.GetType("UnityEditor.WindowAction+ExecuteHandler"), typeof(System.String), typeof(System.Single),  ReleactionUtils.GetType("UnityEditor.WindowAction+DrawHandler"));
					r_RCreateWindowActionButton_String_ExecuteHandler_String_Single_DrawHandler.SetBelong(null);
				}
				return r_RCreateWindowActionButton_String_ExecuteHandler_String_Single_DrawHandler;
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