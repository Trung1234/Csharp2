

class IPhone : Smartphone
    {
        public IPhone () {
            this.OS = "iOS";
        }
        public override void Call () {
            System.Console.WriteLine("Calling with Iphone....");
        }
        public override void Text () {
            System.Console.WriteLine("Texting with Iphone....");
        }
        public override void Camera () {
            System.Console.WriteLine("Taking photos with Iphone ....");
        }
        public void Siri () {
            System.Console.WriteLine("Using Siri....");
        }
    }