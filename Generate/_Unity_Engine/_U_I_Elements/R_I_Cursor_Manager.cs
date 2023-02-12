
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
		protected RMethod r_MSetCursor_Cursor;
		public virtual RMethod RMSetCursor_Cursor
		{
			get
			{
				if(r_MSetCursor_Cursor == null)
				{
					r_MSetCursor_Cursor = new(this, "SetCursor", 0, typeof(UnityEngine.UIElements.Cursor));
					r_MSetCursor_Cursor.SetBelong(this.instance);
				}
				return r_MSetCursor_Cursor;
			}
		}

		/// <summary>
		/// Void ResetCursor()
		/// </summary>
		protected RMethod r_MResetCursor;
		public virtual RMethod RMResetCursor
		{
			get
			{
				if(r_MResetCursor == null)
				{
					r_MResetCursor = new(this, "ResetCursor", 0);
					r_MResetCursor.SetBelong(this.instance);
				}
				return r_MResetCursor;
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

        public virtual void SetCursor(UnityEngine.UIElements.Cursor @cursor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursor};
            var ___result = RMSetCursor_Cursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetCursor.Invoke(___genericsType, ___parameters);

            
        }


    }
}