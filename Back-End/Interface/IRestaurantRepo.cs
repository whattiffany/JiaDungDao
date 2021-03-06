using System.Collections.Generic;
using System.Threading.Tasks;
using Back_End.Models;

namespace Back_End.Interface
{
    public interface IRestaurantRepo
    {
        List<Restaurant> GetAllRestaurant();
        Restaurant GetRestaurantById(int Id);
        List<string> GetAllMenuTypeById(int Id);
        List<Menu> GetAllMenuById(int Id);
        string updateRestaurant(Restaurant oldData,Restaurant restaurant);
        string createRestaurant(Restaurant restaurant);
        int AddMenuItem(Menu newMenuItem);
        bool DeleteMenu(int MenuID);
        bool DeleteRestaurant(int RestaurantID);
        string updateMenu(Menu menu);
        int GetLatestMenuId ();
        int GetLatestRestaurantId();
    }
}