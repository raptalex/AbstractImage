using System;

abstract class Image
{
    // Width and height are in pixels
    public abstract int Width { get; set; }
    public abstract int Height { get; set; }
    public abstract void Info();
    public string Dimensions() {
        return Width + "x" + Height;
    }
}

class Photo : Image
{
    // Width and height are in pixels
    public override int Width { get; set; }
    public override int Height { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime? Time { get; set; }
    public Photo()
    {
        Width = Height = 0;
        Title = Description = string.Empty;
        Time = null;
    }
    public Photo(int _w, int _h, string _t, string _d, DateTime _tm)
    {
        Width = _w;
        Height = _h;
        Title = _t;
        Description = _d;
        Time = _tm;
    }
    public override void Info()
    {
        Console.WriteLine("[Photograph]");
        Console.WriteLine("Title: \"" + Title + "\"");
        Console.WriteLine("Date: " + Time?.ToShortDateString());
        Console.WriteLine("Dimensions: " + this.Dimensions());
        Console.WriteLine("Description: " + Description);
    }
}

class Program
{
    public static void Main()
    {
        Photo photo = new Photo(800, 600, "Picture of Seagulls",
            "A picture with 5 seagulls on a beach.", new DateTime(2007, 6, 12));

        photo.Info();
    }
}