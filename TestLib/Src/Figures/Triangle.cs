using TestLib.Interfaces;

namespace TestLib.Src.Figures
{
    /// <summary>
    /// Примитив треугольник
    /// </summary>
    public class Triangle : IFigureWithArea
    {
        private float _a;
        /// <summary>
        /// Сторона A
        /// </summary>
        public float A
        {
            get
            {
                return _a;
            }
            set
            {
                if (value > 0) _a = value;
                else throw new ArgumentException();
            }
        }

        private float _b;
        /// <summary>
        /// Сторона A
        /// </summary>
        public float B
        {
            get
            {
                return _b;
            }
            set
            {
                if (value > 0) _b = value;
                else throw new ArgumentException();
            }
        }

        private float _c;
        /// <summary>
        /// Сторона A
        /// </summary>
        public float C
        {
            get
            {
                return _c;
            }
            set
            {
                if (value > 0) _c = value;
                else throw new ArgumentException();
            }
        }

        public float GetArea()
        {
            var half_perim = (A + B + C) / 2;
            var square = Math.Sqrt(half_perim * (half_perim - A) * (half_perim - B) * (half_perim - C));

            return (float)square;
        }

        /// <summary>
        /// Возвращает true если треугольник прямоугольный
        /// </summary>
        /// <returns>true, в случае если прямоугольный, иначе false</returns>
        public bool IsRightTriangle()
        {
            var check_1 = C * C == A * A + B * B;
            var check_2 = A * A == C * C + B * B;
            var check_3 = B * B == C * C + A * A;

            return check_1 || check_2 || check_3;
        }
    }
}
