﻿using Bookstore.Customer.ViewModel.Checkout;
using Bookstore.Domain.Customers;
using System.Collections.Generic;
using System.Linq;

namespace Bookstore.Customer.Mappers
{
    public static class AddressToShoppingCartCheckoutAddressViewModelMapper
    {
        public static List<CheckoutAddressViewModel> ToShoppingCartCheckoutAddressViewModels(this IEnumerable<Address> addresses)
        {
            return addresses.Select(x => new CheckoutAddressViewModel
            {
                Id = x.Id,
                AddressLine1= x.AddressLine1,
                AddressLine2= x.AddressLine2,
                City= x.City,
                Country= x.Country,
                IsPrimary= x.IsPrimary,
                State= x.State,
                ZipCode = x.ZipCode
            }).ToList();
        }
    }
}
