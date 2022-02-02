using NUnit.Framework;

namespace OopFriendAssembly.ArrayLibrary.Tests
{
    public class ArrayHelperTests
    {
        [TestCase(SortOrder.Ascending)]
        [TestCase(SortOrder.Descending)]
        [Test]
        public void BubbleSort_ArrayIsNull_ReturnsEmptyArray(SortOrder sortOrder)
        {
            // 1) Arrange
            int[] array = null;

            // 2) Act
            int[] result = ArrayHelper.BubbleSort(array, sortOrder);

            // 3) Assert
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        [TestCase(SortOrder.Ascending)]
        [TestCase(SortOrder.Descending)]
        [Test]
        public void BubbleSort_ArrayIsEmpty_ReturnsEmptyArray(SortOrder sortOrder)
        {
            // 1) Arrange
            int[] array = new int[0];

            // 2) Act
            int[] result = ArrayHelper.BubbleSort(array, sortOrder);

            // 3) Assert
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        [Test]
        public void BubbleSort_ArrayWithKnownValues_ReturnsSortedArray()
        {
            // 1) Arrange
            int[] array = new int[] { 5, 3, 1, 2, 7 };

            // 2) Act
            int[] result = ArrayHelper.BubbleSort(array, SortOrder.Ascending);

            // 3) Assert
            CollectionAssert.AreEqual(
                new int[] { 1, 2, 3, 5, 7 },
                result);
        }

        [Test]
        public void Clone_ArrayIsNull_ReturnsEmptyArray()
        {
            // 1) Arrange
            int[] array = null;

            // 2) Act
            int[] result = ArrayHelper.Clone(array);

            // 3) Assert
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }
    }
}