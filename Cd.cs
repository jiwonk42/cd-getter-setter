using System;
using System.Collections.Generic;

class Cd
{
  private string _title;
  private string _artist;
  private int _price;

  public void SetTitle(string title)
  {
    _title = title;
  }

  public string GetTitle()
  {
    return _title;
  }

  public void SetArtist(string artist)
  {
    _artist = artist;
  }

  public string GetArtist()
  {
    return _artist;
  }

  public void SetPrice(int price)
  {
    _price = price;
  }

  public int GetPrice()
  {
    return _price;
  }
}

public class Program
{
  public static void Main()
  {
    Cd anotherCd = new Cd();
    anotherCd.SetTitle("Danger");
    anotherCd.SetArtist("BTS");
    anotherCd.SetPrice(7);
    Console.WriteLine(anotherCd.GetTitle());
    Console.WriteLine(anotherCd.GetArtist());
    Console.WriteLine(anotherCd.GetPrice());
  }
}
