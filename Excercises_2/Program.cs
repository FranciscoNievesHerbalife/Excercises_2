namespace Excercises_2
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Reverse(string text)
        {
            //Create a function that takes a string and returns the reversed string following the below rules:
            //The UPPERCASE/lowercase positions must be kept in the same order as the original string (see example #1 and #2).
            //Spaces must be kept in the same order as the original string (see example #3).

            //Reverse("Edabit") => "Tibade"
            //Reverse("UPPER lower") => "REWOL reppu"
            //Reverse("1 23 456") => "6 54 321"

            return default;
        }

        public static string Sorting(string text)
        {
            //Create a function that takes a string consisting of lowercase letters, uppercase letters and numbers and returns the string sorted in the same way as the examples below
            //Letters cannot be repeated
            //Numbers can be repeated

            //Sorting("eA2a1EA2") => "aAeE122"
            //sorting("Re4r") => "erR4"
            //sorting("6jnM31Q") => "jMnQ136"

            return default;
        }

        public static string Pattern(int number)
        {
            //Given a number, print the following pattern without using any loop.
            //Decrease 5 until reaching 0 or negative number, then increase 5 until reaching original number

            //Pattern(13) => 13,8,3,-2,3,8,13
            //Pattern(10) => 10,5,0,5,10
            //Pattern(37) => 37,32,27,22,17,12,7,2,-3,2,7,12,17,22,27,32,37

            return default;
        }

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
    }
}
