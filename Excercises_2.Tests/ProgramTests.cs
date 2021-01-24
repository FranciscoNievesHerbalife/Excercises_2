using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excercises_2.Tests
{
    [TestClass]
    public class ProgramTests
    {
        #region Reverse
        //Create a function that takes a string and returns the reversed string following the below rules:
        //The UPPERCASE/lowercase positions must be kept in the same order as the original string (see example #1 and #2).
        //Spaces must be kept in the same order as the original string (see example #3).

        //Reverse("Edabit") => "Tibade"
        //Reverse("UPPER lower") => "REWOL reppu"
        //Reverse("1 23 456") => "6 54 321"

        //[TestMethod]
        //public void Reverse_String()
        //{
        //    Assert.AreEqual("Gnirts", Program.Reverse("String"));
        //}

        //[TestMethod]
        //public void Reverse_UPPERlower()
        //{
        //    Assert.AreEqual("REWOL reppu", Program.Reverse("UPPER lower"));
        //}

        //[TestMethod]
        //public void Reverse_Numbers()
        //{
        //    Assert.AreEqual("6 54 321", Program.Reverse("1 23 456"));
        //}

        //[TestMethod]
        //public void Reverse_HelloWorld()
        //{
        //    Assert.AreEqual("!dlro Wolleh", Program.Reverse("Hello World!"));
        //}

        //[TestMethod]
        //public void Reverse_Dog()
        //{
        //    Assert.AreEqual("?anaidg odru oys 'erehw", Program.Reverse("Where's your dog Diana?"));
        //}

        //[TestMethod]
        //public void Reverse_Addition()
        //{
        //    Assert.AreEqual("5=)2,3(noit id d a", Program.Reverse("addition(3, 2) = 5"));
        //}

        //[TestMethod]
        //public void Reverse_CSS()
        //{
        //    Assert.AreEqual("Stee hsely tsgn IDA csacs Naemsscta Htnwo Nks'ti", Program.Reverse("It's known that CSS means Cascading Style Sheets"));
        //}
        #endregion

        #region Sorting
        //Create a function that takes a string consisting of lowercase letters, uppercase letters and numbers and returns the string sorted in the same way as the examples below
        //Letters cannot be repeated
        //Numbers can be repeated

        //Sorting("eA2a1EA2") => "aAeE122"
        //sorting("Re4r") => "erR4"
        //sorting("6jnM31Q") => "jMnQ136"

        //[TestMethod]
        //public void Sorting_eA2a1EA2()
        //{
        //    Assert.AreEqual("aAeE122", Program.Sorting("eA2a1EA2"));
        //}

        //[TestMethod]
        //public void Sorting_Re4r()
        //{
        //    Assert.AreEqual("erR4", Program.Sorting("Re4r"));
        //}

        //[TestMethod]
        //public void Sorting_6jnM31Q()
        //{
        //    Assert.AreEqual("jMnQ136", Program.Sorting("6jnM31Q"));
        //}

        //[TestMethod]
        //public void Sorting_f5Eex()
        //{
        //    Assert.AreEqual("eEfx5", Program.Sorting("f5Eex"));
        //}

        //[TestMethod]
        //public void Sorting_846ZIbo()
        //{
        //    Assert.AreEqual("bIoZ468", Program.Sorting("846ZIbo"));
        //}

        //[TestMethod]
        //public void Sorting_2lZduOg1jB8SPXf5rakC37wIE094Qvm6Tnyh()
        //{
        //    Assert.AreEqual("aBCdEfghIjklmnOPQrSTuvwXyZ0123456789", Program.Sorting("2lZduOg1jB8SPXf5rakC37wIE094Qvm6Tnyh"));
        //}
        #endregion

        #region Pattern
        //Given a number n, print the following pattern without using any loop.
        //Decrease 5 until reaching 0 or negative number, then increase 5 until reaching original number

        //Pattern(13) => 13,8,3,-2,3,8,13
        //Pattern(10) => 10,5,0,5,10
        //Pattern(37) => 37,32,27,22,17,12,7,2,-3,2,7,12,17,22,27,32,37

        //[TestMethod]
        //public void Pattern_13()
        //{
        //    Assert.AreEqual("13,8,3,-2,3,8,13", Program.Pattern(13));
        //}

        //[TestMethod]
        //public void Pattern_10()
        //{
        //    Assert.AreEqual("10,5,0,5,10", Program.Pattern(10));
        //}

        //[TestMethod]
        //public void Pattern_37()
        //{
        //    Assert.AreEqual("37,32,27,22,17,12,7,2,-3,2,7,12,17,22,27,32,37", Program.Pattern(37));
        //}

        //[TestMethod]
        //public void Pattern_16()
        //{
        //    Assert.AreEqual("16,11,6,1,-4,1,6,11,16", Program.Pattern(16));
        //}

        //[TestMethod]
        //public void Pattern_29()
        //{
        //    Assert.AreEqual("29,24,19,14,9,4,-1,4,9,14,19,24,29", Program.Pattern(29));
        //}
        #endregion

        #region Student API
        //Create a Web API for handling students info
        //Use repository pattern and dependency injection to add CRUD operations
        //Get (string Id) returns 1 student (Student objects cand be hardcoded)
        //Get (parameterless) returns all students (Student objects cand be hardcoded)
        //Post (student object) should return a GUID string
        //Put (student object) should return a GUID string
        //Delete (string Id) should return a GUID string
        //Route must follow this format /api/student/v1/{id}
        //Student object must contain following info
        //Id: GUID string
        //Name: string
        //Last Name: string
        #endregion
    }
}
