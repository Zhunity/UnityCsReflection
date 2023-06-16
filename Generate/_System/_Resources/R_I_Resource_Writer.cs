
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RResources
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Resources.IResourceWriter
	/// </summary>
    public partial class RIResourceWriter : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Resources.IResourceWriter);
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


		/// <summary>
		/// Void AddResource(System.String, System.String)
		/// </summary>
		protected RMethod r_MAddResource_String_String;
		public virtual RMethod RMAddResource_String_String
		{
			get
			{
				if(r_MAddResource_String_String == null)
				{
					r_MAddResource_String_String = new(this, "AddResource", 0, typeof(System.String), typeof(System.String));
				}
				return r_MAddResource_String_String;
			}
		}

		/// <summary>
		/// Void AddResource(System.String, System.Object)
		/// </summary>
		protected RMethod r_MAddResource_String_Object;
		public virtual RMethod RMAddResource_String_Object
		{
			get
			{
				if(r_MAddResource_String_Object == null)
				{
					r_MAddResource_String_Object = new(this, "AddResource", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MAddResource_String_Object;
			}
		}

		/// <summary>
		/// Void AddResource(System.String, Byte[])
		/// </summary>
		protected RMethod r_MAddResource_String_ByteArray;
		public virtual RMethod RMAddResource_String_ByteArray
		{
			get
			{
				if(r_MAddResource_String_ByteArray == null)
				{
					r_MAddResource_String_ByteArray = new(this, "AddResource", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
				}
				return r_MAddResource_String_ByteArray;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_MClose;
		public virtual RMethod RMClose
		{
			get
			{
				if(r_MClose == null)
				{
					r_MClose = new(this, "Close", 0);
				}
				return r_MClose;
			}
		}

		/// <summary>
		/// Void Generate()
		/// </summary>
		protected RMethod r_MGenerate;
		public virtual RMethod RMGenerate
		{
			get
			{
				if(r_MGenerate == null)
				{
					r_MGenerate = new(this, "Generate", 0);
				}
				return r_MGenerate;
			}
		}


        public virtual void AddResource(System.String @name, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddResource_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddResource(System.String @name, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddResource_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddResource(System.String @name, System.Byte[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddResource_String_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Generate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGenerate.Invoke(___genericsType, ___parameters);

            
        }


    }
}
