﻿using System.Collections.Generic;
using Application.Common.Constants;
using IdentityServer4;
using IdentityServer4.Models;

namespace IdentityService
{
    public class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("main.read_write", "Full access to microservice")
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {
                new ApiResource()
                {
                    Name = "document_service",
                    DisplayName = "Document service",
                    Description = "Full access to Document Service",
                    ApiSecrets = { new Secret(AppSettingConstants.IdentityServer.ApiSecret.Sha256()) },
                    Enabled = true,
                    Scopes = { "main.read_write" },
                }
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = AppSettingConstants.IdentityServer.ClientId,
                    AllowedGrantTypes = new List<string> { GrantType.ClientCredentials, GrantType.ResourceOwnerPassword},
                    ClientSecrets = { new Secret (AppSettingConstants.IdentityServer.ClientSecret.Sha256()) },
                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.OfflineAccess,
                        "main.read_write" },
                    AllowOfflineAccess = true,
                    RequireClientSecret = true,
                }
            };
    }
}
