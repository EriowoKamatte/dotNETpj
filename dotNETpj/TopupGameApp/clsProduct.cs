using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopupGameApp
{
    public class Product
    {
        public static string CurrentProdName = "";
        public static int CurrentProdGems = 0;
        public static int CurrentProdCredits = 0;
        public static float CurrentProdPrice = 0;
        public static int CurrentProdID = 0;
        public static void setCurrentProdName(string currentProdName)
        {
            CurrentProdName = currentProdName;
        }
        public static void setCurrentProdGems(int currentProdGems)
        {
            CurrentProdGems = currentProdGems;
        }
        public static void setCurrentProdCredits(int currentProdCredits)
        {
            CurrentProdCredits = currentProdCredits;
        }
        public static void setCurrentProdPrice(int currentProdPrice)
        {
            CurrentProdPrice = currentProdPrice;
        }
        public static void setCurrentProdID(int currentProdID)
        {
            CurrentProdID = currentProdID;
        }
        public static void resetCurrentProduct()
        {
            Product.setCurrentProdID(0);
            Product.setCurrentProdName("");
            Product.setCurrentProdCredits(0);
            Product.setCurrentProdGems(0);
            Product.setCurrentProdPrice(0);
        }
    }
}
