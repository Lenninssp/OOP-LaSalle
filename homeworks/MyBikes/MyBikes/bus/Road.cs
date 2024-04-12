using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    public class Road : Bike
    {
        //Fields
        private double seatHeight;

        //Public Property
        public double SeatHeight
        {
            get { return seatHeight; }
            set { seatHeight = value; }
        }

        //Methods
        //The following functions (Methods) are known as functions overloading

        //This is a STATIC POLYMORPHISM known as compile-time polymorphism (each overloaded function has to behave according to the recieving arguments)

        //Public Default Constructor (with parameters)
        public Road() : base()
        {
            this.seatHeight = 0.0;
        }

        public Road(int serialNumber, int made, string model, int speed, double wheelSize) : base(serialNumber, made, model, speed, wheelSize)
        {
            this.seatHeight = 0.0;
        }

        public Road(int serialNumber, int made, string model, int speed, double wheelSize, EnumFrameType frameType) : base(serialNumber, made, model, speed, wheelSize, frameType)
        {
            this.seatHeight = 0.0;
        }

        public Road(int serialNumber, int made, string model, int speed, double wheelSize, EnumFrameType frameType, Date madeDate) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate)
        {
            this.seatHeight = 0.0;
        }

        public Road(int serialNumber, int made, string model, int speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color)
        {
            this.seatHeight = 0.0;
        }

        public Road(int serialNumber, int made, string model, int speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color, EnumType type) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color, type)
        {
            this.seatHeight = 0.0;
        }

        public Road(int serialNumber, int made, string model, int speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color, EnumType type, double seatHeight) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color, type)
        {
            this.seatHeight = seatHeight;
        }

        // - 2: Methods
        //The following functions (Methods) are known as functions overriding
        //We have many overridden functions

        //This is a DYNAMIC POLYMORPHISM (known as run-time polymorphism)
        //Run-time means execution time
        public override string GetState()
        {
            string state;
            state = base.GetState() + " | " + "Seat Height: " + this.seatHeight;
            return state;
        }
    }
}
