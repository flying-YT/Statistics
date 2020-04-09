using System;
namespace Statistics
{
    public class StatisticsCalculation
    {
        private double[] dataArray;
        public double Sum { set; get; }
        public double Average { set; get; }
        public double Dispersion { set; get; }
        public double StandardDeviation { set; get; }

        public void AverageCalculation()
        {
            if(Sum == 0)
            {
                SumCalculation();
            }
            Average = Sum / dataArray.Length;
        }

        public double DeviationValueCalculation( double x )
        {
            if(StandardDeviation == 0)
            {
                StandardDeviationCalculation();
            }
            return ((x - Average)/StandardDeviation*10+50);
        }

        public void DispersionCalculation()
        {
            if(Average == 0)
            {
                AverageCalculation();
            }
            double n = 0;
            for (int i = 0; i < dataArray.Length; i++)
            {
                n += (dataArray[i] - Average) * (dataArray[i] - Average);
            }
            Dispersion = n / dataArray.Length;
        }

        public double Median()
        {
            double n = 0;
            int centerNumber = dataArray.Length / 2;
            if ( dataArray.Length%2 == 0)
            {
                n = (dataArray[centerNumber] + dataArray[centerNumber])/2;
            }
            else
            {
                n = dataArray[centerNumber];
            }
            return n;
        }

        public double Mode()
        {
            double modeNumber = 0;
            int maxCount = 0;
            int start = 0;
            for(int i=start;i<dataArray.Length;i++)
            {
                int count = 0;
                double n = dataArray[i];
                for(int w=(i+1);w<dataArray.Length;w++)
                {
                    if(n == dataArray[w])
                    {
                        count++;
                    }
                    else
                    {
                        start = w;
                        break;
                    }
                }
                if(maxCount < count)
                {
                    modeNumber = dataArray[i];
                    maxCount = count;
                }
            }
            return modeNumber;
        }

        public void ResetData()
        {
            dataArray = null;
            Sum = 0;
            Average = 0;
            Dispersion = 0;
            StandardDeviation = 0;
        }

        public void SetDataArray( double[] x )
        {
            ResetData();
            dataArray = x;
            Array.Sort(dataArray);
        }

        public void StandardDeviationCalculation()
        {
            if(Dispersion == 0)
            {
                DispersionCalculation();
            }
            StandardDeviation = Math.Sqrt( Dispersion );
        }

        public void SumCalculation()
        {
            if(Sum == 0)
            {
                for (int i = 0; i < dataArray.Length; i++)
                {
                    Sum += dataArray[i];
                }
            }
        }

        public StatisticsCalculation( double[] x )
        {
            dataArray = x;
            Array.Sort(dataArray);
        }
    }
}
