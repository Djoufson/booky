using Basket.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Basket.API.Infrastructure.Configurations;

internal class CustomerBasketConfigurations : IEntityTypeConfiguration<CustomerBasket>
{
    public void Configure(EntityTypeBuilder<CustomerBasket> builder)
    {
        // builder.OwnsMany(c => c.Items, cib =>
        // {
        //     cib.WithOwner();
        // });
        builder
            .Navigation(c => c.Items)
            .AutoInclude();
    }
}
