


 class Samsung : Smartphone // derived class
    {
        private string name;
        public Samsung (string name) {
            this.name  = name;
        }
        public  void Call () {
            System.Console.WriteLine("Calling with Samsung....");
        }
        public  void Text () {
            System.Console.WriteLine("Texting with Samsung....");
        }
        public void Camera () {
            System.Console.WriteLine("Taking photos with Samsung ....");
        }
        // public void SamsungHealth () {
        //     System.Console.WriteLine("Using Samsung Health App...");
        // }
    }