using SMFrame.Editor.Refleaction;
using System;

namespace SMFrame.Editor.Refleaction.SMFrame.Editor.Refleaction
{
    public partial class RA : Member
    {
		public Method RN; //System.Void N()
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
			RN = new Method(this, "N", 0);
			RN_GT_T = new Method(this, "N", 1, Type.MakeGenericMethodParameter(0));
			RN_GT_GU_T_U = new Method(this, "N", 2, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
			RN_Out_Boolean = new Method(this, "N", 0, typeof(System.Boolean).MakeByRefType());
			RN_Boolean = new Method(this, "N", 0, typeof(System.Boolean));
			REquals_Object = new Method(this, "Equals", 0, typeof(System.Object));
			RFinalize = new Method(this, "Finalize", 0);
			RGetHashCode = new Method(this, "GetHashCode", 0);
			RGetType = new Method(this, "GetType", 0);
			RMemberwiseClone = new Method(this, "MemberwiseClone", 0);
			RToString = new Method(this, "ToString", 0);

        }

        public virtual void N()
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{};
            var result = RN.Invoke(genericsType, parameters);

            
        }

        public virtual System.String N<T>(T a)
        {

            var genericsType = new Type[] {typeof(T)};
            var parameters = new object[]{a};
            var result = RN_GT_T.Invoke(genericsType, parameters);

            return (System.String)result;
        }

        public virtual System.String N<T, U>(T a, U b)
        {

            var genericsType = new Type[] {typeof(T), typeof(U)};
            var parameters = new object[]{a, b};
            var result = RN_GT_GU_T_U.Invoke(genericsType, parameters);

            return (System.String)result;
        }

        public virtual System.String N(out System.Boolean a)
        {
			a = default;

            var genericsType = new Type[] {};
            var parameters = new object[]{a};
            var result = RN_Out_Boolean.Invoke(genericsType, parameters);
			a = (System.Boolean)parameters[0];

            return (System.String)result;
        }

        public virtual System.String N(System.Boolean a)
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{a};
            var result = RN_Boolean.Invoke(genericsType, parameters);

            return (System.String)result;
        }

        public virtual System.Boolean Equals(System.Object obj)
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{obj};
            var result = REquals_Object.Invoke(genericsType, parameters);

            return (System.Boolean)result;
        }

        public virtual void Finalize()
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{};
            var result = RFinalize.Invoke(genericsType, parameters);

            
        }

        public virtual System.Int32 GetHashCode()
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{};
            var result = RGetHashCode.Invoke(genericsType, parameters);

            return (System.Int32)result;
        }

        public virtual System.Type GetType()
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{};
            var result = RGetType.Invoke(genericsType, parameters);

            return (System.Type)result;
        }

        public virtual System.Object MemberwiseClone()
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{};
            var result = RMemberwiseClone.Invoke(genericsType, parameters);

            return (System.Object)result;
        }

        public virtual System.String ToString()
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{};
            var result = RToString.Invoke(genericsType, parameters);

            return (System.String)result;
        }

    }
}
