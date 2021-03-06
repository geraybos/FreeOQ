using System;
using System.Globalization;

namespace OpenQuant.Finam
{
  public sealed class TransaqOpenBook
  {
    public int SecId { get; private set; }

    public string SecCode { get; private set; }

    public string Board { get; private set; }

    public double Price { get; private set; }

    public int Buy { get; private set; }

    public int Sell { get; private set; }

    public string SecCodeBoard { get; private set; }

    public TransaqOpenBook(string data)
    {
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      int index = 0;
      while (index < strArray.Length - 1)
      {
        switch (strArray[index])
        {
          case "secid":
            this.SecId = int.Parse(strArray[index + 1]);
            break;
          case "seccode":
            this.SecCode = strArray[index + 1];
            break;
          case "board":
            this.Board = strArray[index + 1];
            break;
          case "price":
            this.Price = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "buy":
            this.Buy = int.Parse(strArray[index + 1]);
            break;
          case "sell":
            this.Sell = int.Parse(strArray[index + 1]);
            break;
        }
        index += 2;
      }
      this.SecCodeBoard = this.SecCode + "|" + this.Board;
    }
  }
}
