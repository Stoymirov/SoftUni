using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking;

public class Car
{


    public Car(string make, string model, int horsePower, string registration)
    {
        Make = make;
        Model = model;
        HorsePower = horsePower;
        RegistrationNumber = registration;
    }


    public string Make { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
    public string RegistrationNumber { get; set; }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Make: {Make}");
        sb.AppendLine($"Model: {Model}");
        sb.AppendLine($"HorsePower: {HorsePower}");
        sb.AppendLine($"RegistrationNumber: {RegistrationNumber}");
        return sb.ToString().TrimEnd();
    }
}


