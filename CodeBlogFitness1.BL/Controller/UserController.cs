using CodeBlogFitness1.BL.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CodeBlogFitness1.BL.Controller
{

    /// <summary>
    /// Контреллер пользователя.
    /// </summary>
  public  class UserController
    {

        /// <summary>
        /// Пользователь приложения.
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Создание нового контроллера.
        /// </summary>
        /// <param name="user"></param>

        public UserController(string userName, string genderName, DateTime birdthDay, double weight, double height)
        {
            //TODO: Проверка.
            var gender = new Gender(genderName);
            User = new User(userName, gender, birdthDay, weight, height);

        }
        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {

                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                //TODO: что делать, если пользователя не прочитали?

            }
        }

        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// Получить данные пользователя.
        /// </summary>
        /// <returns> Пользователь приложения. </returns>
       
    }
}
