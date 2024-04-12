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

        public ModuloNCounter(int serial, int Vaalue, EnumColor color, Date date, EnumCounterType type, int maxLimit)
            : base(serial, Vaalue, color, date, type)
        {
            this.maxLimit = maxLimit;
        }

        public override string GetState()
        {
            string state;
            state = base.GetState() + " | " + this.maxLimit;
            return state;
        }


        public override void Reset()
        {
            this.Vaalue = 1;
        }

        public override void Increment()
        {
            this.Vaalue = this.Vaalue + 2;
        }
        public override void Increment(int Vaalue)
        {
            this.Vaalue = this.Vaalue + Vaalue;
        }

        public override void Decrement()
        {
            this.Vaalue = this.Vaalue - 2;
        }
        public override void Decrement(int value)
        {
            this.Vaalue = this.Vaalue - value;
        }
    }
}