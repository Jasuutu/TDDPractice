using System.Runtime.CompilerServices;
using ConsoleGame.Interfaces;
using Moq;
using NUnit.Framework;

namespace ConsoleGameTests.Moqs
{
    public class StatMock : Mock<IStat>
    {
        public StatMock()
            :base(MockBehavior.Strict)
        {
            SetupStatMockMehtods();
        }

        private void SetupStatMockMehtods()
        {
            this.Setup(getName => getName.GetName())
                .Returns(It.IsAny<string>());

            this.Setup(getValue => getValue.GetValue())
                .Returns(It.IsAny<int>());
        }
    }
}