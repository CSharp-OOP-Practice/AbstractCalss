namespace AbstractCalss
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract void Draw();

        protected int GetCount()
        {
            return 1;
        }

        public string GetShape()
        {
            return "This is shape.";
        }
    }
}
