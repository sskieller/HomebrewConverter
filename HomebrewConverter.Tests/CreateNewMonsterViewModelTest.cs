// <copyright file="CreateNewMonsterViewModelTest.cs">Copyright ©  2019</copyright>
using System;
using HomebrewConverter.ViewModel.CreateNew;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;

namespace HomebrewConverter.ViewModel.CreateNew.Tests
{
    /// <summary>This class contains parameterized unit tests for CreateNewMonsterViewModel</summary>
    [PexClass(typeof(CreateNewMonsterViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class CreateNewMonsterViewModelTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        internal CreateNewMonsterViewModel ConstructorTest()
        {
            CreateNewMonsterViewModel target = new CreateNewMonsterViewModel();
            return target;
            // TODO: add assertions to method CreateNewMonsterViewModelTest.ConstructorTest()
        }
        
    }
}
