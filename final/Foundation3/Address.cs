using System;

class Address {
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    

    public Address(string street, string city, string state, string country) {
        _streetAddress = street;
        _city = city;
        _stateProvince = state;
        _country = country;

    }

    public string FullAddress() {
        return _streetAddress + ", " + _city + ", " + _stateProvince + ", " + _country;
    }
}