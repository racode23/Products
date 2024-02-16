using Products.Models;

namespace Products.Data
{
    public class AppDbInitilizer
    {
        public static void Seed(IApplicationBuilder applicationBuilder ) {

            using (var serviseScope = applicationBuilder.ApplicationServices.CreateScope()) {

                var context = serviseScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Products.Any()) {

                    context.Products.AddRange(
                        
                    new Product()
                    {
                        
                        name = "Fanta",

                        price = 100


                    },

                    new Product()
                    {
                       
                        name = "cocacola",

                        price = 200


                    },


                    new Product()
                    {
                        
                        name = "Sprite",

                        price = 150


                    }) ;
                    context.SaveChanges();

                }
            }
        
        }

        internal static void seed(WebApplication app)
        {
            throw new NotImplementedException();
        }
    }
}
