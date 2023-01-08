using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RResources
{
	/// <summary>
	/// System.Resources.IResourceWriter
	/// </summary>
    public partial class RIResourceWriter : RMember //
    {

		/// <summary>
		/// Void AddResource(System.String, System.String)
		/// </summary>
		protected RMethod r_AddResource_String_String;
		public virtual RMethod RAddResource_String_String
		{
			get
			{
				if(r_AddResource_String_String == null)
				{
					r_AddResource_String_String = new(this, "AddResource", 0, typeof(System.String), typeof(System.String));
					r_AddResource_String_String.SetBelong(this.instance);
				}
				return r_AddResource_String_String;
			}
		}

		/// <summary>
		/// Void AddResource(System.String, System.Object)
		/// </summary>
		protected RMethod r_AddResource_String_Object;
		public virtual RMethod RAddResource_String_Object
		{
			get
			{
				if(r_AddResource_String_Object == null)
				{
					r_AddResource_String_Object = new(this, "AddResource", 0, typeof(System.String), typeof(System.Object));
					r_AddResource_String_Object.SetBelong(this.instance);
				}
				return r_AddResource_String_Object;
			}
		}

		/// <summary>
		/// Void AddResource(System.String, Byte[])
		/// </summary>
		protected RMethod r_AddResource_String_ByteArray;
		public virtual RMethod RAddResource_String_ByteArray
		{
			get
			{
				if(r_AddResource_String_ByteArray == null)
				{
					r_AddResource_String_ByteArray = new(this, "AddResource", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
					r_AddResource_String_ByteArray.SetBelong(this.instance);
				}
				return r_AddResource_String_ByteArray;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_Close;
		public virtual RMethod RClose
		{
			get
			{
				if(r_Close == null)
				{
					r_Close = new(this, "Close", 0);
					r_Close.SetBelong(this.instance);
				}
				return r_Close;
			}
		}

		/// <summary>
		/// Void Generate()
		/// </summary>
		protected RMethod r_Generate;
		public virtual RMethod RGenerate
		{
			get
			{
				if(r_Generate == null)
				{
					r_Generate = new(this, "Generate", 0);
					r_Generate.SetBelong(this.instance);
				}
				return r_Generate;
			}
		}


        public RIResourceWriter() : base("System.Resources.IResourceWriter")
        {
        }

        public RIResourceWriter(System.Object instance) : base("System.Resources.IResourceWriter")
		{
            SetInstance(instance);
		}

        public RIResourceWriter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIResourceWriter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddResource(System.String  @name, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddResource_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddResource(System.String  @name, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddResource_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddResource(System.String  @name, System.Byte[]  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddResource_String_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Generate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGenerate.Invoke(___genericsType, ___parameters);

            
        }


    }
}
