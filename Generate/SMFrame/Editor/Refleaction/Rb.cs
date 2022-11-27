using SMFrame.Editor.Refleaction.RSMFrame.REditor.RRefleaction;
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSMFrame.REditor.RRefleaction
{
    public partial class Rb : Member
    {
		public  Ra<Int32> generic; //SMFrame.Editor.Refleaction.GenerateRClass+a`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]
		public  RInt32[] array; //System.Int32[]
		public  Method Rc_GT; //Void c[T]()
		public  Method REquals_Object; //Boolean Equals(System.Object)
		public  Method RFinalize; //Void Finalize()
		public  Method RGetHashCode; //Int32 GetHashCode()
		public  Method RGetType; //System.Type GetType()
		public  Method RMemberwiseClone; //System.Object MemberwiseClone()
		public  Method RToString; //System.String ToString()


        public Rb() : base("b")
        {
            NewMembers();
        }

        public Rb(Member belongMember, string name) : base(belongMember, name)
	    {
            NewMembers();
	    }

        private void NewMembers()
        {
			generic = new Ra<Int32>(this, "generic");
			array = new RInt32[](this, "array");
			Rc_GT = new Method(this, "c", 1);
			REquals_Object = new Method(this, "Equals", 0, typeof(Object));
			RFinalize = new Method(this, "Finalize", 0);
			RGetHashCode = new Method(this, "GetHashCode", 0);
			RGetType = new Method(this, "GetType", 0);
			RMemberwiseClone = new Method(this, "MemberwiseClone", 0);
			RToString = new Method(this, "ToString", 0);

        }

        public virtual void c<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = Rc_GT.Invoke(___genericsType, ___parameters);

            
        }

        public virtual Boolean Equals(Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (Boolean)___result;
        }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }

        public virtual Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (Int32)___result;
        }

        public virtual Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (Type)___result;
        }

        public virtual Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (Object)___result;
        }

        public virtual String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (String)___result;
        }

    }
}
