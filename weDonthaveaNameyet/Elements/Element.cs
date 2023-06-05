using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weDonthaveaNameyet.Elements
{
    class Element
    {
        public string elementName { get; private set; }

        private Element strongAgainst { get; set; }

        private Element weakAgainst { get; set; }

        private float strengthModifier = 0.2f;
        private float weaknessModifier = -0.2f;
            
        private Element(string elementName, Element strongAgainst, Element weakAgainst)
        {
            this.elementName = elementName;
            this.strongAgainst = strongAgainst;
            this.weakAgainst = weakAgainst;
        }

        private Element(string elementName, Element strongAgainst, Element weakAgainst, float strengthModifier, float weaknessModifier) : this(elementName, strongAgainst, weakAgainst)
        {
            this.strengthModifier = strengthModifier;
            this.weaknessModifier = weaknessModifier;
        }

        bool isStrongAgainst(Element otherElement) => otherElement == strongAgainst;
        bool isWeakAgainst(Element otherElement) => otherElement == weakAgainst;

        public float getModifier(Element otherElement) =>
            otherElement == strongAgainst ? strengthModifier
            : otherElement == weakAgainst ? weaknessModifier
            : 1.0f;

        public static Element Fire   = new Element("Fire", Iron, Air);
        public static Element Iron   = new Element("Iron", Nature, Water);
        public static Element Nature = new Element("Nature", Earth, Fire);
        public static Element Earth  = new Element("Earth", Air, Iron);
        public static Element Air    = new Element("Air", Water, Nature);
        public static Element Water  = new Element("Water", Fire, Earth);
    }
}
