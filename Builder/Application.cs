using Builder.Models;
using System;

namespace Builder
{
    internal class Application
    {
        internal static void Main(string[] args)
        {
            // Let's imagine that we got this data from UI client on our station
            string id = Guid.NewGuid().ToString();
            Company sender = new Company()
            {
                Id = new Random().Next(53) + 1,
                Name = "Super Company",
                Location = "Chernivtsi"
            };
            Company receiver = new Company()
            {
                Id = new Random().Next(53) + 1,
                Name = "Mega Company",
                Location = "Khmelnytskyi"
            };
            FreightType freightType = FreightType.Simple;
            double weight = 13.4;
            double volume = 5.2;
            string description = "Some sort of description.";
            DateTime dispatchedAt = DateTime.Now;

            // So now we gonna build some objects
            FreightBuilder builder1 = new FreightBuilder();
            FreightDetailsBuilder builder2 = new FreightDetailsBuilder();

            builder1.SetId(id)
                    .SetSender(sender)
                    .SetReceiver(receiver)
                    .SetFreightType(freightType)
                    .SetWeight(weight)
                    .SetVolume(volume)
                    .SetDescription(description)
                    .SetDispatchedAt(dispatchedAt);

            builder2.SetId(id)
                    .SetSender(sender)
                    .SetReceiver(receiver)
                    .SetFreightType(freightType)
                    .SetWeight(weight)
                    .SetVolume(volume)
                    .SetDescription(description)
                    .SetDispatchedAt(dispatchedAt);

            Console.WriteLine(builder1.Build());
            Console.WriteLine(builder2.Build());
        }
    }
}
