
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace MVC2Project.Models
{
    public class CategoryDAL
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private readonly IConfiguration configuration;

        public CategoryDAL(IConfiguration configuration)
        {
            this.configuration = configuration;
            con = new SqlConnection(this.configuration.GetConnectionString("SqlConnection"));
        }
        //Display All

        public List<Category> GetAllCategory()
        {
            List<Category> list = new List<Category>();
            string qur = "Select * from category";
            cmd = new SqlCommand(qur,con);
            con.Open();
            dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                { 
                    Category category= new Category();
                    category.CategoryId =Convert.ToInt32(dr["Catg_id"].ToString());
                    category.CategoryName = dr["Catg_Name"].ToString();
                    list.Add(category);

                }
                con.Close();
            }

            return list;

        }
        //display by id 
        public Category GetCategoryById(int id )
        {
            Category category = new Category();

        }

    }
}
