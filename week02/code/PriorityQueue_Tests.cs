using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Tests if the dequeue method returns the highest priority object
    // Expected Result: Retunrs the Highest Priority object
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Teancum", 3);
        priorityQueue.Enqueue("Nephi", 5);
        priorityQueue.Enqueue("Alma", 4);
        
        Assert.AreEqual("Nephi", priorityQueue.Dequeue());
        Assert.AreEqual("Alma", priorityQueue.Dequeue());
        Assert.AreEqual("Teancum", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(priorityQueue.Dequeue);
    }

    // Add more test cases as needed below.
}