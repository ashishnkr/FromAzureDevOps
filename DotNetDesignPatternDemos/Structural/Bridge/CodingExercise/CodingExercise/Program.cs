using System;
using NUnit.Framework;

namespace CodingExercise
{
    public abstract class Shape
    {
        protected IRenderer renderer;
        public string Name { get; set; }

        protected Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public override string ToString()
        {
            return $"Drawing {Name} as {renderer.WhatToRenderAs}";
        }
    }

    public interface IRenderer
    {
        string WhatToRenderAs { get; }
    }
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer)
        {
            Name = "Triangle";
        }
    }

    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer)
        {
            Name = "Square";
        }
    }

    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs { get; } = "lines";
    }

    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs { get; } = "pixels";
    }

    public class VectorSquare : Square
    {
        public VectorSquare(IRenderer renderer) : base(renderer)
        {
        }
    }

    public class RasterSquare : Square
    {
        public RasterSquare(IRenderer renderer) : base(renderer)
        {
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
    // imagine VectorTriangle and RasterTriangle are here too
}

namespace CodingExercise
{
    [TestFixture]
    public class TestSuite
    {
        [Test]
        public void Test()
        {
            Assert.That(
                new Square(new VectorRenderer()).ToString(),
                Is.EqualTo("Drawing Square as lines"));
        }
    }
}

