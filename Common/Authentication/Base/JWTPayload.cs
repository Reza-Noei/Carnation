//using System;
//using System.Collections.Generic;
//using System.IdentityModel.Tokens.Jwt;
//using System.Text;

//namespace Common.Authentication.Base
//{
//    public class JWTPayload : JwtPayload
//    {
//        private const string ConstUserId = "ud";
//        private const string ConstExpire = "exp";
//        private const string ConstIssuer = "iss";

//        public long UserId
//        {
//            get
//            {
//                long userId;
//                long.TryParse(base[ConstUserId].ToString(), out userId);
//                return userId;
//            }

//            set
//            {
//                base[ConstUserId] = value;
//            }

//        }

//        public JWTPayload(long userId) : base("Mobayyen.WebApi", string.Empty, null, DateTime.UtcNow, DateTime.UtcNow.AddMinutes(JsonWebTokenSetting.LifeTime))
//        {
//            this[ConstUserId] = userId;
//        }

//        public JWTPayload(JwtPayload token)
//        {
//            this[ConstUserId] = token[ConstUserId];
//            this[ConstUserDisplayName] = token[ConstUserDisplayName];
//            this[ConstOrganizationTitle] = token[ConstOrganizationTitle];
//            this[ConstOrganizationId] = token[ConstOrganizationId];
//            this[ConstRole] = token[ConstRole];
//            this[ConstRoleId] = token[ConstRoleId];
//            this[ConstUserType] = token[ConstUserType];
//            this[ConstRoleUserId] = token[ConstRoleUserId];

//            this[ConstNotValidBefore] = token[ConstNotValidBefore];
//            this[ConstExpire] = token[ConstExpire];
//            this[ConstIssuer] = token[ConstIssuer];
//        }
//    }
//}
