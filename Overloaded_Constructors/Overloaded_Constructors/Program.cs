namespace Overloaded_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Overloaded constructors = technique to create multiple constructors,
            //                          with a different set of parameters.
            //                          name + parameters = signature


            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");




        }
    }

    class Pizza
    {
        String bread;
        String sauce;
        String chesse;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
  
        }

        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
          
        }

        public Pizza(String bread, String sauce, String chesse)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.chesse = chesse;
        }

        public Pizza(String bread, String sauce, String chesse, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.chesse = chesse;
            this.topping = topping;
        }
    }