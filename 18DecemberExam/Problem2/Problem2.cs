using System;

class Program
{
    static void Main()
    {
        {
            double gatheredMoney = double.Parse(Console.ReadLine());
            double xFloor = double.Parse(Console.ReadLine());
            double yFloor = double.Parse(Console.ReadLine());
            double zTiles = double.Parse(Console.ReadLine());
            double hTiles = double.Parse(Console.ReadLine());
            double priceTiles = double.Parse(Console.ReadLine());
            double priceHandiman = double.Parse(Console.ReadLine());

            double sFloor = xFloor * yFloor;
            double sTiles = zTiles * hTiles / 2;
            double neseseryTiles = Math.Ceiling(sFloor / sTiles + 5);
            double totalSum = neseseryTiles * priceTiles + priceHandiman;

            if (totalSum > gatheredMoney)
            { Console.WriteLine($"You'll need {(totalSum - gatheredMoney).ToString("0.00")} lv more."); }
            else
            { Console.WriteLine($"{(gatheredMoney - totalSum).ToString("0.00")} lv left."); }
        }
    }
}
