using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRestaurent1._1
{
    class Menu
    {
        // Tạo danh sách món ăn đã được chọn
        public static List<Food> listFood
        {
            get;
            set;
        }
        public static List<itemMenu> menuitem {get;set;}
        //= new List<Food>();

        // tạo list tên món ăn để dể dang xét các món cùng tên
        public static List<string> lName 
        {
            get;
            set;
        }
        public Menu()
        {
            menuitem = new List<itemMenu>();
            listFood = new List<Food>();
            lName = new List<string>();
        }
        // = new List<string>();
    }
}
