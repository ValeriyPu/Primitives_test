using TestLib.Interfaces;

namespace TestLib.Src.Figures
{
    /// <summary>
    /// Примитив Круг
    /// </summary>
    public class Round : IFigureWithArea
    {
        private float _r;

        /// <summary>
        /// Радиус круга
        /// </summary>
        public float R
        {
            get
            {
                return _r;
            }
            set
            {
                if (value > 0) _r = value;
                else throw new ArgumentException();
            }
        }

        public float GetArea()
        {
            return (float)(2 * Math.PI * R);
        }
    }
}
