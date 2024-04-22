// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace MultiShop.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
           new ApiResource("ResourceCatalog") { Scopes = {"CatalogFullPermission", "CatalogReadPermission"} },
           new ApiResource("ResourceDiscount") { Scopes = {"DiscountFullPermission"} },
           new ApiResource("ResourceOrder") { Scopes = {"OrderFullPermisson"} },
           new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
          new IdentityResources.OpenId(),
          new IdentityResources.Profile(),
          new IdentityResources.Email()
        };

        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            new ApiScope("CatalogFullPermission", "Katalog operasyonları için full yetki."),
            new ApiScope("CatalogReadPermission", "Katalog operasyonları için okuma yetkisi."),
            new ApiScope("DiscountFullPermission", "İndirim operasyonları için full yetki."),
            new ApiScope("OrderFullPermisson", "Sipariş operasyonları için full yetki."),
            new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<Client> Clients => new Client[]
        {
            //Visitor
            new Client
            {
                ClientId = "MultiShopVisitorId",
                ClientName = "Multi Shop Visitor User",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("multishopsecret".Sha256()) },
                AllowedScopes = { "CatalogReadPermission",  IdentityServerConstants.LocalApi.ScopeName },
                AllowAccessTokensViaBrowser = true
            },

            //Manager
            new Client
            {
                ClientId = "MultiShopManagerId",
                ClientName = "Multi Shop Manager User",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("multishopsecret".Sha256()) },
                AllowedScopes = { "CatalogReadPermission", "CatalogFullPermission",
                IdentityServerConstants.LocalApi.ScopeName,
                IdentityServerConstants.StandardScopes.Email,
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile }
            },

            //Admin
            new Client
            {
                ClientId = "MultiShopAdminId",
                ClientName = "Multi Shop Admin User",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("multishopsecret".Sha256()) },
                AllowedScopes = { "CatalogFullPermission", "CatalogReadPermission", "DiscountFullPermission", "OrderFullPermisson",
                IdentityServerConstants.LocalApi.ScopeName,
                IdentityServerConstants.StandardScopes.Email,
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile
                },
                AccessTokenLifetime = 600
            }
        };
    }
}