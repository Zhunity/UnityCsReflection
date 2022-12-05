using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
    public partial class RFrustumPlanes : Member
    {
		public  Field left; //System.Single
		public  Field right; //System.Single
		public  Field bottom; //System.Single
		public  Field top; //System.Single
		public  Field zNear; //System.Single
		public  Field zFar; //System.Single
		public  Method REquals_Object; //Boolean Equals(System.Object)
		public  Method RGetHashCode; //Int32 GetHashCode()
		public  Method RToString; //System.String ToString()
		public  Method RFinalize; //Void Finalize()
		public  Method RGetType; //System.Type GetType()
		public  Method RMemberwiseClone; //System.Object MemberwiseClone()


        public RFrustumPlanes() : base("UnityEngine.FrustumPlanes")
        {
            NewMembers();
        }

        public RFrustumPlanes(System.Object instance) : base("UnityEngine.FrustumPlanes")
		{
			NewMembers();
            SetInstance(instance);
		}

        public RFrustumPlanes(Member belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
            NewMembers();
	    }

        private void NewMembers()
        {
			left = new Field(this, "left");
			right = new Field(this, "right");
			bottom = new Field(this, "bottom");
			top = new Field(this, "top");
			zNear = new Field(this, "zNear");
			zFar = new Field(this, "zFar");
			REquals_Object = new Method(this, "Equals", 0, typeof(System.Object));
			RGetHashCode = new Method(this, "GetHashCode", 0);
			RToString = new Method(this, "ToString", 0);
			RFinalize = new Method(this, "Finalize", 0);
			RGetType = new Method(this, "GetType", 0);
			RMemberwiseClone = new Method(this, "MemberwiseClone", 0);

        }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }

        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
