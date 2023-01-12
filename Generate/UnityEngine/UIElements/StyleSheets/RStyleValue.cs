using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.StyleValue
	/// </summary>
    public partial class RStyleValue : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId id
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_Fid;
		public virtual RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFid
		{
			get
			{
				if(r_Fid == null)
				{
					r_Fid = new(this, "id");
					r_Fid.SetBelong(this.instance);
				}
				return r_Fid;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleKeyword keyword
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleKeyword r_Fkeyword;
		public virtual RUnityEngine.RUIElements.RStyleKeyword RFkeyword
		{
			get
			{
				if(r_Fkeyword == null)
				{
					r_Fkeyword = new(this, "keyword");
					r_Fkeyword.SetBelong(this.instance);
				}
				return r_Fkeyword;
			}
		}

		/// <summary>
		/// System.Single number
		/// </summary>
		protected RSystem.RSingle r_Fnumber;
		public virtual RSystem.RSingle RFnumber
		{
			get
			{
				if(r_Fnumber == null)
				{
					r_Fnumber = new(this, "number");
					r_Fnumber.SetBelong(this.instance);
				}
				return r_Fnumber;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length length
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_Flength;
		public virtual RUnityEngine.RUIElements.RLength RFlength
		{
			get
			{
				if(r_Flength == null)
				{
					r_Flength = new(this, "length");
					r_Flength.SetBelong(this.instance);
				}
				return r_Flength;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_Fcolor;
		public virtual RUnityEngine.RColor RFcolor
		{
			get
			{
				if(r_Fcolor == null)
				{
					r_Fcolor = new(this, "color");
					r_Fcolor.SetBelong(this.instance);
				}
				return r_Fcolor;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.GCHandle resource
		/// </summary>
		protected RSystem.RRuntime.RInteropServices.RGCHandle r_Fresource;
		public virtual RSystem.RRuntime.RInteropServices.RGCHandle RFresource
		{
			get
			{
				if(r_Fresource == null)
				{
					r_Fresource = new(this, "resource");
					r_Fresource.SetBelong(this.instance);
				}
				return r_Fresource;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition position
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_Fposition;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RFposition
		{
			get
			{
				if(r_Fposition == null)
				{
					r_Fposition = new(this, "position");
					r_Fposition.SetBelong(this.instance);
				}
				return r_Fposition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat repeat
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundRepeat r_Frepeat;
		public virtual RUnityEngine.RUIElements.RBackgroundRepeat RFrepeat
		{
			get
			{
				if(r_Frepeat == null)
				{
					r_Frepeat = new(this, "repeat");
					r_Frepeat.SetBelong(this.instance);
				}
				return r_Frepeat;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}


        public RStyleValue() : base("UnityEngine.UIElements.StyleSheets.StyleValue")
        {
        }

        public RStyleValue(System.Object instance) : base("UnityEngine.UIElements.StyleSheets.StyleValue")
		{
            SetInstance(instance);
		}

        public RStyleValue(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleValue(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
