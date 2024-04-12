using CountersFactory.bus;
using System.Text.Json.Serialization;

namespace CounterApp.bus
{
    [Serializable]
    public abstract class Counter : ICountable, IPrintable
    {
        private int serial;
        private int vaalue;
        private EnumColor color;
        private Date daate;
        private EnumCounterType type;
        private int count = 0;

        public int Serial
        {
            get { return serial; }
            set { serial = value; }
        }
        public int Vaalue
        {
            get { return vaalue; }
            set { vaalue = value; }
        }
        public EnumColor Color
        {
            get { return color; }
            set { color = value; }  
        }
        public Date Daate
        {
            get { return daate; }
            set { daate = value; }
        }

        public EnumCounterType Type
        {
            get { return type; }
            set {  type = value; }
        }

        public Counter()
        {
            this.serial = 0;
            this.vaalue = 0;
            this.color = EnumColor.NONE;
            this.daate = new Date();
            this.type = EnumCounterType.NONE;
        }
        public Counter(
            int serial, 
            int vaalue, 
            EnumColor color, 
            Date daate, 
            EnumCounterType type)
        {
            this.serial = serial;
            this.vaalue = vaalue;
            this.color = color;
            this.daate = daate;
            this.type = type;
        }

        public virtual string GetState()
        {
            return $"{serial} {vaalue} {color} {daate.getState()} {type}";
        }


        public virtual void Reset()
        {
            this.vaalue = 0;
        }
        public abstract void Increment();
        public abstract void Decrement();

        public abstract void Increment(int value);
        public abstract void Decrement(int value);

    }
}