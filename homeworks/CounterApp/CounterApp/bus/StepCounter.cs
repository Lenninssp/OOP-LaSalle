using System;

namespace CounterApp.bus
{
    [Serializable]
    public class StepCounter : Counter
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

        public string GetState()
        {
            return $"{base.GetState()} {steps}";
        }
    }
}
