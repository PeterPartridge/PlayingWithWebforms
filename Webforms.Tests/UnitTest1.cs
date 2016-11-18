using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;

namespace Webforms.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [SetUp]
        public void startUp()
        {
            
        }

       

        [TestMethod]
        public void Returning_one_item_from_a_model()
        {

            var catModel = DataForTesting.OneCatData();


            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, catModel.Count);
        }

        [Test]
        public void Returning_two_Peices_Of_Data()
        {
            IList<TestModel> CatModel = DataForTesting.twoCatData();

            NUnit.Framework.Assert.AreEqual(2, CatModel.Count);
        }

    

        [TestMethod]
        public void Get_Newest_List_Item()
        {
            var CatModel = DataForTesting.twoCatData();
            bool newCatagory2 = true;
            bool oldCatagory2 = false;

            var newestItem = ShowNewestOrOldestItem(CatModel, newCatagory2, oldCatagory2);

            
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, newestItem.Count);
        }

        [TestMethod]
        public void Get_Oldest_List_Item()
        {
            var CatModel = DataForTesting.twoCatData();
            bool newCatagory = false;
            bool oldCatagory = true;
          


            var oldestItem = ShowNewestOrOldestItem(CatModel, newCatagory, oldCatagory);
       

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, oldestItem.Count);
          
        }

        [TestMethod]
        public void Passing_Null_to_List_Item()
        {
            var CatModel = DataForTesting.twoCatData();
            bool newCatagory = false;
            bool oldCatagory = false;



            var nullItem = ShowNewestOrOldestItem(CatModel, newCatagory, oldCatagory);


            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNull(nullItem);

        }



        public IList<TestModel> ShowNewestOrOldestItem(IList<TestModel> Catagories, bool? newCatagory, bool? oldCatagory)
        {
            if (newCatagory!= false)
            {
                var OrderedList = Catagories.OrderByDescending(c => c.WhenCatagoryWasCreated).ToList().FirstOrDefault();
                SortedList.Add(OrderedList);
            }

            else if (oldCatagory != false)
            {
                var OrderedList = Catagories.OrderBy(c => c.WhenCatagoryWasCreated).ToList().FirstOrDefault();
                SortedList.Add(OrderedList);
            }

            else
            {
                return null;
            }

            return SortedList;
        }







        // Old Tests
        //Get new and old items superseads these two
        [Microsoft.VisualStudio.TestTools.UnitTesting.Ignore]
        public void Get_Oldest_List_Item_retired()
        {


            var CatModel = DataForTesting.twoCatData();

            var oldestItem = ShowOldestItem(CatModel);



            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, oldestItem.Count);

        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.Ignore]
        public void Get_Newest_List_Item_retired()
        {
            var CatModel = DataForTesting.twoCatData();

            var newestItem = ShowNewestItem(CatModel);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, newestItem.Count);

        }

        IList<TestModel> SortedList = new List<TestModel>();

        public IList<TestModel> ShowNewestItem(IList<TestModel> Catagories)
        {
            var OrderedList = Catagories.OrderByDescending(c => c.WhenCatagoryWasCreated).ToList().FirstOrDefault();

            SortedList.Add(OrderedList);

            return SortedList;
        }

        public IList<TestModel> ShowOldestItem(IList<TestModel> Catagories)
        {
            var OrderedList = Catagories.OrderBy(c => c.WhenCatagoryWasCreated).ToList().FirstOrDefault();
           
            SortedList.Add(OrderedList);

            return SortedList;
            
        }
    }

  
}
