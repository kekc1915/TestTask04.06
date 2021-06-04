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

        [TestCase("", "������ ��������� ����������, ���� password ������������ - ������ ������",
            TestName = "���������� ������ ������ � �������� ����� ������������")]
        [TestCase("�������-�������-�������-�������-�������-�������-�������-�������-�������-�������", "������ ��������� ����������, ���� password ������������ ������� 50 ��������",
            TestName = "���������� ������������� ����� ������������ ������ 50 ��������")]
        public void TestUsernameSet_ArgumentException(string wrongUsername, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _user.UserName = wrongUsername; },
            message);
        }

        [TestCase("�������", "���� ������� ���� ��������� �� ��������",
            TestName = "���������� ����������� ����� ������������")]
        public void TestUsernameSet_CorrectValue(string rightUsername, string message)
        {
            Assert.DoesNotThrow(
            () => { _user.UserName = rightUsername; },
            message);
        }

        [Test(Description = "���������� ���� ������� Username")]
        public void TestUsernameGet_CorrectValue()
        {
            var expected = "�������";
            _user.UserName = expected;
            var actual = _user.UserName;
            Assert.AreEqual(expected, actual, "������ Username ���������� ������������ ��� ������������");
        }
        [TestCase("", "������ ��������� ����������, ���� ������ - ������ ������",
           TestName = "���������� ������ ������ � �������� ������")]
        [TestCase("-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password-password", "������ ��������� ����������, ���� password ������� 50 ��������",
           TestName = "���������� ������������� ������ ������ 50 ��������")]
        public void TestPasswordSet_ArgumentException(string wrongPassword, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _user.Password = wrongPassword; },
            message);
        }

        [TestCase("ArtemPassword", "���� ������� ���� ��������� �� ��������",
            TestName = "���������� ����������� ������")]
        public void TestPasswordSet_CorrectValue(string right, string massage)
        {
            Assert.DoesNotThrow(
            () => { _user.Password = right; },
            massage);
        }

        [Test(Description = "���������� ���� ������� Password")]
        public void TestPasswordGet_CorrectValue()
        {
            var expected = "Adsadcx";
            _user.Password = expected;
            var actual = _user.Password;
            Assert.AreEqual(expected, actual, "������ Password ���������� ������������ ������");
        }

    }
}