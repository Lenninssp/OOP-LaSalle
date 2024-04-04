using System.Text.Json.Serialization;

namespace CounterApp.bus
{
    [Serializable]
    public class ModuloNCounter : Counter
    {
        int maxLimit;

        public int MaxLimit
        {
            get{ return maxLimit; }
            set{ maxLimit = value; }
        }

        public ModuloNCounter() : base()
        {
            this.maxLimit = 0;
        }

        public ModuloNCounter(int serial, int value, EnumColor color, Date date, EnumCounterType type, int maxLimit)
            : base(serial, value, color, date, type)
        {
            this.maxLimit = maxLimit;
        }

        public string GetState()
        {
            return $"{base.GetState()} {maxLimit}";
        }
    }
}