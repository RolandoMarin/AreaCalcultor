namespace MarinAreaCalculator
{
    //my class library
    public class AreaCalc
    {
        private int multiplying_two = 2;
        private double multiply_half = .5;
        private double _pi = 3.14;
        private int multiplying_100 = 4;

        public double getSquareArea(string width,string height)
        {
            //math broken down here in these methods
            int convertedWidth = stringConverter(width);
            int convertedHeight = stringConverter(height);
            return RoundNumber((double)convertedWidth * convertedHeight);
        }

        public double getSquareArea(int width,int height)
        {
            return RoundNumber((double)width * (double)height);
        }
        public double getRectangleArea(int width, int height)
        {
            return RoundNumber((double) width * height);
        }
        public double getTriangleArea(int baseValue,int height)
        {
            return RoundNumber((double)(multiply_half * baseValue * height));
        }
        public double getParrallelogramArea(int baseValue,int height)
        {
            return RoundNumber((double)baseValue * height);
        }
        public double getCircleRadius(int circumference)
        {
            return RoundNumber((double)circumference / multiplying_100);
        }
        public double getCircleDiameter(int circumference)
        {
            return RoundNumber((double)(circumference/multiplying_two*_pi)*multiplying_two);
        }

        private double RoundNumber(double roundn)
        {
          return Math.Round(roundn *multiplying_100/multiplying_100);
        }

        private int stringConverter(string num)
        {
          
            if(num == "one")
            {
                return 1;
            }
            else if (num == "two")
            {
                return 2;
            }
            else if (num == "three")
            {
                return 3;
            }
            else if (num == "four")
            {
                return 4;
            }
            else if (num == "five")
            {
                return 5;
            }
            else if (num == "six")
            {
                return 6;
            }
            else if (num == "seven")
            {
                return 7;
            }
            else if (num == "eight")
            {
                return 8;
            }
            else if (num == "nine")
            {
                return 9;
            }
            else if (num == "ten")
            {
                return 10;
            }
            else
            {
                return -1;
            }
        }
    }
}