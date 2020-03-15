using System;
using System.Windows;

namespace pr_1_Gaivoronskyi.Processors
{
  class DataProcessor
  {
    public int calculateAge(DateTime dateOfBirth)
    {
      if (DateTime.Today.DayOfYear == dateOfBirth.DayOfYear)
        MessageBox.Show("Happy birthday! ","Oops!",MessageBoxButton.OK, MessageBoxImage.Error);
      int age = DateTime.Today.Year - dateOfBirth.Year;
      if (DateTime.Today.DayOfYear < dateOfBirth.DayOfYear)
        age--;
      // TODO age check
      if(age > 135 || age < 0)
            {
                MessageBox.Show("Wrong age!");
                return -1;
            }
      return age;
    }

    public String calculateSignEast(DateTime dateOfBirth)
    {

            String result = "";
            switch (dateOfBirth.Year % 12)
            {
                case 0:
                    {
                        result = "Monkey";
                        break;
                    }
                case 1:
                    {
                        result = "Rooster";
                        break;
                    }
                case 2:
                    {
                        result = "Dog";
                        break;
                    }
                case 3:
                    {
                        result = "Pig";
                        break;
                    }
                case 4:
                    {
                        result = "Rat";
                        break;
                    }
                case 5:
                    {
                        result = "Bull";
                        break;
                    }
                case 6:
                    {
                        result = "Tiger";
                        break;
                    }
                case 7:
                    {
                        result = "Rabbit";
                        break;
                    }
                case 8:
                    {
                        result = "Dragon";
                        break;

                    }
                case 9:
                    {
                        result = "Snake";
                        break;
                    }
                case 10:
                    {
                        result = "Horse";
                        break;
                    }
                case 11:
                    {
                        result = "Goat";
                        break;
                    }
                default:
                    {
                        result = "Can't calculate your sign, sorry";
                        break;
                    }
            }
            return result;
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
            result = "Pisces";
          break;
        }
        case 3: {
          if (dateOfBirth.Day < 21)
            result = "Pisces";
          else
            result = "Aries";
          break;
        }
        case 4: {
          if (dateOfBirth.Day < 20)
            result = "Aries";
          else
            result = "Taurus";
          break;
        }
        case 5: {
          if (dateOfBirth.Day < 21)
            result = "Taurus";
          else
            result = "Gemini";
          break;
        }
        case 6: {
          if (dateOfBirth.Day < 21)
            result = "Gemini";
          else
            result = "Cancer";
          break;
        }
        case 7: {
          if (dateOfBirth.Day < 23)
            result = "Cancer";
          else
            result = "Leo";
          break;
        }
        case 8: {
          if (dateOfBirth.Day < 23)
            result = "Leo";
          else
            result = "Virgo";
          break;
        }
        case 9: {
          if (dateOfBirth.Day < 23)
            result = "Virgo";
          else
            result = "Libra";
          break;
        }
        case 10: {
          if (dateOfBirth.Day < 23)
            result = "Libra";
          else
            result = "Scorpio";
          break;
        }
        case 11: {
          if (dateOfBirth.Day < 22)
            result = "Scorpio";
          else
            result = "Sagittarius";
          break;
        }
        case 12: {
          if (dateOfBirth.Day < 22)
            result = "Sagittarius";
          else
            result = "Capricorn";
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
