using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using DX.Data.Xpo.Identity;
using DevExpress.Xpo;
using DX.Data.Xpo;
using DX.Data.Xpo.Identity.Persistent;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;

namespace DX.Test.Web.Core.Models
{
	public class ApplicationUserManager : XPUserManager<ApplicationUser, XpoApplicationUser, XpoApplicationRole>
	{
		public ApplicationUserManager(IUserStore<ApplicationUser> store, IOptions<IdentityOptions> optionsAccessor,
		IPasswordHasher<ApplicationUser> passwordHasher,
		IEnumerable<IUserValidator<ApplicationUser>> userValidators,
		IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators, ILookupNormalizer keyNormalizer,
		IdentityErrorDescriber errors, IServiceProvider services, ILogger<ApplicationUserManager> logger)
		: base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger) { }
	}
	public class ApplicationUserMapper : XPUserMapper<ApplicationUser, XpoApplicationUser>
	{
		public override XpoApplicationUser Assign(ApplicationUser source, XpoApplicationUser destination)
		{
			var result = base.Assign(source, destination);
			return result;
		}

		public override string Map(string sourceField)
		{
			return base.Map(sourceField);
		}

		public override Func<XpoApplicationUser, ApplicationUser> CreateModel => base.CreateModel;
	}

	// Add profile data for application users by adding properties to the ApplicationUser class
	public class ApplicationUser : XPIdentityUser
	{
		public ApplicationUser()
		{

		}
	}

	public class ApplicationRole : XPIdentityRole
	{
		public ApplicationRole()
		{ }
	}
	public class ApplicationRoleMapper : XPRoleMapper<string, ApplicationRole, XpoApplicationRole>
	{
		public override Func<XpoApplicationRole, ApplicationRole> CreateModel => base.CreateModel;

		public override XpoApplicationRole Assign(ApplicationRole source, XpoApplicationRole destination)
		{
			XpoApplicationRole result = base.Assign(source, destination);
			return result;
		}

		public override string Map(string sourceField)
		{
			return base.Map(sourceField);
		}
	}
	public class XpoApplicationUserMapper : XPUserMapper<ApplicationUser, XpoApplicationUser>
	{
		public override Func<XpoApplicationUser, ApplicationUser> CreateModel => base.CreateModel;
		public override XpoApplicationUser Assign(ApplicationUser source, XpoApplicationUser destination)
		{
			XpoApplicationUser result = base.Assign(source, destination);

			return result;
		}

		public override string Map(string sourceField)
		{
			return base.Map(sourceField);
		}
	}

    // This class will be persisted in the database by XPO
    // It should have the same properties as the ApplicationUser
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class XpoApplicationUser : XpoDxUser
    {
        public XpoApplicationUser(Session session) : base(session)
        {
        }
    }

    [MapInheritance(MapInheritanceType.ParentTable)]
    public class XpoApplicationRole : XpoDxRole
    {
        public XpoApplicationRole(Session session) : base(session)
        {
        }
    }

}
