﻿namespace elshaday_test_api.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string? City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string? Country { get; set; }
        public int PersonId { get; set; }
        public Person? Person { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
