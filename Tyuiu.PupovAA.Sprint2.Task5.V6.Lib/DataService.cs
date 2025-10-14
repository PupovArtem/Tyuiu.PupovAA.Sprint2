using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PupovAA.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string card_suit;
            switch(value1)
            {
                case 1:
                    card_suit = "пики";
                    break;
                case 2:
                    card_suit = "трефы";
                    break;
                case 3:
                    card_suit = "бубны";
                    break;
                case 4:
                    card_suit = "червы";
                    break;
                default:
                    throw new ArgumentException("Такой масти не существует");
                    
            }
            string card;
            switch(value2)
            {
                case 6:
                    card = " шестерка ";
                    break;
                case 7:
                    card = " семерка ";
                    break;
                case 8:
                    card = " восьмерка ";
                    break;
                case 9:
                    card = " девятка ";
                    break;
                case 10:
                    card = " десятка ";
                    break;
                case 11:
                    card = " валет ";
                    break;
                case 12:
                    card = " дама ";
                    break;
                case 13:
                    card = " король ";
                    break;
                case 14:
                    card = " туз ";
                    break;
                default :
                    throw new ArgumentException("Такой карты не существует");




            }
            return card+ card_suit;
            

        }
    }
}
