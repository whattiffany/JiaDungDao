using System.Collections.Generic;
using System.Linq;
using Back_End.Interface;
using Back_End.Models;
using JiaDungDao.Connection;

namespace Back_End.Repositories
{
    public class RestaurantRepo : IRestaurantRepo
    {
        private readonly ApplicationDbContext db;
        public RestaurantRepo(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }

        public List<Menu> GetAllMenuById(int Id)
        {
            var allMenu = db.Menu.Where(m => m.RestaurantID == Id).OrderBy(m => m.m_type).ToList();
            if (allMenu != null)
            {
                return allMenu;
            }else{
                return null;
            }
        }

        public List<string> GetAllMenuTypeById(int Id)
        {
            var allMenuType = db.Menu.Where(m => m.RestaurantID == Id).OrderBy(m => m.m_type).Select(m => m.m_type).Distinct().ToList();
            if (allMenuType != null)
            {
                return allMenuType;
            }else{
                return null;
            }
        }

        public List<Restaurant> GetAllRestaurant()
        {
            var result = db.Restaurant.ToList();
            if (result != null)
            {
                return result;
            }else{
                return null;
            }
        }

        public Restaurant GetRestaurantById(int Id)
        {
            var result = db.Restaurant.Where(r => r.RestaurantID == Id).FirstOrDefault();
            if (result != null)
            {
                return result;
            }else{
                return null;
            }
        }

    }
}