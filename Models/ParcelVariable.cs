namespace ParcelApp.Models
{
  public class Parcel
  {
    private string _Height;
    private string _Length;
    private string _Width;
    private string _Weight;
    private int Height;
    private int Length;
    private int Width;
    private int Weight;
    private int finalVolume;
    private int finalPrice;

    public string GetHeight()
    {
      return _Height;
    }
    public void SetHeight(string newHeight)
    {
      _Height = newHeight;
    }
    public string GetLength()
    {
      return _Length;
    }
    public void SetLength(string newLength)
    {
      _Length = newLength;
    }
    public string GetWidth()
    {
      return _Width;
    }
    public void SetWidth(string newWidth)
    {
      _Width = newWidth;
    }
    public string GetWeight()
    {
      return _Weight;
    }
    public void SetWeight(string newWeight)
    {
      _Weight = newWeight;
    }
    public int GetVolume()
    {
      Height = int.Parse(_Height);
      Length = int.Parse(_Length);
      Width = int.Parse(_Width);

      finalVolume = Height * Width * Length;
      return finalVolume;
    }
    // public void SetVolume(string newVolume)
    // {
    //   Volume = newVolume;
    // }
    public int GetPrice()
    {
      Weight = int.Parse(_Weight);
      finalPrice = (finalVolume * Weight) / 4;
      return finalPrice;
    }
    // public void SetPrice(string newPrice)
    // {
    //   Price = newPrice;
    // }
  }

}




// height
//length
//width
//weight
