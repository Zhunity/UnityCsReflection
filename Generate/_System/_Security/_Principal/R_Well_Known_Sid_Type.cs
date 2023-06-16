
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Security.Principal.WellKnownSidType
	/// </summary>
    public partial class RWellKnownSidType : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.Principal.WellKnownSidType);
            }
        }

        public RWellKnownSidType() : base("System.Security.Principal.WellKnownSidType")
        {
        }

        public RWellKnownSidType(System.Object instance) : base("System.Security.Principal.WellKnownSidType")
		{
            SetInstance(instance);
		}

        public RWellKnownSidType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWellKnownSidType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType NullSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FNullSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFNullSid
		{
			get
			{
				if(r_FNullSid == null)
				{
					r_FNullSid = new(Type, "NullSid");
				}
				return r_FNullSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WorldSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWorldSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWorldSid
		{
			get
			{
				if(r_FWorldSid == null)
				{
					r_FWorldSid = new(Type, "WorldSid");
				}
				return r_FWorldSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType LocalSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FLocalSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFLocalSid
		{
			get
			{
				if(r_FLocalSid == null)
				{
					r_FLocalSid = new(Type, "LocalSid");
				}
				return r_FLocalSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType CreatorOwnerSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FCreatorOwnerSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFCreatorOwnerSid
		{
			get
			{
				if(r_FCreatorOwnerSid == null)
				{
					r_FCreatorOwnerSid = new(Type, "CreatorOwnerSid");
				}
				return r_FCreatorOwnerSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType CreatorGroupSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FCreatorGroupSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFCreatorGroupSid
		{
			get
			{
				if(r_FCreatorGroupSid == null)
				{
					r_FCreatorGroupSid = new(Type, "CreatorGroupSid");
				}
				return r_FCreatorGroupSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType CreatorOwnerServerSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FCreatorOwnerServerSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFCreatorOwnerServerSid
		{
			get
			{
				if(r_FCreatorOwnerServerSid == null)
				{
					r_FCreatorOwnerServerSid = new(Type, "CreatorOwnerServerSid");
				}
				return r_FCreatorOwnerServerSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType CreatorGroupServerSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FCreatorGroupServerSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFCreatorGroupServerSid
		{
			get
			{
				if(r_FCreatorGroupServerSid == null)
				{
					r_FCreatorGroupServerSid = new(Type, "CreatorGroupServerSid");
				}
				return r_FCreatorGroupServerSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType NTAuthoritySid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FNTAuthoritySid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFNTAuthoritySid
		{
			get
			{
				if(r_FNTAuthoritySid == null)
				{
					r_FNTAuthoritySid = new(Type, "NTAuthoritySid");
				}
				return r_FNTAuthoritySid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType DialupSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FDialupSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFDialupSid
		{
			get
			{
				if(r_FDialupSid == null)
				{
					r_FDialupSid = new(Type, "DialupSid");
				}
				return r_FDialupSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType NetworkSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FNetworkSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFNetworkSid
		{
			get
			{
				if(r_FNetworkSid == null)
				{
					r_FNetworkSid = new(Type, "NetworkSid");
				}
				return r_FNetworkSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BatchSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBatchSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBatchSid
		{
			get
			{
				if(r_FBatchSid == null)
				{
					r_FBatchSid = new(Type, "BatchSid");
				}
				return r_FBatchSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType InteractiveSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FInteractiveSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFInteractiveSid
		{
			get
			{
				if(r_FInteractiveSid == null)
				{
					r_FInteractiveSid = new(Type, "InteractiveSid");
				}
				return r_FInteractiveSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType ServiceSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FServiceSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFServiceSid
		{
			get
			{
				if(r_FServiceSid == null)
				{
					r_FServiceSid = new(Type, "ServiceSid");
				}
				return r_FServiceSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AnonymousSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAnonymousSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAnonymousSid
		{
			get
			{
				if(r_FAnonymousSid == null)
				{
					r_FAnonymousSid = new(Type, "AnonymousSid");
				}
				return r_FAnonymousSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType ProxySid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FProxySid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFProxySid
		{
			get
			{
				if(r_FProxySid == null)
				{
					r_FProxySid = new(Type, "ProxySid");
				}
				return r_FProxySid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType EnterpriseControllersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FEnterpriseControllersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFEnterpriseControllersSid
		{
			get
			{
				if(r_FEnterpriseControllersSid == null)
				{
					r_FEnterpriseControllersSid = new(Type, "EnterpriseControllersSid");
				}
				return r_FEnterpriseControllersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType SelfSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FSelfSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFSelfSid
		{
			get
			{
				if(r_FSelfSid == null)
				{
					r_FSelfSid = new(Type, "SelfSid");
				}
				return r_FSelfSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AuthenticatedUserSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAuthenticatedUserSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAuthenticatedUserSid
		{
			get
			{
				if(r_FAuthenticatedUserSid == null)
				{
					r_FAuthenticatedUserSid = new(Type, "AuthenticatedUserSid");
				}
				return r_FAuthenticatedUserSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType RestrictedCodeSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FRestrictedCodeSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFRestrictedCodeSid
		{
			get
			{
				if(r_FRestrictedCodeSid == null)
				{
					r_FRestrictedCodeSid = new(Type, "RestrictedCodeSid");
				}
				return r_FRestrictedCodeSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType TerminalServerSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FTerminalServerSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFTerminalServerSid
		{
			get
			{
				if(r_FTerminalServerSid == null)
				{
					r_FTerminalServerSid = new(Type, "TerminalServerSid");
				}
				return r_FTerminalServerSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType RemoteLogonIdSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FRemoteLogonIdSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFRemoteLogonIdSid
		{
			get
			{
				if(r_FRemoteLogonIdSid == null)
				{
					r_FRemoteLogonIdSid = new(Type, "RemoteLogonIdSid");
				}
				return r_FRemoteLogonIdSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType LogonIdsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FLogonIdsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFLogonIdsSid
		{
			get
			{
				if(r_FLogonIdsSid == null)
				{
					r_FLogonIdsSid = new(Type, "LogonIdsSid");
				}
				return r_FLogonIdsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType LocalSystemSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FLocalSystemSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFLocalSystemSid
		{
			get
			{
				if(r_FLocalSystemSid == null)
				{
					r_FLocalSystemSid = new(Type, "LocalSystemSid");
				}
				return r_FLocalSystemSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType LocalServiceSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FLocalServiceSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFLocalServiceSid
		{
			get
			{
				if(r_FLocalServiceSid == null)
				{
					r_FLocalServiceSid = new(Type, "LocalServiceSid");
				}
				return r_FLocalServiceSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType NetworkServiceSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FNetworkServiceSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFNetworkServiceSid
		{
			get
			{
				if(r_FNetworkServiceSid == null)
				{
					r_FNetworkServiceSid = new(Type, "NetworkServiceSid");
				}
				return r_FNetworkServiceSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinDomainSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinDomainSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinDomainSid
		{
			get
			{
				if(r_FBuiltinDomainSid == null)
				{
					r_FBuiltinDomainSid = new(Type, "BuiltinDomainSid");
				}
				return r_FBuiltinDomainSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinAdministratorsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinAdministratorsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinAdministratorsSid
		{
			get
			{
				if(r_FBuiltinAdministratorsSid == null)
				{
					r_FBuiltinAdministratorsSid = new(Type, "BuiltinAdministratorsSid");
				}
				return r_FBuiltinAdministratorsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinUsersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinUsersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinUsersSid
		{
			get
			{
				if(r_FBuiltinUsersSid == null)
				{
					r_FBuiltinUsersSid = new(Type, "BuiltinUsersSid");
				}
				return r_FBuiltinUsersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinGuestsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinGuestsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinGuestsSid
		{
			get
			{
				if(r_FBuiltinGuestsSid == null)
				{
					r_FBuiltinGuestsSid = new(Type, "BuiltinGuestsSid");
				}
				return r_FBuiltinGuestsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinPowerUsersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinPowerUsersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinPowerUsersSid
		{
			get
			{
				if(r_FBuiltinPowerUsersSid == null)
				{
					r_FBuiltinPowerUsersSid = new(Type, "BuiltinPowerUsersSid");
				}
				return r_FBuiltinPowerUsersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinAccountOperatorsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinAccountOperatorsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinAccountOperatorsSid
		{
			get
			{
				if(r_FBuiltinAccountOperatorsSid == null)
				{
					r_FBuiltinAccountOperatorsSid = new(Type, "BuiltinAccountOperatorsSid");
				}
				return r_FBuiltinAccountOperatorsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinSystemOperatorsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinSystemOperatorsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinSystemOperatorsSid
		{
			get
			{
				if(r_FBuiltinSystemOperatorsSid == null)
				{
					r_FBuiltinSystemOperatorsSid = new(Type, "BuiltinSystemOperatorsSid");
				}
				return r_FBuiltinSystemOperatorsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinPrintOperatorsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinPrintOperatorsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinPrintOperatorsSid
		{
			get
			{
				if(r_FBuiltinPrintOperatorsSid == null)
				{
					r_FBuiltinPrintOperatorsSid = new(Type, "BuiltinPrintOperatorsSid");
				}
				return r_FBuiltinPrintOperatorsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinBackupOperatorsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinBackupOperatorsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinBackupOperatorsSid
		{
			get
			{
				if(r_FBuiltinBackupOperatorsSid == null)
				{
					r_FBuiltinBackupOperatorsSid = new(Type, "BuiltinBackupOperatorsSid");
				}
				return r_FBuiltinBackupOperatorsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinReplicatorSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinReplicatorSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinReplicatorSid
		{
			get
			{
				if(r_FBuiltinReplicatorSid == null)
				{
					r_FBuiltinReplicatorSid = new(Type, "BuiltinReplicatorSid");
				}
				return r_FBuiltinReplicatorSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinPreWindows2000CompatibleAccessSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinPreWindows2000CompatibleAccessSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinPreWindows2000CompatibleAccessSid
		{
			get
			{
				if(r_FBuiltinPreWindows2000CompatibleAccessSid == null)
				{
					r_FBuiltinPreWindows2000CompatibleAccessSid = new(Type, "BuiltinPreWindows2000CompatibleAccessSid");
				}
				return r_FBuiltinPreWindows2000CompatibleAccessSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinRemoteDesktopUsersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinRemoteDesktopUsersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinRemoteDesktopUsersSid
		{
			get
			{
				if(r_FBuiltinRemoteDesktopUsersSid == null)
				{
					r_FBuiltinRemoteDesktopUsersSid = new(Type, "BuiltinRemoteDesktopUsersSid");
				}
				return r_FBuiltinRemoteDesktopUsersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinNetworkConfigurationOperatorsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinNetworkConfigurationOperatorsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinNetworkConfigurationOperatorsSid
		{
			get
			{
				if(r_FBuiltinNetworkConfigurationOperatorsSid == null)
				{
					r_FBuiltinNetworkConfigurationOperatorsSid = new(Type, "BuiltinNetworkConfigurationOperatorsSid");
				}
				return r_FBuiltinNetworkConfigurationOperatorsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountAdministratorSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountAdministratorSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountAdministratorSid
		{
			get
			{
				if(r_FAccountAdministratorSid == null)
				{
					r_FAccountAdministratorSid = new(Type, "AccountAdministratorSid");
				}
				return r_FAccountAdministratorSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountGuestSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountGuestSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountGuestSid
		{
			get
			{
				if(r_FAccountGuestSid == null)
				{
					r_FAccountGuestSid = new(Type, "AccountGuestSid");
				}
				return r_FAccountGuestSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountKrbtgtSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountKrbtgtSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountKrbtgtSid
		{
			get
			{
				if(r_FAccountKrbtgtSid == null)
				{
					r_FAccountKrbtgtSid = new(Type, "AccountKrbtgtSid");
				}
				return r_FAccountKrbtgtSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountDomainAdminsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountDomainAdminsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountDomainAdminsSid
		{
			get
			{
				if(r_FAccountDomainAdminsSid == null)
				{
					r_FAccountDomainAdminsSid = new(Type, "AccountDomainAdminsSid");
				}
				return r_FAccountDomainAdminsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountDomainUsersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountDomainUsersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountDomainUsersSid
		{
			get
			{
				if(r_FAccountDomainUsersSid == null)
				{
					r_FAccountDomainUsersSid = new(Type, "AccountDomainUsersSid");
				}
				return r_FAccountDomainUsersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountDomainGuestsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountDomainGuestsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountDomainGuestsSid
		{
			get
			{
				if(r_FAccountDomainGuestsSid == null)
				{
					r_FAccountDomainGuestsSid = new(Type, "AccountDomainGuestsSid");
				}
				return r_FAccountDomainGuestsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountComputersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountComputersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountComputersSid
		{
			get
			{
				if(r_FAccountComputersSid == null)
				{
					r_FAccountComputersSid = new(Type, "AccountComputersSid");
				}
				return r_FAccountComputersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountControllersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountControllersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountControllersSid
		{
			get
			{
				if(r_FAccountControllersSid == null)
				{
					r_FAccountControllersSid = new(Type, "AccountControllersSid");
				}
				return r_FAccountControllersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountCertAdminsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountCertAdminsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountCertAdminsSid
		{
			get
			{
				if(r_FAccountCertAdminsSid == null)
				{
					r_FAccountCertAdminsSid = new(Type, "AccountCertAdminsSid");
				}
				return r_FAccountCertAdminsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountSchemaAdminsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountSchemaAdminsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountSchemaAdminsSid
		{
			get
			{
				if(r_FAccountSchemaAdminsSid == null)
				{
					r_FAccountSchemaAdminsSid = new(Type, "AccountSchemaAdminsSid");
				}
				return r_FAccountSchemaAdminsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountEnterpriseAdminsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountEnterpriseAdminsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountEnterpriseAdminsSid
		{
			get
			{
				if(r_FAccountEnterpriseAdminsSid == null)
				{
					r_FAccountEnterpriseAdminsSid = new(Type, "AccountEnterpriseAdminsSid");
				}
				return r_FAccountEnterpriseAdminsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountPolicyAdminsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountPolicyAdminsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountPolicyAdminsSid
		{
			get
			{
				if(r_FAccountPolicyAdminsSid == null)
				{
					r_FAccountPolicyAdminsSid = new(Type, "AccountPolicyAdminsSid");
				}
				return r_FAccountPolicyAdminsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType AccountRasAndIasServersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FAccountRasAndIasServersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFAccountRasAndIasServersSid
		{
			get
			{
				if(r_FAccountRasAndIasServersSid == null)
				{
					r_FAccountRasAndIasServersSid = new(Type, "AccountRasAndIasServersSid");
				}
				return r_FAccountRasAndIasServersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType NtlmAuthenticationSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FNtlmAuthenticationSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFNtlmAuthenticationSid
		{
			get
			{
				if(r_FNtlmAuthenticationSid == null)
				{
					r_FNtlmAuthenticationSid = new(Type, "NtlmAuthenticationSid");
				}
				return r_FNtlmAuthenticationSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType DigestAuthenticationSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FDigestAuthenticationSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFDigestAuthenticationSid
		{
			get
			{
				if(r_FDigestAuthenticationSid == null)
				{
					r_FDigestAuthenticationSid = new(Type, "DigestAuthenticationSid");
				}
				return r_FDigestAuthenticationSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType SChannelAuthenticationSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FSChannelAuthenticationSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFSChannelAuthenticationSid
		{
			get
			{
				if(r_FSChannelAuthenticationSid == null)
				{
					r_FSChannelAuthenticationSid = new(Type, "SChannelAuthenticationSid");
				}
				return r_FSChannelAuthenticationSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType ThisOrganizationSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FThisOrganizationSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFThisOrganizationSid
		{
			get
			{
				if(r_FThisOrganizationSid == null)
				{
					r_FThisOrganizationSid = new(Type, "ThisOrganizationSid");
				}
				return r_FThisOrganizationSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType OtherOrganizationSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FOtherOrganizationSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFOtherOrganizationSid
		{
			get
			{
				if(r_FOtherOrganizationSid == null)
				{
					r_FOtherOrganizationSid = new(Type, "OtherOrganizationSid");
				}
				return r_FOtherOrganizationSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinIncomingForestTrustBuildersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinIncomingForestTrustBuildersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinIncomingForestTrustBuildersSid
		{
			get
			{
				if(r_FBuiltinIncomingForestTrustBuildersSid == null)
				{
					r_FBuiltinIncomingForestTrustBuildersSid = new(Type, "BuiltinIncomingForestTrustBuildersSid");
				}
				return r_FBuiltinIncomingForestTrustBuildersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinPerformanceMonitoringUsersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinPerformanceMonitoringUsersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinPerformanceMonitoringUsersSid
		{
			get
			{
				if(r_FBuiltinPerformanceMonitoringUsersSid == null)
				{
					r_FBuiltinPerformanceMonitoringUsersSid = new(Type, "BuiltinPerformanceMonitoringUsersSid");
				}
				return r_FBuiltinPerformanceMonitoringUsersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinPerformanceLoggingUsersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinPerformanceLoggingUsersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinPerformanceLoggingUsersSid
		{
			get
			{
				if(r_FBuiltinPerformanceLoggingUsersSid == null)
				{
					r_FBuiltinPerformanceLoggingUsersSid = new(Type, "BuiltinPerformanceLoggingUsersSid");
				}
				return r_FBuiltinPerformanceLoggingUsersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType BuiltinAuthorizationAccessSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FBuiltinAuthorizationAccessSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFBuiltinAuthorizationAccessSid
		{
			get
			{
				if(r_FBuiltinAuthorizationAccessSid == null)
				{
					r_FBuiltinAuthorizationAccessSid = new(Type, "BuiltinAuthorizationAccessSid");
				}
				return r_FBuiltinAuthorizationAccessSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinBuiltinTerminalServerLicenseServersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinBuiltinTerminalServerLicenseServersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinBuiltinTerminalServerLicenseServersSid
		{
			get
			{
				if(r_FWinBuiltinTerminalServerLicenseServersSid == null)
				{
					r_FWinBuiltinTerminalServerLicenseServersSid = new(Type, "WinBuiltinTerminalServerLicenseServersSid");
				}
				return r_FWinBuiltinTerminalServerLicenseServersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType MaxDefined
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FMaxDefined;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFMaxDefined
		{
			get
			{
				if(r_FMaxDefined == null)
				{
					r_FMaxDefined = new(Type, "MaxDefined");
				}
				return r_FMaxDefined;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinBuiltinDCOMUsersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinBuiltinDCOMUsersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinBuiltinDCOMUsersSid
		{
			get
			{
				if(r_FWinBuiltinDCOMUsersSid == null)
				{
					r_FWinBuiltinDCOMUsersSid = new(Type, "WinBuiltinDCOMUsersSid");
				}
				return r_FWinBuiltinDCOMUsersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinBuiltinIUsersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinBuiltinIUsersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinBuiltinIUsersSid
		{
			get
			{
				if(r_FWinBuiltinIUsersSid == null)
				{
					r_FWinBuiltinIUsersSid = new(Type, "WinBuiltinIUsersSid");
				}
				return r_FWinBuiltinIUsersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinIUserSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinIUserSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinIUserSid
		{
			get
			{
				if(r_FWinIUserSid == null)
				{
					r_FWinIUserSid = new(Type, "WinIUserSid");
				}
				return r_FWinIUserSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinBuiltinCryptoOperatorsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinBuiltinCryptoOperatorsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinBuiltinCryptoOperatorsSid
		{
			get
			{
				if(r_FWinBuiltinCryptoOperatorsSid == null)
				{
					r_FWinBuiltinCryptoOperatorsSid = new(Type, "WinBuiltinCryptoOperatorsSid");
				}
				return r_FWinBuiltinCryptoOperatorsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinUntrustedLabelSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinUntrustedLabelSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinUntrustedLabelSid
		{
			get
			{
				if(r_FWinUntrustedLabelSid == null)
				{
					r_FWinUntrustedLabelSid = new(Type, "WinUntrustedLabelSid");
				}
				return r_FWinUntrustedLabelSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinLowLabelSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinLowLabelSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinLowLabelSid
		{
			get
			{
				if(r_FWinLowLabelSid == null)
				{
					r_FWinLowLabelSid = new(Type, "WinLowLabelSid");
				}
				return r_FWinLowLabelSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinMediumLabelSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinMediumLabelSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinMediumLabelSid
		{
			get
			{
				if(r_FWinMediumLabelSid == null)
				{
					r_FWinMediumLabelSid = new(Type, "WinMediumLabelSid");
				}
				return r_FWinMediumLabelSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinHighLabelSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinHighLabelSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinHighLabelSid
		{
			get
			{
				if(r_FWinHighLabelSid == null)
				{
					r_FWinHighLabelSid = new(Type, "WinHighLabelSid");
				}
				return r_FWinHighLabelSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinSystemLabelSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinSystemLabelSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinSystemLabelSid
		{
			get
			{
				if(r_FWinSystemLabelSid == null)
				{
					r_FWinSystemLabelSid = new(Type, "WinSystemLabelSid");
				}
				return r_FWinSystemLabelSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinWriteRestrictedCodeSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinWriteRestrictedCodeSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinWriteRestrictedCodeSid
		{
			get
			{
				if(r_FWinWriteRestrictedCodeSid == null)
				{
					r_FWinWriteRestrictedCodeSid = new(Type, "WinWriteRestrictedCodeSid");
				}
				return r_FWinWriteRestrictedCodeSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinCreatorOwnerRightsSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinCreatorOwnerRightsSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinCreatorOwnerRightsSid
		{
			get
			{
				if(r_FWinCreatorOwnerRightsSid == null)
				{
					r_FWinCreatorOwnerRightsSid = new(Type, "WinCreatorOwnerRightsSid");
				}
				return r_FWinCreatorOwnerRightsSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinCacheablePrincipalsGroupSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinCacheablePrincipalsGroupSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinCacheablePrincipalsGroupSid
		{
			get
			{
				if(r_FWinCacheablePrincipalsGroupSid == null)
				{
					r_FWinCacheablePrincipalsGroupSid = new(Type, "WinCacheablePrincipalsGroupSid");
				}
				return r_FWinCacheablePrincipalsGroupSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinNonCacheablePrincipalsGroupSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinNonCacheablePrincipalsGroupSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinNonCacheablePrincipalsGroupSid
		{
			get
			{
				if(r_FWinNonCacheablePrincipalsGroupSid == null)
				{
					r_FWinNonCacheablePrincipalsGroupSid = new(Type, "WinNonCacheablePrincipalsGroupSid");
				}
				return r_FWinNonCacheablePrincipalsGroupSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinEnterpriseReadonlyControllersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinEnterpriseReadonlyControllersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinEnterpriseReadonlyControllersSid
		{
			get
			{
				if(r_FWinEnterpriseReadonlyControllersSid == null)
				{
					r_FWinEnterpriseReadonlyControllersSid = new(Type, "WinEnterpriseReadonlyControllersSid");
				}
				return r_FWinEnterpriseReadonlyControllersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinAccountReadonlyControllersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinAccountReadonlyControllersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinAccountReadonlyControllersSid
		{
			get
			{
				if(r_FWinAccountReadonlyControllersSid == null)
				{
					r_FWinAccountReadonlyControllersSid = new(Type, "WinAccountReadonlyControllersSid");
				}
				return r_FWinAccountReadonlyControllersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinBuiltinEventLogReadersGroup
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinBuiltinEventLogReadersGroup;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinBuiltinEventLogReadersGroup
		{
			get
			{
				if(r_FWinBuiltinEventLogReadersGroup == null)
				{
					r_FWinBuiltinEventLogReadersGroup = new(Type, "WinBuiltinEventLogReadersGroup");
				}
				return r_FWinBuiltinEventLogReadersGroup;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinNewEnterpriseReadonlyControllersSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinNewEnterpriseReadonlyControllersSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinNewEnterpriseReadonlyControllersSid
		{
			get
			{
				if(r_FWinNewEnterpriseReadonlyControllersSid == null)
				{
					r_FWinNewEnterpriseReadonlyControllersSid = new(Type, "WinNewEnterpriseReadonlyControllersSid");
				}
				return r_FWinNewEnterpriseReadonlyControllersSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinBuiltinCertSvcDComAccessGroup
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinBuiltinCertSvcDComAccessGroup;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinBuiltinCertSvcDComAccessGroup
		{
			get
			{
				if(r_FWinBuiltinCertSvcDComAccessGroup == null)
				{
					r_FWinBuiltinCertSvcDComAccessGroup = new(Type, "WinBuiltinCertSvcDComAccessGroup");
				}
				return r_FWinBuiltinCertSvcDComAccessGroup;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinMediumPlusLabelSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinMediumPlusLabelSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinMediumPlusLabelSid
		{
			get
			{
				if(r_FWinMediumPlusLabelSid == null)
				{
					r_FWinMediumPlusLabelSid = new(Type, "WinMediumPlusLabelSid");
				}
				return r_FWinMediumPlusLabelSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinLocalLogonSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinLocalLogonSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinLocalLogonSid
		{
			get
			{
				if(r_FWinLocalLogonSid == null)
				{
					r_FWinLocalLogonSid = new(Type, "WinLocalLogonSid");
				}
				return r_FWinLocalLogonSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinConsoleLogonSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinConsoleLogonSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinConsoleLogonSid
		{
			get
			{
				if(r_FWinConsoleLogonSid == null)
				{
					r_FWinConsoleLogonSid = new(Type, "WinConsoleLogonSid");
				}
				return r_FWinConsoleLogonSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinThisOrganizationCertificateSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinThisOrganizationCertificateSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinThisOrganizationCertificateSid
		{
			get
			{
				if(r_FWinThisOrganizationCertificateSid == null)
				{
					r_FWinThisOrganizationCertificateSid = new(Type, "WinThisOrganizationCertificateSid");
				}
				return r_FWinThisOrganizationCertificateSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinApplicationPackageAuthoritySid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinApplicationPackageAuthoritySid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinApplicationPackageAuthoritySid
		{
			get
			{
				if(r_FWinApplicationPackageAuthoritySid == null)
				{
					r_FWinApplicationPackageAuthoritySid = new(Type, "WinApplicationPackageAuthoritySid");
				}
				return r_FWinApplicationPackageAuthoritySid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinBuiltinAnyPackageSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinBuiltinAnyPackageSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinBuiltinAnyPackageSid
		{
			get
			{
				if(r_FWinBuiltinAnyPackageSid == null)
				{
					r_FWinBuiltinAnyPackageSid = new(Type, "WinBuiltinAnyPackageSid");
				}
				return r_FWinBuiltinAnyPackageSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinCapabilityInternetClientSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinCapabilityInternetClientSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinCapabilityInternetClientSid
		{
			get
			{
				if(r_FWinCapabilityInternetClientSid == null)
				{
					r_FWinCapabilityInternetClientSid = new(Type, "WinCapabilityInternetClientSid");
				}
				return r_FWinCapabilityInternetClientSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinCapabilityInternetClientServerSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinCapabilityInternetClientServerSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinCapabilityInternetClientServerSid
		{
			get
			{
				if(r_FWinCapabilityInternetClientServerSid == null)
				{
					r_FWinCapabilityInternetClientServerSid = new(Type, "WinCapabilityInternetClientServerSid");
				}
				return r_FWinCapabilityInternetClientServerSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinCapabilityPrivateNetworkClientServerSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinCapabilityPrivateNetworkClientServerSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinCapabilityPrivateNetworkClientServerSid
		{
			get
			{
				if(r_FWinCapabilityPrivateNetworkClientServerSid == null)
				{
					r_FWinCapabilityPrivateNetworkClientServerSid = new(Type, "WinCapabilityPrivateNetworkClientServerSid");
				}
				return r_FWinCapabilityPrivateNetworkClientServerSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinCapabilityPicturesLibrarySid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinCapabilityPicturesLibrarySid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinCapabilityPicturesLibrarySid
		{
			get
			{
				if(r_FWinCapabilityPicturesLibrarySid == null)
				{
					r_FWinCapabilityPicturesLibrarySid = new(Type, "WinCapabilityPicturesLibrarySid");
				}
				return r_FWinCapabilityPicturesLibrarySid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinCapabilityVideosLibrarySid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinCapabilityVideosLibrarySid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinCapabilityVideosLibrarySid
		{
			get
			{
				if(r_FWinCapabilityVideosLibrarySid == null)
				{
					r_FWinCapabilityVideosLibrarySid = new(Type, "WinCapabilityVideosLibrarySid");
				}
				return r_FWinCapabilityVideosLibrarySid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinCapabilityMusicLibrarySid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinCapabilityMusicLibrarySid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinCapabilityMusicLibrarySid
		{
			get
			{
				if(r_FWinCapabilityMusicLibrarySid == null)
				{
					r_FWinCapabilityMusicLibrarySid = new(Type, "WinCapabilityMusicLibrarySid");
				}
				return r_FWinCapabilityMusicLibrarySid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinCapabilityDocumentsLibrarySid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinCapabilityDocumentsLibrarySid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinCapabilityDocumentsLibrarySid
		{
			get
			{
				if(r_FWinCapabilityDocumentsLibrarySid == null)
				{
					r_FWinCapabilityDocumentsLibrarySid = new(Type, "WinCapabilityDocumentsLibrarySid");
				}
				return r_FWinCapabilityDocumentsLibrarySid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinCapabilitySharedUserCertificatesSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinCapabilitySharedUserCertificatesSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinCapabilitySharedUserCertificatesSid
		{
			get
			{
				if(r_FWinCapabilitySharedUserCertificatesSid == null)
				{
					r_FWinCapabilitySharedUserCertificatesSid = new(Type, "WinCapabilitySharedUserCertificatesSid");
				}
				return r_FWinCapabilitySharedUserCertificatesSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinCapabilityEnterpriseAuthenticationSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinCapabilityEnterpriseAuthenticationSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinCapabilityEnterpriseAuthenticationSid
		{
			get
			{
				if(r_FWinCapabilityEnterpriseAuthenticationSid == null)
				{
					r_FWinCapabilityEnterpriseAuthenticationSid = new(Type, "WinCapabilityEnterpriseAuthenticationSid");
				}
				return r_FWinCapabilityEnterpriseAuthenticationSid;
			}
		}

		/// <summary>
		/// System.Security.Principal.WellKnownSidType WinCapabilityRemovableStorageSid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType r_FWinCapabilityRemovableStorageSid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RWellKnownSidType RFWinCapabilityRemovableStorageSid
		{
			get
			{
				if(r_FWinCapabilityRemovableStorageSid == null)
				{
					r_FWinCapabilityRemovableStorageSid = new(Type, "WinCapabilityRemovableStorageSid");
				}
				return r_FWinCapabilityRemovableStorageSid;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
				}
				return r_MGetValue;
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
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
				}
				return r_MGetTypeCode;
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
				}
				return r_MMemberwiseClone;
			}
		}


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
