
			using System;
			using System.IO;
			using System.Collections.Generic;
			using System.Linq;
			using System.Text;
			using System.Web;
			using System.Web.Mvc;
			using System.Reflection;
			using runnerDotNet;
			namespace runnerDotNet
			{
				public static partial class SecuritySettings_class
				{
					static public XVar settings()
					{
						return new XVar( "providers", XVar.Array(),
"sessionControl", new XVar( "lifeTime", 15,
"sessionName", "p0VoWnQS7qAgqhL6aHJf",
"JWTSecret", "0XYrr8e3DvuyaE07hL9z" ),
"registration", new XVar( "passwordValidation", new XVar( "strong", false,
"minimumLength", 8,
"uniqueCharacters", 4,
"digitsAndSymbols", 2,
"upperAndLowerCase", false ),
"remindMethod", 0,
"hashAlgorithm", 0,
"registerPage", false ),
"captchaSettings", new XVar( "captchaType", 0,
"siteKey", "",
"secretKey", "",
"passesCount", 5 ),
"emailSettings", new XVar( "fromEmail", "",
"usePHPDefinedSMTP", false,
"useBuiltInMailer", false,
"SMTPServer", "localhost",
"SMTPPort", 25,
"SMTPUser", "",
"SMTPPassword", "",
"securityProtocol", 0 ),
"advancedSecurity", new XVar( "allowGuestLogin", false ),
"auditAndLocking", new XVar( "loggingTable", new XVar( "connId", "",
"table", "" ),
"lockingTable", new XVar( "connId", "",
"table", "" ),
"tables", new XVar(  ),
"loggingMode", 0,
"loggingFile", "audit.log",
"logSecurityActions", false,
"lockAfterUnsuccessfulLogin", false,
"enableLocking", false ),
"twoFactorSettings", new XVar( "available", false,
"required", false,
"enable", true,
"remember", true,
"types", new XVar(  ),
"twoFactorField", "",
"emailField", "",
"phoneField", "",
"codeField", "",
"projectName", "" ),
"projectName", "GPMS",
"loginDataSource", "",
"loginForm", 3,
"dynamicPermissions", false,
"dpTablePrefix", "",
"dpTableConnId", "",
"hardcodedLogin", false,
"enabled", false,
"advancedSecurityAvailable", false,
"userGroupsAvailable", false,
"adOnlyLogin", false,
"adAdminGroups", XVar.Array(),
"showUserSource", false,
"dbProviderCodes", XVar.Array(),
"notifications", new XVar(  ) );
					}
				}
			}