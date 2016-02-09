namespace Parcels.Objects
{
  public class ParcelVariables
  {
    public int Height { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }
    public int Weight { get; set; }
    public int Volume = 0;
    public int Price = 0;

    public ParcelVariables() {
    }
    public void SetVolume()
    {
      Volume = ((Height * Width) * Depth);
    }
    public void SetPrice()
    {
      Price = ((Volume / 25) * Weight);
    }

  }
}
