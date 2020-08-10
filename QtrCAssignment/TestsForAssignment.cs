using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QtrCAssignment
{

    [TestClass]
    public class TestsForAssignment
    {
        /*
         * לפני כל שורה של פונקציית טסט, אנחנו צריכים להגדיר שזוהי פונקציית טסט
         * כך כאשר נריץ את הטסטים, הוא ידע להריץ גם את הפונקציה הזו
         * כמו כן יש שימוש ב Timeout
         * אנחנו נגדיר לו כמה זמן באלפיות שנייה מותר לפונקציה הזו לרוץ
         * 5000 miliseconds = 5 seconds
         * בתום הזמן, תיזרק שגיאה, והטסט ייכשל
         * המימוש שלי רץ לרוב בפחות מאלפית השניה, ככה אמור להיות גם אצלכם
         * ולכן חמש שניות לטסט זה נצח במונחי התוכנית שלכם
         * בכל מקרה, אנחנו לא בחנו אתכם לפי כמה זמן זה רץ
         * הסיבה להגבלת הזמן היא על מנת לתפוס בעיות של לולאה אינסופית 
         * או לחלופין שימוש בקליטה, בניגוד להוראות
         * אם התוכנית שלכם רצה 5 שניות, אז אחד מהשניים הללו קרה בוודאות
         */

        [TestMethod, Timeout(5000)]
        public void TestMethod01()
        {
            //Test 1/2 for Q1
            int[] arr = { 5, 8, 6, 0, 4, 7, 10, 63 };
            int expected = 1350;
            Assert.AreEqual(expected, Program.ShowTicketsPrice(arr));
            //test will fail if result != 1350
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod02()
        {
            //Test 2/2 for Q1
            int[] arr = { 0, 8, 29, 38, 91, 100, 7, 8 };
            int expected = 2846;
            Assert.AreEqual(expected, Program.ShowTicketsPrice(arr));
            //test will fail if result != 2846
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod03()
        {
            //Test 1/2 for Q2a
            int[] arr = { 6, 9, 20, 4, 12, 0, 0 };
            //sum=51<100
            Assert.IsFalse(Program.SedimentAmount(arr));
            //test will fail if result != false
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod04()
        {
            //Test 2/2 for Q2a
            int[] arr = { 15, 16, 17, 18, 19, 20, 21 };
            //sum=126>100
            Assert.IsTrue(Program.SedimentAmount(arr));
            //test will fail if result != true
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod05()
        {
            //Test 1/1 for Q2b
            int[] arr = { 6, 9, 20, 4, 12, 0, 0 };
            //max = 20;
            int max = 20;
            Assert.AreEqual(max, Program.MaxSedimentAmount(arr));

        }

        [TestMethod, Timeout(5000)]
        public void TestMethod06()
        {
            //Test 1/2 for Q2c
            int[] arr = { 6, 9, 20, 4, 12, 0, 0 };
            Assert.IsTrue(Program.IsOnlyOneMax(arr));
            //test will fail if result != true
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod07()
        {
            //Test 2/2 for Q2c
            int[] arr = { 6, 9, 20, 4, 12, 20, 0 };
            Assert.IsFalse(Program.IsOnlyOneMax(arr));
            //test will fail if result != false
        }

        public void TemplateTestQ3(int[] testedArr, int[] expectedOddArr, int[] expectedEvenArr)
        {
            int[] oddArr = new int[expectedOddArr.Length];
            int[] evenArr = new int[expectedEvenArr.Length];
            int[] resultQ3 = Program.ReverseArray(testedArr);
            Assert.AreEqual(testedArr.Length, resultQ3.Length);
            //first thing to check if the array returns is in the same length.
            //test will fail and will not contiue if length are not equal
            try
            {
                for (int i = 0; i < testedArr.Length; i++)
                {
                    if (i < evenArr.Length)
                        evenArr[i] = resultQ3[i];
                    else
                        oddArr[i - evenArr.Length] = resultQ3[i];
                }
            }
            catch (Exception)
            {
                Assert.Fail("Copying to odd or even arr got exception");
            }
            //copying the array to oddArr and evenArr
            //if something goes wrong - the test will fail and there will be an annoucment
            CollectionAssert.AreEquivalent(expectedEvenArr, evenArr);
            CollectionAssert.AreEquivalent(expectedOddArr, oddArr);
            //those are checking if 2 arrays have the same elements.
            //test will sucess if it will not fail until line 116
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod08()
        {
            //Test 1/4 for Q3
            int[] testedArr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] expectedOddArr = { 7, 5, 3, 1 };
            int[] expectedEvenArr = { 8, 6, 4, 2 };
            TemplateTestQ3(testedArr, expectedOddArr, expectedEvenArr);
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod09()
        {
            //Test 2/4 for Q3
            int[] testedArr = { 3, 3, 2, 2, 2 };
            int[] expectedOddArr = { 3, 3 };
            int[] expectedEvenArr = { 2, 2, 2 };
            TemplateTestQ3(testedArr, expectedOddArr, expectedEvenArr);
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod10()
        {
            //Test 3/4 for Q3
            int[] testedArr = { 9, 2 };
            int[] expectedOddArr = { 9 };
            int[] expectedEvenArr = { 2 };
            TemplateTestQ3(testedArr, expectedOddArr, expectedEvenArr);
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod11()
        {
            //Test 4/4 for Q3
            int[] testedArr = { 2, 4, 6, 8, 1, 3, 5, 7 };
            int[] expectedOddArr = { 7, 5, 3, 1 };
            int[] expectedEvenArr = { 8, 6, 4, 2 };
            TemplateTestQ3(testedArr, expectedOddArr, expectedEvenArr);
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod12()
        {
            //Test 1/2 for Q4a

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = 0;
            int expected = 0;
            Assert.AreEqual(expected, Program.PartialSum(arr, index));

        }

        [TestMethod, Timeout(5000)]
        public void TestMethod13()
        {
            //Test 2/2 for Q4a

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = 6;
            int expected = 21;
            Assert.AreEqual(expected, Program.PartialSum(arr, index));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod14()
        {
            //Test 1/2 for Q4b
            int[] arr = { 1 };
            int[] expected = { 0, 1 };
            CollectionAssert.AreEqual(expected, Program.PartialSumArray(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod15()
        {
            //Test 2/2 for Q4b
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expected = { 0, 1, 3, 6, 10, 15, 21, 28, 36, 45 };
            CollectionAssert.AreEqual(expected, Program.PartialSumArray(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod16()
        {
            //Test 1/4 for Q5
            int num = 1745411;
            int[] expected = { 0, 3, 0, 0, 2, 1, 0, 1, 0, 0 };
            CollectionAssert.AreEqual(expected, Program.NumOfEachDigit(num));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod17()
        {
            //Test 2/4 for Q5
            int num = 0;
            int[] expected = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(expected, Program.NumOfEachDigit(num));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod18()
        {
            //Test 3/4 for Q5
            int num = 222222222;
            int[] expected = { 0, 0, 9, 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(expected, Program.NumOfEachDigit(num));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod19()
        {
            //Test 4/4 for Q5
            int num = 894456094;
            int[] expected = { 1, 0, 0, 0, 3, 1, 1, 0, 1, 2 };
            CollectionAssert.AreEqual(expected, Program.NumOfEachDigit(num));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod20()
        {
            //Test 1/2 for Q6c
            int[] arr = { 100 };
            int expected = 0;
            Assert.AreEqual(expected, Program.NumOfLowElements(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod21()
        {
            //Test 2/2 for Q6c
            int[] arr = { 80, 90, 40, 50, 55, 77, 46, 100, 4 };
            int expected = 5;
            Assert.AreEqual(expected, Program.NumOfLowElements(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod22()
        {
            //Test 1/4 for Q6d
            int[] arr = { 60, 60, 60, 60, 60, 0, 60 };
            Assert.IsFalse(Program.IsClassNormal(arr));

        }

        [TestMethod, Timeout(5000)]
        public void TestMethod23()
        {
            //Test 2/4 for Q6d
            int[] arr = { 100, 100, 0, 100 };
            Assert.IsFalse(Program.IsClassNormal(arr));

        }

        [TestMethod, Timeout(5000)]
        public void TestMethod24()
        {
            //Test 3/4 for Q6d
            int[] arr = new int[101];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            Assert.IsFalse(Program.IsClassNormal(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod25()
        {
            //Test 4/4 for Q6d
            int[] arr = { 80, 90, 90, 60, 57, 77, 64, 100, 49, 100 };
            Assert.IsTrue(Program.IsClassNormal(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod26()
        {
            //Test 1/4 for Q7
            int[] arr = { 80, 90, 90, 60, 57, 77, 64, 100, 49, 100 };
            int expected = 0;
            Assert.AreEqual(expected, Program.IsSorted(arr));

        }

        [TestMethod, Timeout(5000)]
        public void TestMethod27()
        {
            //Test 2/4 for Q7
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int expected = 1;
            Assert.AreEqual(expected, Program.IsSorted(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod28()
        {
            //Test 3/4 for Q7
            int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int expected = -1;
            Assert.AreEqual(expected, Program.IsSorted(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod29()
        {
            //Test 4/4 for Q7
            int[] arr = { 81, 92, 91 };
            int expected = 0;
            Assert.AreEqual(expected, Program.IsSorted(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod30()
        {
            //Test 1/2 for Q8a
            int num = 0;
            int expected = 1;
            Assert.AreEqual(expected, Program.NumOfDigits(num));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod31()
        {
            //Test 2/2 for Q8a
            int num = 567;
            int expected = 3;
            Assert.AreEqual(expected, Program.NumOfDigits(num));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod32()
        {
            //Test 1/3 for Q8b
            int num = 0;
            int[] expected = { 0 };
            CollectionAssert.AreEqual(expected, Program.NumToArray(num));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod33()
        {
            //Test 2/3 for Q8b
            int num = 14568;
            int[] expected = { 8,6,5,4,1 };
            CollectionAssert.AreEqual(expected, Program.NumToArray(num));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod34()
        {
            //Test 3/3 for Q8b
            int num = 567;
            int[] expected = { 7, 6, 5 };
            CollectionAssert.AreEqual(expected, Program.NumToArray(num));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod35()
        {
            //Test 1/6 for Q9
            bool[] arr = { true };
            Assert.IsTrue(Program.IsFlipping(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod36()
        {
            //Test 2/6 for Q9
            bool[] arr = { false };
            Assert.IsTrue(Program.IsFlipping(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod37()
        {
            //Test 3/6 for Q9
            bool[] arr = { true, false, true, false, true };
            Assert.IsTrue(Program.IsFlipping(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod38()
        {
            //Test 4/6 for Q9
            bool[] arr = { false, true, false, true, false };
            Assert.IsTrue(Program.IsFlipping(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod39()
        {
            //Test 5/6 for Q9
            bool[] arr = { true, false, true, true };
            Assert.IsFalse(Program.IsFlipping(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod40()
        {
            //Test 6/6 for Q9
            bool[] arr = { false, false, true, true };
            Assert.IsFalse(Program.IsFlipping(arr));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod41()
        {
            //Test 1/2 for Q10a
            int num = 1454;
            int digit = 4;
            int expected = 2;
            Assert.AreEqual(expected, Program.DigitInNumber(num, digit));

        }

        [TestMethod, Timeout(5000)]
        public void TestMethod42()
        {
            //Test 2/2 for Q10a
            int num = 1454;
            int digit = 3;
            int expected = 0;
            Assert.AreEqual(expected, Program.DigitInNumber(num, digit));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod43()
        {
            //Test 1/2 for Q10b
            int[] arr = { 12, 459, 7, 86, 311 };
            int digit = 1;
            int expected = 3;
            Assert.AreEqual(expected, Program.DigitInArray(arr, digit));
        }

        [TestMethod, Timeout(5000)]
        public void TestMethod44()
        {
            //Test 2/2 for Q10b
            int[] arr = { 102, 459, 7, 0, 311 };
            int digit = 0;
            int expected = 2;
            Assert.AreEqual(expected, Program.DigitInArray(arr, digit));
        }
    }
}
