using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.HighlightState
	/// </summary>
    public partial class RHighlightState : RMember //
    {

		/// <summary>
		/// UnityEngine.Color32 color
		/// </summary>
		protected RUnityEngine.RColor32 r_color;
		public virtual RUnityEngine.RColor32 Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color");
					r_color.SetBelong(this.instance);
				}
				return r_color;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.Offset padding
		/// </summary>
		protected RUnityEngine.RTextCore.RText.ROffset r_padding;
		public virtual RUnityEngine.RTextCore.RText.ROffset Rpadding
		{
			get
			{
				if(r_padding == null)
				{
					r_padding = new(this, "padding");
					r_padding.SetBelong(this.instance);
				}
				return r_padding;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.Text.HighlightState, UnityEngine.TextCore.Text.HighlightState)
		/// </summary>
		protected static RMethod r_Rop_Equality_HighlightState_HighlightState;
		public static RMethod Rop_Equality_HighlightState_HighlightState
		{
			get
			{
				if(r_Rop_Equality_HighlightState_HighlightState == null)
				{
					r_Rop_Equality_HighlightState_HighlightState = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"),  ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"));
					r_Rop_Equality_HighlightState_HighlightState.SetBelong(null);
				}
				return r_Rop_Equality_HighlightState_HighlightState;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.Text.HighlightState, UnityEngine.TextCore.Text.HighlightState)
		/// </summary>
		protected static RMethod r_Rop_Inequality_HighlightState_HighlightState;
		public static RMethod Rop_Inequality_HighlightState_HighlightState
		{
			get
			{
				if(r_Rop_Inequality_HighlightState_HighlightState == null)
				{
					r_Rop_Inequality_HighlightState_HighlightState = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"),  ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"));
					r_Rop_Inequality_HighlightState_HighlightState.SetBelong(null);
				}
				return r_Rop_Inequality_HighlightState_HighlightState;
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
		/// Boolean Equals(UnityEngine.TextCore.Text.HighlightState)
		/// </summary>
		protected RMethod r_REquals_HighlightState;
		public virtual RMethod REquals_HighlightState
		{
			get
			{
				if(r_REquals_HighlightState == null)
				{
					r_REquals_HighlightState = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"));
					r_REquals_HighlightState.SetBelong(this.instance);
				}
				return r_REquals_HighlightState;
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


        public RHighlightState() : base("UnityEngine.TextCore.Text.HighlightState")
        {
        }

        public RHighlightState(System.Object instance) : base("UnityEngine.TextCore.Text.HighlightState")
		{
            SetInstance(instance);
		}

        public RHighlightState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHighlightState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }



        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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