using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialNetwork.BLL.Services;
using AutoFixture;
using SocialNetwork.BLL.Models;

namespace SocialNetwork.Tests
{
    [TestClass()]
    public class UserServiceTests
    {
        private Fixture fixture;
        private UserService service;

        [TestInitialize]
        public void Init()
        {
            fixture = new Fixture();
            service = new UserService();
        }

        [TestMethod("Проверка поиска по email")]
        public void FindByEmailTest()
        {
            if (service.FindById(1).Email == "")
            {
                var val = fixture.Build<UserRegistrationData>()
                    .With(u => u.Email, "valerii@mail.ru").Create();
                service.Register(val);

                var dim = fixture.Build<UserRegistrationData>()
                    .With(u => u.Email, "dmitrii@mail.ru").Create();
                service.Register(dim);

                var serg = fixture.Build<UserRegistrationData>()
                    .With(u => u.Email, "sergei@mail.ru").Create();
                service.Register(serg);
            }

            var findBymail = service.FindByEmail("sergei@mail.ru");
            Assert.IsNotNull(findBymail);
            Assert.AreEqual(findBymail.Email, "sergei@mail.ru");
        }
    }
}