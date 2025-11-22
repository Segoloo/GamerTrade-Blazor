namespace BlazorShop.Web.Pages.Public
{
    public partial class FAQ
    {
        private List<FaqItem> FAQs = new()
                                         {
                                             new FaqItem
                                                 {
                                                     Question = "¿Cómo puedo rastrear mi pedido?",
                                                     Answer =
                                                         "Puedes rastrear tu pedido en la sección 'Pedidos' después de iniciar sesión en tu cuenta."
                                                 },
                                             new FaqItem
                                                 {
                                                     Question = "¿Cuál es la política de devoluciones?",
                                                     Answer =
                                                         "Ofrecemos una política de devolución de 30 días para la mayoría de los productos. Por favor revisa nuestra sección 'Devoluciones' para más detalles."
                                                 },
                                             new FaqItem
                                                 {
                                                     Question = "¿Cómo puedo contactar al servicio al cliente?",
                                                     Answer =
                                                         "Puedes contactarnos en soporte@gamertrade.com o llamarnos al +57 123-456-7890."
                                                 },
                                             new FaqItem
                                                 {
                                                     Question = "¿Qué métodos de pago aceptan?",
                                                     Answer =
                                                         "Aceptamos todas las tarjetas de crédito principales, PayPal y transferencias bancarias."
                                                 },
                                             new FaqItem
                                                 {
                                                     Question = "¿Cuánto tiempo tarda el envío?",
                                                     Answer =
                                                         "El envío generalmente toma 5-7 días hábiles para pedidos nacionales. Los tiempos de envío internacional varían."
                                                 }
                                         };

        private class FaqItem
        {
            public required string Question { get; set; }

            public required string Answer { get; set; }
        }
    }
}