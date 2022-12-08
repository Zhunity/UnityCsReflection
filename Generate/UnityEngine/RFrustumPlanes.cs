using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
    public partial class RFrustumPlanes : RMember
    {
		public  RField left; //System.Single
		public  RField right; //System.Single
		public  RField bottom; //System.Single
		public  RField top; //System.Single
		public  RField zNear; //System.Single
		public  RField zFar; //System.Single
		public  RMethod REquals_Object; //Boolean Equals(System.Object)
		public  RMethod RGetHashCode; //Int32 GetHashCode()
		public  RMethod RToString; //System.String ToString()
		public  RMethod RFinalize; //Void Finalize()
		public  RMethod RGetType; //System.Type GetType()
		public  RMethod RMemberwiseClone; //System.Object MemberwiseClone()


        public RFrustumPlanes() : base("UnityEngine.FrustumPlanes")
        {
            NewMembers();
        }

        public RFrustumPlanes(System.Object instance) : base("UnityEngine.FrustumPlanes")
		{
			NewMembers();
            SetInstance(instance);
		}

        public RFrustumPlanes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
            NewMembers();
	    }

        private void NewMembers()
        {
			left = new RField(this, "left");
			right = new RField(this, "right");
			bottom = new RField(this, "bottom");
			top = new RField(this, "top");
			zNear = new RField(this, "zNear");
			zFar = new RField(this, "zFar");
			REquals_Object = new RMethod(this, "Equals", 0, typeof(System.Object));
			RGetHashCode = new RMethod(this, "GetHashCode", 0);
			RToString = new RMethod(this, "ToString", 0);
			RFinalize = new RMethod(this, "Finalize", 0);
			RGetType = new RMethod(this, "GetType", 0);
			RMemberwiseClone = new RMethod(this, "MemberwiseClone", 0);

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
