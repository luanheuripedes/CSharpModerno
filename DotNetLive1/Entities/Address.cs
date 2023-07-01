﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLive1.Entities
{
    public class Address
    {
        public Address()
        {
                
        }
        public Address(string street, string city, string state, string zipCode)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }


        public string GetFullAddress()
        {
            return $"Rua: {Street} - Cidade: {City} - Estado: {State} - CEP: {ZipCode}";
        }
    }
}
