using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1Api.Models;

namespace Lab1Api.Services
{
    public interface ICalculator
    {
        double Calculate(CalculateData calculateData);

        Task<double> CalculateAsync(CalculateData calculateData);
    }
}
