using Android.BillingClient.Api;
using System.Collections.Generic;

namespace DeepSound.PaymentGoogle
{
    public static class InAppBillingGoogle
    {
        public static readonly string ProductId = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAnST2CAGvmxqp9zvuDlEk8vg3sclE/ATtXHnvyDprvKH/bTkIXka29a8BQXvdrcAcTgay7Ta7puJPMk9IdFNwZc3QeZzP0bY8lX7F/u++e33YMqVl5/4JgZ3IpjfMPwuwvZiO5ML8gc96lAoaBbJ6La2RGWHevziwuxJj1cACcOQF6bI3FoW9BPBP8BDMVDd+noTpbn0pIzmP4WsOmMVRbxleMRw+0p2n351McGFhIO0lXHPCuKG+VI5e7A0042BrbNYJvzIL2oSQrKH06jr0t/D1LtoXiBSXy4hCGIhPVj2ccce956yzTQv/EEBsCLjsb3vaZZvCb02R2FjpYP2ERwIDAQAB";
        public const string Membership = "membership";

        public static readonly List<QueryProductDetailsParams.Product> ListProductSku = new List<QueryProductDetailsParams.Product> // ID Product
        {
            //All products should be of the same product type.
            QueryProductDetailsParams.Product.NewBuilder().SetProductId(Membership).SetProductType(BillingClient.ProductType.Inapp).Build(),
        };
    }
}