using System;

namespace Dealership{
  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string About;

    public Car(string makeModel, int price, int miles, string about)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      About = about;
    }
    public void SetPrice(int newPrice)
    {
        Price =  newPrice;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }
    public int GetPrice()
   {
     return Price;
   }

   public int GetMiles()
   {
     return Miles;
   }

   public string GetAbout()
   {
     return About;
   }

    public bool WorthBuying (int maxPrice)
    {
      return (Price < maxPrice);
    }
    public bool WorthDriving(int maxMiles)
    {
      return (Miles < maxMiles);
    }
  }
}
