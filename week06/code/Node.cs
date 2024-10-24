public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        //Check if the current Node is equal
        if (value == Data){
            return true;
        }
        //Check if Left Node is null
        else if (value < Data)
        {
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        //Check if Right Node is null
        else
        {
            // Insert to the right
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        } 
        
    }

    public int GetHeight()
    {
    // Step 1: Get left height
    int leftHeight = 0;
    if (Left != null)
    {
        leftHeight = Left.GetHeight();
    }
    
    // Step 2: Get right height
    int rightHeight = 0;
    if (Right != null)
    {
        rightHeight = Right.GetHeight();
    }
    
    // Step 3: Find the bigger height between left and right
    int biggerHeight;
    if (leftHeight > rightHeight)
    {
        biggerHeight = leftHeight;
    }
    else
    {
        biggerHeight = rightHeight;
    }
    
    // Step 4: Add 1 for the current node and return
    return 1 + biggerHeight;
    }
}