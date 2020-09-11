using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public double average;
        public double min;
        public double max;
        public Stats(double average, double min, double max)
        {
            this.average = average;
            this.min = min;
            this.max = max;
        }
    }
    
    public class StatsComputer
    {
        double getAverage(List<double> numbers)
        {
            if (numbers.Count == 0)
                return Double.NaN;
            else
                return (numbers.AsQueryable().Sum() / numbers.Count);
        }

        double getMin(List<double> numbers)
        {
            numbers.Sort();
            if (numbers.Count != 0)
            {
                return numbers[0];
            }
            return Double.NaN;
        }

        double getMax(List<double> numbers)
        {
            numbers.Sort();
            if (numbers.Count!=0)
            {
                return numbers[numbers.Count- 1];
            }
            return Double.NaN;
        }
        
        public Stats CalculateStatistics(List<double> numbers) {
            Stats stats = new Stats(getAverage(numbers), getMin(numbers), getMax(numbers));
            return stats;
        }
    }
}
