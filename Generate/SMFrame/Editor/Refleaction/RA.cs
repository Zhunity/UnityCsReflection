using SMFrame.Editor.Refleaction;
using System;

namespace SMFrame.Editor.Refleaction.SMFrame.Editor.Refleaction
{
    public class RA : Member
    {
		public Method RN_GT_T; //System.String N<T>(T a)
		public Method RN_GT_GU_T_U; //System.String N<T, U>(T a, U b)
		public Method RN_Out_Boolean; //System.String N(System.Boolean a)
		public Method RN_Boolean; //System.String N(System.Boolean a)
		public Method REquals_Object; //System.Boolean Equals(System.Object obj)
		public Method RFinalize; //System.Void Finalize()
		public Method RGetHashCode; //System.Int32 GetHashCode()
		public Method RGetType; //System.Type GetType()
		public Method RMemberwiseClone; //System.Object MemberwiseClone()
		public Method RToString; //System.String ToString()


        public RA() : base("SMFrame.Editor.Refleaction.A")
        {
            NewMembers();
        }

        public RA(Member belongMember, string name) : base(belongMember, name)
	    {
            NewMembers();
	    }

        private void NewMembers()
        {
			RN_GT_T = new Method(this, "N", 1, Type.MakeGenericMethodParameter(0));
			RN_GT_GU_T_U = new Method(this, "N", 2, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
			RN_Out_Boolean = new Method(this, "N", 0, typeof(System.Boolean));
			RN_Boolean = new Method(this, "N", 0, typeof(System.Boolean));
			REquals_Object = new Method(this, "Equals", 0, typeof(System.Object));
			RFinalize = new Method(this, "Finalize", 0);
			RGetHashCode = new Method(this, "GetHashCode", 0);
			RGetType = new Method(this, "GetType", 0);
			RMemberwiseClone = new Method(this, "MemberwiseClone", 0);
			RToString = new Method(this, "ToString", 0);

        }

        public System.String N<T>(T a)
        {
            return (System.String)RN_GT_T.Invoke(new Type[] { typeof(T) }, a);
        }

        public System.String N<T, U>(T a, U b)
        {
            return (System.String)RN_GT_GU_T_U.Invoke(new Type[] { typeof(T), typeof(U) }, a, b);
        }



        public System.String N(System.Boolean a)
        {
            return (System.String)RN_Boolean.Invoke(a);
        }

        public System.Boolean Equals(System.Object obj)
        {
            return (System.Boolean)REquals_Object.Invoke(obj);
        }

        public void Finalize()
        {
            RFinalize.Invoke();
        }

        public System.Int32 GetHashCode()
        {
            return (System.Int32)RGetHashCode.Invoke();
        }

        public System.Type GetType()
        {
            return (System.Type)RGetType.Invoke();
        }

        public System.Object MemberwiseClone()
        {
            return (System.Object)RMemberwiseClone.Invoke();
        }

        public System.String ToString()
        {
            return (System.String)RToString.Invoke();
        }

    }
}
