// <copyright file="MonsterTest.cs">Copyright ©  2019</copyright>

using System;
using HomebrewConverter.Model;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;

namespace HomebrewConverter.Model.Tests
{
    /// <summary>This class contains parameterized unit tests for Monster</summary>
    [TestFixture]
    [PexClass(typeof(Monster))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MonsterTest
    {

        /// <summary>Test stub for .ctor(String, String, String, String)</summary>
        [PexMethod]
        internal Monster ConstructorTest(
            string title,
            string monsterSize,
            string monsterType,
            string monsterAlignment
        )
        {
            Monster target = new Monster(title, monsterSize, monsterType, monsterAlignment);
            return target;
            // TODO: add assertions to method MonsterTest.ConstructorTest(String, String, String, String)
        }
    }
}
