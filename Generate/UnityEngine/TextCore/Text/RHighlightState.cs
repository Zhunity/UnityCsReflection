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
		protected static RMethod r_op_Equality_HighlightState_HighlightState;
		public static RMethod Rop_Equality_HighlightState_HighlightState
		{
			get
			{
				if(r_op_Equality_HighlightState_HighlightState == null)
				{
					r_op_Equality_HighlightState_HighlightState = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"),  ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"));
					r_op_Equality_HighlightState_HighlightState.SetBelong(null);
				}
				return r_op_Equality_HighlightState_HighlightState;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.Text.HighlightState, UnityEngine.TextCore.Text.HighlightState)
		/// </summary>
		protected static RMethod r_op_Inequality_HighlightState_HighlightState;
		public static RMethod Rop_Inequality_HighlightState_HighlightState
		{
			get
			{
				if(r_op_Inequality_HighlightState_HighlightState == null)
				{
					r_op_Inequality_HighlightState_HighlightState = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"),  ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"));
					r_op_Inequality_HighlightState_HighlightState.SetBelong(null);
				}
				return r_op_Inequality_HighlightState_HighlightState;
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
		/// Boolean Equals(UnityEngine.TextCore.Text.HighlightState)
		/// </summary>
		protected RMethod r_Equals_HighlightState;
		public virtual RMethod REquals_HighlightState
		{
			get
			{
				if(r_Equals_HighlightState == null)
				{
					r_Equals_HighlightState = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.HighlightState"));
					r_Equals_HighlightState.SetBelong(this.instance);
				}
				return r_Equals_HighlightState;
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
