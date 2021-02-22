using DevExpress.Xpo;
using DX.Data.Xpo.Identity.Persistent;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DX.Data.Xpo.Identity
{
    public class XPUserManager<TUser, TXPOUser, TXPORole> : UserManager<TUser>
        where TUser : class, IXPUser<string>, new()
        where TXPOUser : XPBaseObject, IXPUser<string>
        where TXPORole : XpoDxRole, IXPRole<string>
    {
        //private XPUserStore<TUser> _store = null;
        private XPUserStore<string, TUser, TXPOUser, TXPORole, XpoDxUserLogin, XpoDxUserClaim, XpoDxUserToken> _store = null;

        public XPUserManager(IUserStore<TUser> store, IOptions<IdentityOptions> optionsAccessor,
        IPasswordHasher<TUser> passwordHasher,
        IEnumerable<IUserValidator<TUser>> userValidators,
        IEnumerable<IPasswordValidator<TUser>> passwordValidators, ILookupNormalizer keyNormalizer,
        IdentityErrorDescriber errors, IServiceProvider services, ILogger<XPUserManager<TUser, TXPOUser, TXPORole>> logger)
        : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            _store = (XPUserStore<string, TUser, TXPOUser, TXPORole, XpoDxUserLogin, XpoDxUserClaim, XpoDxUserToken>)store;
        }

        public Task AddToAlienRoleAsync(TUser user, string roleName, int alienID)
        {
            return _store.AddToAlienRoleAsync(user, roleName.ToUpper(), alienID);
        }

        public Task<IList<int>> GetAliensAsync(TUser user)
        {
            return _store.GetAliensAsync(user);
        }

        public Task<IList<int>> GetAliensAsync(TUser user, string roleName)
        {
            return _store.GetAliensAsync(user, roleName.ToUpper());
        }

        public Task<IList<string>> GetAlienRolesAsync(TUser user, int alienID)
        {
            return _store.GetAlienRolesAsync(user, alienID);
        }

        public Task<IList<TUser>> GetAlienUsersInRoleAsync(string roleName, int alienID)
        {
            return _store.GetAlienUsersInRoleAsync(roleName.ToUpper(), alienID);
        }

        public Task<bool> IsInAlienRoleAsync(TUser user, string roleName, int alienID)
        {
            return _store.IsInAlienRoleAsync(user, roleName.ToUpper(), alienID);
        }

        public Task RemoveFromAlienRoleAsync(TUser user, string roleName, int alienID)
        {
            return _store.RemoveFromAlienRoleAsync(user, roleName.ToUpper(), alienID);
        }
    }
}
