using System;

namespace CounterApp.bus
{
    [Serializable]
    public abstract class StepCounter : Counter
    {
        private int steps;

        public int Steps
        {
            get { return steps; }
            set { steps = value; }
        }

        public StepCounter() : base()
        {
            this.steps = 0;
        }

        public StepCounter(int serial, int value, EnumColor color, Date date, EnumCounterType type, int steps)
            : base(serial, value, color, date, type)
        {
            this.steps = steps;
        }

        public override string GetState()
        {
            string state;
            state = base.GetState() + " | " + this.steps;
            return state;
        }

        public override void Increment()
        {
            this.Vaalue = this.Vaalue + 1;
        }
        public override void Increment(int value)
        {
            this.Vaalue = this.Vaalue + value;
        }

        public override void Decrement(int value)
        {
            this.Vaalue = this.Vaalue - value;
        }
        public override void Decrement()
        {
            this.Vaalue = this.Vaalue - 1;
        }
    }
}
