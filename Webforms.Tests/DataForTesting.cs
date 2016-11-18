using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Webforms.Tests
{
    public static class DataForTesting
    {
        public static IList<TestModel> OneCatData()
        {

            return new List<TestModel>{
            new TestModel{
                CategoryID = 1,
                CategoryName = "Airplanes",
                Description = "plastic planes made to look liek real planes"
            } };
        }

        public static IList<TestModel> twoCatData()
        {

            return new List<TestModel>{
            new TestModel{
                CategoryID = 1,
                WhenCatagoryWasCreated = new DateTime(2016,1,1),
                CategoryName = "Airplanes",
                Description = "plastic planes made to look liek real planes"
            },
            new TestModel{
                CategoryID = 1,
                WhenCatagoryWasCreated = new DateTime(2015,1,1),
                CategoryName = "Airplanes",
                Description = "plastic planes made to look liek real planes"
            }};



        }

       

        }


    }

