using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ICursorManager
	/// </summary>
    public partial class RICursorManager : RMember //
    {

		/// <summary>
		/// Void SetCursor(UnityEngine.UIElements.Cursor)
		/// </summary>
		protected RMethod r_RSetCursor_Cursor;
		public virtual RMethod RSetCursor_Cursor
		{
			get
			{
				if(r_RSetCursor_Cursor == null)
				{
					r_RSetCursor_Cursor = new(this, "SetCursor", 0, typeof(UnityEngine.UIElements.Cursor));
					r_RSetCursor_Cursor.SetBelong(this.instance);
				}
				return r_RSetCursor_Cursor;
			}
		}

		/// <summary>
		/// Void ResetCursor()
		/// </summary>
		protected RMethod r_RResetCursor;
		public virtual RMethod RResetCursor
		{
			get
			{
				if(r_RResetCursor == null)
				{
					r_RResetCursor = new(this, "ResetCursor", 0);
					r_RResetCursor.SetBelong(this.instance);
				}
				return r_RResetCursor;
			}
		}


        public RICursorManager() : base("UnityEngine.UIElements.ICursorManager")
        {
        }

        public RICursorManager(System.Object instance) : base("UnityEngine.UIElements.ICursorManager")
		{
            SetInstance(instance);
		}

        public RICursorManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RICursorManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetCursor(UnityEngine.UIElements.Cursor  @cursor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursor};
            var ___result = RSetCursor_Cursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetCursor.Invoke(___genericsType, ___parameters);

            
        }


    }
}
