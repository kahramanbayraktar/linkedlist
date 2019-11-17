using NUnit.Framework;

namespace LinkedList.Tests
{
    public class Tests
    {
        LinkedList<int> _linkedList;

        [SetUp]
        public void Setup()
        {
            _linkedList = new LinkedList<int>(new[] { 3, 11, 5 });
        }

        [Test]
        public void LinkedList_AddFirst()
        {
            // Arrange

            // Act
            _linkedList.AddFirst(9);

            // Assert
            Assert.AreEqual(_linkedList.Head.Value, 9);
            Assert.AreEqual(_linkedList.Head.Next.Value, 3);
        }

        [Test]
        public void LinkedList_AddLast()
        {
            // Arrange
            
            // Act
            _linkedList.AddLast(9);

            // Assert
            Assert.AreEqual(_linkedList.Head.Value, 3);
            Assert.AreEqual(_linkedList.Head.Next.Next.Next.Value, 9);
        }

        [Test]
        public void LinkedList_AddAfter()
        {
            // Arrange

            // Act
            _linkedList.AddAfter(7, 11);

            // Assert
            Assert.AreEqual(_linkedList.Contains(7), true);
            Assert.AreEqual(_linkedList.Head.Next.Next.Value, 7);
        }

        [Test]
        public void LinkedList_AddBefore()
        {
            // Arrange

            // Act
            _linkedList.AddBefore(7, 11);

            // Assert
            Assert.AreEqual(_linkedList.Contains(7), true);
            Assert.AreEqual(_linkedList.Head.Next.Value, 7);
        }

        [Test]
        public void LinkedList_Remove()
        {
            // Arrange

            // Act
            _linkedList.Remove(11);

            // Assert
            Assert.AreEqual(_linkedList.Contains(11), false);
            Assert.AreEqual(_linkedList.Head.Next.Value, 5);
        }

        [Test]
        public void LinkedList_RemoveFirst()
        {
            // Arrange

            // Act
            _linkedList.RemoveFirst();

            // Assert
            Assert.AreEqual(_linkedList.Contains(3), false);
            Assert.AreEqual(_linkedList.Head.Value, 11);
        }

        [Test]
        public void LinkedList_RemoveLast()
        {
            // Arrange

            // Act
            _linkedList.RemoveLast();

            // Assert
            Assert.AreEqual(_linkedList.Contains(5), false);
            Assert.AreEqual(_linkedList.Head.Value, 3);
        }

        [Test]
        public void LinkedList_Clear()
        {
            // Arrange

            // Act
            _linkedList.Clear();

            // Assert
            Assert.AreEqual(_linkedList.Length(), 0);
        }

        [Test]
        public void LinkedList_Length_AfterInitialization()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(_linkedList.Length(), 3);
        }

        [Test]
        public void LinkedList_Length_AfterAddLast()
        {
            // Arrange

            // Act
            _linkedList.AddLast(5);

            // Assert
            Assert.AreEqual(_linkedList.Length(), 4);
        }

        [Test]
        public void LinkedList_Length_AfterRemove()
        {
            // Arrange

            // Act
            _linkedList.Remove(5);

            // Assert
            Assert.AreEqual(_linkedList.Length(), 2);
        }
    }
}