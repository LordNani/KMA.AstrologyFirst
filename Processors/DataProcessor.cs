using System;
using System.Windows;

namespace pr_1_Gaivoronskyi.Processors
{
  class DataProcessor
  {
    public int calculateAge(DateTime dateOfBirth)
    {
      if (DateTime.Today.DayOfYear == dateOfBirth.DayOfYear)
        MessageBox.Show("Happy birthday! ");
      int age = DateTime.Today.Year - dateOfBirth.Year;
      if (DateTime.Today.DayOfYear < dateOfBirth.DayOfYear)
        age--;
      // TODO age check
      return age;
    }

    public String calculateSignEast(DateTime dateOfBirth)
    {

      // TODO age check
      return "nodata";
      // MessageBox.Show($"Date picked: {model.Age}");
    }

    public String calculateSignWest(DateTime dateOfBirth)
    {
      String result = "";
      switch (dateOfBirth.Month) {
        case 1: {
          if (dateOfBirth.Day < 20)
            result = "Capricorn";
          else
            result = "Aquarius";
          break;
        }
        case 2: {
          if (dateOfBirth.Day < 19)
            result = "Aquarius";
          else
            result = "pisces";
          break;
        }
        case 3: {
          if (dateOfBirth.Day < 21)
            result = "Pisces";
          else
            result = "aries";
          break;
        }
        case 4: {
          if (dateOfBirth.Day < 20)
            result = "Aries";
          else
            result = "taurus";
          break;
        }
        case 5: {
          if (dateOfBirth.Day < 21)
            result = "Taurus";
          else
            result = "gemini";
          break;
        }
        case 6: {
          if (dateOfBirth.Day < 21)
            result = "Gemini";
          else
            result = "cancer";
          break;
        }
        case 7: {
          if (dateOfBirth.Day < 23)
            result = "Cancer";
          else
            result = "leo";
          break;
        }
        case 8: {
          if (dateOfBirth.Day < 23)
            result = "Leo";
          else
            result = "virgo";
          break;
        }
        case 9: {
          if (dateOfBirth.Day < 23)
            result = "Virgo";
          else
            result = "libra";
          break;
        }
        case 10: {
          if (dateOfBirth.Day < 23)
            result = "Libra";
          else
            result = "scorpio";
          break;
        }
        case 11: {
          if (dateOfBirth.Day < 22)
            result = "scorpio";
          else
            result = "sagittarius";
          break;
        }
        case 12: {
          if (dateOfBirth.Day < 22)
            result = "Sagittarius";
          else
            result = "capricorn";
          break;
        }
        default: {
          result = "Can't calculate your sign, sorry";
          break;
        }
      }
      // TODO age check
      return result;
      // MessageBox.Show($"Date picked: {model.Age}");
    }
  }
}
