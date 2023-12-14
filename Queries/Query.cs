using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TodoDemo.project;



namespace TodoDemo.Queries
{
    public static class Query
    {
        public static int checkLogin(string username, string password)
        {
            ToDoFianl3Context  context = new ToDoFianl3Context ();        
            var user = context.Users.FirstOrDefault(x => x.UserName == username && x.Password == password);
            return user.UserId ;
        }
        public static void signup(string username, string password)
        {
            ToDoFianl3Context context = new ToDoFianl3Context();

            var newUser = new User
            {
                UserName =username,
                Password = password
            };
            // Add the new user to the database
            context.Users.Add(newUser);
            context.SaveChanges();

        }
   
        public static List<project.Task> getTaskByUserID(int id)
        {
            ToDoFianl3Context context = new ToDoFianl3Context();
            var data = context.Tasks.Where(x=>x.UserId == id).ToList();
            return data;

        }


    }
}
