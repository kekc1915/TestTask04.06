using NUnit.Framework;
using System;
using WindowsFormsAppTestTask3;

namespace TestForTestTask
{
    [TestFixture]
    public class UserTest
    {
        private User _user;
        [SetUp]
        public void InitUser()
        {
            _user = new User();
        }

        [TestCase("", "Должно возникать исключение, если password пользователя - пустая строка",
            TestName = "Присвоение пустой строки в качестве имени пользователя")]
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов", "Должно возникать исключение, если password пользователя длиннее 50 символов",
            TestName = "Присвоение неправильного имени пользователя больше 50 символов")]
        public void TestUsernameSet_ArgumentException(string wrongUsername, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _user.UserName = wrongUsername; },
            message);
        }

        [TestCase("Родичев", "Тест пройден если иключений не возникло",
            TestName = "Присвоение правильного имени пользователя")]
        public void TestUsernameSet_CorrectValue(string rightUsername, string message)
        {
            Assert.DoesNotThrow(
            () => { _user.UserName = rightUsername; },
            message);
        }

        [Test(Description = "Позитивный тест геттера Username")]
        public void TestUsernameGet_CorrectValue()
        {
            var expected = "Смирнов";
            _user.UserName = expected;
            var actual = _user.UserName;
            Assert.AreEqual(expected, actual, "Геттер Username возвращает неправильное имя пользователя");
        }
        [TestCase("", "Должно возникать исключение, если пароль - пустая строка",
           TestName = "Присвоение пустой строки в качестве пароля")]
        [TestCase("-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password", "Должно возникать исключение, если password длиннее 50 символов",
           TestName = "Присвоение неправильного пароля больше 50 символов")]
        public void TestPasswordSet_ArgumentException(string wrongPassword, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _user.Password = wrongPassword; },
            message);
        }

        [TestCase("ArtemPassword", "Тест пройден если иключений не возникло",
            TestName = "Присвоение правильного пароля")]
        public void TestPasswordSet_CorrectValue(string right, string massage)
        {
            Assert.DoesNotThrow(
            () => { _user.Password = right; },
            massage);
        }

        [Test(Description = "Позитивный тест геттера Password")]
        public void TestPasswordGet_CorrectValue()
        {
            var expected = "Adsadcx";
            _user.Password = expected;
            var actual = _user.Password;
            Assert.AreEqual(expected, actual, "Геттер Password возвращает неправильный пароль");
        }

    }
}