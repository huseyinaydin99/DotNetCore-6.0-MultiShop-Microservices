using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace MultiShop.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
           new ApiResource("ResourceCatalog"){Scopes={"CatalogFullPermission","CatalogReadPermission"} },
           new ApiResource("ResourceDiscount"){Scopes={"DiscountFullPermission"} },
           new ApiResource("ResourceOrder"){Scopes={"OrderFullPermisson"}},
           new ApiResource("ResourceCargo"){Scopes={"CargoFullPermission"} },
           new ApiResource("ResourceBasket"){Scopes={"BasketFullPermission"} },
           new ApiResource("ResourceComment"){Scopes={"CommentFullPermission"} },
           new ApiResource("ResourcePayment"){Scopes={ "PaymentFullPermission" } },
           new ApiResource("ResourceImage"){Scopes={ "ImageFullPermission" } },
           new ApiResource("ResourceOcelot"){Scopes={"OcelotFullPermission"} },
           new ApiResource("ResourceMessage"){Scopes={"MessageFullPermission"} },
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
            new ApiScope("CargoFullPermission", "Kargo operasyonları için full yetki."),
            new ApiScope("BasketFullPermission", "Sepet operasyonları için full yetki."),
            new ApiScope("PaymentFullPermission","Ödeme operasyonları için full yetki."),
            new ApiScope("ImageFullPermission","Resim operasyonları için full yetki."),
            new ApiScope("MessageFullPermission","Mesaj operasyonları için full yetki."),
            new ApiScope("OcelotFullPermission","Ocelot APIGateway operasyonları için full yetki."),
            new ApiScope("CommentFullPermission","Comment APIGateway operasyonları için full yetki."),
            new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<Client> Clients => new Client[]
        {
            //Visitor
            new Client
            {
                ClientId="MultiShopVisitorId",
                ClientName="Multi Shop Visitor User",
                AllowedGrantTypes=GrantTypes.ClientCredentials,
                ClientSecrets={new Secret("multishopsecret".Sha256())},
                AllowedScopes={"CatalogReadPermission","CatalogFullPermission", "DiscountFullPermission","OcelotFullPermission","CommentFullPermission","ImageFullPermission", "CommentFullPermission",  IdentityServerConstants.LocalApi.ScopeName },
                AllowAccessTokensViaBrowser=true
            },

            //Manager
            new Client
            {
                ClientId="MultiShopManagerId",
                ClientName="Multi Shop Manager User",
                AllowedGrantTypes=GrantTypes.ResourceOwnerPassword,
                ClientSecrets={new Secret("multishopsecret".Sha256()) },
                AllowedScopes={ "CatalogReadPermission", "CatalogFullPermission", "BasketFullPermission", "OcelotFullPermission", "CommentFullPermission", "PaymentFullPermission", "ImageFullPermission","DiscountFullPermission","OrderFullPermisson","MessageFullPermission","CargoFullPermission",
                IdentityServerConstants.LocalApi.ScopeName,
                IdentityServerConstants.StandardScopes.Email,
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile }
            },

            //Admin
            new Client
            {
                ClientId="MultiShopAdminId",
                ClientName="Multi Shop Admin User",
                AllowedGrantTypes=GrantTypes.ResourceOwnerPassword,
                ClientSecrets={new Secret("multishopsecret".Sha256()) },
                AllowedScopes={ "CatalogFullPermission", "CatalogReadPermission", "DiscountFullPermission", "OrderFullPermisson","CargoFullPermission","BasketFullPermission","OcelotFullPermission","CommentFullPermission","PaymentFullPermission","ImageFullPermission","CargoFullPermission",
                IdentityServerConstants.LocalApi.ScopeName,
                IdentityServerConstants.StandardScopes.Email,
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile
                },
                AccessTokenLifetime=600
            }
        };
    }
}