using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Statistics
    {
        public static double Average( double[] x )
        {
            return ( Sum( x ) / x.Length );
        }

        public static double Average( int[] x )
        {
            return ( Sum( x ) / x.Length );
        }

        public static double Sum( double[] x )
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum;
        }

        public static int Sum( int[] x )
        {
            int sum = 0;
            for(int i=0;i<x.Length;i++)
            {
                sum += x[i];
            }
            return sum;
        }

        public static double[] AscendingOrder( double[] x )
        {
            while( !JudgeAscendingOrder( x ) )
            {
                for(int i=0;i<(x.Length-1);i++)
                {
                    if( x[i] > x[i+1] )
                    {
                        double z = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = z;
                    }
                }
            }
            return x;
        }

        public static int[] AscendingOrder( int[] x )
        {
            while ( !JudgeAscendingOrder( x ) )
            {
                for (int i = 0; i < (x.Length - 1); i++)
                {
                    if (x[i] > x[i + 1])
                    {
                        int z = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = z;
                    }
                }
            }
            return x;
        }

        public static double[] DescendingOrder( double[] x )
        {
            while( !JudgeDescendingOrder( x ) )
            {
                for(int i=0;i<(x.Length-1);i++)
                {
                    if(x[i] < x[i+1])
                    {
                        double z = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = z;
                    }
                }
            }
            return x;
        }

        public static int[] DescendingOrder( int[] x )
        {
            while( !JudgeDescendingOrder( x ) )
            {
                for(int i=0;i<(x.Length-1);i++)
                {
                    int z = x[i];
                    x[i] = x[i + 1];
                    x[i + 1] = z;
                }
            }
            return x;
        }

        public static double Dispersion( double[] x )
        {
            int n = x.Length;
            double ave = Average( x );
            double z = 0;
            for(int i=0;i<x.Length;i++)
            {
                z += (x[i] - ave) * (x[i] - ave);
            }
            return z / n;
        }

        public static double Dispersion( int[] x )
        {
            int n = x.Length;
            double ave = Average( x );
            double z = 0;
            for(int i=0;i<x.Length;i++)
            {
                z += (x[i] - ave) * (x[i] - ave);
            }
            return z / n;
        }

        public static double FirstQuartile( double[] x )
        {
            int n = x.Length;
            double[] y;
            if( n%2 == 0 )
            {
                y = new double[x.Length/2];
            }
            else
            {
                y = new double[(x.Length-1)/2];
            }
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = x[i];
            }
            return Median( y );
        }

        public static double FirstQuartile( int[] x )
        {
            int n = x.Length;
            int[] y;
            if( n%2 == 0 )
            {
                y = new int[x.Length/2];
            }
            else
            {
                y = new int[(x.Length - 1) / 2];
            }
            for(int i=0;i<y.Length;i++)
            {
                y[i] = x[i];
            }
            return Median( y );
        }

        public static double ThirdQuartile( double[] x )
        {
            int n = x.Length;
            double[] y;
            if( n%2 == 0 )
            {
                y = new double[x.Length/2];
            }
            else
            {
                y = new double[(x.Length-1)/2];
            }
            int m = x.Length - y.Length;
            int count = 0;
            for(int i=m;i<y.Length;i++)
            {
                y[count] = x[i];
                count++;
            }
            return Median( y );
        }

        public static double ThirdQuartile( int[] x )
        {
            int n = x.Length;
            int[] y;
            if( n%2 == 0 )
            {
                y = new int[x.Length/2];
            }
            else
            {
                y = new int[(x.Length - 1) / 2];
            }
            int m = x.Length - y.Length;
            int count = 0;
            for(int i=m;i<x.Length;i++)
            {
                y[count] = x[i];
                count++;
            }
            return Median( y );
        }

        private static bool JudgeAscendingOrder( double[] x )
        {
            bool b = true;
            for(int i=0;i<(x.Length-1);i++)
            {
                if( x[i] > x[i+1] )
                {
                    b = false;
                    break;
                }
            }
            return b;
        }

        private static bool JudgeAscendingOrder( int[] x ) 
        {
            bool b = true;
            for (int i = 0; i < (x.Length - 1); i++)
            {
                if (x[i] > x[i + 1])
                {
                    b = false;
                    break;
                }
            }
            return b;
        }

        private static bool JudgeDescendingOrder( double[] x )
        {
            bool b = true;
            for(int i=0;i<(x.Length-1);i++)
            {
                if(x[i] < x[i+1])
                {
                    b = false;
                    break;
                }
            }
            return b;
        }

        private static bool JudgeDescendingOrder( int[] x )
        {
            bool b = true;
            for(int i=0;i<(x.Length-1);i++)
            {
                if(x[i] < x[i+1])
                {
                    b = false;
                    break;
                }
            }
            return b;
        }

        public static double Median( double[] x )
        {
            int n = x.Length;
            x = AscendingOrder( x );
            if( n%2 == 0 )
            {
                n = (n / 2) - 1;
                return ( x[n] + x[n+1] ) / 2;
            }
            else
            {
                n = (n - 1) / 2;
                return x[n];
            }
        }

        public static int Median( int[] x )
        {
            int n = x.Length;
            x = AscendingOrder( x );
            if( n%2 == 0 )
            {
                n = (n / 2) - 1;
                return ( x[n] + x[n+1] ) / 2;
            }
            else
            {
                n = (n - 1) / 2;
                return x[n];
            }
        }

        public static double[] Mode( double[] x )
        {
            List<double> list = new List<double>();
            x = AscendingOrder( x );
            double number;
            int maxCount = 0;
            for(int i=0;i<x.Length;i++)
            {
                int count = 0;
                number = x[i];
                for(int w=i;w<x.Length;w++)
                {
                    if(number == x[w])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if( count >= maxCount )
                {
                    if(count > maxCount)
                    {
                        list.Clear();
                    }
                    list.Add( number );
                    maxCount = count;
                }
            }
            double[] mode = new double[list.Count];
            int modeCount = 0;
            foreach( double n in list )
            {
                mode[modeCount] = n;
                modeCount++;
            }
            return mode;
        }

        public static int[] Mode( int[] x )
        {
            List<int> list = new List<int>();
            x = AscendingOrder( x );
            int number;
            int maxCount = 0;
            for(int i=0;i<x.Length;i++)
            {
                int count = 0;
                number = x[i];
                for(int w=i;w<x.Length;w++)
                {
                    if(number == x[w])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if( count >= maxCount )
                {
                    if(count > maxCount)
                    {
                        list.Clear();
                    }
                    list.Add( number );
                    maxCount = count;
                }
            }
            int[] mode = new int[list.Count];
            int modeCount = 0;
            foreach ( int n in list )
            {
                mode[modeCount] = n;
                modeCount++;
            }
            return mode;
        }

        public static void PrintArray( double[] x )
        {
            for(int i=0;i<x.Length;i++)
            {
                Console.Write( x[i] + " " );
            }
            Console.Write( "\n" );
        }

        public static void PrintArray( int[] x )
        {
            for(int i=0;i<x.Length;i++)
            {
                Console.Write( x[i] + " " );
            }
            Console.Write( "\n" );
        }

        public static double StandardDeviation( double[] x )
        {
            return Math.Sqrt( Dispersion( x ) );
        }

        public static double StandardDeviation( int[] x )
        {
            return Math.Sqrt( Dispersion( x ) );
        }
    }
}
