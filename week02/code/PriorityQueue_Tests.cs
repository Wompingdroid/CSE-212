using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements. 

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Test whether the priority queue will Dequeue the items based off priority
    // Expected Result: 1, 2, 3, 4
    // Defect(s) Found: none
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        var first = new PriorityItem("1", 10);
        var third = new PriorityItem("3", 4);
        var fourth = new PriorityItem ("4", 1);
        var second = new PriorityItem("2", 8);

        PriorityItem[] expectedResult = [first, second, third, fourth];

        priorityQueue.Enqueue(fourth.Value, fourth.Priority);
        priorityQueue.Enqueue(second.Value, second.Priority);
        priorityQueue.Enqueue(third.Value, third.Priority);
        priorityQueue.Enqueue(first.Value, first.Priority);

        
    }
    

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        var first = new PriorityItem("1", 1);
        var third = new PriorityItem("3", 1);
        var fourth = new PriorityItem ("4", 1);
        var second = new PriorityItem("2", 1);

        PriorityItem[] expectedResult = [fourth, second, third, first];

        priorityQueue.Enqueue(fourth.Value, fourth.Priority);
        priorityQueue.Enqueue(second.Value, second.Priority);
        priorityQueue.Enqueue(third.Value, third.Priority);
        priorityQueue.Enqueue(first.Value, first.Priority);
    }

    // Add more test cases as needed below.
}