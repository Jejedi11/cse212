using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Tests if the dequeue method returns the highest priority object
    // Expected Result: Returns the Highest Priority object
    // Defect(s) Found: The Loop was skipping the last item.
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
    // Scenario: The program is run without anything in the queue and then multiple items are added of the same priority.
    // Expected Result: The Program should first throw an error, then it should dequeue all equal priority items based on thier index.
    // Defect(s) Found: The list was checking from front to back so it would remove the last matching priority value instead of the first.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(priorityQueue.Dequeue);

        priorityQueue.Enqueue("Helaman", 3);
        priorityQueue.Enqueue("Corianton", 3);
        priorityQueue.Enqueue("Shiblon", 3);
        
        Assert.AreEqual("Helaman", priorityQueue.Dequeue());
        Assert.AreEqual("Corianton", priorityQueue.Dequeue());
        Assert.AreEqual("Shiblon", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}
