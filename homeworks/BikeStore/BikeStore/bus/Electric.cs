﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    public class Electric : Bike
    {
        //Fields
        private int batteryIndicator;

        //Properties
        public int BatteryIndicator
        {
            get { return this.batteryIndicator; }
            set { this.batteryIndicator = value; }
        }

        //Public Default Constructor (with parameters)
        //Methods
        //The following functions (Methods) are known as functions overloading

        //This is a STATIC POLYMORPHISM known as compile-time polymorphism (each overloaded function has to behave according to the recieving arguments)

        //Public Default Constructor (with parameters)
        public Electric() : base()
        {
            this.batteryIndicator = 0;
        }

        public Electric(int serialNumber, int made, string model, int speed, double wheelSize) : base(serialNumber, made, model, speed, wheelSize)
        {
            this.batteryIndicator = 0;
        }

        public Electric(int serialNumber, int made, string model, int speed, double wheelSize, EnumFrameType frameType) : base(serialNumber, made, model, speed, wheelSize, frameType)
        {
            this.batteryIndicator = 0;
        }

        public Electric(int serialNumber, int made, string model, int speed, double wheelSize, EnumFrameType frameType, Date madeDate) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate)
        {
            this.batteryIndicator = 0;
        }

        public Electric(int serialNumber, int made, string model, int speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color)
        {
            this.batteryIndicator = 0;
        }

        public Electric(int serialNumber, int made, string model, int speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color, EnumType type) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color, type)
        {
            this.batteryIndicator = 0;
        }

        public Electric(int serialNumber, int made, string model, int speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color, EnumType type, int batteryIndicator) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color, type)
        {
            this.batteryIndicator = batteryIndicator;
        }

        // - 2: Methods
        //The following functions (Methods) are known as functions overriding
        //We have many overridden functions

        //This is a DYNAMIC POLYMORPHISM (known as run-time polymorphism)
        //Run-time means execution time
        public override string GetState()
        {
            string state;
            state = base.GetState() + " | " + "Battery: " + this.batteryIndicator + "% ";
            return state; 
        }
    }
}
