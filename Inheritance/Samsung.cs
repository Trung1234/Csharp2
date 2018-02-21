

 class Samsung : Smartphone // derived class
    {
        public Samsung () {
            this.OS = "Android";
        }
        // public override void Call () {
        //     System.Console.WriteLine("Calling with Samsung....");
        // }
        public override void Text () {
            System.Console.WriteLine("Texting with Samsung....");
        }
        public override void Camera () {
            System.Console.WriteLine("Taking photos with Samsung ....");
        }
        public void SamsungHealth () {
            System.Console.WriteLine("Using Samsung Health App...");
        }
    }