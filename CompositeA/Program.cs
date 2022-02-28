using System;
using System.Linq;
using System.Collections.Generic;
namespace Composite.Structural
{
    /// <summary>
    /// Composite Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Leaf obj1 = new Leaf("Turbox TV", 500);
            Leaf obj2 = new Leaf("Entos Sofa", 1600);
            Leaf obj3 = new Leaf("Pirounia", 40);
            Leaf obj4 = new Leaf("Trapezi", 160);
            Composite saloni = new Composite("Saloni");
            saloni.Add(obj1);
            saloni.Add(obj2);
            Composite trapezaria = new Composite("Trapezaria");
            trapezaria.Add(obj3);
            trapezaria.Add(obj4);
            saloni.Add(trapezaria);
            saloni.Display(0);
        }
    }
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    public abstract class Component
    {
        protected string name;
        public abstract int Price { get; protected set; }
        // Constructor
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    public class Composite : Component
    {
        List<Component> children = new List<Component>();
        private int price;
        public override int Price
        {
            get
            {
                return children.Sum(x => x.Price);
            }
            protected set { price = value; }
        }
        public Composite(string name) : base(name)
        {
        }
        public override void Add(Component component)
        {
            children.Add(component);
        }
        public override void Remove(Component component)
        {
            children.Remove(component);
        }
        public override void Display(int depth)   //2
        {
            Console.WriteLine(new String('-', depth) + name + " : " + Price);    //--Hector
            // Recursively display child nodes
            foreach (Component component in children)
            {
                component.Display(depth + 2);                   //------Onoma
            }
        }
    }
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    public class Leaf : Component
    {
        public override int Price { get; protected set; }
        // Constructor
        public Leaf(string name, int price) : base(name)
        {
            Price = price;
        }
        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }
        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " : " + Price);
        }
    }
}