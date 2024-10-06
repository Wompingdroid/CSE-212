using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements. 

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Test whether the priority queue will Dequeue the items based off priority
    // Expected Result: 1, 2, 3, 4
    // Defect(s) Found: added _queue.RemoveAt(highPriorityIndex); to remove the index in the dequeue
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        // var first = new PriorityItem("1", 10);
        // var third = new PriorityItem("3", 4);
        // var fourth = new PriorityItem ("4", 1);
        // var second = new PriorityItem("2", 8);

        priorityQueue.Enqueue("4", 4);
        priorityQueue.Enqueue("2", 2);
        priorityQueue.Enqueue("3", 3);
        priorityQueue.Enqueue("1", 1);


        List<string> expectedResult = ["4", "3", "2" , "1"];
        

        for(int i =0; i < priorityQueue.theCount() -1; i++ ){
            Assert.AreEqual(expectedResult[i], priorityQueue.Dequeue());

        }
    }
    

    [TestMethod]
    // Scenario: all of the priorities are the same
    // Expected Result: deal with the values in order of first come first serve
    // Defect(s) Found: index started at 1 in dequeue method, and changed >= to >
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        // var first = new PriorityItem("1", 1);
        // var third = new PriorityItem("3", 1);
        // var fourth = new PriorityItem ("4", 1);
        // var second = new PriorityItem("2", 1);

        List<string> expectedResult = ["4", "2", "3" , "1"];

        priorityQueue.Enqueue("4", 1);
        priorityQueue.Enqueue("2", 1);
        priorityQueue.Enqueue("3", 1);
        priorityQueue.Enqueue("1", 1);

        for(int i =0; i < priorityQueue.theCount() -1; i++ ){
            Assert.AreEqual(expectedResult[i], priorityQueue.Dequeue());
        }

        
    }


    // Scenario: empty list
    // Expected Result: return error
    // Defect(s) Found:
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();

        
    }
    // Add more test cases as needed below.
}