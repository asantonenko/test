public abstract class Animal
    {
        private string name;
        public Animal()
        {
            name = "noname";
        }
        public Animal(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
        public abstract string talk();

    }



public class Cat: Animal
    {
        public Cat (): base () {}
        public Cat (string name): base (name) {}
        public override string talk()
        {
            return "Meow!";
        }
        public override string ToString()
        {
            return "Cat "+Name;
        }
    }


public class Dog: Animal
    {
        private string message = "Arf! Arf!";
        public Dog (): base () {}
        public Dog (string name) : base(name) { }
        public override string talk()
        {
            string toSay = message;
            message = message + " Rrrr!";
            if (message.Length > 30)
                throw new Exception("\""+message + "\" too long!");
            return message;
        }
        public override string ToString()
        {
            return "Dog " + Name;
        }
    }