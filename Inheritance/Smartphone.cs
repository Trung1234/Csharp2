

class Smartphone // base class
    {
        public string Name { get; set; }
        public string OS { get; set; }
        public string SerialNumber { get; set; }

        public virtual void Call () {
            System.Console.WriteLine("Calling....");
        }
        public virtual void Text () {
            System.Console.WriteLine("Texting....");
        }
        public virtual void Camera () {
            System.Console.WriteLine("Taking photos....");
        }
    }